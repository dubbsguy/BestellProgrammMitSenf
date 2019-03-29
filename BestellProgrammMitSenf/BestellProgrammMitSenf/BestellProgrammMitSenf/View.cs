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
using BestellProgrammMitSenf.common;

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

         

           // button2.Enabled = false;
            button9.Enabled = false;
            button13.Enabled = false;
            button20.Enabled = false;

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
            bestellungDataGridView1.DataSource = bESTELLUNGBindingSource;
            rowFilterSet.RowFilterEvent += (s, eventArgs) => { bESTELLUNGBindingSource.Filter = eventArgs.Filter;};
            bESTELLUNGBindingSource.Filter = rowFilterSet.Filter;


            kUNDETableAdapter.Fill(this.dataSet1.KUNDE);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bESTELLUNGTableAdapter.Update(dataSet1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form addCustomer = new AddCustomer( this );
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
            addOrder.FormClosing += InsertRow;
            addOrder.Show();
            
        }

        private void InsertRow(object sender, EventArgs eventArgs)
        {
            AddOrder addOrder = ((AddOrder)sender);
            if(addOrder.Save)
            {

                DbAccess access = new DbAccess();
                Bestellung bestellung = new Bestellung();
                bestellung.KundenNr = long.Parse(addOrder.KundenNr);
                bestellung.ZahlungsartNr = long.Parse(addOrder.ZahlungsNr);
                bestellung.LieferadressNr = long.Parse(addOrder.Lieferadressnr);
                try
                {
                    Oracle.ManagedDataAccess.Types.OracleDate date = new Oracle.ManagedDataAccess.Types.OracleDate(Convert.ToDateTime(addOrder.Datum));
                    bestellung.Bestelldatum = date;
                }
                catch (Exception e) { }
                bestellung.bestellElemente = new List<BestellElement>();
                access.insertBestellung(bestellung);
                DataRow dataRow = dataSet1.BESTELLUNG.NewRow();
                dataRow.SetField("kundenNr", addOrder.KundenNr);
                dataRow.SetField("zahlungsartnr", addOrder.ZahlungsNr);
                dataRow.SetField("lieferadressnr", addOrder.Lieferadressnr);
                dataRow.SetField("datum", addOrder.Datum);
                dataSet1.BESTELLUNG.Rows.Add(dataRow);
            }
        }

        private void UpdateRow(object sender, EventArgs eventArgs)
        {
            AddOrder addOrder = ((AddOrder)sender);
            if(addOrder.Save)
            {
                try
                {
                    DataRow dataRow = dataSet1.BESTELLUNG[addOrder.Index];
                    dataRow.SetField("kundenNr", addOrder.KundenNr);
                    dataRow.SetField("lieferadressnr", addOrder.Lieferadressnr);
                    dataRow.SetField("zahlungsartnr", addOrder.ZahlungsNr);
                    dataRow.SetField("datum", addOrder.Datum);
                }
                catch (Exception e)
                {

                }
            }
        }

        private void Bestellungen_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //button2.Enabled = true;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button9.Enabled = true;
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button20.Enabled = true;
        }
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = dataSet1.KUNDE[comboBox1.SelectedIndex].NAME;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if(bestellungDataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int index = bestellungDataGridView1.SelectedRows[0].Index;
                    DataRow dataRow = dataSet1.BESTELLUNG[index];
                    long lieferadressnr = dataRow.Field<long>("lieferadressnr");
                    long kundennr = dataRow.Field<long>("kundennr");
                    long zahlungsnr = dataRow.Field<long>("zahlungsartnr");
                    DateTime datum = dataRow.Field<DateTime>("datum");
                    Form addOrder = new AddOrder(index, kundennr, lieferadressnr, zahlungsnr, datum);
                    addOrder.FormClosing += UpdateRow;
                    addOrder.Show();
                } catch (Exception)
                {

                }

            }
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (bestellungDataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    if (bestellungDataGridView1.SelectedRows.Count > 0)
                    {
                        int index = bestellungDataGridView1.SelectedRows[0].Index;
                        DataRow dataRow = dataSet1.BESTELLUNG[index];
                        long bestellnr = dataRow.Field<long>("bestellnr");
                        DbAccess access = new DbAccess();
                        access.deleteBestellung(bestellnr);
                        bESTELLUNGTableAdapter.Update(dataSet1);
                    }
                }
                catch (Exception)
                {

                }
             }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Form addFood = new AddFood();
            addFood.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                    int index = dataGridView2.SelectedRows[0].Index;
                    DataRow dataRow = dataSet1.KUNDE[index];
                    long kundennr = dataRow.Field<long>("kundennr");
                    DbAccess access = new DbAccess();
                    access.deleteKunde(kundennr);
                    kUNDETableAdapter.Update( dataSet1 );
            }
        }
    }
}
