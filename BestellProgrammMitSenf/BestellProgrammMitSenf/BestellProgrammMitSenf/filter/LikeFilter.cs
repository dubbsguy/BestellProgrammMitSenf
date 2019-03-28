using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestellProgrammMitSenf
{
    class LikeFilter : EqualsFilter
    {
        public LikeFilter(string column) : base(column)
        {
            this.isntance = this;
            this.expression = "{0} LIKE '{1}'";
        }
    }
}
