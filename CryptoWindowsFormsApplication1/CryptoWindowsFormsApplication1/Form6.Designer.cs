namespace CryptoWindowsFormsApplication1
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cryptoDataSet = new CryptoWindowsFormsApplication1.cryptoDataSet();
            this.utilizatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilizatorTableAdapter = new CryptoWindowsFormsApplication1.cryptoDataSetTableAdapters.UtilizatorTableAdapter();
            this.tableAdapterManager = new CryptoWindowsFormsApplication1.cryptoDataSetTableAdapters.TableAdapterManager();
            this.cardTableAdapter = new CryptoWindowsFormsApplication1.cryptoDataSetTableAdapters.CardTableAdapter();
            this.tranzactiiTableAdapter = new CryptoWindowsFormsApplication1.cryptoDataSetTableAdapters.TranzactiiTableAdapter();
            this.walletTableAdapter = new CryptoWindowsFormsApplication1.cryptoDataSetTableAdapters.WalletTableAdapter();
            this.walletBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tranzactiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cryptoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.walletBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tranzactiiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 142);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Confirma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(319, 142);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 39);
            this.button2.TabIndex = 7;
            this.button2.Text = "Anuleaza";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cryptoDataSet
            // 
            this.cryptoDataSet.DataSetName = "cryptoDataSet";
            this.cryptoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilizatorBindingSource
            // 
            this.utilizatorBindingSource.DataMember = "Utilizator";
            this.utilizatorBindingSource.DataSource = this.cryptoDataSet;
            // 
            // utilizatorTableAdapter
            // 
            this.utilizatorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CardTableAdapter = this.cardTableAdapter;
            this.tableAdapterManager.PretCryptoTableAdapter = null;
            this.tableAdapterManager.Tranzactii_UtilizatoriTableAdapter = null;
            this.tableAdapterManager.TranzactiiTableAdapter = this.tranzactiiTableAdapter;
            this.tableAdapterManager.UpdateOrder = CryptoWindowsFormsApplication1.cryptoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilizatorTableAdapter = this.utilizatorTableAdapter;
            this.tableAdapterManager.WalletTableAdapter = this.walletTableAdapter;
            // 
            // cardTableAdapter
            // 
            this.cardTableAdapter.ClearBeforeFill = true;
            // 
            // tranzactiiTableAdapter
            // 
            this.tranzactiiTableAdapter.ClearBeforeFill = true;
            // 
            // walletTableAdapter
            // 
            this.walletTableAdapter.ClearBeforeFill = true;
            // 
            // walletBindingSource
            // 
            this.walletBindingSource.DataMember = "Wallet";
            this.walletBindingSource.DataSource = this.cryptoDataSet;
            // 
            // tranzactiiBindingSource
            // 
            this.tranzactiiBindingSource.DataMember = "Tranzactii";
            this.tranzactiiBindingSource.DataSource = this.cryptoDataSet;
            // 
            // cardBindingSource
            // 
            this.cardBindingSource.DataMember = "Card";
            this.cardBindingSource.DataSource = this.cryptoDataSet;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "label7";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 229);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Activated += new System.EventHandler(this.Form6_Activated);
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cryptoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.walletBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tranzactiiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private cryptoDataSet cryptoDataSet;
        private System.Windows.Forms.BindingSource utilizatorBindingSource;
        private cryptoDataSetTableAdapters.UtilizatorTableAdapter utilizatorTableAdapter;
        private cryptoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private cryptoDataSetTableAdapters.WalletTableAdapter walletTableAdapter;
        private System.Windows.Forms.BindingSource walletBindingSource;
        private cryptoDataSetTableAdapters.TranzactiiTableAdapter tranzactiiTableAdapter;
        private System.Windows.Forms.BindingSource tranzactiiBindingSource;
        private cryptoDataSetTableAdapters.CardTableAdapter cardTableAdapter;
        private System.Windows.Forms.BindingSource cardBindingSource;
        private System.Windows.Forms.Label label7;
    }
}