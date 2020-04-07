using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinControlLocalization
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        [Browsable(true), DefaultValue(""), SRDescription(SR.ControlTextLocalization)]
        public string TextLocalization { get; set; } = "";
    }
}
