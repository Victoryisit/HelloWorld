using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * My First GitHub
 */


namespace HelloWorld
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();

            this.OctoBox.MouseDoubleClick += (s, e) =>
            {
                Application.Exit();
            };

            ToolTip tt = new ToolTip();
            tt.ToolTipTitle = "Well Done!";
            tt.SetToolTip(this.OctoBox, "Please double-click to exit the program. :)");
        }
    }
}
