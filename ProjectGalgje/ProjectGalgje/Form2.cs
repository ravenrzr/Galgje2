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

            //set path to "woorden.txt"
            string path = AppDomain.CurrentDomain.BaseDirectory + "woorden.txt";
            StreamReader lees = new StreamReader(path);

            //create array from "woorden.txt" and replace all spaces
            string[] list = lees.ReadToEnd().Split(',');

            for(int count = 0; count < list.Length; count++)
            {
                //check if the array contains spaces
                if(list[count].Contains(" "))
                {
                    //replace spaces with empty string
                    list[count] = list[count].Replace(" ", "");
                }
                //set the items in the item list to the array
                lstbxwoorden.Items.Add(list[count]);
            }
        }

        private void Btnverwijderen_Click(object sender, EventArgs e)
        {
            //check if the user hasn't selected any items from the list
            if(lstbxwoorden.SelectedIndex == -1)
            {
                //send error message
                MessageBox.Show("Niks geselecteerd!", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //remove item from list
                lstbxwoorden.Items.Remove(lstbxwoorden.SelectedItem);
            }
        }

        private void Btninvoegen_Click(object sender, EventArgs e)
        {
            //check if the user has filled in the textbox
            if(!txtinvoegen.Text.Equals(""))
            {
                //check if the word in the textbox is already a part of the list
                if (!lstbxwoorden.Items.Contains(txtinvoegen.Text))
                {
                    //add word in textbox to list
                    lstbxwoorden.Items.Add(txtinvoegen.Text);
                }
                else
                {
                    //send errormessage
                    MessageBox.Show("Dit woord is al een deel van de woordenlijst!", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //send errormessage
                MessageBox.Show("Vul alstublieft iets in om toe te voegen tot de woordenlijst!", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btnleeg_Click(object sender, EventArgs e)
        {
            //check if the list has any items to clear
            if(lstbxwoorden.Items.Count != 0)
            {
                //clear list
                lstbxwoorden.Items.Clear();
            }
            else
            {
                //send error message
                MessageBox.Show("Niks om te legen!", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frmwoorden_FormClosing(object sender, FormClosingEventArgs e)
        {
            //set path to "galgje.txt"
            string path = AppDomain.CurrentDomain.BaseDirectory + "galgje.txt";

            //write the items from the list to "galgje.txt"
            using (StreamWriter writer = File.CreateText(path))
            {
                for (int count = 0; count < lstbxwoorden.Items.Count; count++)
                {
                    writer.WriteLine(lstbxwoorden.Items[count].ToString());
                }
            }
        }

        private void Frmwoorden_Load(object sender, EventArgs e)
        {

        }

        private void Cmbxcat_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmbxcat.SelectedIndex)
            {
                case 0:
                    lstbxwoorden.Items.Add("broek");
                    lstbxwoorden.Items.Add("tshirt");
                    lstbxwoorden.Items.Add("hemd");
                    lstbxwoorden.Items.Add("trui");
                    lstbxwoorden.Items.Add("onderbroek");
                    lstbxwoorden.Items.Add("sokken");
                    lstbxwoorden.Items.Add("handschoenen");
                    lstbxwoorden.Items.Add("schoenen");
                    break;
                case 1:
                    lstbxwoorden.Items.Add("sofa");
                    lstbxwoorden.Items.Add("stoel");
                    lstbxwoorden.Items.Add("kast");
                    lstbxwoorden.Items.Add("bureau");
                    lstbxwoorden.Items.Add("tafel");
                    break;
                case 2:
                    lstbxwoorden.Items.Add("gorilla");
                    lstbxwoorden.Items.Add("giraf");
                    lstbxwoorden.Items.Add("zebra");
                    lstbxwoorden.Items.Add("leeuw");
                    lstbxwoorden.Items.Add("schildpad");
                    lstbxwoorden.Items.Add("nijlpaard");
                    lstbxwoorden.Items.Add("neushoorn");
                    lstbxwoorden.Items.Add("eekhoorn");
                    lstbxwoorden.Items.Add("paard");
                    lstbxwoorden.Items.Add("kat");
                    lstbxwoorden.Items.Add("hond");
                    break;
                case 3:
                    lstbxwoorden.Items.Add("processor");
                    lstbxwoorden.Items.Add("videokaart");
                    lstbxwoorden.Items.Add("geheugen");
                    lstbxwoorden.Items.Add("hardeschijf");
                    lstbxwoorden.Items.Add("moederbord");
                    lstbxwoorden.Items.Add("case");
                    break;
                case 4:
                    lstbxwoorden.Items.Add("Doom");
                    lstbxwoorden.Items.Add("Minecraft");
                    lstbxwoorden.Items.Add("Valorant");
                    lstbxwoorden.Items.Add("Apex");
                    lstbxwoorden.Items.Add("Halo");
                    lstbxwoorden.Items.Add("csgo");
                    break;
            }
        }
    }
}
