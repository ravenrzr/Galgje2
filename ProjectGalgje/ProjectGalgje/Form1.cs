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
using Microsoft.VisualBasic;

namespace ProjectGalgje
{
    public partial class frmgalgje : Form
    {
        private int time = 0;

        private int seconds = 300;

        private int tllr = 0;
        public frmgalgje()
        {
            InitializeComponent();
        }

        private string woord = "";

        private string guessedword;

        private char letter;

        //set path to "galgje.txt"
        private string path = AppDomain.CurrentDomain.BaseDirectory + "galgje.txt";

        private void BtnI_Click(object sender, EventArgs e)
        {
            btnI.Enabled = false;             //disable the button
            letter = 'I';            //set the specified letter
            SetGalg();            //call function to change the label and check if player has won
        }

        private void BtnA_Click_1(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            letter = 'A';
            SetGalg();
        }

        private void RondeButton23_Click(object sender, EventArgs e)
        {
            btnF.Enabled = false;
            letter = 'F';
            SetGalg();
        }

        private void BtnB_Click_1(object sender, EventArgs e)
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

        private void RondeButton15_Click(object sender, EventArgs e)
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
                    tmrdeath.Enabled = false;
                    MessageBox.Show("Je hebt gewonnen!", "Uitslag", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    disable();
                    tllr = 0;
                    btnstart.Enabled = true;
                    btnstart.Visible = true;
                    woord = "";
                }
            }
            else
            {
                tllr++;

                switch (tllr)
                {
                    case 1:
                        pbHangman.Image = Properties.Resources._1;
                        break;
                    case 2:
                        pbHangman.Image = Properties.Resources._2;
                        break;
                    case 3:
                        pbHangman.Image = Properties.Resources._3;
                        break;
                    case 4:
                        pbHangman.Image = Properties.Resources._4;
                        break;
                    case 5:
                        pbHangman.Image = Properties.Resources._5;
                        break;
                    case 6:
                        pbHangman.Image = Properties.Resources._6;
                        break;
                    case 7:
                        pbHangman.Image = Properties.Resources._7;
                        break;
                    case 8:
                        pbHangman.Image = Properties.Resources._8;
                        break;
                    case 9:
                        pbHangman.Image = Properties.Resources._9;
                        break;
                    case 10:
                        pbHangman.Image = Properties.Resources._10;
                        tmrdeath.Enabled = false;
                        MessageBox.Show("helaas, je bent verloren\n\nHet woord was: " + woord, "Uitslag", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tllr = 0;
                        disable();
                        btnstart.Enabled = true;
                        btnstart.Visible = true;
                        woord = "";
                        break;
                }
            }
        }

        public void disable()
        {
            lblwoord.Text = "";
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;
            btnF.Enabled = false;
            btnG.Enabled = false;
            btnH.Enabled = false;
            btnI.Enabled = false;
            btnJ.Enabled = false;
            btnK.Enabled = false;
            btnL.Enabled = false;
            btnM.Enabled = false;
            btnN.Enabled = false;
            btnO.Enabled = false;
            btnP.Enabled = false;
            btnQ.Enabled = false;
            btnR.Enabled = false;
            btnS.Enabled = false;
            btnT.Enabled = false;
            btnU.Enabled = false;
            btnV.Enabled = false;
            btnW.Enabled = false;
            btnX.Enabled = false;
            btnY.Enabled = false;
            btnZ.Enabled = false;
            pbHangman.Image = null;
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

        }

        private void Button1_Click(object sender, EventArgs e)
        {
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
                //call reset function
                Reset();

                for (int count = 0; count < woord.Length; count++)
                {
                    lblwoord.Text += "_";
                }
                guessedword = lblwoord.Text;

                //enable buttons
                btnstart.Enabled = false;
                btnstart.Visible = false;
                time = 0;
                tmrdeath.Enabled = true;
            }
        }

        private void Frmgalgje_Load(object sender, EventArgs e)
        {
            disable();
            File.WriteAllText(path, "");
        }

        private void AuteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Matthis Van Hoecke en Avid Akbar Ghafouri", "Auteurs", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Tmrdeath_Tick(object sender, EventArgs e)
        {
            time++;
            int min = (seconds - time)/60;
            int sec = (seconds - time) % 60;

            if(min < 10)
            {
                lbltime.Text = "0" + min;
            }
            else
            {
                lbltime.Text = min.ToString();
            }
            if(sec < 10)
            {
                lbltime.Text += ":0" + sec;
            }
            else
            {
                lbltime.Text += ":" + sec;
            }

            if (time == seconds)
            {
                pbHangman.Image = Properties.Resources._10;
                tmrdeath.Enabled = false;
                MessageBox.Show("tijd verlopen, je bent verloren\n\nHet woord was: " + woord, "Uitslag", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tllr = 0;
                disable();
                btnstart.Enabled = true;
                btnstart.Visible = true;
                woord = "";
            }
        }

        private void TimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (!int.TryParse(Interaction.InputBox("Zet timer in hoeveelheid tijd in seconden: ", "Timer"), out seconds))
            {
                MessageBox.Show("Geef alstublieft een cijfer in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
