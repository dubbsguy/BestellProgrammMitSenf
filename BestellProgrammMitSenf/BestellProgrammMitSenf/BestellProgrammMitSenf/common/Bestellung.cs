using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Types;

namespace BestellProgrammMitSenf.common
{
    public class Bestellung
    {
        public long BestellNr;
        public OracleDate Bestelldatum;
        public long KundenNr;
        public string Beschreibung; //Name Vorname Speise
        public string Groesse;
        public long Anzahl;
        public string Extras;
    }
}
