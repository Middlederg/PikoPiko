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
    public partial class PlayerInfo : BaseUserControl
    {
        public void SetAsWinner() => WinnerLabel.Text = "WINNER!";

        private Player player;
        public Player Player 
        { 
            get => player;
            set
            {
                player = value;
                NameLabel.Text = player.ToString();
                Points.Text = player.Worms().ToString();
                NumberOfTiles.Text = player.RationCount.ToString();
            }
        }

        public PlayerInfo()
        {
            InitializeComponent();
        }
    }
}
