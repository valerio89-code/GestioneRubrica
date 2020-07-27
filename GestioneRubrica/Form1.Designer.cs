namespace GestioneRubrica
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_caricaCSV = new System.Windows.Forms.Button();
            this.btn_addContact = new System.Windows.Forms.Button();
            this.btn_saveCSV = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(895, 385);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_caricaCSV
            // 
            this.btn_caricaCSV.Location = new System.Drawing.Point(35, 424);
            this.btn_caricaCSV.Name = "btn_caricaCSV";
            this.btn_caricaCSV.Size = new System.Drawing.Size(168, 75);
            this.btn_caricaCSV.TabIndex = 1;
            this.btn_caricaCSV.Text = "Carica CSV";
            this.btn_caricaCSV.UseVisualStyleBackColor = true;
            this.btn_caricaCSV.Click += new System.EventHandler(this.btn_caricaCSV_Click);
            // 
            // btn_addContact
            // 
            this.btn_addContact.Enabled = false;
            this.btn_addContact.Location = new System.Drawing.Point(358, 424);
            this.btn_addContact.Name = "btn_addContact";
            this.btn_addContact.Size = new System.Drawing.Size(168, 75);
            this.btn_addContact.TabIndex = 2;
            this.btn_addContact.Text = "Aggiungi contatto";
            this.btn_addContact.UseVisualStyleBackColor = true;
            this.btn_addContact.Click += new System.EventHandler(this.btn_addContact_Click);
            // 
            // btn_saveCSV
            // 
            this.btn_saveCSV.Enabled = false;
            this.btn_saveCSV.Location = new System.Drawing.Point(700, 424);
            this.btn_saveCSV.Name = "btn_saveCSV";
            this.btn_saveCSV.Size = new System.Drawing.Size(168, 75);
            this.btn_saveCSV.TabIndex = 3;
            this.btn_saveCSV.Text = "Salva CSV";
            this.btn_saveCSV.UseVisualStyleBackColor = true;
            this.btn_saveCSV.Click += new System.EventHandler(this.btn_saveCSV_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "(*.csv)|*.csv";
            this.openFileDialog1.InitialDirectory = "C:\\Corso c#";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "*.csv";
            this.saveFileDialog1.Filter = "(*.csv)|*.csv";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 521);
            this.Controls.Add(this.btn_saveCSV);
            this.Controls.Add(this.btn_addContact);
            this.Controls.Add(this.btn_caricaCSV);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_caricaCSV;
        private System.Windows.Forms.Button btn_addContact;
        private System.Windows.Forms.Button btn_saveCSV;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

