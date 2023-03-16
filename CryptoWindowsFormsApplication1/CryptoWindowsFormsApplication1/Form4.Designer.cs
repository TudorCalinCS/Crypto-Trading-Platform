namespace CryptoWindowsFormsApplication1
{
    partial class Form4
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
            this.cryptoDataSet = new CryptoWindowsFormsApplication1.cryptoDataSet();
            this.cardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardTableAdapter = new CryptoWindowsFormsApplication1.cryptoDataSetTableAdapters.CardTableAdapter();
            this.tableAdapterManager = new CryptoWindowsFormsApplication1.cryptoDataSetTableAdapters.TableAdapterManager();
            this.pretCryptoTableAdapter = new CryptoWindowsFormsApplication1.cryptoDataSetTableAdapters.PretCryptoTableAdapter();
            this.utilizatorTableAdapter = new CryptoWindowsFormsApplication1.cryptoDataSetTableAdapters.UtilizatorTableAdapter();
            this.walletTableAdapter = new CryptoWindowsFormsApplication1.cryptoDataSetTableAdapters.WalletTableAdapter();
            this.pretCryptoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilizatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.walletBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tranzactiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tranzactiiTableAdapter = new CryptoWindowsFormsApplication1.cryptoDataSetTableAdapters.TranzactiiTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cryptoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pretCryptoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.walletBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tranzactiiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cryptoDataSet
            // 
            this.cryptoDataSet.DataSetName = "cryptoDataSet";
            this.cryptoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cardBindingSource
            // 
            this.cardBindingSource.DataMember = "Card";
            this.cardBindingSource.DataSource = this.cryptoDataSet;
            // 
            // cardTableAdapter
            // 
            this.cardTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CardTableAdapter = this.cardTableAdapter;
            this.tableAdapterManager.PretCryptoTableAdapter = this.pretCryptoTableAdapter;
            this.tableAdapterManager.Tranzactii_UtilizatoriTableAdapter = null;
            this.tableAdapterManager.TranzactiiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CryptoWindowsFormsApplication1.cryptoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilizatorTableAdapter = this.utilizatorTableAdapter;
            this.tableAdapterManager.WalletTableAdapter = this.walletTableAdapter;
            // 
            // pretCryptoTableAdapter
            // 
            this.pretCryptoTableAdapter.ClearBeforeFill = true;
            // 
            // utilizatorTableAdapter
            // 
            this.utilizatorTableAdapter.ClearBeforeFill = true;
            // 
            // walletTableAdapter
            // 
            this.walletTableAdapter.ClearBeforeFill = true;
            // 
            // pretCryptoBindingSource
            // 
            this.pretCryptoBindingSource.DataMember = "PretCrypto";
            this.pretCryptoBindingSource.DataSource = this.cryptoDataSet;
            // 
            // utilizatorBindingSource
            // 
            this.utilizatorBindingSource.DataMember = "Utilizator";
            this.utilizatorBindingSource.DataSource = this.cryptoDataSet;
            // 
            // walletBindingSource
            // 
            this.walletBindingSource.DataMember = "Wallet";
            this.walletBindingSource.DataSource = this.cryptoDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 158);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Confirma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(284, 158);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "Anuleaza";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tranzactiiBindingSource
            // 
            this.tranzactiiBindingSource.DataMember = "Tranzactii";
            this.tranzactiiBindingSource.DataSource = this.cryptoDataSet;
            // 
            // tranzactiiTableAdapter
            // 
            this.tranzactiiTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "---";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 260);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Activated += new System.EventHandler(this.Form4_Activated);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cryptoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pretCryptoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.walletBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tranzactiiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cryptoDataSet cryptoDataSet;
        private System.Windows.Forms.BindingSource cardBindingSource;
        private cryptoDataSetTableAdapters.CardTableAdapter cardTableAdapter;
        private cryptoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private cryptoDataSetTableAdapters.PretCryptoTableAdapter pretCryptoTableAdapter;
        private System.Windows.Forms.BindingSource pretCryptoBindingSource;
        private cryptoDataSetTableAdapters.UtilizatorTableAdapter utilizatorTableAdapter;
        private System.Windows.Forms.BindingSource utilizatorBindingSource;
        private cryptoDataSetTableAdapters.WalletTableAdapter walletTableAdapter;
        private System.Windows.Forms.BindingSource walletBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource tranzactiiBindingSource;
        private cryptoDataSetTableAdapters.TranzactiiTableAdapter tranzactiiTableAdapter;
        private System.Windows.Forms.Label label5;
    }
}