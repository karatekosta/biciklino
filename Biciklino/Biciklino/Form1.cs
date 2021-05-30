using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Biciklino
{
    public partial class Form1 : Form
    {
        private readonly BiciklinoEntities biciklino;
        public Form1()
        {
            InitializeComponent();
            biciklino = new BiciklinoEntities();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var vrsta = biciklino.Delovis.ToList();
            comboBoxKategorija.DisplayMember = "Deo";
            comboBoxKategorija.ValueMember = "id";
            comboBoxKategorija.DataSource = vrsta;
        }

        private void kalkulatorPP_Click(object sender, EventArgs e)
        {
            PopupCalc popup = new PopupCalc();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void buttonDodajDeo_Click(object sender, EventArgs e)
        {
            PopUpDodaj oglas = new PopUpDodaj();
            oglas.Show();
        }

        #region 
        private void labelKategorija_Click(object sender, EventArgs e)
        {

        }
        private void comboBoxKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle,
              Color.DimGray, 1, ButtonBorderStyle.Solid, // left
              Color.DimGray, 1, ButtonBorderStyle.Solid, // top
              Color.DimGray, 1, ButtonBorderStyle.Solid, // right
              Color.DimGray, 1, ButtonBorderStyle.Solid);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void labelNazivOglasa_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
