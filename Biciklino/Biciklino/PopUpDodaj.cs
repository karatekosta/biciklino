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
    public partial class PopUpDodaj : Form
    {
        public PopUpDodaj()
        {
            InitializeComponent();
        }

        private void PopUpDodaj_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kategorija = (comboBoxKategorija.SelectedItem).ToString();
            switch (kategorija)
            {
                case "Grupa":
                    comboBoxProizvodjac.Items.Clear();
                    comboBoxProizvodjac.Items.Add("SRAM");
                    comboBoxProizvodjac.Items.Add("Shimano");
                    break;
                case "Gume":
                    comboBoxProizvodjac.Items.Clear();
                    comboBoxProizvodjac.Items.Add("Maxxis");
                    comboBoxProizvodjac.Items.Add("Schwalbe");
                    comboBoxProizvodjac.Items.Add("Continental");
                    break;
            }
        }

        private void comboBoxProizvodjac_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
