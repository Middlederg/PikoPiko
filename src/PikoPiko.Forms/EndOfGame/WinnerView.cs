using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PikoPiko.Forms
{
    public partial class WinnerView : BaseForm
    {

        public WinnerView(GameContext game)
        {
            InitializeComponent();

            foreach (var player in game.Players.Ranking())
            {
                var control = new PlayerInfo() { Player = player, Margin = new Padding(40, 5, 40, 5) };
                if (player.Equals(game.Winner()))
                {
                    control.SetAsWinner();
                }
                Flp.Controls.Add(control);
            }
        }

        private void BackButton_Click(object sender, EventArgs e) => Close();
        
    }
}
