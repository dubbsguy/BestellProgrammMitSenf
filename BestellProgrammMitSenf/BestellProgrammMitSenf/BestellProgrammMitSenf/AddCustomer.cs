using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BestellProgrammMitSenf.common;

namespace BestellProgrammMitSenf
{
    public partial class AddCustomer : Form
    {
        View view;
        public AddCustomer( View view )
        {
            this.view = view;
            InitializeComponent();
        }
        //TODO: Methode welche überprüft ob die eingebene Emailadresse "valide" ist.
        private void validEmail()
        {
           if(textBox6.Text.Contains('@'))
            {
                button5.Enabled = true;
            }
        }
        //TODO: Methode welche die Eingabe der TextBoxen in den Eingabeformularen überprüft.  
        private void testTextBox()
        {
            button5.Enabled = false;
            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0 && maskedTextBox1.Text.Length != 0 && textBox4.Text.Length != 0 && textBox5.Text.Length != 0 && textBox6.Text.Length != 0 && textBox8.Text.Length != 0)
            {
                button5.Enabled = true;
            }
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            //TODO: Aufruf der oben deklarierten Methode "testTextBox".
            testTextBox();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //TODO: Aufruf der oben deklarierten Methode "testTextBox".
            testTextBox();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //TODO: Aufruf der oben deklarierten Methode "testTextBox".
            testTextBox();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //TODO: Aufruf der oben deklarierten Methode "testTextBox".
            testTextBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO: Schließt dieses Formular.
            this.Close();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            //TODO: Aufruf der oben deklarierten Methode "testTextBox".
            testTextBox();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //TODO: Aufruf der oben deklarierten Methode "testTextBox".
            testTextBox();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //TODO: Aufruf der oben deklarierten Methode "validEmail".
            validEmail();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DbAccess access = new DbAccess();
            Kunde kunde = new Kunde();
            kunde.Name = textBox1.Text;
            kunde.Vorname = textBox2.Text;
            kunde.EMail = textBox6.Text;
            Adresse addresse = new Adresse();
            kunde.adresse = addresse;
            addresse.PLZ = long.Parse(maskedTextBox1.Text);
            addresse.Ort = textBox8.Text;
            addresse.Strasse = textBox4.Text;
            addresse.Hausnummer = textBox5.Text;
            access.insertKunde(kunde);
            view.kUNDETableAdapter.Update(view.dataSet1);
            this.Close();

        }
    }
}
