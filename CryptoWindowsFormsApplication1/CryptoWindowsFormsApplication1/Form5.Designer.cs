﻿namespace CryptoWindowsFormsApplication1
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cryptoDataSet = new CryptoWindowsFormsApplication1.cryptoDataSet();
            this.utilizatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilizatorTableAdapter = new CryptoWindowsFormsApplication1.cryptoDataSetTableAdapters.UtilizatorTableAdapter();
            this.tableAdapterManager = new CryptoWindowsFormsApplication1.cryptoDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.cryptoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parola actuala:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 82);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 27);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parola noua:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(171, 148);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 27);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 245);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Schimba parola!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.tableAdapterManager.CardTableAdapter = null;
            this.tableAdapterManager.PretCryptoTableAdapter = null;
            this.tableAdapterManager.Tranzactii_UtilizatoriTableAdapter = null;
            this.tableAdapterManager.TranzactiiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CryptoWindowsFormsApplication1.cryptoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilizatorTableAdapter = this.utilizatorTableAdapter;
            this.tableAdapterManager.WalletTableAdapter = null;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 333);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cryptoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private cryptoDataSet cryptoDataSet;
        private System.Windows.Forms.BindingSource utilizatorBindingSource;
        private cryptoDataSetTableAdapters.UtilizatorTableAdapter utilizatorTableAdapter;
        private cryptoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}