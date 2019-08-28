using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PikoPiko.Forms
{
    public partial class Dice : BaseUserControl
    {
        public event EventHandler OnDiceClicked;

        public IResult Result
        {
            get => Picture.Tag as IResult;
            set
            {
                if (value != null)
                {
                    Picture.Tag = value;
                    Picture.Image = value.GetImage();
                }
            }
        }

        public Dice()
        {
            InitializeComponent();
            //Picture.BackColor = BackColor;
        }

        private void Picture_Click(object sender, EventArgs e)
        {
            Activate();
            OnDiceClicked?.Invoke(this, EventArgs.Empty);
        }

        public void Activate() => MainPanel.BackColor = ForeColor;
        public void Disable() => MainPanel.BackColor = Color.Transparent;
        public bool IsSelected() => MainPanel.BackColor == ForeColor;

        public void Roll()
        {
            Task.Run(RollDice);
        }

        private void RollDice()
        {
            int[] ms = new int[] { 40, 80, 90, 110, 180, 300 };
            for (int i = 0; i < ms.Length; i++)
            {
                Picture.Image = ResultFactory.Any.GetImage();
                Thread.Sleep(ms[i]);
                //System.Threading.Thread.Sleep((int)(ms[i] * ((Double)(Configuracion.r.Next(70, 130)) / 100)));
            }
            Picture.Image = Result.GetImage();
        }
    }
}
