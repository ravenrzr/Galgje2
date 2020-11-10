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
    public partial class frmhoofd : Form
    {
        public static double totaal = 0, hulp;
        public static bool taal = false;
        public frmhoofd()
        {
            InitializeComponent();
        }

        private void VerkoopsgegevensIngevenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsub frmsub_instance = new frmsub();
            frmsub_instance.Show();
        }

        private void AfrekenenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            totaal = 0;
            lstvwartikelen.Items.Clear();
            for (int teller = 0; teller < frmsub.naam.Length; teller++)
            {
                if (frmsub.naam[teller] != "" && frmsub.naam[teller] != null)
                {
                    double subtotaal = (frmsub.prijs[teller]-((frmsub.prijs[teller] / 100) * frmsub.btw[teller]))*frmsub.aantal[teller];

                    ListViewItem item = new ListViewItem(frmsub.naam[teller]);
                    item.SubItems.Add(frmsub.aantal[teller].ToString());
                    item.SubItems.Add("€ " + frmsub.prijs[teller].ToString());
                    item.SubItems.Add(frmsub.btw[teller].ToString()+"%");
                    item.SubItems.Add("€ " + subtotaal.ToString());
                    lstvwartikelen.Items.Add(item);
                    totaal += subtotaal;
                }
            }
            if(cmbxsort.SelectedIndex == 0)
            {
                lstvwartikelen.Sorting = SortOrder.Ascending;
            }
            else
            {
                lstvwartikelen.Sorting = SortOrder.Descending;
            }
            txttotaal.Text = "€ " + totaal.ToString();
        }

        private void Lstbxartikelen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Frmhoofd_Load(object sender, EventArgs e)
        {

        }

        private void Cmbxsort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxsort.SelectedIndex == 0)
            {
                lstvwartikelen.Sorting = SortOrder.Ascending;
            }
            else
            {
                lstvwartikelen.Sorting = SortOrder.Descending;
            }
        }

        private void NieuwToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(taal == true)
            {
                DialogResult dialog = MessageBox.Show("Are you sure you want to clear all this data?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    lstvwartikelen.Items.Clear();
                    for (int teller = 0; teller < frmsub.naam.Length; teller++)
                    {
                        frmsub.aantal[teller] = 0;
                        frmsub.naam[teller] = "";
                        frmsub.prijs[teller] = 0;
                        frmsub.btw[teller] = 0;
                        totaal = 0;
                        txttotaal.Text = "";
                    }
                }
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Bent u zeker dat u al deze gegevens wilt wissen?", "Bevestig", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    lstvwartikelen.Items.Clear();
                    for (int teller = 0; teller < frmsub.naam.Length; teller++)
                    {
                        frmsub.aantal[teller] = 0;
                        frmsub.naam[teller] = "";
                        frmsub.prijs[teller] = 0;
                        frmsub.btw[teller] = 0;
                        totaal = 0;
                        txttotaal.Text = "";
                    }
                }
            }
        }

        private void NederlandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmhoofd frm = new frmhoofd();
            frm.Text = "Inventaris";
            verkoopsgegevensIngevenToolStripMenuItem.Text = "Verkoopsgegevens Ingeven";
            afrekenenToolStripMenuItem.Text = "Afrekening";
            nieuwToolStripMenuItem.Text = "Wissen";
            taalToolStripMenuItem.Text = "Taal";
            auteurToolStripMenuItem.Text = "Auteur";
            eindeToolStripMenuItem.Text = "Einde";
            lbltitel.Text = "Producten";
            columnHeader1.Text = "Productnaam";
            columnHeader2.Text = "Aantal";
            columnHeader3.Text = "Prijs";
            columnHeader4.Text = "BTW-Percentage";
            columnHeader5.Text = "Subtotaal";
            lblsorteer.Text = "Sorteer";
            cmbxsort.Items[0] = "Oplopend";
            cmbxsort.Items[1] = "Aflopend";
            lbltotaal.Text = "Totaal";
            cmbxsort.Text = "Oplopend";
            taal = false;
        }

        private void EindeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AuteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(taal == true)
            {
                MessageBox.Show("Matthis Van Hoecke", "Author", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Matthis Van Hoecke", "Auteur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EnglishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmhoofd frm = new frmhoofd();
            frm.Text = "Inventory";
            verkoopsgegevensIngevenToolStripMenuItem.Text = "Enter Data";
            afrekenenToolStripMenuItem.Text = "Checkout";
            nieuwToolStripMenuItem.Text = "Clear";
            taalToolStripMenuItem.Text = "Language";
            auteurToolStripMenuItem.Text = "Author";
            eindeToolStripMenuItem.Text = "End";
            lbltitel.Text = "Products";
            columnHeader1.Text = "Product Name";
            columnHeader2.Text = "Amount";
            columnHeader3.Text = "Price";
            columnHeader4.Text = "VAT-Percentage";
            columnHeader5.Text = "Subtotal";
            lblsorteer.Text = "Sort";
            cmbxsort.Items[0] = "Ascending";
            cmbxsort.Items[1] = "Descending";
            lbltotaal.Text = "Total";
            cmbxsort.Text = "Ascending";
            taal = true;
        }
    }
}
