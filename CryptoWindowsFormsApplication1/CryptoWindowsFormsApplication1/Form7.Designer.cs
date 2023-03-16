namespace CryptoWindowsFormsApplication1
{
    partial class Form7
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
            this.tranzactii_UtilizatoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tranzactii_UtilizatoriTableAdapter = new CryptoWindowsFormsApplication1.cryptoDataSetTableAdapters.Tranzactii_UtilizatoriTableAdapter();
            this.tableAdapterManager = new CryptoWindowsFormsApplication1.cryptoDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.utilizatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilizatorTableAdapter = new CryptoWindowsFormsApplication1.cryptoDataSetTableAdapters.UtilizatorTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cryptoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tranzactii_UtilizatoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cryptoDataSet
            // 
            this.cryptoDataSet.DataSetName = "cryptoDataSet";
            this.cryptoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tranzactii_UtilizatoriBindingSource
            // 
            this.tranzactii_UtilizatoriBindingSource.DataMember = "Tranzactii_Utilizatori";
            this.tranzactii_UtilizatoriBindingSource.DataSource = this.cryptoDataSet;
            // 
            // tranzactii_UtilizatoriTableAdapter
            // 
            this.tranzactii_UtilizatoriTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CardTableAdapter = null;
            this.tableAdapterManager.PretCryptoTableAdapter = null;
            this.tableAdapterManager.Tranzactii_UtilizatoriTableAdapter = this.tranzactii_UtilizatoriTableAdapter;
            this.tableAdapterManager.TranzactiiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CryptoWindowsFormsApplication1.cryptoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilizatorTableAdapter = null;
            this.tableAdapterManager.WalletTableAdapter = null;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 161);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Confirma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(314, 161);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 45);
            this.button2.TabIndex = 6;
            this.button2.Text = "Anuleaza";
            this.button2.UseVisualStyleBackColor = true;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 30);
            this.label6.TabIndex = 7;
            this.label6.Text = "label6";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 263);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Activated += new System.EventHandler(this.Form7_Activated);
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cryptoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tranzactii_UtilizatoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cryptoDataSet cryptoDataSet;
        private System.Windows.Forms.BindingSource tranzactii_UtilizatoriBindingSource;
        private cryptoDataSetTableAdapters.Tranzactii_UtilizatoriTableAdapter tranzactii_UtilizatoriTableAdapter;
        private cryptoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource utilizatorBindingSource;
        private cryptoDataSetTableAdapters.UtilizatorTableAdapter utilizatorTableAdapter;
        private System.Windows.Forms.Label label6;
    }
}