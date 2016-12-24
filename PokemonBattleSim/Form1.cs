using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonBattleSim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitTitles();
        }

        private void InitTitles()
        {
            Font f = new Font(FontFamily.GenericSansSerif, 7.8F, FontStyle.Bold);
            string[] titles = { "Pokemon", "Item", "Ability", "Move 1", "Move 2", "Move 3", "Move 4", "Nature", "EVs", "IVs" };
            Color[] titleColors = { Color.Cyan, Color.Lime, Color.MediumPurple, Color.LightGoldenrodYellow, Color.LightGoldenrodYellow,
                Color.LightGoldenrodYellow, Color.LightGoldenrodYellow, Color.LightPink, Color.PeachPuff, Color.PeachPuff };
            var titleBoxes = ThePanel.Controls;

            for (int i = 0; i < 9; i++)
            {
                titleBoxes[i].Margin = new Padding(1);
                titleBoxes[i].BackColor = titleColors[i];
                titleBoxes[i].Text = titles[i];
                titleBoxes[i].Font = f;
                titleBoxes[i].ForeColor = Color.Black;
                ((TextBox)titleBoxes[i]).ReadOnly = true;
            }
        }
    }
}
