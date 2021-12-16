using SchoolLibraryADONET_BusinessLogicLayer;
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
    public partial class FormLoanBookManagement : Form
    {
        public FormLoanBookManagement()
        {
            InitializeComponent();
        }

        BookLoanOperationManager bookLoanOperationManager = new BookLoanOperationManager();

        private void FormLoanBookManagement_Load(object sender, EventArgs e)
        {
            BringAllStudentsToCombo();
            CleanStudentGroupBox();
            BookGroupBoxDisabled();
            LoanDatesGroupBoxDisabled();

        }

        private void BringAllBooksToCombo()
        {
            comboBoxBook.DisplayMember = "BookName";
            comboBoxBook.ValueMember = "BookId";
            comboBoxBook.DataSource = bookLoanOperationManager.BringAllBooks();
        }

        private void BringAllStudentsToCombo()
        {
            comboBoxStudent.DisplayMember = "StudentFullName";
            comboBoxStudent.ValueMember = "Id";
            comboBoxStudent.DataSource = bookLoanOperationManager.BringAllStudents();
        }

        private void CleanStudentGroupBox()
        {
            comboBoxStudent.SelectedIndex = -1;
        }

        private void BookGroupBoxEnabled()
        {
            groupBoxBook.Enabled = true;
        }

        private void BookGroupBoxDisabled()
        {
            comboBoxBook.SelectedIndex = -1;
            groupBoxBook.Enabled = false;
        }

        private void LoanDatesGroupBoxDisabled()
        {
            dateTimePickerStarts.Value = DateTime.Now;
            dateTimePickerEnds.Value = DateTime.Now.AddDays(1);
            UC_MyButtonLoan.Enabled = false;
            groupBoxLoanDates.Enabled = false;
        }

        private void comboBoxStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStudent.SelectedIndex > -1)
            {
                //isActive?
                BookGroupBoxEnabled();
                BringAllBooksToCombo();
                comboBoxBook.SelectedIndex = -1;
            }
        }
    }
}
