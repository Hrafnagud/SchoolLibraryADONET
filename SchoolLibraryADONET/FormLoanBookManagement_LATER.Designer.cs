
namespace SchoolLibraryADONET
{
    partial class FormLoanBookManagement_LATER
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
            this.UC_MyListBoxStudents = new SchoolLibraryADONET.UC_MyListBox();
            this.groupBoxBook = new System.Windows.Forms.GroupBox();
            this.UC_MyListBoxBooks = new SchoolLibraryADONET.UC_MyListBox();
            this.groupBoxStudent.SuspendLayout();
            this.groupBoxBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxStudent
            // 
            this.groupBoxStudent.Controls.Add(this.UC_MyListBoxStudents);
            this.groupBoxStudent.Location = new System.Drawing.Point(12, 58);
            this.groupBoxStudent.Name = "groupBoxStudent";
            this.groupBoxStudent.Size = new System.Drawing.Size(325, 637);
            this.groupBoxStudent.TabIndex = 0;
            this.groupBoxStudent.TabStop = false;
            this.groupBoxStudent.Text = "Student";
            // 
            // UC_MyListBoxStudents
            // 
            this.UC_MyListBoxStudents.Location = new System.Drawing.Point(6, 21);
            this.UC_MyListBoxStudents.Name = "UC_MyListBoxStudents";
            this.UC_MyListBoxStudents.Size = new System.Drawing.Size(291, 610);
            this.UC_MyListBoxStudents.TabIndex = 1;
            // 
            // groupBoxBook
            // 
            this.groupBoxBook.Controls.Add(this.UC_MyListBoxBooks);
            this.groupBoxBook.Location = new System.Drawing.Point(363, 58);
            this.groupBoxBook.Name = "groupBoxBook";
            this.groupBoxBook.Size = new System.Drawing.Size(333, 644);
            this.groupBoxBook.TabIndex = 0;
            this.groupBoxBook.TabStop = false;
            this.groupBoxBook.Text = "Book";
            // 
            // UC_MyListBoxBooks
            // 
            this.UC_MyListBoxBooks.Location = new System.Drawing.Point(6, 21);
            this.UC_MyListBoxBooks.Name = "UC_MyListBoxBooks";
            this.UC_MyListBoxBooks.Size = new System.Drawing.Size(289, 617);
            this.UC_MyListBoxBooks.TabIndex = 1;
            // 
            // FormLoanBookManagement_LATER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 707);
            this.Controls.Add(this.groupBoxBook);
            this.Controls.Add(this.groupBoxStudent);
            this.Name = "FormLoanBookManagement_LATER";
            this.Text = "Book Loaning Operations";
            this.Load += new System.EventHandler(this.FormLoanBookManagement_LATER_Load);
            this.groupBoxStudent.ResumeLayout(false);
            this.groupBoxBook.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxStudent;
        private System.Windows.Forms.GroupBox groupBoxBook;
        private UC_MyListBox UC_MyListBoxStudents;
        private UC_MyListBox UC_MyListBoxBooks;
    }
}