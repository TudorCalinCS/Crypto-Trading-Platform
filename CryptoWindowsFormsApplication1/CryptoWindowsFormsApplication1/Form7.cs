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
    public partial class Form7 : Form
    {
        string username;
        string cetrimit;
        double suma;
        int userid;
        public Form7(string u,string c,double s,int idu)
        {
            InitializeComponent();
            username = u;
            cetrimit = c;
            suma = s;
            userid = idu;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cryptoDataSet.Utilizator' table. You can move, or remove it, as needed.
            //this.utilizatorTableAdapter.Fill(this.cryptoDataSet.Utilizator);
            // TODO: This line of code loads data into the 'cryptoDataSet.Tranzactii_Utilizatori' table. You can move, or remove it, as needed.
           /// this.tranzactii_UtilizatoriTableAdapter.Fill(this.cryptoDataSet.Tranzactii_Utilizatori);

            cryptoDataSet.EnforceConstraints = false;

        }

        private void tranzactii_UtilizatoriBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tranzactii_UtilizatoriBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cryptoDataSet);

        }

        private void Form7_Activated(object sender, EventArgs e)
        {
            //label2.Text = suma.ToString();
           // label3.Text = cetrimit;
            //label5.Text = username;
            label6.Text = "Vei trimite " + suma.ToString() + " " + cetrimit + " utilizatorului " + username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iduprimeste=utilizatorTableAdapter.ScalarQueryId(username).Value;
            

            tranzactii_UtilizatoriTableAdapter.InsertQueryTranzUtilizatori(userid, iduprimeste, cetrimit, suma);
            MessageBox.Show("Tranzactie initiata!" + '\n' + "Suma va fi virata dupa ce " + username + " accepta tranzactia!");
            this.Close();
        }
    }
}
