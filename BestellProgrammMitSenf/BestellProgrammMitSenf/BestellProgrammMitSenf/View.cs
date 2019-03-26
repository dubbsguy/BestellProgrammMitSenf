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
            textBox1.Text = name;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
       
        }
    }
}
