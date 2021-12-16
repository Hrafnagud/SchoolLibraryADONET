
namespace SchoolLibraryADONET
{
    partial class FormLoanBookManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxStudent = new System.Windows.Forms.GroupBox();
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            this.groupBoxBook = new System.Windows.Forms.GroupBox();
            this.comboBoxBook = new System.Windows.Forms.ComboBox();
            this.groupBoxLoanDates = new System.Windows.Forms.GroupBox();
            this.dateTimePickerEnds = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStarts = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewLoanedBooks = new System.Windows.Forms.DataGridView();
            this.UC_MyButtonLoan = new SchoolLibraryADONET.UC_MyButton();
            this.groupBoxStudent.SuspendLayout();
            this.groupBoxBook.SuspendLayout();
            this.groupBoxLoanDates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoanedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxStudent
            // 
            this.groupBoxStudent.Controls.Add(this.comboBoxStudent);
            this.groupBoxStudent.Location = new System.Drawing.Point(26, 23);
            this.groupBoxStudent.Name = "groupBoxStudent";
            this.groupBoxStudent.Size = new System.Drawing.Size(619, 100);
            this.groupBoxStudent.TabIndex = 0;
            this.groupBoxStudent.TabStop = false;
            this.groupBoxStudent.Text = "Choose a Student";
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(8, 41);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(592, 24);
            this.comboBoxStudent.TabIndex = 1;
            this.comboBoxStudent.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudent_SelectedIndexChanged);
            // 
            // groupBoxBook
            // 
            this.groupBoxBook.Controls.Add(this.comboBoxBook);
            this.groupBoxBook.Location = new System.Drawing.Point(26, 155);
            this.groupBoxBook.Name = "groupBoxBook";
            this.groupBoxBook.Size = new System.Drawing.Size(619, 105);
            this.groupBoxBook.TabIndex = 0;
            this.groupBoxBook.TabStop = false;
            this.groupBoxBook.Text = "Choose a Book";
            // 
            // comboBoxBook
            // 
            this.comboBoxBook.FormattingEnabled = true;
            this.comboBoxBook.Location = new System.Drawing.Point(8, 44);
            this.comboBoxBook.Name = "comboBoxBook";
            this.comboBoxBook.Size = new System.Drawing.Size(592, 24);
            this.comboBoxBook.TabIndex = 2;
            this.comboBoxBook.SelectedIndexChanged += new System.EventHandler(this.comboBoxBook_SelectedIndexChanged);
            // 
            // groupBoxLoanDates
            // 
            this.groupBoxLoanDates.Controls.Add(this.UC_MyButtonLoan);
            this.groupBoxLoanDates.Controls.Add(this.dateTimePickerEnds);
            this.groupBoxLoanDates.Controls.Add(this.dateTimePickerStarts);
            this.groupBoxLoanDates.Controls.Add(this.label1);
            this.groupBoxLoanDates.Controls.Add(this.label2);
            this.groupBoxLoanDates.Location = new System.Drawing.Point(686, 23);
            this.groupBoxLoanDates.Name = "groupBoxLoanDates";
            this.groupBoxLoanDates.Size = new System.Drawing.Size(493, 237);
            this.groupBoxLoanDates.TabIndex = 0;
            this.groupBoxLoanDates.TabStop = false;
            this.groupBoxLoanDates.Text = "Choose Date Intervals";
            // 
            // dateTimePickerEnds
            // 
            this.dateTimePickerEnds.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnds.Location = new System.Drawing.Point(9, 132);
            this.dateTimePickerEnds.Name = "dateTimePickerEnds";
            this.dateTimePickerEnds.Size = new System.Drawing.Size(453, 22);
            this.dateTimePickerEnds.TabIndex = 5;
            // 
            // dateTimePickerStarts
            // 
            this.dateTimePickerStarts.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStarts.Location = new System.Drawing.Point(9, 61);
            this.dateTimePickerStarts.Name = "dateTimePickerStarts";
            this.dateTimePickerStarts.Size = new System.Drawing.Size(453, 22);
            this.dateTimePickerStarts.TabIndex = 4;
            this.dateTimePickerStarts.ValueChanged += new System.EventHandler(this.dateTimePickerStarts_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loan Starting Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loan Ending Date";
            // 
            // dataGridViewLoanedBooks
            // 
            this.dataGridViewLoanedBooks.AllowUserToAddRows = false;
            this.dataGridViewLoanedBooks.AllowUserToDeleteRows = false;
            this.dataGridViewLoanedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoanedBooks.Location = new System.Drawing.Point(26, 305);
            this.dataGridViewLoanedBooks.Name = "dataGridViewLoanedBooks";
            this.dataGridViewLoanedBooks.ReadOnly = true;
            this.dataGridViewLoanedBooks.RowHeadersWidth = 51;
            this.dataGridViewLoanedBooks.RowTemplate.Height = 24;
            this.dataGridViewLoanedBooks.Size = new System.Drawing.Size(1153, 361);
            this.dataGridViewLoanedBooks.TabIndex = 0;
            // 
            // UC_MyButtonLoan
            // 
            this.UC_MyButtonLoan.Location = new System.Drawing.Point(9, 176);
            this.UC_MyButtonLoan.Name = "UC_MyButtonLoan";
            this.UC_MyButtonLoan.Size = new System.Drawing.Size(453, 46);
            this.UC_MyButtonLoan.TabIndex = 6;
            // 
            // FormLoanBookManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 678);
            this.Controls.Add(this.dataGridViewLoanedBooks);
            this.Controls.Add(this.groupBoxBook);
            this.Controls.Add(this.groupBoxLoanDates);
            this.Controls.Add(this.groupBoxStudent);
            this.Name = "FormLoanBookManagement";
            this.Text = "WELCOME TO BOOK LOAN FORM";
            this.Load += new System.EventHandler(this.FormLoanBookManagement_Load);
            this.groupBoxStudent.ResumeLayout(false);
            this.groupBoxBook.ResumeLayout(false);
            this.groupBoxLoanDates.ResumeLayout(false);
            this.groupBoxLoanDates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoanedBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxStudent;
        private System.Windows.Forms.ComboBox comboBoxStudent;
        private System.Windows.Forms.GroupBox groupBoxBook;
        private System.Windows.Forms.ComboBox comboBoxBook;
        private System.Windows.Forms.GroupBox groupBoxLoanDates;
        private UC_MyButton UC_MyButtonLoan;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnds;
        private System.Windows.Forms.DateTimePicker dateTimePickerStarts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewLoanedBooks;
    }
}