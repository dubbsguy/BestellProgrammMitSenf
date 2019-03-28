using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestellProgrammMitSenf
{
    abstract class RowFilter
    {
        protected RowFilter isntance;
        protected string filter = "";
        protected string column = "";
        protected string expression = "";

        public string Filter { get { return filter; } }
        public string Column { get { return column; } }
        public string Expression {
            get { return expression;}
            set {
                this.expression = value;
                UpdateFilter();
                RaiseFilterEvent();
            }
        }
        
        public RowFilter(string expression)
        {
            this.isntance = this;
            this.expression = expression;
            UpdateFilter();
        }

        public event EventHandler<RowFilterEventArgs> RowFilterEvent;

        protected virtual void RaiseFilterEvent( )
        {
            // Raise the event by using the () operator.
            if (RowFilterEvent != null)
            {
                RowFilterEvent(this.isntance, new RowFilterEventArgs( this.isntance.filter));
            }
        }

        protected abstract void UpdateFilter();
    }

    class RowFilterEventArgs : EventArgs
    {
        public string Filter { get; }
        public RowFilterEventArgs(string filter)
        {
            this.Filter = filter;
        }
    }
}

/*
  bool isValid = !arguments.Any<string>(s => String.IsNullOrEmpty(s));
            if (isValid)
            {
                this.filter = String.Format(expression, arguments);
            }
            else
            {
                this.filter = "";
            }
            
     */
