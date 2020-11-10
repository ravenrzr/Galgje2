using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class frmsub : Form
    {
        public frmsub()
        {
            InitializeComponent();
        }

        public static String[] naam = new String[100];
        public static double[] prijs = new double[100];
        public static int[] btw = new int[100];
        public static int i = 0;
        public static int[] aantal = new int[100];

        private void Frmsub_Load(object sender, EventArgs e)
        {
            if(frmhoofd.taal == true)
            {
                frmsub frmsub_instance = new frmsub();
                frmsub_instance.Text = "Enter Data";
                lblprijs.Text = "Price";
                lblaantal.Text = "Amount";
                lblbtw.Text = "VAT-perc";
                btnbewaar.Text = "Save";
                btnnieuw.Text = "New";
            }
            else
            {
                frmsub frmsub_instance = new frmsub();
                frmsub_instance.Text = "Ingeven";
                lblprijs.Text = "Prijs";
                lblaantal.Text = "Aantal";
                lblbtw.Text = "BTW-perc";
                btnbewaar.Text = "Bewaar";
                btnnieuw.Text = "Nieuw";
            }
        }

        private void Btnbewaar_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtprijs.Text, out prijs[i]) && !int.TryParse(txtaantal.Text, out aantal[i]))
            {
                MessageBox.Show("Geef een getal in bij 'Prijs' en 'Aantal'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!double.TryParse(txtprijs.Text, out prijs[i]))
                {
                    MessageBox.Show("Geef een getal in bij 'Prijs'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (!int.TryParse(txtaantal.Text, out aantal[i]))
                {
                    MessageBox.Show("Geef een getal in bij 'Aantal'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (txtnaam.Text == "")
            {
                MessageBox.Show("Geef een productnaam in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                naam[i] = txtnaam.Text;
            }
            if (rdbtn6.Checked == true)
            {
                btw[i] = 6;
            }
            if(rdbtn12.Checked == true)
            {
                btw[i] = 12;
            }
            if(rdbtn21.Checked == true)
            {
                btw[i] = 21;
            }
            if(rdbtn12.Checked == false && rdbtn6.Checked == false && rdbtn21.Checked == false)
            {
                MessageBox.Show("Duid een BTW-Percentage aan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            i++;
        }

        private void Btnnieuw_Click(object sender, EventArgs e)
        {
            txtnaam.Text = "";
            txtprijs.Text = "";
            txtaantal.Text = "";
            rdbtn6.Checked = false;
            rdbtn12.Checked = false;
            rdbtn21.Checked = false;
            txtnaam.Focus();
        }
    }
}
