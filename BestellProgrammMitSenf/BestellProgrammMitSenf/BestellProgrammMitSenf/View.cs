using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;

namespace BestellProgrammMitSenf
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
            string constr = "DATA SOURCE = 172.16.200.30:1522 / bbs2orcl; PASSWORD = Gruppe1; USER ID = PIZZA";
            OracleConnection conn = new OracleConnection(constr);

            conn.Open();
            OracleCommand command = new OracleCommand("select * from user_tables",conn);
            OracleDataReader reader = command.ExecuteReader();
            String name = reader.GetName(0);
            //textBox1.Text = name;
        }

        private void View_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dataSet1.KUNDE". Sie können sie bei Bedarf verschieben oder entfernen.
            this.kUNDETableAdapter.Fill(this.dataSet1.KUNDE);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dataSet1.BESTELLUNG". Sie können sie bei Bedarf verschieben oder entfernen.
            this.bESTELLUNGTableAdapter.Fill(this.dataSet1.BESTELLUNG);

        }

        private void Kunden_Click(object sender, EventArgs e)
        {

        }
    }
}
