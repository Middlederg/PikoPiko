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
    public partial class Move : BaseUserControl
    {
        private PlayMove move;
        public int Minimun { get; set; }

        public Move()
        {
            InitializeComponent();

            DiceGroup.OnDiceGroupSelected += DiceGroupsSelected;

            move = new PlayMove();
            move.Roll();
            DiceGroup.SetResults(move.CurrentRoll.GetAllResults().ToList());
        }

        private void DiceGroupsSelected(object sender, EventArgs e)
        {
            var result = (sender as Dice).Result;
            ButtonRoll.Enabled = move.CanKeepRolling() && move.IsFailure(Minimun);
        }

        private void ButtonRoll_Click(object sender, EventArgs e)
        {
            var result = DiceGroup.SelectedResult;
            move.Save(result);
            move.Roll();
            DiceGroup.SetResults(move.CurrentRoll.GetAllResults());
            DiceGroup.RollDices();
        }

        private void ButonStop_Click(object sender, EventArgs e)
        {

        }
    }
}
