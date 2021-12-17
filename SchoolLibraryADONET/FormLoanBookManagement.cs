using SchoolLibraryADONET_BusinessLogicLayer;
using System;
using System.Collections;
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
            //DatetimePicker configurations
            dateTimePickerStarts.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnds.CustomFormat = "dd.MM.yyyy";
            dateTimePickerStarts.MinDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            dateTimePickerEnds.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnds.CustomFormat = "dd.MM.yyyy";
            dateTimePickerEnds.MinDate = dateTimePickerStarts.Value.AddDays(1);
            dateTimePickerEnds.MaxDate = dateTimePickerStarts.Value.AddMonths(3);

            //Fill Data Grid
            GridViewConfigureAndFill();
            UC_MyButtonLoan.myButton.Text = "Loan Book";
            UC_MyButtonLoan.myButton.Click += new EventHandler(btn_LoanBook);
        }


        private void btn_LoanBook(object sender, EventArgs e)
        {
            try
            {
                bool flag = false;
                //tarihleri kontrol et
                if (dateTimePickerEnds.Value < dateTimePickerStarts.Value)
                {
                    MessageBox.Show("Erroneous date info entry!");
                }
                else
                {
                    if (comboBoxStudent.SelectedIndex > -1)
                    {
                        if (comboBoxBook.SelectedIndex > -1)
                        {
                            //Is there any books left available for loan?
                            flag = bookLoanOperationManager.BringBookStock((int)comboBoxBook.SelectedValue) == 0 ? false : true;
                        }
                        else
                        {
                            MessageBox.Show("Can not operate without a book selection!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Can not operate without a student selection!");
                    }
                }

                if (flag)
                {
                    string startDate = $"'{dateTimePickerStarts.Value.ToString("yyyy-MM-dd HH:mm:ss")}'";
                    string endDate = $"'{dateTimePickerEnds.Value.ToString("yyyy-MM-dd HH:mm:ss")}'";
                    Hashtable htData = new Hashtable();
                    htData.Add("StudentId", (int)comboBoxStudent.SelectedValue);
                    htData.Add("BookId", (int)comboBoxBook.SelectedValue);
                    htData.Add("LoanStarts", startDate);
                    htData.Add("LoanEnds", endDate);

                    if (bookLoanOperationManager.RegisterBookLoan("LoanBook", htData))
                    {
                        MessageBox.Show("Booking operation has been successfuly saved.");
                        //Cleaning
                        GridViewConfigureAndFill();
                        CleanStudentGroupBox();
                        BookGroupBoxDisabled();
                        LoanDatesGroupBoxDisabled();
                    }
                    else
                    {
                        MessageBox.Show("Unexpected error has occured!");
                    }

                }

                else
                {
                    MessageBox.Show("ERROR: There is no available book left in stock.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error has occured" + ex.Message);
            }

        }
        private void GridViewConfigureAndFill()
        {
            dataGridViewLoanedBooks.MultiSelect = false;
            dataGridViewLoanedBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLoanedBooks.DataSource = bookLoanOperationManager.BringDataToGrid();
            dataGridViewLoanedBooks.Columns["OperationId"].Visible = false;
            dataGridViewLoanedBooks.Columns["BookId"].Visible = false;


            //datagridview width configuration
            for (int i = 0; i < dataGridViewLoanedBooks.Columns.Count; i++)
            {
                dataGridViewLoanedBooks.Columns[i].Width = 160;
            }
            dataGridViewLoanedBooks.ContextMenuStrip = contextMenuStrip1;
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
            groupBoxLoanDates.Enabled = false;
        }

        private void LoanDatesGroupBoxEnabled()
        {
            dateTimePickerStarts.Value = DateTime.Now;
            dateTimePickerEnds.Value = DateTime.Now.AddDays(1);
            groupBoxLoanDates.Enabled = true ;
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

        private void comboBoxBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxBook.SelectedIndex > -1)
            {
                LoanDatesGroupBoxEnabled();
            }
            else
            {
                LoanDatesGroupBoxDisabled();
            }
        }

        private void dateTimePickerStarts_ValueChanged(object sender, EventArgs e)
        {
            //chosen date here, will affect dateTimePickerEnds.
            dateTimePickerEnds.MinDate = dateTimePickerStarts.Value.AddDays(1);

            dateTimePickerEnds.Value = dateTimePickerStarts.Value.AddDays(1);

            dateTimePickerEnds.MaxDate = dateTimePickerStarts.Value.AddMonths(3);
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //chosen line will be retrieved from datagridview, then chosen line's operationId and bookId will be received
                DataGridViewRow chosenLine = dataGridViewLoanedBooks.SelectedRows[0];

                //OperationId
                int operationId = (int)chosenLine.Cells["OperationId"].Value;

                //BookId
                int bookId = (int)chosenLine.Cells["BookId"].Value;

                bool returnResult = false;
                returnResult = bookLoanOperationManager.ReturnLoanedBook("LoanBook", operationId, bookId);

                if (returnResult)
                {
                    MessageBox.Show("Book has been delivered. Have a life enjoyin books forever!");

                    //cleaning
                    GridViewConfigureAndFill();
                    CleanStudentGroupBox();
                    BookGroupBoxDisabled();
                    LoanDatesGroupBoxDisabled();
                }
                else
                {
                    MessageBox.Show("ERROR: Book hasn't been returned!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured! " + ex.Message + " " + ex.ToString());
            }
        }
    }
}
