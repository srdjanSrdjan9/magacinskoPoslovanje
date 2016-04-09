namespace Views
{
    partial class KreiranjeKlijentaForm
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
            this.nazivLabel = new System.Windows.Forms.Label();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.pibLabel = new System.Windows.Forms.Label();
            this.maticniBrojLabel = new System.Windows.Forms.Label();
            this.adresaLabel = new System.Windows.Forms.Label();
            this.mestoLabel = new System.Windows.Forms.Label();
            this.brojLabel = new System.Windows.Forms.Label();
            this.pibTextBox = new System.Windows.Forms.TextBox();
            this.maticniBrojTextBox = new System.Windows.Forms.TextBox();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.mestoTextBox = new System.Windows.Forms.TextBox();
            this.brojTextBox = new System.Windows.Forms.TextBox();
            this.sacuvajButton = new System.Windows.Forms.Button();
            this.ponistiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nazivLabel
            // 
            this.nazivLabel.AutoSize = true;
            this.nazivLabel.Location = new System.Drawing.Point(13, 13);
            this.nazivLabel.Name = "nazivLabel";
            this.nazivLabel.Size = new System.Drawing.Size(34, 13);
            this.nazivLabel.TabIndex = 0;
            this.nazivLabel.Text = "Naziv";
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.Location = new System.Drawing.Point(94, 6);
            this.nazivTextBox.MaxLength = 80;
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(100, 20);
            this.nazivTextBox.TabIndex = 1;
            // 
            // pibLabel
            // 
            this.pibLabel.AutoSize = true;
            this.pibLabel.Location = new System.Drawing.Point(13, 40);
            this.pibLabel.Name = "pibLabel";
            this.pibLabel.Size = new System.Drawing.Size(22, 13);
            this.pibLabel.TabIndex = 2;
            this.pibLabel.Text = "Pib";
            // 
            // maticniBrojLabel
            // 
            this.maticniBrojLabel.AutoSize = true;
            this.maticniBrojLabel.Location = new System.Drawing.Point(16, 73);
            this.maticniBrojLabel.Name = "maticniBrojLabel";
            this.maticniBrojLabel.Size = new System.Drawing.Size(61, 13);
            this.maticniBrojLabel.TabIndex = 3;
            this.maticniBrojLabel.Text = "Matični broj";
            // 
            // adresaLabel
            // 
            this.adresaLabel.AutoSize = true;
            this.adresaLabel.Location = new System.Drawing.Point(16, 103);
            this.adresaLabel.Name = "adresaLabel";
            this.adresaLabel.Size = new System.Drawing.Size(40, 13);
            this.adresaLabel.TabIndex = 4;
            this.adresaLabel.Text = "Adresa";
            // 
            // mestoLabel
            // 
            this.mestoLabel.AutoSize = true;
            this.mestoLabel.Location = new System.Drawing.Point(16, 135);
            this.mestoLabel.Name = "mestoLabel";
            this.mestoLabel.Size = new System.Drawing.Size(36, 13);
            this.mestoLabel.TabIndex = 5;
            this.mestoLabel.Text = "Mesto";
            // 
            // brojLabel
            // 
            this.brojLabel.AutoSize = true;
            this.brojLabel.Location = new System.Drawing.Point(16, 164);
            this.brojLabel.Name = "brojLabel";
            this.brojLabel.Size = new System.Drawing.Size(25, 13);
            this.brojLabel.TabIndex = 6;
            this.brojLabel.Text = "Broj";
            // 
            // pibTextBox
            // 
            this.pibTextBox.Location = new System.Drawing.Point(94, 40);
            this.pibTextBox.Name = "pibTextBox";
            this.pibTextBox.Size = new System.Drawing.Size(100, 20);
            this.pibTextBox.TabIndex = 7;
            // 
            // maticniBrojTextBox
            // 
            this.maticniBrojTextBox.Location = new System.Drawing.Point(94, 73);
            this.maticniBrojTextBox.Name = "maticniBrojTextBox";
            this.maticniBrojTextBox.Size = new System.Drawing.Size(100, 20);
            this.maticniBrojTextBox.TabIndex = 8;
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.Location = new System.Drawing.Point(94, 103);
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(100, 20);
            this.adresaTextBox.TabIndex = 9;
            // 
            // mestoTextBox
            // 
            this.mestoTextBox.Location = new System.Drawing.Point(94, 135);
            this.mestoTextBox.Name = "mestoTextBox";
            this.mestoTextBox.Size = new System.Drawing.Size(100, 20);
            this.mestoTextBox.TabIndex = 10;
            // 
            // brojTextBox
            // 
            this.brojTextBox.Location = new System.Drawing.Point(94, 164);
            this.brojTextBox.Name = "brojTextBox";
            this.brojTextBox.Size = new System.Drawing.Size(100, 20);
            this.brojTextBox.TabIndex = 11;
            // 
            // sacuvajButton
            // 
            this.sacuvajButton.Location = new System.Drawing.Point(16, 217);
            this.sacuvajButton.Name = "sacuvajButton";
            this.sacuvajButton.Size = new System.Drawing.Size(75, 23);
            this.sacuvajButton.TabIndex = 12;
            this.sacuvajButton.Text = "Sačuvaj";
            this.sacuvajButton.UseVisualStyleBackColor = true;
            this.sacuvajButton.Click += new System.EventHandler(this.sacuvajButton_Click);
            // 
            // ponistiButton
            // 
            this.ponistiButton.Location = new System.Drawing.Point(118, 216);
            this.ponistiButton.Name = "ponistiButton";
            this.ponistiButton.Size = new System.Drawing.Size(75, 23);
            this.ponistiButton.TabIndex = 13;
            this.ponistiButton.Text = "Poništi";
            this.ponistiButton.UseVisualStyleBackColor = true;
            this.ponistiButton.Click += new System.EventHandler(this.ponistiButton_Click);
            // 
            // KreiranjeKlijentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ponistiButton);
            this.Controls.Add(this.sacuvajButton);
            this.Controls.Add(this.brojTextBox);
            this.Controls.Add(this.mestoTextBox);
            this.Controls.Add(this.adresaTextBox);
            this.Controls.Add(this.maticniBrojTextBox);
            this.Controls.Add(this.pibTextBox);
            this.Controls.Add(this.brojLabel);
            this.Controls.Add(this.mestoLabel);
            this.Controls.Add(this.adresaLabel);
            this.Controls.Add(this.maticniBrojLabel);
            this.Controls.Add(this.pibLabel);
            this.Controls.Add(this.nazivTextBox);
            this.Controls.Add(this.nazivLabel);
            this.Name = "KreiranjeKlijentaForm";
            this.Text = "KreiranjeKlijentaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nazivLabel;
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.Label pibLabel;
        private System.Windows.Forms.Label maticniBrojLabel;
        private System.Windows.Forms.Label adresaLabel;
        private System.Windows.Forms.Label mestoLabel;
        private System.Windows.Forms.Label brojLabel;
        private System.Windows.Forms.TextBox pibTextBox;
        private System.Windows.Forms.TextBox maticniBrojTextBox;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.TextBox mestoTextBox;
        private System.Windows.Forms.TextBox brojTextBox;
        private System.Windows.Forms.Button sacuvajButton;
        private System.Windows.Forms.Button ponistiButton;
    }
}