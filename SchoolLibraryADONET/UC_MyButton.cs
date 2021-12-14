using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolLibraryADONET
{
    public partial class UC_MyButton : UserControl
    {
        public UC_MyButton()
        {
            InitializeComponent();
            myButton.MouseMove += new MouseEventHandler(btn_MouseMoveOnMyButtonChangeColor);
            myButton.MouseLeave += new EventHandler(btn_MouseLeaveOnMyButtonChangeColor);
            myButton.BackColor = Color.White;
        }

        private void btn_MouseMoveOnMyButtonChangeColor(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackColor = Color.PaleGoldenrod;
        }

        private void btn_MouseLeaveOnMyButtonChangeColor(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.White;
        }

    }
}
