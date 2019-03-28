using System;
using System.Data.SqlClient;
using Oracle.ManagedDataAccess.Client;
using BestellProgrammMitSenf.common;
using System.Collections.Generic;
using Oracle.DataAccess;
public class DbAccess
{
    private OracleConnection conn;

    public DbAccess()
	{
        string constr = "DATA SOURCE = 172.16.200.30:1522 / bbs2orcl; PASSWORD = Gruppe1; USER ID = PIZZA";
        conn = new OracleConnection(constr);
        try
        {
            conn.Open();
            conn.Close();
        }
        catch (Exception ex)
        {
            constr = "DATA SOURCE = 134.76.247.35:1522 / bbs2orcl; PASSWORD = Gruppe1; USER ID = PIZZA";
            conn = new OracleConnection(constr);
            conn.Open();
            conn.Close();
        }
        
    }

    public OracleConnection getConnection()
    {
        return conn;
    }

    public double ladeKostenLaufenderMonat()
    {
        conn.Open();
        OracleCommand command = new OracleCommand("select KostenImLaufendenMonat from kostenLaufenderMonatView", conn);
        OracleDataReader reader = command.ExecuteReader();
        double kostenLaufenderMonat = -1;
        if (reader.Read())
        {
            kostenLaufenderMonat = reader.GetDouble(0);
        }
        conn.Close();
        return kostenLaufenderMonat;
    }

    public void insertBestellung( Bestellung bestellung )
    {
        conn.Open();
        //Bestellung Speichern
        OracleCommand command = new OracleCommand("INSERT INTO Bestellung( KundenNr, LieferadressNr, ZahlungsartNr, Bestelldatum ) VALUES(:pKundenNr, :pLieferadressNr, :pZahlungsartNr, :pBestelldatum)", conn);
        command.Parameters.Add(new OracleParameter("pKundenNr", bestellung.KundenNr ) );
        command.Parameters.Add(new OracleParameter("pLieferadressNr", bestellung.LieferadressNr ) );
        command.Parameters.Add(new OracleParameter("pZahlungsartNr", bestellung.ZahlungsartNr ) );
        command.Parameters.Add(new OracleParameter("pBestelldatum", bestellung.Bestelldatum ) );
        command.ExecuteNonQuery();
        command.Transaction.Commit();
        long bestellNr = ladeBestellNr(bestellung, conn);
        //BestellElemente Speichern
        foreach (BestellElement element in bestellung.bestellElemente)
        {
            insertBestellElement(element, bestellNr);
            long bestellElementNr = ladeBestellElemenNr(element, bestellNr, conn);
            //ExtraZutaten speichern
            foreach (long zutat in element.ExtraZutaten)
            {
                insertExtraZutat(zutat, bestellElementNr );
            }
        }
        conn.Close();
        insertRechnung(bestellNr, getPreisVonBestellung(bestellNr));
    }

    public double getPreisVonBestellung(long BestellNr)
    {
        return 0; //ToDo
    }

    private long ladeBestellNr(Bestellung bestellung, OracleConnection conn)
    {
        conn.Open();
        OracleCommand command = new OracleCommand("Select bestellNr from Bestellung where KundenNr = :pKundenNr and LieferadressNr = :pLieferadressNr and ZahlungsartNr = :pZahlungsartNr and Bestelldatum = :pBestelldatum", conn);
        command.Parameters.Add(new OracleParameter("pKundenNr", bestellung.KundenNr));
        command.Parameters.Add(new OracleParameter("pLieferadressNr", bestellung.LieferadressNr));
        command.Parameters.Add(new OracleParameter("pZahlungsartNr", bestellung.ZahlungsartNr));
        command.Parameters.Add(new OracleParameter("pBestelldatum", bestellung.Bestelldatum));
        OracleDataReader reader = command.ExecuteReader();
        long BestellNr = reader.GetInt64(0);
        conn.Close();
        return BestellNr;
    }

    private int insertBestellElement(BestellElement element, long bestellNr)
    {
        conn.Open();
        OracleCommand command = new OracleCommand("INSERT INTO BestellElement( SpeiseNr, bestellNr, SpeiseGroessenID, Anzahl ) VALUES(:pSpeiseNr, :pBestellNr, :pSpeiseGroessenID, :pAnzahl)", conn);
        command.Parameters.Add(new OracleParameter("pSpeiseNr", element.SpeiseNr));
        command.Parameters.Add(new OracleParameter("pBestellNr", bestellNr));
        command.Parameters.Add(new OracleParameter("pSpeiseGroessenID", element.SpeiseGroessenID));
        command.Parameters.Add(new OracleParameter("pAnzahl", element.Anzahl));
        int resultstate = command.ExecuteNonQuery();
        command.Transaction.Commit();
        conn.Close();
        return resultstate;
    }

    private long ladeBestellElemenNr(BestellElement element, long bestellNr, OracleConnection conn)
    {
        conn.Open();
        OracleCommand command = new OracleCommand("Select bestellElementNr from BestellElement where SpeiseNr = :pSpeiseNr and bestellNr = :pBestellNr and SpeiseGroessenID = :pSpeiseGroessenID and Anzahl = :pAnzahl", conn);
        command.Parameters.Add(new OracleParameter("pSpeiseNr", element.SpeiseNr));
        command.Parameters.Add(new OracleParameter("pBestellNr", bestellNr));
        command.Parameters.Add(new OracleParameter("pSpeiseGroessenID", element.SpeiseGroessenID));
        command.Parameters.Add(new OracleParameter("pAnzahl", element.Anzahl));
        OracleDataReader reader = command.ExecuteReader();
        long BestellElemenNr =  reader.GetInt64(0);
        conn.Close();
        return BestellElemenNr;
    }

    private int insertExtraZutat(long ZutatNr, long bestellElementNr)
    {
        conn.Open();
        OracleCommand command = new OracleCommand("INSERT INTO ExtraZutat( ZutatNr, bestellElementNr ) VALUES(:pZutatNr, :pbestellElementNr)", conn);
        command.Parameters.Add(new OracleParameter("pZutatNr", ZutatNr));
        command.Parameters.Add(new OracleParameter("pbestellElementNr", bestellElementNr ));
        int resultstate = command.ExecuteNonQuery();
        command.Transaction.Commit();
        conn.Close();
        return resultstate;
    }

    private int insertRechnung( long BestellNr, double Betrag )
    {
        conn.Open();
        OracleCommand command = new OracleCommand("INSERT INTO Rechnung( BestellNr, Betrag ) VALUES(:pBestellNr, :pBetrag)", conn);
        command.Parameters.Add(new OracleParameter("pBestellNr", BestellNr));
        command.Parameters.Add(new OracleParameter("pBetrag", Betrag));
        int resultstate = command.ExecuteNonQuery();
        command.Transaction.Commit();
        conn.Close();
        return resultstate;
    }

    public double ladeKostenTaeglich()
    {
        conn.Open();
        OracleCommand command = new OracleCommand("select KostenAmTag from KostenTaeglichView", conn);
        OracleDataReader reader = command.ExecuteReader();
        double kostenLaufenderMonat = -1;
        if (reader.Read())
        {
            kostenLaufenderMonat = reader.GetDouble(0);
        }
        conn.Close();
        return kostenLaufenderMonat;
    }

    public int insertKunde( Kunde kunde )
    {
        insertAdresse( kunde.adresse );
        long AdressNr = loadNrForAdresse(kunde.adresse);
        conn.Open();
        OracleCommand command = new OracleCommand("INSERT INTO Kunde(AdressNr, Name, Vorname, Email, Telefonnummer) VALUES(:pAdressNr, :pName, :pVorname, :pEmail, :pTelefonnummer)", conn);
        command.Parameters.Add( new OracleParameter( "pAdressNr", AdressNr ) );
        command.Parameters.Add( new OracleParameter( "pName", kunde.Name ) );
        command.Parameters.Add( new OracleParameter( "pVorname", kunde.Vorname) );
        command.Parameters.Add( new OracleParameter( "pAdressNr", kunde.Vorname) );
        command.Parameters.Add( new OracleParameter( "pEmail", kunde.EMail ) );
        command.Parameters.Add( new OracleParameter( "pTelefonnummer", kunde.Telefonnummer ) );
        int resultstate = command.ExecuteNonQuery();
        command.Transaction.Commit();
        conn.Close();
        return resultstate;
    }

    public long loadNrForAdresse( Adresse adresse )
    {
        conn.Open();
        OracleCommand command = new OracleCommand("select AdressNr from Adresse where PLZ= :pPLZ and Ort = :pOrt and Strasse = :pStrasse and Hausnummer = :pHausnummer", conn);
        command.Parameters.Add(new OracleParameter("pPLZ", adresse.PLZ));
        command.Parameters.Add(new OracleParameter("pOrt", adresse.Ort));
        command.Parameters.Add(new OracleParameter("pStrasse", adresse.Strasse));
        command.Parameters.Add(new OracleParameter("pHausnummer", adresse.Hausnummer));
        OracleDataReader reader = command.ExecuteReader();
        long AdressNr = -1;
        if (reader.Read())
        {
            AdressNr = reader.GetInt64(0);
        }
        conn.Close();
        return AdressNr;
    }

    public int insertAdresse(Adresse adresse )
    {
        conn.Open();
        OracleCommand command = new OracleCommand("INSERT INTO ADRESSE (PLZ, Ort, Strasse, Hausnummer) VALUES (:pPLZ, :pOrt, :pStrasse, :pHausnummer)", conn);
        command.Parameters.Add(new OracleParameter("pPLZ", adresse.PLZ));
        command.Parameters.Add(new OracleParameter("pOrt", adresse.Ort));
        command.Parameters.Add(new OracleParameter("pStrasse", adresse.Strasse));
        command.Parameters.Add(new OracleParameter("pHausnummer", adresse.Hausnummer));
        int resultstate = command.ExecuteNonQuery();
        command.Transaction.Commit();
        conn.Close();
        return resultstate;
    }


    public int deleteKundenAdresse( long KundenNr )
    {
        conn.Open();
        OracleCommand command = new OracleCommand("delete from ADRESSE where AdressNr = (select AdressNr from Kunde where KundenNr = :pKundenNr)", conn);
        command.Parameters.Add(new OracleParameter("pKundenNr", KundenNr));
        int resultstate = command.ExecuteNonQuery();
        command.Transaction.Commit();
        conn.Close();
        return resultstate;
    }

    public int deleteBestellung(long BestellNr)
    {
        conn.Open();
        OracleCommand command = new OracleCommand("delete from Bestellung where BestellNr = : pBestellNr", conn);
        command.Parameters.Add(new OracleParameter("pBestellNr", BestellNr));
        int resultstate = command.ExecuteNonQuery();
        command.Transaction.Commit();
        conn.Close();
        return resultstate;
    }


    public int deleteKunde(long KundenNr)
    {
        deleteKundenAdresse(KundenNr);
        conn.Open();
        OracleCommand command = new OracleCommand("delete from KUNDE where KundenNr = :pKundenNr", conn);
        command.Parameters.Add(new OracleParameter("pKundenNr", KundenNr));
        int resultstate = command.ExecuteNonQuery();
        command.Transaction.Commit();
        conn.Close();
        return resultstate;
    }

    public int updateKundenAdresse( long KundenNr, Adresse adresse )
    {
        conn.Open();
        OracleCommand command = new OracleCommand("update Adresse set PLZ =:pPLZ, Ort = :pOrt, Strasse = :pStrasse, Hausnummer = :pHausnummer where AdressNr = (select AdressNr from Kunde where KundenNr = :pKundenNr)", conn);
        command.Parameters.Add(new OracleParameter("pPLZ", adresse.PLZ ) );
        command.Parameters.Add(new OracleParameter("pOrt", adresse.Ort));
        command.Parameters.Add(new OracleParameter("pStrasse", adresse.Strasse));
        command.Parameters.Add(new OracleParameter("pHausnummer", adresse.Hausnummer));
        int resultstate = command.ExecuteNonQuery();
        command.Transaction.Commit();
        conn.Close();
        return resultstate;
    }

    public Adresse ladeAdresseFromNr( long AdressNr )
    {
        conn.Open();
        OracleCommand command = new OracleCommand("select AdressNr, PLZ, Ort, Strasse, Hausnummer from Adresse where AdressNr = :pAdressNr", conn);
        command.Parameters.Add( new OracleParameter("pAdressNr",AdressNr ) );
        OracleDataReader reader = command.ExecuteReader();
        Adresse adresse = null;
        if (reader.Read())
        {
            adresse = new Adresse();
            adresse.PLZ = reader.GetInt64(1);
            adresse.Ort = reader.GetString(2);
            adresse.Strasse = reader.GetString(3);
            adresse.Hausnummer = reader.GetString(4);
        }
        conn.Close();
        return adresse;
    }
}
