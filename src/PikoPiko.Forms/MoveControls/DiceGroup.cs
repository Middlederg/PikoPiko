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
    public partial class DiceGroup : BaseUserControl
    {
        public event EventHandler OnDiceClicked;
        public event EventHandler OnStartClicked;

        public void SetResults(IEnumerable<IResult> value)
        {
            MainPanel.Controls.Clear();
            foreach (var result in value)
            {
                var dice = new Dice() { Result = result, Margin = new Padding(0, 0, 5, 5) };
                dice.OnDiceClicked += DiceClicked;
                MainPanel.Controls.Add(dice);
            }
        }

        public IResult SelectedResult => MainPanel.Controls.OfType<Dice>().FirstOrDefault(x => x.IsSelected())?.Result;

        private void DiceClicked(object sender, EventArgs e)
        {
            DisableAll();
            Enable(sender as Dice);
            OnDiceClicked?.Invoke(sender, EventArgs.Empty);
        }

        private void DisableAll()
        {
            foreach (var dice in MainPanel.Controls.OfType<Dice>())
                dice.Disable();
        }

        private void Enable(Dice dice)
        {
            foreach (var selectedDice in MainPanel.Controls.OfType<Dice>().Where(x => x.Result.Equals(dice.Result)))
                selectedDice.Activate();
        }

        public DiceGroup()
        {
            InitializeComponent();
        }

        public void RollDices()
        {
            foreach (var dice in MainPanel.Controls.OfType<Dice>())
                dice.Roll();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            OnStartClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
