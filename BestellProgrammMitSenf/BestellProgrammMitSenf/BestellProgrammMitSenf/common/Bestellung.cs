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
        public long KundenNr;
        public long ZahlungsartNr;
        public long LieferadressNr;
        public OracleDate Bestelldatum;
        public List<BestellElement> bestellElemente;
    }
}
