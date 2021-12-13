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
    public partial class Event_Exercise : Form
    {
        public Event_Exercise()
        {
            InitializeComponent();
        }

        private void btn_ButtonHoverColorChange(object sender, EventArgs e)
        {
            //button1.BackColor = Color.Blue;
            //button2.BackColor = Color.Blue;
            //If more than a lot button exists we can use loop
            foreach (var item in this.Controls)
            {
                if(item is Button && ((Button)sender).Name == ((Button)item).Name)
                {
                    ((Button)item).BackColor = Color.PaleGoldenrod;
                }
            }
        }

        private void btn_ButtonLeavesColorDefault(object sender, EventArgs e)
        {
            //button1.BackColor = Color.Blue;
            //button2.BackColor = Color.Blue;
            //If more than a lot button exists we can use loop
            foreach (var item in this.Controls)
            {
                if (item is Button && ((Button)sender).Name == ((Button)item).Name)
                {
                    ((Button)item).BackColor = SystemColors.Control;
                }
            }
        }

        private void Event_Exercise_Load(object sender, EventArgs e)
        {
            //Handle button mouseleave events in the form load method with code rather than properties screen of events. (That's cumbersome right?!)
            //button1.MouseLeave += new EventHandler(btn_ButtonLeavesColorDefault);

            //button2.MouseLeave += new EventHandler(btn_ButtonLeavesColorDefault);

            //button3.MouseLeave += new EventHandler(btn_ButtonLeavesColorDefault);

            //OR with loops which is ideal!

            foreach (var item in this.Controls)
            {
                if(item is Button)
                {
                    ((Button)item).MouseLeave += new EventHandler(btn_ButtonLeavesColorDefault);
                }
            }

            tabControl1.Click += new EventHandler(TabClicked);
        }

        private void TabClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked!!");
        }
    }


}
