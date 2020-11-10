using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oef2
{
    public partial class frmoef2 : Form
    {
        public frmoef2()
        {
            InitializeComponent();
        }

        private void Btngenereer_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int aantal, ingang;
            int[] getallen = new int[0];
            if (!int.TryParse(txtaantal.Text, out aantal))
            {
                MessageBox.Show("Je moet een getal ingeven!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Array.Resize(ref getallen, aantal);
                for (int teller = 0; teller < aantal; teller++)
                {
                    getallen[teller] = random.Next(0, 100);
                }
                for (int teller = 0; teller < aantal; teller++)
                {
                    txtvoor.Text = txtvoor.Text + getallen[teller] + ", ";
                }
            }
            if (!int.TryParse(txtingang.Text, out ingang))
            {
                MessageBox.Show("Je moet een getal ingeven!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(ingang > aantal)
                {
                    MessageBox.Show("De ingang is te groot!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    for (int teller = ingang; teller < aantal - 1; teller++)
                    {
                        getallen[teller] = getallen[teller + 1];
                    }
                    Array.Resize(ref getallen, getallen.Length - 1);
                    for (int teller = 0; teller < aantal - 1; teller++)
                    {
                        txtna.Text = txtna.Text + getallen[teller] + ", ";
                    }
                }
            }
        }

        private void Frmoef2_Load(object sender, EventArgs e)
        {

        }

        private void Btngenereer_Leave(object sender, EventArgs e)
        {
            txtna.Text = "";
            txtvoor.Text = "";
            txtaantal.Text = "";
            txtingang.Text = "";
        }
    }
}
