using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CryptoWindowsFormsApplication1
{
    public partial class Form5 : Form
    {
        private int userid;
        public Form5(int iduser)
        {
         
            InitializeComponent();
            userid = iduser;
        }

        private void utilizatorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utilizatorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cryptoDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cryptoDataSet.Utilizator' table. You can move, or remove it, as needed.
            ///this.utilizatorTableAdapter.Fill(this.cryptoDataSet.Utilizator);

            cryptoDataSet.EnforceConstraints = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string parolaactuala = textBox1.Text;
            string parolanoua = textBox2.Text;
            if (parolaactuala != utilizatorTableAdapter.ScalarQueryPasswordById(userid))
            {
                MessageBox.Show("Parola actuala gresita!");
            }
            else {
                utilizatorTableAdapter.UpdateQueryPasswordById(parolanoua, userid);
                MessageBox.Show("Parola schimbata!");      
                this.Hide();
            }
        }
    }
}
