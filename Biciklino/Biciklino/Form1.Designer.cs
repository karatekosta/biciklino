
namespace Biciklino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxKategorija = new System.Windows.Forms.ComboBox();
            this.labelKategorija = new System.Windows.Forms.Label();
            this.kalkulatorPP = new System.Windows.Forms.Button();
            this.buttonDodajDeo = new System.Windows.Forms.Button();
            this.pictureBoxSettings = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(441, 52);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(31, 52);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 487);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBoxKategorija
            // 
            this.comboBoxKategorija.FormattingEnabled = true;
            this.comboBoxKategorija.Location = new System.Drawing.Point(801, 52);
            this.comboBoxKategorija.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxKategorija.Name = "comboBoxKategorija";
            this.comboBoxKategorija.Size = new System.Drawing.Size(201, 24);
            this.comboBoxKategorija.TabIndex = 2;
            this.comboBoxKategorija.SelectedIndexChanged += new System.EventHandler(this.comboBoxKategorija_SelectedIndexChanged);
            // 
            // labelKategorija
            // 
            this.labelKategorija.AutoSize = true;
            this.labelKategorija.Location = new System.Drawing.Point(801, 28);
            this.labelKategorija.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKategorija.Name = "labelKategorija";
            this.labelKategorija.Size = new System.Drawing.Size(72, 17);
            this.labelKategorija.TabIndex = 3;
            this.labelKategorija.Text = "Kategorija";
            this.labelKategorija.Click += new System.EventHandler(this.labelKategorija_Click);
            // 
            // kalkulatorPP
            // 
            this.kalkulatorPP.Location = new System.Drawing.Point(1043, 270);
            this.kalkulatorPP.Margin = new System.Windows.Forms.Padding(4);
            this.kalkulatorPP.Name = "kalkulatorPP";
            this.kalkulatorPP.Size = new System.Drawing.Size(24, 113);
            this.kalkulatorPP.TabIndex = 4;
            this.kalkulatorPP.Text = "Calc";
            this.kalkulatorPP.UseVisualStyleBackColor = true;
            this.kalkulatorPP.Click += new System.EventHandler(this.kalkulatorPP_Click);
            // 
            // buttonDodajDeo
            // 
            this.buttonDodajDeo.Location = new System.Drawing.Point(857, 469);
            this.buttonDodajDeo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDodajDeo.Name = "buttonDodajDeo";
            this.buttonDodajDeo.Size = new System.Drawing.Size(179, 70);
            this.buttonDodajDeo.TabIndex = 5;
            this.buttonDodajDeo.Text = "Dodaj deo";
            this.buttonDodajDeo.UseVisualStyleBackColor = true;
            this.buttonDodajDeo.Click += new System.EventHandler(this.buttonDodajDeo_Click);
            // 
            // pictureBoxSettings
            // 
            this.pictureBoxSettings.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSettings.Image")));
            this.pictureBoxSettings.Location = new System.Drawing.Point(1010, 12);
            this.pictureBoxSettings.Name = "pictureBoxSettings";
            this.pictureBoxSettings.Size = new System.Drawing.Size(45, 45);
            this.pictureBoxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSettings.TabIndex = 6;
            this.pictureBoxSettings.TabStop = false;
            this.pictureBoxSettings.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pictureBoxSettings);
            this.Controls.Add(this.buttonDodajDeo);
            this.Controls.Add(this.kalkulatorPP);
            this.Controls.Add(this.labelKategorija);
            this.Controls.Add(this.comboBoxKategorija);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Biciklino";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxKategorija;
        private System.Windows.Forms.Label labelKategorija;
        private System.Windows.Forms.Button kalkulatorPP;
        private System.Windows.Forms.Button buttonDodajDeo;
        private System.Windows.Forms.PictureBox pictureBoxSettings;
    }
}

