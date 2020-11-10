using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjectGalgje
{
    public partial class frmwoorden : Form
    {
        public frmwoorden()
        {
            InitializeComponent();
        }

        private void Btnalle_Click(object sender, EventArgs e)
        {

            string path = AppDomain.CurrentDomain.BaseDirectory + "woorden.txt";
            StreamReader lees = new StreamReader(path);

            string[] list = lees.ReadToEnd().Split(',');
            for(int count = 0; count < list.Length; count++)
            {
                if(list[count].Contains(" "))
                {
                    list[count] = list[count].Replace(" ", "");
                }
                lstbxwoorden.Items.Add(list[count]);
            }
        }

        private void Btnverwijderen_Click(object sender, EventArgs e)
        {
            if(lstbxwoorden.SelectedIndex == -1)
            {
                MessageBox.Show("Niks geselecteerd!", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lstbxwoorden.Items.Remove(lstbxwoorden.SelectedItem);
            }
        }

        private void Btninvoegen_Click(object sender, EventArgs e)
        {
            if(!txtinvoegen.Text.Equals(""))
            {
                if (!lstbxwoorden.Items.Contains(txtinvoegen.Text))
                {
                    lstbxwoorden.Items.Add(txtinvoegen.Text);
                }
                else
                {
                    MessageBox.Show("Dit woord is al een deel van de woordenlijst!", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vul alstublieft iets in om toe te voegen tot de woordenlijst!", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btnleeg_Click(object sender, EventArgs e)
        {
            if(lstbxwoorden.Items.Count != 0)
            {
                lstbxwoorden.Items.Clear();
            }
            else
            {
                MessageBox.Show("Niks om te legen!", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frmwoorden_FormClosing(object sender, FormClosingEventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "galgje.txt";

            using (StreamWriter writer = File.CreateText(path))
            {
                for (int count = 0; count < lstbxwoorden.Items.Count; count++)
                {
                    writer.WriteLine(lstbxwoorden.Items[count].ToString());
                }
            }
        }
    }
}
