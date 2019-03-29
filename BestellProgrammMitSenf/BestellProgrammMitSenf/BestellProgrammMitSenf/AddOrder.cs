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
        public AddOrder()
        {
            InitializeComponent();
        }

        //TODO: Methode welche die Eingabe der TextBoxen in den Eingabeformularen überprüft.  
        private void testTextBox()
        {
            button5.Enabled = false;
            if (textBox2.Text.Length != 0 && textBox3.Text.Length != 0 && textBox4.Text.Length != 0)
            {
                button5.Enabled = true;
            }
        }
        private void AddOrder_Load(object sender, EventArgs e)
        {
            //TODO: Aufruf der oben deklarierten Methode "testTextBox".
            testTextBox();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //TODO: Aufruf der oben deklarierten Methode "testTextBox".
            testTextBox();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //TODO: Aufruf der oben deklarierten Methode "testTextBox".
            testTextBox();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //TODO: Aufruf der oben deklarierten Methode "testTextBox".
            testTextBox();
        }
    }
}
