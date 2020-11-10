using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oefeningen_engels
{
    public partial class frmOefenen : Form
    {
        int getal;
        public frmOefenen()
        {
            InitializeComponent();
        }

        private void OpenenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmvertalen frmvertalen_instance = new frmvertalen();
            frmvertalen_instance.Show();
        }

        private void AfsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btnopgave_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            getal = random.Next(0, frmvertalen.i+1);

            txtengels.Text = frmvertalen.engels[getal];
            txtneder.Text = "";
            lblantwoord.Text = "";
            txtneder.Focus();
        }

        private void Btncontrole_Click(object sender, EventArgs e)
        {
            if (frmvertalen.ned[getal].Equals(txtneder.Text))
            {
                lblantwoord.Text = "Juist!";
            }
            else
            {
                lblantwoord.Text = "Fout!";
            }
            txtneder.Text = "";
            txtneder.Focus();
        }
    }
}
