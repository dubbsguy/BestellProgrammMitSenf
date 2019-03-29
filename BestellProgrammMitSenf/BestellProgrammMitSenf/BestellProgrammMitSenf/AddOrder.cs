using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestellProgrammMitSenf
{
    public partial class AddOrder : Form
    {
        public bool Save { get { return save; } }
        public string Lieferadressnr { get { return lieferadressNrTxtBox.Text; } }
        public string KundenNr { get { return kundenNrTxtBox.Text; } }
        public string Datum { get { return dateTimePicker1.Text; } }
        public string ZahlungsNr { get { return zahlungsartNrTxtBox.Text; } }

        private int index;
        private bool save;

        public int Index { get { return index; } }

        public AddOrder(): this(-1,0,0,0,DateTime.Now)
        { }

        public AddOrder(int index, long kundennr, long lieferadressnr, long zahlungsnr,  DateTime datum)
        {
            InitializeComponent();
            this.save = true;
            this.index = index;
            lieferadressNrTxtBox.Text = lieferadressnr.ToString();
            kundenNrTxtBox.Text = kundennr.ToString();
            zahlungsartNrTxtBox.Text = zahlungsnr.ToString();
            dateTimePicker1.Value = datum;
            
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AbortBtn_Click(object sender, EventArgs e)
        {
            this.save = false;
            this.Close();
        }
    }
}
