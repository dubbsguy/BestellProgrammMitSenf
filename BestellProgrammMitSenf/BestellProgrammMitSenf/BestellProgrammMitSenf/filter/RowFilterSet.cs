using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestellProgrammMitSenf
{
    class RowFilterSet
    {
        IEnumerable<RowFilter> rowFilters;
        private string filter = "";
        public string Filter { get { return filter; } }

        public RowFilterSet(IEnumerable<RowFilter> rowFilters)
        {
            this.rowFilters = rowFilters;
            foreach ( RowFilter rowFilter in rowFilters)
            {
                rowFilter.RowFilterEvent += (s, eventArgs) => { UpdateFilter(); RaiseFilterEvent(); };
            }
            UpdateFilter();
        }

        public event EventHandler<RowFilterSetEventArgs> RowFilterEvent;

        protected virtual void RaiseFilterEvent()
        {
            // Raise the event by using the () operator.
            if (RowFilterEvent != null)
            {
                RowFilterEvent(this, new RowFilterSetEventArgs(this.filter));
            }
        }

        private void UpdateFilter()
        {
            StringBuilder filter = new StringBuilder();
            IEnumerable<RowFilter> validFilters = rowFilters.Where(f => !String.IsNullOrEmpty(f.Filter)).ToList();
            foreach (RowFilter rowFilter in validFilters)
            {
                if(filter.Length != 0)
                {
                    filter.Append(" AND ");
                }
                filter.Append(rowFilter.Filter);
            }
            this.filter = filter.ToString();
        }
    }

    class RowFilterSetEventArgs : EventArgs
    {
        public string Filter { get; }
        public RowFilterSetEventArgs(string filter)
        {
            this.Filter = filter;
        }
    }
}
