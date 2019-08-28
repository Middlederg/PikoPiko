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
    public partial class RationPanel : BaseUserControl
    {
        public event EventHandler OnRationClicked;

        public void SetRations(IEnumerable<Ration> value)
        {
            MainPanel.Controls.Clear();
            foreach (var ration in value)
            {
                var tile = new RationTile()
                {
                    RationValue = ration,
                    Margin = new Padding(5, 5, 5, 0),
                    Activable = false
                };
                tile.OnRationClicked += RationClicked;
                MainPanel.Controls.Add(tile);
            }
        }

        private void RationClicked(object sender, EventArgs e)
        {
            OnRationClicked?.Invoke(sender, EventArgs.Empty);
        }

        public Ration SelectedResult => MainPanel.Controls.OfType<RationTile>().FirstOrDefault(x => x.IsSelected())?.RationValue;

        public void Enable(Ration ration)
        {
            DisableAll();
            MainPanel.Controls.OfType<RationTile>().FirstOrDefault(x => x.RationValue.Equals(ration))?.Activate();
        }

        private void DisableAll()
        {
            foreach (var tile in MainPanel.Controls.OfType<RationTile>())
                tile.Disable();
        }

        public RationPanel()
        {
            InitializeComponent();
        }
    }
}
