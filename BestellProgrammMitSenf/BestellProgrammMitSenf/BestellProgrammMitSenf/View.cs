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


        private static EqualsFilter bestellKundenNr = new EqualsFilter("KundenNr");
        private static EqualsFilter bestellZahlungsartNr = new EqualsFilter("ZahlungsartNr");
        private static RowFilterSet rowFilterSet = new RowFilterSet(new List<RowFilter> { bestellKundenNr, bestellZahlungsartNr });
        public static DataTable dataTable = new DataTable();

        public View()
        {
       


            InitializeComponent();
            bool isSchool = true;
            string ip = (isSchool)? "172.16.200.30:1522" : "134.76.247.35:1522";
            string constr = "DATA SOURCE=" + ip + "/bbs2orcl;PASSWORD=Gruppe1;USER ID=PIZZA";
            OracleConnection conn = new OracleConnection(constr);

            bESTELLUNGTableAdapter.Connection.ConnectionString = constr;
            kUNDETableAdapter.Connection.ConnectionString = constr;
            rECHNUNGTableAdapter.Connection.ConnectionString = constr;
 
            /*
            OracleCommand command = new OracleCommand("select * from user_tables",conn);
            OracleDataReader reader = command.ExecuteReader();
            String name = reader.GetName(0);
            */
            //textBox1.Text = name;
        }

        private void View_Load(object sender, EventArgs e)
        {
 






            // TODO: Diese Codezeile lädt Daten in die Tabelle "dataSet1.FIXKOSTEN". Sie können sie bei Bedarf verschieben oder entfernen.
            this.fIXKOSTENTableAdapter.Fill(this.dataSet1.FIXKOSTEN);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dataSet1.SPEISE". Sie können sie bei Bedarf verschieben oder entfernen.
            this.sPEISETableAdapter.Fill(this.dataSet1.SPEISE);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dataSet1.RECHNUNG". Sie können sie bei Bedarf verschieben oder entfernen.
            //this.rECHNUNGTableAdapter.Fill(this.dataSet1.RECHNUNG);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dataSet1.KUNDE". Sie können sie bei Bedarf verschieben oder entfernen.
            // this.kUNDETableAdapter.Fill(this.dataSet1.KUNDE);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dataSet1.BESTELLUNG". Sie können sie bei Bedarf verschieben oder entfernen.
            this.bESTELLUNGTableAdapter.Fill(this.dataSet1.BESTELLUNG);
            dataGridView1.DataSource = bESTELLUNGBindingSource;
            rowFilterSet.RowFilterEvent += (s, eventArgs) => { bESTELLUNGBindingSource.Filter = eventArgs.Filter;};
            bESTELLUNGBindingSource.Filter = rowFilterSet.Filter;

            kUNDETableAdapter.Fill(this.dataSet1.KUNDE);

            OracleConnection con = new OracleConnection("DATA SOURCE=172.16.200.30:1522/bbs2orcl;PASSWORD=Gruppe1;USER ID=PIZZA");
            OracleDataAdapter oracleDataAdapter = new OracleDataAdapter();
   


            string cmd = @"
                            SELECT b.BestellNr AS BestellNr,
                                   b.Datum AS Bestelldatum,
                                   b.KundenNr AS KundenNr,
                                   k.Vorname || ' ' || k.Name AS KundenName,
                                   '#' || be.SpeiseNr || ' ' || s.NAME AS Speise,
                                   sg.BESCHREIBUNG AS Groesse,
                                   be.Anzahl AS Anzahl,
                                   NVL(zu.Name, '---') AS ExtraZutat
                            FROM Bestellung b
                            JOIN Kunde k
                            ON b.KundenNr = k.KundenNr
                            JOIN Adresse a
                            ON b.LieferadressNr = a.adressNr
                            JOIN Zahlungsart z
                            ON b.ZahlungsartNr = z.ZahlungsartNr
                            JOIN BestellElement be
                            ON b.BestellNr = be.BestellNr
                            JOIN Speise s
                            ON be.SpeiseNr = s.SpeiseNr
                            JOIN Speisengroesse sg
                            ON be.SPEISEGROESSENID = sg.SPEISENGROESSEID
                            LEFT OUTER JOIN ExtraZutat ez
                            ON be.BESTELLELEMENTNR = ez.BESTELLELEMENTNR
                            LEFT OUTER JOIN Zutat zu
                            ON ez.ZUTATNR = zu.ZutatNr
                            ";

            // SQL Kommando zum Abfragen der Daten festlegen:
            oracleDataAdapter.SelectCommand = new OracleCommand(cmd, con);
            oracleDataAdapter.Fill(dataTable);
            
            dataGridView5.DataSource = oracleDataAdapter;
            dataGridView6.DataSource = oracleDataAdapter;

    
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bESTELLUNGTableAdapter.Update(dataSet1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form addCustomer = new AddCustomer();
            addCustomer.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void bestellungenBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void kundenBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void rechnungenBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void kostenBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void speisekarteBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 5;
        }

        private void kalenderBtn_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.BackColor = Color.DarkGray;
            Control control = new MonthCalendar();
            control.Dock = DockStyle.Fill;
            form.Controls.Add(control);
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bestellKundenNr.Value = ((TextBox)sender).Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form addOrder = new AddOrder();
            addOrder.Show();
        }

        private void Bestellungen_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = dataSet1.KUNDE[comboBox1.SelectedIndex].NAME;
        }
    }
}
