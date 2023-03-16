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
    public partial class Form8 : Form
    {
        private string lb2text;
        private int idtrimitator;
        private string cetrimite;
        private double suma;
        private int userid;
        private int idtranzutilizator;
        public Form8(string l,int i,string ce,double s,int user,int idtrz)
        {
            InitializeComponent();
            lb2text = l;
            idtrimitator = i;
            cetrimite = ce;
            suma = s;
            userid=user;
            idtranzutilizator = idtrz;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cryptoDataSet.Wallet' table. You can move, or remove it, as needed.
            //this.walletTableAdapter.Fill(this.cryptoDataSet.Wallet);
            // TODO: This line of code loads data into the 'cryptoDataSet.Utilizator' table. You can move, or remove it, as needed.
            //this.utilizatorTableAdapter.Fill(this.cryptoDataSet.Utilizator);
            // TODO: This line of code loads data into the 'cryptoDataSet.Tranzactii_Utilizatori' table. You can move, or remove it, as needed.
            //this.tranzactii_UtilizatoriTableAdapter.Fill(this.cryptoDataSet.Tranzactii_Utilizatori);
            // TODO: This line of code loads data into the 'cryptoDataSet.Card' table. You can move, or remove it, as needed.
            //this.cardTableAdapter.Fill(this.cryptoDataSet.Card);
            cryptoDataSet.EnforceConstraints = false;
        }

        private void cardBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cardBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cryptoDataSet);

        }

        private void Form8_Activated(object sender, EventArgs e)
        {
            label1.Text = lb2text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cetrimite == "USD") {
                cardTableAdapter.UpdateQuerybalantaUSD(suma * (-1), idtrimitator);
                cardTableAdapter.UpdateQuerybalantaUSD(suma , userid);
            }
            if (cetrimite == "EURO")
            {
                cardTableAdapter.UpdateQuerybalantaEURO(suma * (-1), idtrimitator);
                cardTableAdapter.UpdateQuerybalantaEURO(suma , userid);
            }
            if (cetrimite == "LEI")
            {
                cardTableAdapter.UpdateQuerybalantaLEI(suma * (-1), idtrimitator);
                cardTableAdapter.UpdateQuerybalantaLEI(suma , userid);
            }
            if (cetrimite == "BTC") {
                walletTableAdapter.UpdateQuerybalantaBTC(suma * (-1), idtrimitator);
                walletTableAdapter.UpdateQuerybalantaBTC(suma, userid);
            }
            if (cetrimite == "ETH")
            {
                walletTableAdapter.UpdateQuerybalantaETH(suma * (-1), idtrimitator);
                walletTableAdapter.UpdateQuerybalantaETH(suma, userid);
            }
            if (cetrimite == "SOL")
            {
                walletTableAdapter.UpdateQuerybalantaSOL(suma * (-1), idtrimitator);
                walletTableAdapter.UpdateQuerybalantaSOL(suma, userid);
            }
            if (cetrimite == "MANA")
            {
                walletTableAdapter.UpdateQuerybalantaMANA(suma * (-1), idtrimitator);
                walletTableAdapter.UpdateQuerybalantaMANA(suma, userid);
            }
            if (cetrimite == "BNB")
            {
                walletTableAdapter.UpdateQuerybalantaBNB(suma * (-1), idtrimitator);
                walletTableAdapter.UpdateQuerybalantaBNB(suma, userid);
            }
            MessageBox.Show("Tranzactie efectuata!");
            tranzactii_UtilizatoriTableAdapter.DeleteQueryByIdTranzUtiliz(idtranzutilizator);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tranzactie stearsa!");
            tranzactii_UtilizatoriTableAdapter.DeleteQueryByIdTranzUtiliz(idtranzutilizator);
            this.Close();
        }
    }
}
