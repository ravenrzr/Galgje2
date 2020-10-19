using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string[] list = "aan, aanbod, aanraken, aanval, aap, aardappel, aarde, aardig, acht, achter, actief, activiteit, ademen, af, afgelopen, afhangen, afmaken, afname, afspraak, afval, al, algemeen, alleen, alles, als, alsjeblieft, altijd, ander, andere, anders, angst, antwoord, antwoorden, appel, arm, auto, avond, avondeten, baan, baby, bad, bal, bang, bank, basis, bed, bedekken, bedreiging, bedreven, been, beer, beest, beetje, begin, begrijpen, begrip, behalve, beide, beker, bel, belangrijk, bellen, belofte, beneden, benzine, berg, beroemd, beroep, bescherm, beslissen, best, betalen, beter, bevatten, bewegen, bewolkt, bezoek, bibliotheek, bieden, bij, bijna, bijten, bijvoorbeeld, bijzonder, binnen, binnenkort, blad, blauw, blazen, blij, blijven, bloed, bloem, bodem, boek, boerderij, boete, boom, boon, boord, boos, bord, borstelen, bos, bot, bouwen, boven, branden, brandstof, breed, breken, brengen, brief, broer, broek, brood, brug, bruikbaar, bruiloft, bruin, bui, buiten, bureau, buren, bus, buurman, buurvrouw, 5".Split(',');
            for(int count = 0; count < list.Length; count++)
            {
                listBox1.Items.Add(list[count]);
            }
        }
    }
}
