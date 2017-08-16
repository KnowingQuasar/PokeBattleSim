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
    public partial class SlotDialog : Form
    {
        int group;
        int slot;

        public SlotDialog()
        {
            InitializeComponent();
            group = 1;
            slot = 1;
        }
        public SlotDialog(int group, int slot) : base()
        {
            this.group = group;
            this.slot = slot;
        }
    }
}
