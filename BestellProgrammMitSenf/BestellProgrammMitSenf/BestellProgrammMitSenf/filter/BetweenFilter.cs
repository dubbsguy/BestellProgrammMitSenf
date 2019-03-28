using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestellProgrammMitSenf
{
    class BetweenFilter : RowFilter
    {
        protected string minValue;
        protected string maxValue;
        public String MinValue
        {
            get { return minValue; }
            set
            {
                this.minValue = value;
                UpdateFilter();
                RaiseFilterEvent();
            }
        }
        public String MaxValue
        {
            get { return maxValue; }
            set
            {
                this.maxValue = value;
                UpdateFilter();
                RaiseFilterEvent();
            }
        }

        public BetweenFilter(string column) : base("{0} >= {1} AND {0} <= {2}")
        {
            this.isntance = this;
            this.column = column;
        }

        protected override void UpdateFilter()
        {
            bool isValid = !(String.IsNullOrEmpty(column) || String.IsNullOrEmpty(minValue) || String.IsNullOrEmpty(maxValue));
            if (isValid)
            {
                this.filter = String.Format(expression, column, minValue, maxValue);
            }
            else
            {
                this.filter = "";
            }
        }
    }
}
