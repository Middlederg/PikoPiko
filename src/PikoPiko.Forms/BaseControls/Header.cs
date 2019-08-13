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
    public partial class Header : BaseUserControl
    {
        public string Title
        {
            get => TitleLabel.Text.Trim();
            set => TitleLabel.Text = value;
        }

        public Header()
        {
            InitializeComponent();
        }
    }
}
