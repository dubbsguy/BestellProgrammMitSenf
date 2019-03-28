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
            adresse.AdressNr = reader.GetInt64(0);
            adresse.PLZ = reader.GetInt64(1);
            adresse.Ort = reader.GetString(2);
            adresse.Strasse = reader.GetString(3);
            adresse.Hausnummer = reader.GetString(4);
        }
        conn.Close();
        return adresse;
    }
}
