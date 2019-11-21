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
    public partial class MainMenu : BaseForm
    {
        public MainMenu()
        {
            InitializeComponent();

            Icon = new IconImage().GetIcon();
            MainTitle.BackgroundImage = new TitleImage().GetImage();

            PlayersListBox.Items.Add("Player 1");
            PlayersListBox.Items.Add("Player 2");
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Visible = false;
            Play();
            Visible = true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Play()
        {
            var players = PlayersListBox.Items.OfType<string>();
            using (var gameView = new GameView(new GameContext(players)))
            {
                gameView.ShowDialog();
            }
        }

        private void AddPlayer_Click(object sender, EventArgs e)
        {
           
        }

        private void EditName_Click(object sender, EventArgs e)
        {

        }

        private void RemovePlayer_Click(object sender, EventArgs e)
        {

        }
    }
}
