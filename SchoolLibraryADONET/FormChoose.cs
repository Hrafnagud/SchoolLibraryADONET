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
    public partial class FormChoose : Form
    {
        public FormChoose()
        {
            InitializeComponent();
        }

        private void FormChoose_Load(object sender, EventArgs e)
        {
            UC_MyButton_FormBooks.myButton.Text = "Go to Books Form";
            UC_MyButton_FormBooks.myButton.Click += new EventHandler(btn_FormBooks);
        }

        private void btn_FormBooks(object sender, EventArgs e)
        {
            FormBooks formBook = new FormBooks();
            this.Hide();
            formBook.Show();
        }
    }
}
