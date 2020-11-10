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
    public partial class frmvertalen : Form
    {
        public static String[] engels = new String[100];
        public static String[] ned = new String[100];        public static int i = -1;
        public frmvertalen()
        {
            InitializeComponent();
        }

        private void SluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Btntoevoeg_Click(object sender, EventArgs e)
        {
            i += 1;
            engels[i] = txteng.Text;
            ned[i] = txtned.Text;

            lstbxvertaling.Items.Add(engels[i] + "-" + ned[i]);
            txteng.Text = "";
            txtned.Text = "";
            txteng.Focus();
        }

        private void Btnverwijderen_Click(object sender, EventArgs e)
        {
            int lijsti = lstbxvertaling.SelectedIndex;

            lstbxvertaling.Items.Remove(lstbxvertaling.SelectedItem);

            for (int teller = lijsti+1; teller < i; teller++)
            {
                engels[teller-1] = engels[teller];
                ned[teller - 1] = ned[teller];
            }
            i -= 1;
        }

        private void Frmvertalen_Load(object sender, EventArgs e)
        {

        }

        private void Frmvertalen_Activated(object sender, EventArgs e)
        {
            if(engels[i+1] != "")
            {
                for (int teller = 0; teller <= i; teller++)
                {
                    lstbxvertaling.Items.Add(engels[teller] + "-" + ned[teller]);
                }
            }
        }
    }
}
