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
    public partial class RationTile : BaseUserControl
    {
        public event EventHandler OnRationClicked;
        public bool Activable { get; set; } = false;

        public Ration RationValue
        {
            get => Picture.Tag as Ration;
            set
            {
                if (value != null)
                {
                    NumberLabel.Text = value.Value.ToString();
                    Picture.Tag = value;
                    Picture.Image = value.GetImage();
                }
            }
        }

        public RationTile()
        {
            InitializeComponent();
        }

        private void TileClick(object sender, EventArgs e)
        {
            if (Activable)
            {
                Activate();
                OnRationClicked?.Invoke(this, EventArgs.Empty);
            }
        }

        public void Activate() => MainPanel.BackColor = ForeColor;
        public void Disable() => MainPanel.BackColor = Color.Transparent;
        public bool IsSelected() => MainPanel.BackColor == ForeColor;
    }
}
