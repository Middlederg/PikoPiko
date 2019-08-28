using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PikoPiko.Forms
{
    public partial class PlayerPanel : BaseUserControl
    {
        public void SetPlayer(Player player)
        {
            Tile.Visible = player.HasRations;
            if (player.HasRations)
            {
                Tile.RationValue = player.VisibleRation;
            }
            NumberOfTiles.Text = player.RationCount.ToString();
            Points.Text = player.Worms().ToString();
        }

        public PlayerPanel()
        {
            InitializeComponent();
        }
    }
}
