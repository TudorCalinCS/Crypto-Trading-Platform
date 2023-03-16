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
    

    public partial class Form2 : Form
    {
        private int userid;
        private string usernameSelectat;
        private int idfiat;
        private float suma;
        private int cod_fiat_selectat;
        private int relatie_vc = 1;
        private double sumaFiat;
        private string from;
        private string to;
        private double raportD;
        private int isFromFiat = -1, isToFiat = -1;
       private PictureBox pictureboxBTC=new PictureBox();
       private PictureBox pictureboxETH = new PictureBox();
       private PictureBox pictureboxSOL = new PictureBox();
       private PictureBox pictureboxMANA = new PictureBox();
       private PictureBox pictureboxBNB = new PictureBox();
       private PictureBox pictureboxUSD = new PictureBox();
       private PictureBox pictureboxEURO = new PictureBox();
       private PictureBox pictureboxLEI = new PictureBox();
       
        public Form2(int id,string ustnm)
        {
            InitializeComponent();
            userid = id;
            usernameSelectat = ustnm;
            //MessageBox.Show(id.ToString());
        }


        private void button1_Click(object sender, EventArgs e)//CUMPARA -WALLET
        {
            string cidf=comboBox1.Text;
            if (cidf == "USD")
                idfiat = 1;
            else if (cidf == "EURO") idfiat = 2;
            else idfiat = 3;
            suma = float.Parse(textBox1.Text);

            Form f3 = new Form3(userid,idfiat,suma,comboBox1.Text.ToString());
            f3.Show();
        }

        private void cardBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cardBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cryptoDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cryptoDataSet.Tranzactii_Utilizatori' table. You can move, or remove it, as needed.
            //this.tranzactii_UtilizatoriTableAdapter.Fill(this.cryptoDataSet.Tranzactii_Utilizatori);
            // TODO: This line of code loads data into the 'cryptoDataSet.Tranzactii' table. You can move, or remove it, as needed.
          //  this.tranzactiiTableAdapter.Fill(this.cryptoDataSet.Tranzactii);
            // TODO: This line of code loads data into the 'cryptoDataSet.Wallet' table. You can move, or remove it, as needed.
           /// this.walletTableAdapter.Fill(this.cryptoDataSet.Wallet);
            // TODO: This line of code loads data into the 'cryptoDataSet.Utilizator' table. You can move, or remove it, as needed.
            ///this.utilizatorTableAdapter.Fill(this.cryptoDataSet.Utilizator);
            // TODO: This line of code loads data into the 'cryptoDataSet.PretCrypto' table. You can move, or remove it, as needed.
           /// this.pretCryptoTableAdapter.Fill(this.cryptoDataSet.PretCrypto);
            // TODO: This line of code loads data into the 'cryptoDataSet.Card' table. You can move, or remove it, as needed.
           /// this.cardTableAdapter.Fill(this.cryptoDataSet.Card);
            this.cryptoDataSet.EnforceConstraints = false;
            timer1.Enabled = true;

            ///hide tabcontrol1 header
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
           
           /* pictureboxBTC.Image = Image.FromFile("H:\\CryptoWindowsForm\\UI DESIGN\\bitcoin.png");
            pictureboxETH.Image = Image.FromFile("H:\\CryptoWindowsForm\\UI DESIGN\\ethereum.png");
            pictureboxSOL.Image = Image.FromFile("H:\\CryptoWindowsForm\\UI DESIGN\\solana.png");
            pictureboxMANA.Image = Image.FromFile("H:\\CryptoWindowsForm\\UI DESIGN\\decentraland.png");
            pictureboxBNB.Image = Image.FromFile("H:\\CryptoWindowsForm\\UI DESIGN\\binance.png");
            pictureboxUSD.Image = CryptoWindowsFormsApplication1.Properties.Resources.dollars;
            pictureboxEURO.Image = Image.FromFile("H:\\CryptoWindowsForm\\UI DESIGN\\euros.png");
            pictureboxLEI.Image = Image.FromFile("H:\\CryptoWindowsForm\\UI DESIGN\\romania-money.png");*/
            pictureboxBTC.Image = CryptoWindowsFormsApplication1.Properties.Resources.bitcoin;
            pictureboxETH.Image=CryptoWindowsFormsApplication1.Properties.Resources.ethereum;
            pictureboxSOL.Image = CryptoWindowsFormsApplication1.Properties.Resources.solana;
            pictureboxMANA.Image = CryptoWindowsFormsApplication1.Properties.Resources.decentraland;
            pictureboxBNB.Image = CryptoWindowsFormsApplication1.Properties.Resources.binance;
            pictureboxUSD.Image = CryptoWindowsFormsApplication1.Properties.Resources.dollars;
            pictureboxEURO.Image = CryptoWindowsFormsApplication1.Properties.Resources.euros;
            pictureboxLEI.Image = CryptoWindowsFormsApplication1.Properties.Resources.romania_money;
            
        }

        private void tabPage2_Enter(object sender, EventArgs e)//WALLET
        {
            textBox2.Text = cardTableAdapter.ScalarQueryBalantaUSD(userid).Value.ToString("0.0#");
            textBox3.Text = cardTableAdapter.ScalarQueryBalantaEURO(userid).Value.ToString("0.0#");
            textBox4.Text = walletTableAdapter.ScalarQueryBalantaBTC(userid).Value.ToString();
            textBox5.Text = walletTableAdapter.ScalarQueryBalantaETH(userid).Value.ToString();
            textBox6.Text = walletTableAdapter.ScalarQueryBalantaSOL(userid).Value.ToString() ;
            textBox7.Text = walletTableAdapter.ScalarQueryBalantaMANA(userid).Value.ToString();
            textBox8.Text = walletTableAdapter.ScalarQueryBalantaBNB(userid).Value.ToString();
            textBox9.Text = cardTableAdapter.ScalarQueryBalantaLEI(userid).Value.ToString("0.0#");


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)//VALUTA -CUMPARA CRYPTO
        {
            label14.Text = "";
            
            if (comboBox2.Text == "USD") {
                label14.Text = cardTableAdapter.ScalarQueryBalantaUSD(userid).Value.ToString("0.0#");
                cod_fiat_selectat = 1;
                sumaFiat = cardTableAdapter.ScalarQueryBalantaUSD(userid).Value;
                sumaFiat = Convert.ToDouble(sumaFiat.ToString("0.0#"));
                pictureBox18.Image = pictureboxUSD.Image;
                if (comboBox3.Text != "")
                    pictureBox20.Image = pictureBox18.Image;   

            }
            else if (comboBox2.Text == "EURO")
            {
                label14.Text = cardTableAdapter.ScalarQueryBalantaEURO(userid).Value.ToString("0.0#");
                cod_fiat_selectat = 2;
                sumaFiat = cardTableAdapter.ScalarQueryBalantaEURO(userid).Value;
                sumaFiat = Convert.ToDouble(sumaFiat.ToString("0.0#"));
                pictureBox18.Image = pictureboxEURO.Image;
                if (comboBox3.Text != "")
                    pictureBox20.Image = pictureBox18.Image;
            }
            else if(comboBox2.Text=="LEI") {
                label14.Text = cardTableAdapter.ScalarQueryBalantaLEI(userid).Value.ToString("0.0#");
                cod_fiat_selectat = 3;
                sumaFiat = cardTableAdapter.ScalarQueryBalantaLEI(userid).Value;
                sumaFiat = Convert.ToDouble(sumaFiat.ToString("0.0#"));
                pictureBox18.Image = pictureboxLEI.Image;
                if (comboBox3.Text != "")
                    pictureBox20.Image = pictureBox18.Image;
            }
        }
        void updateBalanta() { //UPDATE SCADERE BALANTA
        
        if (comboBox2.Text == "USD") {
                label14.Text = cardTableAdapter.ScalarQueryBalantaUSD(userid).Value.ToString("0.0#");
               
            }
            else if (comboBox2.Text == "EURO")
            {
                label14.Text = cardTableAdapter.ScalarQueryBalantaEURO(userid).Value.ToString("0.0#");
               
            }
        else if (comboBox2.Text == "LEI")
        {
                label14.Text = cardTableAdapter.ScalarQueryBalantaLEI(userid).Value.ToString("0.0#");
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)//CRESTERE/SCADERE CRYPTO
        {
            
            Random rd = new Random();
            
            double randBTC = rd.Next(1000, 3000) / 1000.0;
           double MinusSauPlus = rd.Next(1, 3);
           if (MinusSauPlus < 2)
               randBTC = randBTC * (-1);
           double randETH = rd.Next(300, 800) / 150.0;
            MinusSauPlus = rd.Next(1, 3);
            if (MinusSauPlus < 2)
                randETH = randETH * (-1);
            double randSOL = rd.Next(20, 80) / 100.0;
            MinusSauPlus = rd.Next(1, 3);
            if (MinusSauPlus < 2)
                randSOL = randSOL * (-1);
            double randMANA = rd.Next(30, 90) / 100.0;
            MinusSauPlus = rd.Next(1, 3);
            if (MinusSauPlus < 2)
                randMANA = randMANA * (-1);
            double randBNB = rd.Next(100, 200) / 100.0;
            MinusSauPlus = rd.Next(1, 3);
            if (MinusSauPlus < 2)
                randBNB = randBNB * (-1);
            pretCryptoTableAdapter.UpdateQueryCyptoValoare(randBTC,"BTC");
            pretCryptoTableAdapter.UpdateQueryCyptoValoare(randETH, "ETH");
            pretCryptoTableAdapter.UpdateQueryCyptoValoare(randSOL, "SOL");
            pretCryptoTableAdapter.UpdateQueryCyptoValoare(randMANA, "MANA");
            pretCryptoTableAdapter.UpdateQueryCyptoValoare(randBNB, "BNB");
            if (comboBox3.Text != "") {
                double x = pretCryptoTableAdapter.ScalarQueryValoareCryptoByNume(comboBox3.Text).Value;
                if (comboBox2.Text == "USD")
                    x = x*1;
                else if (comboBox2.Text == "EURO")
                {  
                    x = x * 0.94;
                }
                else
                {
                    x = x * 4.64;
                }
                label17.Text = x.ToString("0.00#");
            }

            Convertire_Vc();
            updateBalanta();
           //MessageBox.Show(walletTableAdapter.ScalarQueryBalantaETH(userid).Value.ToString().Contains("E").ToString());
           // timer1.Enabled = false;
           if (walletTableAdapter.ScalarQueryBalantaBTC(userid).Value.ToString().Contains("E"))
           {
                walletTableAdapter.UpdateQuerybalantaBTC_0(userid);
            }
           if (walletTableAdapter.ScalarQueryBalantaETH(userid).Value.ToString().Contains("E"))
            {
                walletTableAdapter.UpdateQuerybalantaETH_0(userid);
            }
           if (walletTableAdapter.ScalarQueryBalantaSOL(userid).Value.ToString().Contains("E"))
            {
                walletTableAdapter.UpdateQuerybalantaSOL_0(userid);
            }
           if (walletTableAdapter.ScalarQueryBalantaMANA(userid).Value.ToString().Contains("E"))
            {
                walletTableAdapter.UpdateQuerybalantaMANA_0(userid);
            }
           if (walletTableAdapter.ScalarQueryBalantaBNB(userid).Value.ToString().Contains("E"))
            {
                walletTableAdapter.UpdateQuerybalantaBNB_0(userid);
            }
           if (cardTableAdapter.ScalarQueryBalantaEURO(userid).Value.ToString().Contains("E"))
           {
                cardTableAdapter.UpdateQuerybalantaEURO_0(userid); 
           }
           if (cardTableAdapter.ScalarQueryBalantaUSD(userid).Value.ToString().Contains("E"))
            {
                cardTableAdapter.UpdateQuerybalantaUSD_0(userid);
            }
           if (cardTableAdapter.ScalarQueryBalantaLEI(userid).Value.ToString().Contains("E"))
            {
                cardTableAdapter.UpdateQuerybalantaLEI_0(userid);
            }
           
        
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)//CRYPTO- CUMPARA CRYPTO
        {
            label17.Text = "";
            label18.Text =comboBox3.Text;
            pictureBox20.Image = pictureBox18.Image;
            double x = pretCryptoTableAdapter.ScalarQueryValoareCryptoByNume(comboBox3.Text).Value;
                if (comboBox2.Text == "USD")
                    x = x*1;
                else if (comboBox2.Text == "EURO")
                {  
                    x = x * 0.94;
                }
                else
                {
                    x = x * 4.64;
                }
                label17.Text = x.ToString("0.00#");

                if (comboBox3.Text == "BTC") {
                    pictureBox19.Image = pictureboxBTC.Image;
                }
                if (comboBox3.Text == "ETH") {
                    pictureBox19.Image = pictureboxETH.Image; ;
                }
                if (comboBox3.Text == "SOL")
                {
                    pictureBox19.Image = pictureboxSOL.Image; ;
                }
                if (comboBox3.Text == "MANA")
                {
                    pictureBox19.Image = pictureboxMANA.Image;
                }
                if (comboBox3.Text == "BNB")
                {
                    pictureBox19.Image = pictureboxBNB.Image;
                }

        }
        void Convertire_Vc() {
            if (textBox10.Text != "")
            {
                double platafiat = float.Parse(textBox10.Text);
                double z;
                double x = pretCryptoTableAdapter.ScalarQueryValoareCryptoByNume(comboBox3.Text).Value;
                if (cod_fiat_selectat == 1)
                    z = 1;
                else if (cod_fiat_selectat == 2)
                    z = 0.94;
                else z = 4.64;
                if (relatie_vc == 1)
                    textBox11.Text = (platafiat/(x*z)).ToString("0.00000000#");
                else
                {
                    textBox11.Text = (platafiat * z * x).ToString("0.00#");
                }
            }
            else
                textBox11.Text = "";
        
        }
        private void textBox10_TextChanged(object sender, EventArgs e)//TEXT VALUTA- CUMPARA CRYPTO
        {
        
            Convertire_Vc();
        }

        private void button3_Click(object sender, EventArgs e)//BUTON SCHIMBARE - CUMPARA CRYPTO
        {
            if (relatie_vc == 1)
                relatie_vc = 0;
            else relatie_vc = 1;

            string x = label19.Text;
            label19.Text = label20.Text;
            label20.Text = x.ToString();


        }

        private void button2_Click(object sender, EventArgs e)//BUTON CUMPARA - CUMPARA CRYPTO
        {
            if (comboBox2.Text == "" || comboBox3.Text == "" || textBox10.Text == "")
            {
                MessageBox.Show("Campuri necompletate!");
            }
            else {
                int ok = 1;
               // MessageBox.Show(sumaFiat.ToString());
                if (relatie_vc == 1)
                {


                    if (sumaFiat < Convert.ToDouble(textBox10.Text))
                    {
                        MessageBox.Show("Balanta fiat insuficienta!");
                        ok = 0;
                    }
                 }

                else {

                    if (sumaFiat < Convert.ToDouble(textBox11.Text))
                    {
                        MessageBox.Show("Balanta fiat insuficienta!");
                        ok = 0;
                    }
                   }
                if (ok == 1) {
                    if (relatie_vc == 1)
                    {
                        Form f4 = new Form4(userid, relatie_vc, textBox10.Text, textBox11.Text, comboBox2.Text, comboBox3.Text, timer1);
                        f4.Show();
                    }
                    else {
                        Form f4 = new Form4(userid, relatie_vc, textBox11.Text, textBox10.Text, comboBox2.Text, comboBox3.Text, timer1);
                    f4.Show();
                    }

                    
                    timer1.Enabled=false;
                  

                }
            
            }
        }

        private void tabPage4_Enter(object sender, EventArgs e)//TRANZACTII- PROFIL
        {
            timer4.Enabled = true;
            listBox1.Items.Clear();
            this.tranzactiiTableAdapter.FillTranzByUser(cryptoDataSet.Tranzactii,userid);
            DataTable dt = cryptoDataSet.Tranzactii;
            for (int i = 0; i < dt.Rows.Count; i++) {
                if (dt.Rows[i]["tiptranz"].ToString() == "1")
                {
                    listBox1.Items.Add("Ati cumparat " + dt.Rows[i]["catfiat"] + " " + dt.Rows[i]["cefiat"] + " in "+dt.Rows[i]["datatranz"]);

                }
                else if (dt.Rows[i]["tiptranz"].ToString() == "2")
                {

                    listBox1.Items.Add("Ati cumparat " + dt.Rows[i]["catcrypto"] + " " + dt.Rows[i]["cecrypto"] + " cu " + dt.Rows[i]["catfiat"] + " " + dt.Rows[i]["cefiat"] + " in " + dt.Rows[i]["datatranz"]);

                }
                else {
                    listBox1.Items.Add("Ati convertit " + dt.Rows[i]["catcrypto"] + " " + dt.Rows[i]["cecrypto"] + " pentru " + dt.Rows[i]["catfiat"] + " " + dt.Rows[i]["cefiat"] + " in " + dt.Rows[i]["datatranz"]);
                
                }
            }
            int count_notificari = tranzactii_UtilizatoriTableAdapter.ScalarQueryCountNotificare(userid).Value;
            if (count_notificari > 0) {
                label33.Visible = true;
                label33.Text = count_notificari.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void label21_DoubleClick(object sender, EventArgs e)//SCHIMBA PAROLA-PROFIL
        {
            Form f5 = new Form5(userid);
            f5.Show();
        }

        private void label23_DoubleClick(object sender, EventArgs e)//LOGOUT- PROFIL
        {
            Form f1 = new Form1();
            this.Close();
            f1.Show();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)//FROM- TRADE
        {
            if (comboBox4.Text == comboBox5.Text && comboBox4.Text != "")
            {
                MessageBox.Show("Nu poti schimba " + comboBox4.Text + " cu " + comboBox5.Text + "!");
            }
            else {
                from = comboBox4.Text;
                to = comboBox5.Text;
            
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)//TO-TRADE
        {
            if (comboBox4.Text == comboBox5.Text && comboBox4.Text != "")
            {
                MessageBox.Show("Nu poti schimba " + comboBox4.Text + " cu " + comboBox5.Text + "!");
            }
            else
            {
                to = comboBox5.Text;
                from = comboBox4.Text;

            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)//FROM
        {
            if (comboBox4.Text == "" || comboBox5.Text == "")
            {
                MessageBox.Show("Introdu mai intai toate datele!");
                textBox12.Clear();
            }
            else
            {
                raport(from, to);
                if (textBox12.Text == "")
                {
                    MessageBox.Show("Campuri goale!");
                    textBox13.Clear();
                }
                else
                {
                    
                    textBox13.Text = (Convert.ToDouble(textBox12.Text) * raportD).ToString("0.000#");
                }
            }
        }

        void raport(string from, string to)//RAPORT FROM-TO
        {
             isFromFiat = 0; isToFiat = 0;
            if (from == "USD" || from == "EURO" || from == "LEI")
                isFromFiat = 1;
            if (to == "USD" || to == "EURO" || to == "LEI")
                isToFiat = 1;

            if (isFromFiat == 1 && isToFiat == 1)
            {

                if (from == "USD")
                {
                    if (to == "EURO")
                        raportD = 0.94;
                    else raportD = 4.64;
                }
                else if (from == "EURO")
                {
                    if (to == "USD")
                        raportD = 1.07;
                    else raportD = 4.95;
                }
                else
                {
                    if (to == "EURO")
                        raportD = 0.2;
                    else raportD = 0.21;
                }

            }
            if (isFromFiat == 1 && isToFiat == 0)
            {

                double x = pretCryptoTableAdapter.ScalarQueryValoareCryptoByNume(to).Value;
                if (from == "USD")
                {
                    raportD = 1 / x;
                }
                else if (from == "EURO")
                {
                    raportD = 1 / (x * 0.94);
                }
                else raportD = 1 / (x * 4.64);
            }
            if (isFromFiat == 0 && isToFiat == 1)
            {
                double x = pretCryptoTableAdapter.ScalarQueryValoareCryptoByNume(from).Value;
                if (to == "USD")
                    raportD = 1*x;
                else if (to == "EURO")
                {
                    raportD = 0.94*x;

                }
                else raportD = 4.64*x;

            }
            if(isFromFiat==0&&isToFiat==0) {
                double x = pretCryptoTableAdapter.ScalarQueryValoareCryptoByNume(from).Value;
                double y = pretCryptoTableAdapter.ScalarQueryValoareCryptoByNume(to).Value;
                raportD = x / y;
            
            }
        }

        private void tabPage5_Enter(object sender, EventArgs e)//ACTIVARE TIMER2
        {
            timer2.Enabled = true;

        }

        private void timer2_Tick(object sender, EventArgs e)//UPDATE TEXTBOX
        {

            if (comboBox4.Text != "" && comboBox5.Text != "")
            //if (from != null && to != null && comboBox4.Text != null && comboBox5.Text != null)
            {
                raport(from, to);
                if(textBox12.Text!="")
                    textBox13.Text = (Convert.ToDouble(textBox12.Text) * raportD).ToString("0.0000000#");
            }
        }

        private void button4_Click(object sender, EventArgs e)//BUTON CONVERTESTE- TRADE
        {
           // MessageBox.Show(isFromFiat.ToString() + isToFiat.ToString())
            int ok = 1;
            if (isFromFiat == 1)
            {
                double z;
                if (comboBox4.Text == "USD")
                    z = cardTableAdapter.ScalarQueryBalantaUSD(userid).Value;
                else if (comboBox4.Text == "EURO")
                    z = cardTableAdapter.ScalarQueryBalantaEURO(userid).Value;
                else z = cardTableAdapter.ScalarQueryBalantaLEI(userid).Value;
                string str =z.ToString("0.0#");
                z = Convert.ToDouble(str);
                if (Convert.ToDouble(textBox12.Text) > z)
                {
                    MessageBox.Show("Balanta " + comboBox4.Text + " insuficienta" + '\n' + "Balanta: " + z.ToString("0.00#"));
                    ok = 0;
                }
            }
            else {

                double t=0.0;
                if (comboBox4.Text == "BTC")
                    t = walletTableAdapter.ScalarQueryBalantaBTC(userid).Value;
                 else if (comboBox4.Text == "ETH")
                    t = walletTableAdapter.ScalarQueryBalantaETH(userid).Value;
                else  if (comboBox4.Text == "SOL")
                    t = walletTableAdapter.ScalarQueryBalantaSOL(userid).Value;
                else if (comboBox4.Text == "MANA")
                    t = walletTableAdapter.ScalarQueryBalantaMANA(userid).Value;
                else   if (comboBox4.Text == "BNB")
                    t = walletTableAdapter.ScalarQueryBalantaBNB(userid).Value;
                string str = t.ToString("0.00000#");
                t = Convert.ToDouble(str);
                if (Convert.ToDouble(textBox12.Text) > t && !(Convert.ToDouble(textBox12.Text).ToString().Equals(t.ToString())))
                {
                    MessageBox.Show("Balanta " + comboBox4.Text + " insuficienta" + '\n' + "Balanta: " + t.ToString("0.00#"));
                    ok = 0;
                    MessageBox.Show(Convert.ToDouble(textBox12.Text).ToString()+" "+t);
                }
            
            }
            if (ok == 1) {
                Form f6 = new Form6(textBox12.Text,comboBox4.Text,textBox13.Text,comboBox5.Text,userid);
                f6.Show();
            
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(isFromFiat.ToString() + '\n' + isToFiat.ToString() + '\n' + raportD.ToString() + '\n');
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//LOCATIE PICTURE BOX LOCATIE PICTURE BOX LOCATIE PICTURE BOX 
        {
            label28.Text = comboBox1.Text;
            if (label28.Text == "USD")
            {
                label29.Text = cardTableAdapter.ScalarQueryBalantaUSD(userid).Value.ToString("0.0#");
                pictureBox17.Image = pictureboxUSD.Image;
            }
            if (label28.Text == "EURO")
            {
                label29.Text = cardTableAdapter.ScalarQueryBalantaEURO(userid).Value.ToString("0.0#");
                pictureBox17.Image = pictureboxEURO.Image ;
            }
            if (label28.Text == "LEI")
            {
                label29.Text = cardTableAdapter.ScalarQueryBalantaLEI(userid).Value.ToString("0.0#");
                pictureBox17.Image = pictureboxLEI.Image;
            
            }
           
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            timer3.Enabled = true;
            
        }

        private void tabPage1_Leave(object sender, EventArgs e)
        {
            timer3.Enabled = false;
        }

        private void timer3_Tick(object sender, EventArgs e)//TIMER UPDATE BALANTA- CUMPARA VALUTA
        {
            if (comboBox1.Text != "")
            {
                if (label28.Text == "USD")
                    label29.Text = cardTableAdapter.ScalarQueryBalantaUSD(userid).Value.ToString("0.0#");
                if (label28.Text == "EURO")
                    label29.Text = cardTableAdapter.ScalarQueryBalantaEURO(userid).Value.ToString("0.0#");
                if (label28.Text == "LEI")
                    label29.Text = cardTableAdapter.ScalarQueryBalantaLEI(userid).Value.ToString("0.0#");

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox4.Text == "USD") {
                textBox12.Text = cardTableAdapter.ScalarQueryBalantaUSD(userid).Value.ToString("0.0#");
            }
            if (comboBox4.Text == "EURO")
            {
                textBox12.Text = cardTableAdapter.ScalarQueryBalantaEURO(userid).Value.ToString("0.0#");
            }
            if (comboBox4.Text == "LEI")
            {
                textBox12.Text = cardTableAdapter.ScalarQueryBalantaLEI(userid).Value.ToString("0.0#");
            }
            if (comboBox4.Text == "BTC") {
                textBox12.Text = walletTableAdapter.ScalarQueryBalantaBTC(userid).Value.ToString("0.000000");
            }
            if (comboBox4.Text == "ETH")
            {
                textBox12.Text = walletTableAdapter.ScalarQueryBalantaETH(userid).Value.ToString("0.000000");
            }
            if (comboBox4.Text == "SOL")
            {
                textBox12.Text = walletTableAdapter.ScalarQueryBalantaSOL(userid).Value.ToString("0.000000");
            }
            if (comboBox4.Text == "MANA")
            {
                textBox12.Text = walletTableAdapter.ScalarQueryBalantaMANA(userid).Value.ToString("0.000000");
            }
            if (comboBox4.Text == "BNB")
            {
                textBox12.Text = walletTableAdapter.ScalarQueryBalantaBNB(userid).Value.ToString("0.000000");
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string utilizatorT = textBox14.Text;
            DataTable dt = cryptoDataSet.Utilizator;
            utilizatorTableAdapter.Fill(cryptoDataSet.Utilizator);
            int ok = 0;
            if (utilizatorT == usernameSelectat)
                ok = -1;
            for (int i = 0; i < dt.Rows.Count && ok == 0; i++)
            {
                if (utilizatorT.ToString() == dt.Rows[i]["username"].ToString())
                    ok = 1;
            }
            if (ok == -1) {
                MessageBox.Show("Nu-ti poti trimite tie!");
                textBox14.Text = "";
            }
            else if (ok == 0)
            {
                MessageBox.Show("Nu exista utilizator cu username " + utilizatorT);
                textBox14.Text = "";
            }
            else {

               dt= cryptoDataSet.Tranzactii_Utilizatori;
               tranzactii_UtilizatoriTableAdapter.Fill(cryptoDataSet.Tranzactii_Utilizatori);
               int okk = 1;
               for (int i = 0; i < dt.Rows.Count&&okk==1; i++) {
                   if (Convert.ToInt32(dt.Rows[i]["userTrimite"]) == userid && dt.Rows[i]["cetrimite"].ToString() == comboBox6.Text)
                       okk =0;
            
               }

               if (okk == 0)
                   MessageBox.Show("Asteapta finalizarea tranzactiei cu " + comboBox6.Text + " pentru a trimite din nou " + comboBox6.Text);
               else
               {

                   double x = 0.0;
                   string xx;
                   if (comboBox6.Text == "USD")
                   {
                       x = cardTableAdapter.ScalarQueryBalantaUSD(userid).Value;
                       
                   }
                   if (comboBox6.Text == "EURO")
                   {
                       x = cardTableAdapter.ScalarQueryBalantaEURO(userid).Value;
                   }
                   if (comboBox6.Text == "LEI")
                   {
                       x = cardTableAdapter.ScalarQueryBalantaLEI(userid).Value;
                   }
                   if (comboBox6.Text == "BTC")
                   {
                       x = walletTableAdapter.ScalarQueryBalantaBTC(userid).Value;
                   }
                   if (comboBox6.Text == "ETH")
                   {
                       x = walletTableAdapter.ScalarQueryBalantaETH(userid).Value;
                   }
                   if (comboBox6.Text == "SOL")
                   {
                       x = walletTableAdapter.ScalarQueryBalantaSOL(userid).Value;
                   }
                   if (comboBox6.Text == "MANA")
                   {
                       x = walletTableAdapter.ScalarQueryBalantaMANA(userid).Value;
                   }
                   if (comboBox6.Text == "BNB")
                   {
                       x = walletTableAdapter.ScalarQueryBalantaBNB(userid).Value;
                   }
                   xx = x.ToString("0.000000");
                   x = Convert.ToDouble(xx);
                   if (Convert.ToDouble(textBox15.Text) > x)
                   {
                       MessageBox.Show("Suma depaseste balanta" + '\n' + "Balanta " + comboBox6.Text + " : " + x.ToString());
                   }
                   else
                   {
                       Form f7 = new Form7(textBox14.Text, comboBox6.Text, Convert.ToDouble(textBox15.Text), userid);
                       f7.Show();
                   }

               }
           
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox6.Text == "USD")
            {
                textBox15.Text = cardTableAdapter.ScalarQueryBalantaUSD(userid).Value.ToString("0.0#");
            }
            if (comboBox6.Text == "EURO")
            {
                textBox15.Text = cardTableAdapter.ScalarQueryBalantaEURO(userid).Value.ToString("0.0#");
            }
            if (comboBox6.Text == "LEI")
            {
                textBox15.Text = cardTableAdapter.ScalarQueryBalantaLEI(userid).Value.ToString("0.0#");
            }
            if (comboBox6.Text == "BTC")
            {
                textBox15.Text = walletTableAdapter.ScalarQueryBalantaBTC(userid).Value.ToString("0.000000");
            }
            if (comboBox6.Text == "ETH")
            {
                textBox15.Text = walletTableAdapter.ScalarQueryBalantaETH(userid).Value.ToString("0.000000");
            }
            if (comboBox6.Text == "SOL")
            {
                textBox15.Text = walletTableAdapter.ScalarQueryBalantaSOL(userid).Value.ToString("0.000000");
            }
            if (comboBox6.Text == "MANA")
            {
                textBox15.Text = walletTableAdapter.ScalarQueryBalantaMANA(userid).Value.ToString("0.000000");
            }
            if (comboBox6.Text == "BNB")
            {
                textBox15.Text = walletTableAdapter.ScalarQueryBalantaBNB(userid).Value.ToString("0.000000");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel1.Visible=false;
        }

        private void panel1_VisibleChanged(object sender, EventArgs e)
        {
            if (panel1.Visible == true) {
                listBox2.Items.Clear();
                DataTable dt = cryptoDataSet.Tranzactii_Utilizatori;
                tranzactii_UtilizatoriTableAdapter.FillByUserTrUt(cryptoDataSet.Tranzactii_Utilizatori,userid);
                for (int i = 0; i < dt.Rows.Count; i++) {
                    int usertrimite = Convert.ToInt32(dt.Rows[i]["userTrimite"]);
                    string usernameTrimite = utilizatorTableAdapter.ScalarQueryUsernameById(usertrimite);
                    string cetrimite = dt.Rows[i]["cetrimite"].ToString();
                    double cattrimite = Convert.ToDouble(dt.Rows[i]["cattrimite"]);
                    listBox2.Items.Add(usernameTrimite + " doreste sa-ti trimita " + cattrimite.ToString() + " " + cetrimite);
                    

                }
            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBox2.SelectedIndex;
            DataTable dt = cryptoDataSet.Tranzactii_Utilizatori;
            tranzactii_UtilizatoriTableAdapter.FillByUserTrUt(cryptoDataSet.Tranzactii_Utilizatori, userid);
            int usertrimite = Convert.ToInt32(dt.Rows[i]["userTrimite"]);
            string usernameTrimite = utilizatorTableAdapter.ScalarQueryUsernameById(usertrimite);
            string cetrimite = dt.Rows[i]["cetrimite"].ToString();
            double cattrimite = Convert.ToDouble(dt.Rows[i]["cattrimite"]);
            int idtranzutilizator =Convert.ToInt32(dt.Rows[i]["id_tranzutilizatori"]);
            Form f8 = new Form8( listBox2.Text,usertrimite, cetrimite,cattrimite,userid,idtranzutilizator);
            f8.Show();

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                listBox2.Items.Clear();
                DataTable dt = cryptoDataSet.Tranzactii_Utilizatori;
                tranzactii_UtilizatoriTableAdapter.FillByUserTrUt(cryptoDataSet.Tranzactii_Utilizatori, userid);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int usertrimite = Convert.ToInt32(dt.Rows[i]["userTrimite"]);
                    string usernameTrimite = utilizatorTableAdapter.ScalarQueryUsernameById(usertrimite);
                    string cetrimite = dt.Rows[i]["cetrimite"].ToString();
                    double cattrimite = Convert.ToDouble(dt.Rows[i]["cattrimite"]);
                    listBox2.Items.Add(usernameTrimite + " doreste sa-ti trimita " + cattrimite.ToString() + " " + cetrimite);


                }
            }
            int count_notificari = tranzactii_UtilizatoriTableAdapter.ScalarQueryCountNotificare(userid).Value;
            if (count_notificari > 0)
            {
                label33.Visible = true;
                label33.Text = count_notificari.ToString();
                pictureBox1.Visible = true;
            }
            else {
                pictureBox1.Visible = false;
                label33.Visible = false ;
                panel1.Visible = false;
            
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            if (relatie_vc == 1)
                relatie_vc = 0;
            else relatie_vc = 1;

            string x = label19.Text;
            label19.Text = label20.Text;
            label20.Text = x.ToString();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.Text == "USD")
                pictureBox24.Image = pictureboxUSD.Image;
            if (comboBox6.Text == "EURO")
                pictureBox24.Image = pictureboxEURO.Image;
            if (comboBox6.Text == "LEI")
                pictureBox24.Image = pictureboxLEI.Image;
            if (comboBox6.Text == "BTC")
                pictureBox24.Image = pictureboxBTC.Image;
            if (comboBox6.Text == "ETH")
                pictureBox24.Image = pictureboxETH.Image;
            if (comboBox6.Text == "SOL")
                pictureBox24.Image = pictureboxSOL.Image;
            if (comboBox6.Text == "MANA")
                pictureBox24.Image = pictureboxMANA.Image;
            if (comboBox6.Text == "BNB")
                pictureBox24.Image = pictureboxBNB.Image;
        }

       

       

      
    }
}
