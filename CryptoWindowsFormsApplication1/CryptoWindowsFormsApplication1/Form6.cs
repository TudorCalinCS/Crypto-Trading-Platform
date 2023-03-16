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
    public partial class Form6 : Form
    {
        private string catFrom;
        private string ceFrom;
        private string catTo;
        private string ceTo;
        private int userid;
        Label label2 = new Label();
        Label label3 = new Label();
        Label label5 = new Label();
        Label label6 = new Label();
        public Form6(string catfrom,string cefrom,string catto,string ceto,int iduser)
        {
            InitializeComponent();
            catFrom = catfrom;
            ceFrom = cefrom;
            catTo = catto;
            ceTo = ceto;
            userid = iduser;
        }

        private void Form6_Activated(object sender, EventArgs e)
        {
            label2.Text = catFrom;
            label3.Text = ceFrom;
            label5.Text = catTo;
            label6.Text = ceTo;
            label7.Text = "Vei schimba " + catFrom + " " + ceFrom + " pentru " + catTo + " " + ceTo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double z=Convert.ToDouble(label2.Text)*(-1);
            if (label3.Text == "USD") cardTableAdapter.UpdateQuerybalantaUSD(z, userid);
            else if (label3.Text == "EURO") cardTableAdapter.UpdateQuerybalantaEURO(z, userid);
            else if (label3.Text == "LEI") cardTableAdapter.UpdateQuerybalantaLEI(z, userid);
            else if (label3.Text == "BTC") walletTableAdapter.UpdateQuerybalantaBTC(z, userid);
            else if (label3.Text == "ETH") walletTableAdapter.UpdateQuerybalantaETH(z, userid);
            else if (label3.Text == "SOL") walletTableAdapter.UpdateQuerybalantaSOL(z, userid);
            else if (label3.Text == "MANA") walletTableAdapter.UpdateQuerybalantaMANA(z, userid);
            else if (label3.Text == "BNB") walletTableAdapter.UpdateQuerybalantaBNB(z, userid);

            double x = Convert.ToDouble(label5.Text);

            if (label6.Text == "USD") cardTableAdapter.UpdateQuerybalantaUSD(x, userid);
            else if (label6.Text == "EURO") cardTableAdapter.UpdateQuerybalantaEURO(x, userid);
            else if (label6.Text == "LEI") cardTableAdapter.UpdateQuerybalantaLEI(x, userid);
            else if (label6.Text == "BTC") walletTableAdapter.UpdateQuerybalantaBTC(x, userid);
            else if (label6.Text == "ETH") walletTableAdapter.UpdateQuerybalantaETH(x, userid);
            else if (label6.Text == "SOL") walletTableAdapter.UpdateQuerybalantaSOL(x, userid);
            else if (label6.Text == "MANA") walletTableAdapter.UpdateQuerybalantaMANA(x, userid);
            else if (label6.Text == "BNB") walletTableAdapter.UpdateQuerybalantaBNB(x, userid);
            DateTime dt = DateTime.Now;
            z = z * (-1);
            tranzactiiTableAdapter.InsertQueryTranzactie(userid, label3.Text, label6.Text, z.ToString(), x.ToString(), 3, dt.ToString());
            MessageBox.Show("Convertire reusita!");
            this.Close();
            
        }

        private void utilizatorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utilizatorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cryptoDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cryptoDataSet.Card' table. You can move, or remove it, as needed.
            //this.cardTableAdapter.Fill(this.cryptoDataSet.Card);
            // TODO: This line of code loads data into the 'cryptoDataSet.Tranzactii' table. You can move, or remove it, as needed.
            //this.tranzactiiTableAdapter.Fill(this.cryptoDataSet.Tranzactii);
            // TODO: This line of code loads data into the 'cryptoDataSet.Wallet' table. You can move, or remove it, as needed.
            //this.walletTableAdapter.Fill(this.cryptoDataSet.Wallet);
            // TODO: This line of code loads data into the 'cryptoDataSet.Utilizator' table. You can move, or remove it, as needed.
            //this.utilizatorTableAdapter.Fill(this.cryptoDataSet.Utilizator);
            cryptoDataSet.EnforceConstraints = false;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
