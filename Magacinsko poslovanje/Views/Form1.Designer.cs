namespace Views
{
    partial class KreiranjeKorisnikaFrm
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
            this.ImeLbl = new System.Windows.Forms.Label();
            this.ImeTextBox = new System.Windows.Forms.TextBox();
            this.PrezimeLabel = new System.Windows.Forms.Label();
            this.PrezimeTextBox = new System.Windows.Forms.TextBox();
            this.JMBGLabel = new System.Windows.Forms.Label();
            this.JMBGTextBox = new System.Windows.Forms.TextBox();
            this.AdresaLabel = new System.Windows.Forms.Label();
            this.AdresaTextBox = new System.Windows.Forms.TextBox();
            this.SacuvajButton = new System.Windows.Forms.Button();
            this.PonistiButton = new System.Windows.Forms.Button();
            this.MestoLabel = new System.Windows.Forms.Label();
            this.MestoTextBox = new System.Windows.Forms.TextBox();
            this.BrojLabel = new System.Windows.Forms.Label();
            this.BrojTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ImeLbl
            // 
            this.ImeLbl.AutoSize = true;
            this.ImeLbl.Location = new System.Drawing.Point(14, 20);
            this.ImeLbl.Name = "ImeLbl";
            this.ImeLbl.Size = new System.Drawing.Size(24, 13);
            this.ImeLbl.TabIndex = 0;
            this.ImeLbl.Text = "Ime";
            this.ImeLbl.UseWaitCursor = true;
            // 
            // ImeTextBox
            // 
            this.ImeTextBox.Location = new System.Drawing.Point(108, 13);
            this.ImeTextBox.Name = "ImeTextBox";
            this.ImeTextBox.Size = new System.Drawing.Size(100, 20);
            this.ImeTextBox.TabIndex = 1;
            // 
            // PrezimeLabel
            // 
            this.PrezimeLabel.AutoSize = true;
            this.PrezimeLabel.Location = new System.Drawing.Point(13, 44);
            this.PrezimeLabel.Name = "PrezimeLabel";
            this.PrezimeLabel.Size = new System.Drawing.Size(44, 13);
            this.PrezimeLabel.TabIndex = 2;
            this.PrezimeLabel.Text = "Prezime";
            // 
            // PrezimeTextBox
            // 
            this.PrezimeTextBox.Location = new System.Drawing.Point(108, 37);
            this.PrezimeTextBox.Name = "PrezimeTextBox";
            this.PrezimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.PrezimeTextBox.TabIndex = 3;
            // 
            // JMBGLabel
            // 
            this.JMBGLabel.AutoSize = true;
            this.JMBGLabel.Location = new System.Drawing.Point(13, 70);
            this.JMBGLabel.Name = "JMBGLabel";
            this.JMBGLabel.Size = new System.Drawing.Size(36, 13);
            this.JMBGLabel.TabIndex = 4;
            this.JMBGLabel.Text = "JMBG";
            // 
            // JMBGTextBox
            // 
            this.JMBGTextBox.Location = new System.Drawing.Point(108, 63);
            this.JMBGTextBox.MaxLength = 13;
            this.JMBGTextBox.Name = "JMBGTextBox";
            this.JMBGTextBox.Size = new System.Drawing.Size(100, 20);
            this.JMBGTextBox.TabIndex = 5;
            // 
            // AdresaLabel
            // 
            this.AdresaLabel.AutoSize = true;
            this.AdresaLabel.Location = new System.Drawing.Point(13, 96);
            this.AdresaLabel.Name = "AdresaLabel";
            this.AdresaLabel.Size = new System.Drawing.Size(40, 13);
            this.AdresaLabel.TabIndex = 6;
            this.AdresaLabel.Text = "Adresa";
            // 
            // AdresaTextBox
            // 
            this.AdresaTextBox.Location = new System.Drawing.Point(108, 89);
            this.AdresaTextBox.Name = "AdresaTextBox";
            this.AdresaTextBox.Size = new System.Drawing.Size(100, 20);
            this.AdresaTextBox.TabIndex = 7;
            // 
            // SacuvajButton
            // 
            this.SacuvajButton.Location = new System.Drawing.Point(17, 202);
            this.SacuvajButton.Name = "SacuvajButton";
            this.SacuvajButton.Size = new System.Drawing.Size(75, 23);
            this.SacuvajButton.TabIndex = 8;
            this.SacuvajButton.Text = "Sačuvaj";
            this.SacuvajButton.UseVisualStyleBackColor = true;
            this.SacuvajButton.Click += new System.EventHandler(this.SacuvajButton_Click);
            // 
            // PonistiButton
            // 
            this.PonistiButton.Location = new System.Drawing.Point(133, 202);
            this.PonistiButton.Name = "PonistiButton";
            this.PonistiButton.Size = new System.Drawing.Size(75, 23);
            this.PonistiButton.TabIndex = 9;
            this.PonistiButton.Text = "Poništi";
            this.PonistiButton.UseVisualStyleBackColor = true;
            // 
            // MestoLabel
            // 
            this.MestoLabel.AutoSize = true;
            this.MestoLabel.Location = new System.Drawing.Point(13, 122);
            this.MestoLabel.Name = "MestoLabel";
            this.MestoLabel.Size = new System.Drawing.Size(36, 13);
            this.MestoLabel.TabIndex = 10;
            this.MestoLabel.Text = "Mesto";
            // 
            // MestoTextBox
            // 
            this.MestoTextBox.Location = new System.Drawing.Point(108, 115);
            this.MestoTextBox.Name = "MestoTextBox";
            this.MestoTextBox.Size = new System.Drawing.Size(100, 20);
            this.MestoTextBox.TabIndex = 11;
            // 
            // BrojLabel
            // 
            this.BrojLabel.AutoSize = true;
            this.BrojLabel.Location = new System.Drawing.Point(13, 148);
            this.BrojLabel.Name = "BrojLabel";
            this.BrojLabel.Size = new System.Drawing.Size(25, 13);
            this.BrojLabel.TabIndex = 12;
            this.BrojLabel.Text = "Broj";
            // 
            // BrojTextBox
            // 
            this.BrojTextBox.Location = new System.Drawing.Point(108, 141);
            this.BrojTextBox.Name = "BrojTextBox";
            this.BrojTextBox.Size = new System.Drawing.Size(100, 20);
            this.BrojTextBox.TabIndex = 13;
            // 
            // KreiranjeKorisnikaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BrojTextBox);
            this.Controls.Add(this.BrojLabel);
            this.Controls.Add(this.MestoTextBox);
            this.Controls.Add(this.MestoLabel);
            this.Controls.Add(this.PonistiButton);
            this.Controls.Add(this.SacuvajButton);
            this.Controls.Add(this.AdresaTextBox);
            this.Controls.Add(this.AdresaLabel);
            this.Controls.Add(this.JMBGTextBox);
            this.Controls.Add(this.JMBGLabel);
            this.Controls.Add(this.PrezimeTextBox);
            this.Controls.Add(this.PrezimeLabel);
            this.Controls.Add(this.ImeTextBox);
            this.Controls.Add(this.ImeLbl);
            this.Name = "KreiranjeKorisnikaFrm";
            this.Text = "Kreiraj korisnika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ImeLbl;
        private System.Windows.Forms.TextBox ImeTextBox;
        private System.Windows.Forms.Label PrezimeLabel;
        private System.Windows.Forms.TextBox PrezimeTextBox;
        private System.Windows.Forms.Label JMBGLabel;
        private System.Windows.Forms.TextBox JMBGTextBox;
        private System.Windows.Forms.Label AdresaLabel;
        private System.Windows.Forms.TextBox AdresaTextBox;
        private System.Windows.Forms.Button SacuvajButton;
        private System.Windows.Forms.Button PonistiButton;
        private System.Windows.Forms.Label MestoLabel;
        private System.Windows.Forms.TextBox MestoTextBox;
        private System.Windows.Forms.Label BrojLabel;
        private System.Windows.Forms.TextBox BrojTextBox;
    }
}

