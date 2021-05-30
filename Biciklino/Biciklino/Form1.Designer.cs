
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxKategorija = new System.Windows.Forms.ComboBox();
            this.labelKategorija = new System.Windows.Forms.Label();
            this.kalkulatorPP = new System.Windows.Forms.Button();
            this.buttonDodajDeo = new System.Windows.Forms.Button();
            this.labelNazivOglasa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(331, 42);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(23, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 396);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBoxKategorija
            // 
            this.comboBoxKategorija.FormattingEnabled = true;
            this.comboBoxKategorija.Location = new System.Drawing.Point(601, 42);
            this.comboBoxKategorija.Name = "comboBoxKategorija";
            this.comboBoxKategorija.Size = new System.Drawing.Size(152, 21);
            this.comboBoxKategorija.TabIndex = 2;
            this.comboBoxKategorija.SelectedIndexChanged += new System.EventHandler(this.comboBoxKategorija_SelectedIndexChanged);
            // 
            // labelKategorija
            // 
            this.labelKategorija.AutoSize = true;
            this.labelKategorija.Location = new System.Drawing.Point(601, 23);
            this.labelKategorija.Name = "labelKategorija";
            this.labelKategorija.Size = new System.Drawing.Size(54, 13);
            this.labelKategorija.TabIndex = 3;
            this.labelKategorija.Text = "Kategorija";
            this.labelKategorija.Click += new System.EventHandler(this.labelKategorija_Click);
            // 
            // kalkulatorPP
            // 
            this.kalkulatorPP.Location = new System.Drawing.Point(778, 219);
            this.kalkulatorPP.Name = "kalkulatorPP";
            this.kalkulatorPP.Size = new System.Drawing.Size(22, 92);
            this.kalkulatorPP.TabIndex = 4;
            this.kalkulatorPP.Text = "Calc";
            this.kalkulatorPP.UseVisualStyleBackColor = true;
            this.kalkulatorPP.Click += new System.EventHandler(this.kalkulatorPP_Click);
            // 
            // buttonDodajDeo
            // 
            this.buttonDodajDeo.Location = new System.Drawing.Point(643, 381);
            this.buttonDodajDeo.Name = "buttonDodajDeo";
            this.buttonDodajDeo.Size = new System.Drawing.Size(134, 57);
            this.buttonDodajDeo.TabIndex = 5;
            this.buttonDodajDeo.Text = "Dodaj deo";
            this.buttonDodajDeo.UseVisualStyleBackColor = true;
            this.buttonDodajDeo.Click += new System.EventHandler(this.buttonDodajDeo_Click);
            // 
            // labelNazivOglasa
            // 
            this.labelNazivOglasa.AutoSize = true;
            this.labelNazivOglasa.Location = new System.Drawing.Point(331, 22);
            this.labelNazivOglasa.Name = "labelNazivOglasa";
            this.labelNazivOglasa.Size = new System.Drawing.Size(68, 13);
            this.labelNazivOglasa.TabIndex = 6;
            this.labelNazivOglasa.Text = "Naziv oglasa";
            this.labelNazivOglasa.Click += new System.EventHandler(this.labelNazivOglasa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelNazivOglasa);
            this.Controls.Add(this.buttonDodajDeo);
            this.Controls.Add(this.kalkulatorPP);
            this.Controls.Add(this.labelKategorija);
            this.Controls.Add(this.comboBoxKategorija);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Biciklino";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label labelNazivOglasa;
    }
}

