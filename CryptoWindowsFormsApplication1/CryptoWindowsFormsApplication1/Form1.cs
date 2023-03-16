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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ///DBCC CHECKIDENT ('Wallet',RESEED,0)  
        }

      
        private void cardBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cardBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cryptoDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cryptoDataSet.Wallet' table. You can move, or remove it, as needed.
           // this.walletTableAdapter.Fill(this.cryptoDataSet.Wallet);
            // TODO: This line of code loads data into the 'cryptoDataSet.Utilizator' table. You can move, or remove it, as needed.
            //this.utilizatorTableAdapter.Fill(this.cryptoDataSet.Utilizator);
            // TODO: This line of code loads data into the 'cryptoDataSet.Card' table. You can move, or remove it, as needed.
            //this.cardTableAdapter.Fill(this.cryptoDataSet.Card);

            cryptoDataSet.EnforceConstraints = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string u = textBox1.Text.ToString();
            string p = textBox2.Text.ToString();
            this.utilizatorTableAdapter.Fill(this.cryptoDataSet.Utilizator);
            DataTable dt = cryptoDataSet.Utilizator;
            int ok = 0;
            for (int i = 0; i < dt.Rows.Count && ok == 0; i++) {
                if (dt.Rows[i]["username"].ToString() == u&&dt.Rows[i]["password"].ToString()==p)
                    ok = 1;
            }
            if (ok == 0)
            {
                MessageBox.Show("Nu exista User");
            }
            else { 
                
            Form f=new Form2(utilizatorTableAdapter.ScalarQueryIdByUsername(u,p).Value,u);
            f.Show();
            this.Hide();
            
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string u = textBox1.Text.ToString();
            string p = textBox2.Text.ToString();
            if (u != "" && p != "")
            {
                int idcw;
                if (this.walletTableAdapter.ScalarQueryMaxID().Value == 0)
                    idcw = 1;
                else idcw = this.walletTableAdapter.ScalarQueryMaxID().Value + 1;
                 this.walletTableAdapter.InsertQueryWallet();
                 this.cardTableAdapter.InsertQueryCard();
                this.utilizatorTableAdapter.InsertQueryUser(u, p, idcw, idcw);
 
                MessageBox.Show("User inregistrat");


            }
            else MessageBox.Show("Campurile sunt goale!");

        }

     
    }
}
