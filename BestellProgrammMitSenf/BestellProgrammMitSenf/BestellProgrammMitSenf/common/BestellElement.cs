using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestellProgrammMitSenf.common
{
    public class BestellElement
    {
        public long SpeiseNr;
        public long SpeiseGroessenID;
        public long Anzahl;
        public List<long> ExtraZutaten;
    }
}
