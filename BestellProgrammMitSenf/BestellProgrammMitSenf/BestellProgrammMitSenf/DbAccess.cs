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

    public List<Speise> ladeSpeiseKarte()
    {
        conn.Open();
        List<Speise> liste = new List<Speise>();
        OracleCommand command = new OracleCommand("select SpeiseNr, BildNr, Beschreibung, Name, StandardPreis, StandardKosten from Speise", conn);
        OracleDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            Speise speise = new Speise();
            speise.SpeiseNr = reader.GetInt64(0);
            speise.BildNr = reader.GetInt64(1);
            speise.Beschreibung = reader.GetString(2);
            speise.Name = reader.GetString(3);
            speise.StandardPreis = reader.GetDouble(4);
            speise.StandardKosten = reader.GetDouble(5);
            liste.Add(speise);

        }
        conn.Close();
        return liste;
    }

    public List<Kunde> ladeKunden()
    {
        conn.Open();
        List<Kunde> liste = new List<Kunde>();
        OracleCommand command = new OracleCommand("select KundenNr, AdresseNr, Name, Vorname, Firmierung, EMail, Telefonnummer from Kunde", conn);
        OracleDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            Kunde kunde = new Kunde();
            kunde.KundenNr = reader.GetInt64(0);
            kunde.AdresseNr = reader.GetInt64(1);
            kunde.Name = reader.GetString(2);
            kunde.Vorname = reader.GetString(3);
            kunde.Firmierung = reader.GetString(4);
            kunde.EMail = reader.GetString(5);
            kunde.Telefonnummer = reader.GetString(6);
            liste.Add(kunde);
        }
        conn.Close();
        return liste;
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
