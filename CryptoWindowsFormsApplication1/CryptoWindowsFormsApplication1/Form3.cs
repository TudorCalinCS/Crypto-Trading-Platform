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

    public partial class Form3 : Form
    {
       
 //private int cont = 0;
        private int userid;
        private int idfiat;
        private float suma;
        private string carefiat;
        private int x = 0;
        private int y = 1;
        private TextBox ft;
        public Form3(int id,int idfiat,float suma,string cef)
        {
            InitializeComponent();
            userid = id;
            this.suma = suma;
            this.idfiat = idfiat;
            carefiat = cef;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(DateTime.Today.ToString());
            //MessageBox.Show(dateTimePicker1);
           // if (DateTime.Today > dateTimePicker1.MaxDate)
               // MessageBox.Show("DATA EXPIRATA");
            //MessageBox.Show(DateTime.Now.ToString());

            if (textBox1.Text.Count() != 19)
            {
                MessageBox.Show("Numar card invalid");
                textBox1.Clear();

            }

            else if (textBox2.Text.Count() != 3)
            {

                MessageBox.Show("CVV invalid");
                textBox2.Clear();
            }
            else if (DateTime.Compare(DateTime.Now, dateTimePicker1.Value) > 0)
            {
                MessageBox.Show("Card expirat!");
                dateTimePicker1.DataBindings.Clear();
            
            }
            else
            {
               // MessageBox.Show(DateTime.Now.ToString() + '\n' + dateTimePicker1.Value);
                int idc = this.utilizatorTableAdapter.ScalarQueryIdCardByUser(userid).Value;
                if (idfiat == 1)
                {
                    ///MessageBox.Show(suma.ToString()+idfiat.ToString());
                    cardTableAdapter.UpdateQuerybalantaUSD(suma, userid);


                }
                else if (idfiat == 2)
                {
                    ///MessageBox.Show(suma.ToString() + idfiat.ToString());
                    cardTableAdapter.UpdateQuerybalantaEURO(suma, userid);
                }
                else
                {
                    ///MessageBox.Show(suma.ToString() + idfiat.ToString());
                    cardTableAdapter.UpdateQuerybalantaLEI(suma, userid);
                }
                tranzactiiTableAdapter.InsertQueryTranzactie(userid, null, carefiat, null, suma.ToString(), 1, DateTime.Now.ToString());
                MessageBox.Show("Plata reusita!");
                this.Hide();

            }
            }

        private void utilizatorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utilizatorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cryptoDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cryptoDataSet.Tranzactii' table. You can move, or remove it, as needed.
           // this.tranzactiiTableAdapter.Fill(this.cryptoDataSet.Tranzactii);
            // TODO: This line of code loads data into the 'cryptoDataSet.Card' table. You can move, or remove it, as needed.
            ///this.cardTableAdapter.Fill(this.cryptoDataSet.Card);
            // TODO: This line of code loads data into the 'cryptoDataSet.Utilizator' table. You can move, or remove it, as needed.
           /// this.utilizatorTableAdapter.Fill(this.cryptoDataSet.Utilizator);
           /// 
            cryptoDataSet.EnforceConstraints = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Count() > 19)
            {
                
                MessageBox.Show("Prea multe numere!");
                textBox1.Text = "";
                y = 1;
                
            }
            else
            {
                ft = textBox1;
                x = textBox1.TextLength;
                if (x != y)
                {
                    textBox1.Text = "";
                    x = 0;
                    y = 1;
                }
                else
                {
                    y++;
                    if (textBox1.Text.Count() == 4 || textBox1.Text.Count() == 9 || textBox1.Text.Count() == 14)
                    {
                        textBox1.Text += "-";
                        textBox1.SelectionStart = textBox1.Text.Length;
                    }
                }
            }
        }
    }
}
