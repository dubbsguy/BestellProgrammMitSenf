using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestellProgrammMitSenf
{
    class EqualsFilter : RowFilter
    {
        protected string value;
        public String Value
        {
            get { return value; }
            set
            {
                this.value = value;
                UpdateFilter();
                RaiseFilterEvent();
            }
        }

        public EqualsFilter(string column) : base("{0} = {1}")
        {
            this.isntance = this;
            this.column = column;
        }

        protected override void UpdateFilter()
        {
            bool isValid = ! ( String.IsNullOrEmpty(column) || String.IsNullOrEmpty(value)) ;
            if (isValid)
            {
                this.filter = String.Format(expression, column, value);
            }
            else
            {
                this.filter = "";
            }
        }
    }
}
