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
    public partial class GameView : BaseForm
    {
        private readonly GameContext game;

        private List<Move> Moves => PlayersPanel.Controls.OfType<Move>().ToList();
        private Move CurrentMove => Moves[game.Players.CurrentTurn];

        public GameView(GameContext game)
        {
            InitializeComponent();
            this.game = game;
            Icon = new IconImage().GetIcon();

            foreach (var player in game.Players.PlayerList)
            {
                var move = new Move()
                {
                    Margin = new Padding(20, 0, 0, 20)
                };
                move.OnMoveFinished += MoveFinished;
                PlayersPanel.Controls.Add(move);
            }
            UpdateGameStatus();
        }

        private void MoveFinished(object sender, EventArgs e)
        {
            //CurrentMove.SetPlayerInfo(game.CurrentPlayer);

            if (game.IsSuccess(CurrentMove.Points))
                game.TakeRation(CurrentMove.Points);
            else
                game.LoseRation();

            UpdateGameStatus();

            if (game.IsEndOfGame())
            {
                using (var winnerView = new WinnerView(game))
                {
                    winnerView.ShowDialog();
                }
                CurrentMove.End();
                Close();
            }
        }

        private void UpdateGameStatus()
        {
            int i = 0;
            foreach (var move in Moves)
            {
                move.SetPlayerInfo(game.Players.PlayerList[i]);
                i++;
            }
            Grill.SetRations(game.Grill.GetRations());
            CurrentMove.Minimun = game.MinimunObjetive;
            CurrentMove.Setinfo($"Minimun: {CurrentMove.Minimun.ToString()}");
            CurrentMove.Prepare();
        }
    }
}
