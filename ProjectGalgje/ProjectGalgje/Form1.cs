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
    public partial class frmgalgje : Form
    {
        int tllr = 0;
        public frmgalgje()
        {
            InitializeComponent();
        }

        private string woord = "";

        private string guessedword;

        private char letter;

        private void Button6_Click(object sender, EventArgs e)
        {
            btnI.Enabled = false;             //disable the button
            letter = 'I';            //set the specified letter
            SetGalg();            //call function to change the label and check if player has won
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            letter = 'A';
            SetGalg();
        }

        private void BtnF_Click(object sender, EventArgs e)
        {
            btnF.Enabled = false;
            letter = 'F';
            SetGalg();
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            btnB.Enabled = false;
            letter = 'B';
            SetGalg();
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            btnC.Enabled = false;
            letter = 'C';
            SetGalg();

        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            btnD.Enabled = false;
            letter = 'D';
            SetGalg();
        }

        private void BtnE_Click(object sender, EventArgs e)
        {
            btnE.Enabled = false;
            letter = 'E';
            SetGalg();
        }

        private void BtnG_Click(object sender, EventArgs e)
        {
            btnG.Enabled = false;
            letter = 'G';
            SetGalg();
        }

        private void BtnH_Click(object sender, EventArgs e)
        {
            btnH.Enabled = false;
            letter = 'H';
            SetGalg();
        }

        private void BtnJ_Click(object sender, EventArgs e)
        {
            btnJ.Enabled = false;
            letter = 'J';
            SetGalg();
        }

        private void BtnK_Click(object sender, EventArgs e)
        {
            btnK.Enabled = false;
            letter = 'K';
            SetGalg();
        }

        private void BtnL_Click(object sender, EventArgs e)
        {
            btnL.Enabled = false;
            letter = 'L';
            SetGalg();
        }

        private void BtnM_Click(object sender, EventArgs e)
        {
            btnM.Enabled = false;
            letter = 'M';
            SetGalg();
        }

        private void BtnN_Click(object sender, EventArgs e)
        {
            btnN.Enabled = false;
            letter = 'N';
            SetGalg();
        }

        private void BtnO_Click(object sender, EventArgs e)
        {
            btnO.Enabled = false;
            letter = 'O';
            SetGalg();
        }

        private void BtnP_Click(object sender, EventArgs e)
        {
            btnP.Enabled = false;
            letter = 'P';
            SetGalg();
        }

        private void BtnQ_Click(object sender, EventArgs e)
        {
            btnQ.Enabled = false;
            letter = 'Q';
            SetGalg();
        }

        private void BtnR_Click(object sender, EventArgs e)
        {
            btnR.Enabled = false;
            letter = 'R';
            SetGalg();
        }

        private void BtnS_Click(object sender, EventArgs e)
        {
            btnS.Enabled = false;
            letter = 'S';
            SetGalg();
        }

        private void BtnT_Click(object sender, EventArgs e)
        {
            btnT.Enabled = false;
            letter = 'T';
            SetGalg();
        }

        private void BtnU_Click(object sender, EventArgs e)
        {
            btnU.Enabled = false;
            letter = 'U';
            SetGalg();
        }

        private void BtnV_Click(object sender, EventArgs e)
        {
            btnV.Enabled = false;
            letter = 'V';
            SetGalg();
        }

        private void BtnW_Click(object sender, EventArgs e)
        {
            btnW.Enabled = false;
            letter = 'W';
            SetGalg();
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            btnW.Enabled = false;
            letter = 'X';
            SetGalg();
        }

        private void BtnY_Click(object sender, EventArgs e)
        {
            btnY.Enabled = false;
            letter = 'Y';
            SetGalg();
        }

        private void BtnZ_Click(object sender, EventArgs e)
        {
            btnZ.Enabled = false;
            letter = 'Z';
            SetGalg();
        }

        private void WoordenIngevenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open wikipedia for the rules
            System.Diagnostics.Process.Start("https://nl.wikipedia.org/wiki/Galgje");
        }

        private void WoordenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open form2
            frmwoorden frm_instantie = new frmwoorden();
            frm_instantie.Show();

        }

        private void AfsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frmgalgje_FormClosing(object sender, FormClosingEventArgs e)
        {
            //confirm exit
            DialogResult dialog = MessageBox.Show("Bent u zeker dat u wilt afsluiten?", "Bevestiging", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if answer is no, cancel exit
            e.Cancel = (dialog == DialogResult.No);

        }

        //function to set the label and determine if the player has won
        private void SetGalg()
        {

            pbHangman.Visible = true;
            

            //check if word contains the pressed letter

            if (woord.Contains(letter.ToString().ToLower()))
            {
                //create array to split the chosen word into letters
                char[] newword = woord.ToCharArray();


                for (int count = 0; count < newword.Length; count++)
                {
                    //check if the specified letter in the array is equal to the pressed letter
                    if (newword[count].ToString() == letter.ToString().ToLower())
                    {

                        //create new array that contains the unfinished word and assign the pressed letter to the right place
                        char[] newer = guessedword.ToCharArray();
                        newer[count] = letter;
                        guessedword = new string(newer);
                    }
                }

                //set label to unfinished word
                lblwoord.Text = guessedword;

                //if the guessed word is equal to the chosen word then the player wins
                if (guessedword.ToLower().Equals(woord))
                {
                    MessageBox.Show("Je hebt gewonnen!", "Uitslag", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnstart.Enabled = true;
                    btnstart.Visible = true;
                }
            }
            else
            { tllr++;
                
                if(tllr == 1) { pbHangman.Image = Properties.Resources.Screenshot_94; }
                if (tllr == 2) { pbHangman.Image = Properties.Resources.Screenshot_95; }
                if (tllr == 3) { pbHangman.Image = Properties.Resources.Screenshot_96; }
                if (tllr == 4) { pbHangman.Image = Properties.Resources.Screenshot_97; }
                if (tllr == 5) { pbHangman.Image = Properties.Resources.Screenshot_98; }
                if (tllr == 6) { pbHangman.Image = Properties.Resources.Screenshot_99; }
                if (tllr == 7) { pbHangman.Image = Properties.Resources.Screenshot_100; }
                if (tllr == 8) { pbHangman.Image = Properties.Resources.Screenshot_101; }
                if (tllr == 9) { pbHangman.Image = Properties.Resources.Screenshot_102; }
                if (tllr == 10)
                {
                    pbHangman.Image = Properties.Resources.Screenshot_103;
                    MessageBox.Show("helaas, je bent verloren");
                    Reset();
                    tllr = 0;
                }



            }
        }

        //reset the game
        public void Reset()
        {

            //reset label
            lblwoord.Text = "";

            //reset buttons
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnE.Enabled = true;
            btnF.Enabled = true;
            btnG.Enabled = true;
            btnH.Enabled = true;
            btnI.Enabled = true;
            btnJ.Enabled = true;
            btnK.Enabled = true;
            btnL.Enabled = true;
            btnM.Enabled = true;
            btnN.Enabled = true;
            btnO.Enabled = true;
            btnP.Enabled = true;
            btnQ.Enabled = true;
            btnR.Enabled = true;
            btnS.Enabled = true;
            btnT.Enabled = true;
            btnU.Enabled = true;
            btnV.Enabled = true;
            btnW.Enabled = true;
            btnX.Enabled = true;
            btnY.Enabled = true;
            btnZ.Enabled = true;
            pbHangman.Image = null;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //call reset function
            Reset();

            //enable buttons
            btnstart.Enabled = false;
            btnstart.Visible = false;

            //set path to "galgje.txt"
            string path = AppDomain.CurrentDomain.BaseDirectory + "galgje.txt";

            


            //create random numbergenerator

            Random random = new Random();

            //set int getal to the amount of lines in "galgje.txt"
            int getal = random.Next(File.ReadAllLines(path).Length);


            //read the specified line chosen by the random numbergenerator and set word to that line
            using (StreamReader reader = new StreamReader(path))
            {
                for(int count = 0; count < getal; count++)
                {
                    woord = reader.ReadLine();
                }
            }


            //if word is not given then send an error message else, set the label and the unfinished (guessed) word to "_"
            if (woord.Equals(""))
            {
                MessageBox.Show("Geen woorden ingegeven!", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int count = 0; count < woord.Length; count++)
                {
                    lblwoord.Text += "_";
                }
                guessedword = lblwoord.Text;
            }
        }

        private void Frmgalgje_Load(object sender, EventArgs e)
        {

        }
    }
}
