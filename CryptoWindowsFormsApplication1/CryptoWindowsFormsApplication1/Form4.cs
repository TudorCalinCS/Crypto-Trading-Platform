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
    public partial class Form4 : Form
    {
        int relatiaVC;
        string valfiat;
        string valcrypto;
        string cefiat;
        string cecrypto;
        int userid;
        Timer t2;
        public Form4(int iduser,int rel,string catfiat,string catcrypto,string carefiat,string carecrypto,Timer t1)
        {

            userid = iduser;
            relatiaVC = rel;
            InitializeComponent();
            valfiat = catfiat;
            valcrypto = catcrypto;
            cefiat = carefiat;
            cecrypto = carecrypto;
            t2 = t1;
        }

        private void cardBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cardBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cryptoDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cryptoDataSet.Tranzactii' table. You can move, or remove it, as needed.
            //this.tranzactiiTableAdapter.Fill(this.cryptoDataSet.Tranzactii);
            // TODO: This line of code loads data into the 'cryptoDataSet.Wallet' table. You can move, or remove it, as needed.
           // this.walletTableAdapter.Fill(this.cryptoDataSet.Wallet);
            // TODO: This line of code loads data into the 'cryptoDataSet.Utilizator' table. You can move, or remove it, as needed.
            //this.utilizatorTableAdapter.Fill(this.cryptoDataSet.Utilizator);
            // TODO: This line of code loads data into the 'cryptoDataSet.PretCrypto' table. You can move, or remove it, as needed.
            //this.pretCryptoTableAdapter.Fill(this.cryptoDataSet.PretCrypto);
            // TODO: This line of code loads data into the 'cryptoDataSet.Card' table. You can move, or remove it, as needed.
           // this.cardTableAdapter.Fill(this.cryptoDataSet.Card);
            cryptoDataSet.EnforceConstraints = false;
            

        }

       
        private void Form4_Activated(object sender, EventArgs e)
        {
       
     
                label5.Text="Vei cumpara "+valcrypto.ToString()+" "+cecrypto.ToString()+" cu "+valfiat.ToString()+cefiat.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (cefiat == "USD") {
                cardTableAdapter.UpdateQuerybalantaUSD(Convert.ToDouble(valfiat.ToString()) * (-1), userid);
            }
            else if (cefiat == "EURO")
            {
                cardTableAdapter.UpdateQuerybalantaEURO(Convert.ToDouble(valfiat.ToString()) * (-1), userid);

            }
            else {
                cardTableAdapter.UpdateQuerybalantaLEI(Convert.ToDouble(valfiat.ToString()) * (-1), userid);
            }
            if (cecrypto == "BTC")
                walletTableAdapter.UpdateQuerybalantaBTC(Convert.ToDouble(valcrypto), userid);
            if (cecrypto == "ETH")
                walletTableAdapter.UpdateQuerybalantaETH(Convert.ToDouble(valcrypto), userid);
            if (cecrypto == "SOL")
                walletTableAdapter.UpdateQuerybalantaSOL(Convert.ToDouble(valcrypto), userid);
            if (cecrypto == "MANA")
                walletTableAdapter.UpdateQuerybalantaMANA(Convert.ToDouble(valcrypto), userid);
            if (cecrypto == "BNB")
                walletTableAdapter.UpdateQuerybalantaBNB(Convert.ToDouble(valcrypto), userid);
            tranzactiiTableAdapter.InsertQueryTranzactie(userid, cecrypto, cefiat, valcrypto, valfiat, 2, DateTime.Now.ToString());
            MessageBox.Show("Tranzactie reusita!");
            this.Hide();
            t2.Enabled = true;
            
         

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Tranzactie anulata!");
            this.Hide();
            t2.Enabled = true;
        }
       
    }
}
