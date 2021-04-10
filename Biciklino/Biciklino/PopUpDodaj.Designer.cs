
namespace Biciklino
{
    partial class PopUpDodaj
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
            this.comboBoxKategorija = new System.Windows.Forms.ComboBox();
            this.textBoxImeOglasa = new System.Windows.Forms.TextBox();
            this.comboBoxProizvodjac = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxKategorija
            // 
            this.comboBoxKategorija.FormattingEnabled = true;
            this.comboBoxKategorija.Items.AddRange(new object[] {
            "Grupa",
            "Gume"});
            this.comboBoxKategorija.Location = new System.Drawing.Point(12, 114);
            this.comboBoxKategorija.Name = "comboBoxKategorija";
            this.comboBoxKategorija.Size = new System.Drawing.Size(155, 24);
            this.comboBoxKategorija.TabIndex = 0;
            this.comboBoxKategorija.SelectedIndexChanged += new System.EventHandler(this.comboBoxKategorija_SelectedIndexChanged);
            // 
            // textBoxImeOglasa
            // 
            this.textBoxImeOglasa.Location = new System.Drawing.Point(12, 28);
            this.textBoxImeOglasa.Multiline = true;
            this.textBoxImeOglasa.Name = "textBoxImeOglasa";
            this.textBoxImeOglasa.Size = new System.Drawing.Size(204, 45);
            this.textBoxImeOglasa.TabIndex = 1;
            // 
            // comboBoxProizvodjac
            // 
            this.comboBoxProizvodjac.FormattingEnabled = true;
            this.comboBoxProizvodjac.Location = new System.Drawing.Point(224, 114);
            this.comboBoxProizvodjac.Name = "comboBoxProizvodjac";
            this.comboBoxProizvodjac.Size = new System.Drawing.Size(155, 24);
            this.comboBoxProizvodjac.TabIndex = 2;
            this.comboBoxProizvodjac.SelectedIndexChanged += new System.EventHandler(this.comboBoxProizvodjac_SelectedIndexChanged);
            // 
            // PopUpDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 497);
            this.Controls.Add(this.comboBoxProizvodjac);
            this.Controls.Add(this.textBoxImeOglasa);
            this.Controls.Add(this.comboBoxKategorija);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PopUpDodaj";
            this.Text = "Dodaj deo";
            this.Load += new System.EventHandler(this.PopUpDodaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxKategorija;
        private System.Windows.Forms.TextBox textBoxImeOglasa;
        private System.Windows.Forms.ComboBox comboBoxProizvodjac;
    }
}