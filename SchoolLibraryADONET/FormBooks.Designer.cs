
namespace SchoolLibraryADONET
{
    partial class FormBooks
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBoxBookUpdate = new System.Windows.Forms.ComboBox();
            this.groupBoxBookUpdate = new System.Windows.Forms.GroupBox();
            this.numericUpDownUpdateStoc = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPagesUpdate = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboUpdateAuthor = new System.Windows.Forms.ComboBox();
            this.comboUpdateGenre = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textUpdateBookName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textAddBookName = new System.Windows.Forms.TextBox();
            this.comboAddAuthor = new System.Windows.Forms.ComboBox();
            this.comboAddGenre = new System.Windows.Forms.ComboBox();
            this.numericUpDownAddPages = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAddStock = new System.Windows.Forms.NumericUpDown();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.comboRemoveBook = new System.Windows.Forms.ComboBox();
            this.richTextBoxBook = new System.Windows.Forms.RichTextBox();
            this.UC_AddButton = new SchoolLibraryADONET.UC_MyButton();
            this.UC_MyButtonUpdate = new SchoolLibraryADONET.UC_MyButton();
            this.UC_MyButtonDelete = new SchoolLibraryADONET.UC_MyButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBoxBookUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUpdateStoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPagesUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddStock)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 562);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewBooks);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(992, 529);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ShowList";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AllowUserToAddRows = false;
            this.dataGridViewBooks.AllowUserToDeleteRows = false;
            this.dataGridViewBooks.AllowUserToOrderColumns = true;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewBooks.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.ReadOnly = true;
            this.dataGridViewBooks.RowHeadersWidth = 51;
            this.dataGridViewBooks.RowTemplate.Height = 24;
            this.dataGridViewBooks.Size = new System.Drawing.Size(970, 512);
            this.dataGridViewBooks.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.UC_AddButton);
            this.tabPage2.Controls.Add(this.numericUpDownAddStock);
            this.tabPage2.Controls.Add(this.numericUpDownAddPages);
            this.tabPage2.Controls.Add(this.comboAddGenre);
            this.tabPage2.Controls.Add(this.comboAddAuthor);
            this.tabPage2.Controls.Add(this.textAddBookName);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(992, 529);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboBoxBookUpdate);
            this.tabPage3.Controls.Add(this.groupBoxBookUpdate);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(992, 529);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Update";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBoxBookUpdate
            // 
            this.comboBoxBookUpdate.FormattingEnabled = true;
            this.comboBoxBookUpdate.Location = new System.Drawing.Point(36, 81);
            this.comboBoxBookUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxBookUpdate.Name = "comboBoxBookUpdate";
            this.comboBoxBookUpdate.Size = new System.Drawing.Size(912, 28);
            this.comboBoxBookUpdate.TabIndex = 0;
            this.comboBoxBookUpdate.SelectedIndexChanged += new System.EventHandler(this.comboBoxBookUpdate_SelectedIndexChanged);
            // 
            // groupBoxBookUpdate
            // 
            this.groupBoxBookUpdate.Controls.Add(this.UC_MyButtonUpdate);
            this.groupBoxBookUpdate.Controls.Add(this.numericUpDownUpdateStoc);
            this.groupBoxBookUpdate.Controls.Add(this.numericUpDownPagesUpdate);
            this.groupBoxBookUpdate.Controls.Add(this.label6);
            this.groupBoxBookUpdate.Controls.Add(this.label5);
            this.groupBoxBookUpdate.Controls.Add(this.comboUpdateAuthor);
            this.groupBoxBookUpdate.Controls.Add(this.comboUpdateGenre);
            this.groupBoxBookUpdate.Controls.Add(this.label4);
            this.groupBoxBookUpdate.Controls.Add(this.label3);
            this.groupBoxBookUpdate.Controls.Add(this.textUpdateBookName);
            this.groupBoxBookUpdate.Controls.Add(this.label2);
            this.groupBoxBookUpdate.Location = new System.Drawing.Point(36, 119);
            this.groupBoxBookUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxBookUpdate.Name = "groupBoxBookUpdate";
            this.groupBoxBookUpdate.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxBookUpdate.Size = new System.Drawing.Size(932, 398);
            this.groupBoxBookUpdate.TabIndex = 1;
            this.groupBoxBookUpdate.TabStop = false;
            this.groupBoxBookUpdate.Text = "groupBox1";
            // 
            // numericUpDownUpdateStoc
            // 
            this.numericUpDownUpdateStoc.Location = new System.Drawing.Point(589, 258);
            this.numericUpDownUpdateStoc.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownUpdateStoc.Name = "numericUpDownUpdateStoc";
            this.numericUpDownUpdateStoc.Size = new System.Drawing.Size(150, 26);
            this.numericUpDownUpdateStoc.TabIndex = 9;
            // 
            // numericUpDownPagesUpdate
            // 
            this.numericUpDownPagesUpdate.Location = new System.Drawing.Point(121, 251);
            this.numericUpDownPagesUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownPagesUpdate.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownPagesUpdate.Name = "numericUpDownPagesUpdate";
            this.numericUpDownPagesUpdate.Size = new System.Drawing.Size(159, 26);
            this.numericUpDownPagesUpdate.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(518, 260);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Stock: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 258);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Pages: ";
            // 
            // comboUpdateAuthor
            // 
            this.comboUpdateAuthor.FormattingEnabled = true;
            this.comboUpdateAuthor.Location = new System.Drawing.Point(164, 106);
            this.comboUpdateAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.comboUpdateAuthor.Name = "comboUpdateAuthor";
            this.comboUpdateAuthor.Size = new System.Drawing.Size(416, 28);
            this.comboUpdateAuthor.TabIndex = 5;
            // 
            // comboUpdateGenre
            // 
            this.comboUpdateGenre.FormattingEnabled = true;
            this.comboUpdateGenre.Location = new System.Drawing.Point(164, 158);
            this.comboUpdateGenre.Margin = new System.Windows.Forms.Padding(4);
            this.comboUpdateGenre.Name = "comboUpdateGenre";
            this.comboUpdateGenre.Size = new System.Drawing.Size(416, 28);
            this.comboUpdateGenre.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Author:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Genre:";
            // 
            // textUpdateBookName
            // 
            this.textUpdateBookName.Location = new System.Drawing.Point(164, 55);
            this.textUpdateBookName.Margin = new System.Windows.Forms.Padding(4);
            this.textUpdateBookName.Name = "textUpdateBookName";
            this.textUpdateBookName.Size = new System.Drawing.Size(416, 26);
            this.textUpdateBookName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(301, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose The Book You Want to Update";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Book Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(182, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Author:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(182, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Genre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(182, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Pages:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(182, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Stock Left:";
            // 
            // textAddBookName
            // 
            this.textAddBookName.Location = new System.Drawing.Point(327, 80);
            this.textAddBookName.Name = "textAddBookName";
            this.textAddBookName.Size = new System.Drawing.Size(420, 26);
            this.textAddBookName.TabIndex = 5;
            // 
            // comboAddAuthor
            // 
            this.comboAddAuthor.FormattingEnabled = true;
            this.comboAddAuthor.Location = new System.Drawing.Point(327, 118);
            this.comboAddAuthor.Name = "comboAddAuthor";
            this.comboAddAuthor.Size = new System.Drawing.Size(420, 28);
            this.comboAddAuthor.TabIndex = 6;
            // 
            // comboAddGenre
            // 
            this.comboAddGenre.FormattingEnabled = true;
            this.comboAddGenre.Location = new System.Drawing.Point(327, 165);
            this.comboAddGenre.Name = "comboAddGenre";
            this.comboAddGenre.Size = new System.Drawing.Size(420, 28);
            this.comboAddGenre.TabIndex = 7;
            // 
            // numericUpDownAddPages
            // 
            this.numericUpDownAddPages.Location = new System.Drawing.Point(327, 210);
            this.numericUpDownAddPages.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownAddPages.Name = "numericUpDownAddPages";
            this.numericUpDownAddPages.Size = new System.Drawing.Size(207, 26);
            this.numericUpDownAddPages.TabIndex = 8;
            // 
            // numericUpDownAddStock
            // 
            this.numericUpDownAddStock.Location = new System.Drawing.Point(327, 253);
            this.numericUpDownAddStock.Name = "numericUpDownAddStock";
            this.numericUpDownAddStock.Size = new System.Drawing.Size(207, 26);
            this.numericUpDownAddStock.TabIndex = 9;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.UC_MyButtonDelete);
            this.tabPage4.Controls.Add(this.richTextBoxBook);
            this.tabPage4.Controls.Add(this.comboRemoveBook);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(992, 529);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Delete";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(344, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(304, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Choose The Book You Want to Remove";
            // 
            // comboRemoveBook
            // 
            this.comboRemoveBook.FormattingEnabled = true;
            this.comboRemoveBook.Location = new System.Drawing.Point(156, 114);
            this.comboRemoveBook.Name = "comboRemoveBook";
            this.comboRemoveBook.Size = new System.Drawing.Size(667, 28);
            this.comboRemoveBook.TabIndex = 1;
            this.comboRemoveBook.SelectedIndexChanged += new System.EventHandler(this.comboRemoveBook_SelectedIndexChanged);
            // 
            // richTextBoxBook
            // 
            this.richTextBoxBook.Location = new System.Drawing.Point(156, 162);
            this.richTextBoxBook.Name = "richTextBoxBook";
            this.richTextBoxBook.ReadOnly = true;
            this.richTextBoxBook.Size = new System.Drawing.Size(667, 261);
            this.richTextBoxBook.TabIndex = 2;
            this.richTextBoxBook.Text = "";
            // 
            // UC_AddButton
            // 
            this.UC_AddButton.Location = new System.Drawing.Point(576, 210);
            this.UC_AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.UC_AddButton.Name = "UC_AddButton";
            this.UC_AddButton.Size = new System.Drawing.Size(171, 69);
            this.UC_AddButton.TabIndex = 10;
            // 
            // UC_MyButtonUpdate
            // 
            this.UC_MyButtonUpdate.Location = new System.Drawing.Point(11, 308);
            this.UC_MyButtonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.UC_MyButtonUpdate.Name = "UC_MyButtonUpdate";
            this.UC_MyButtonUpdate.Size = new System.Drawing.Size(901, 60);
            this.UC_MyButtonUpdate.TabIndex = 2;
            // 
            // UC_MyButtonDelete
            // 
            this.UC_MyButtonDelete.Location = new System.Drawing.Point(156, 443);
            this.UC_MyButtonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.UC_MyButtonDelete.Name = "UC_MyButtonDelete";
            this.UC_MyButtonDelete.Size = new System.Drawing.Size(667, 61);
            this.UC_MyButtonDelete.TabIndex = 3;
            // 
            // FormBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormBooks";
            this.Text = "FormBooks";
            this.Load += new System.EventHandler(this.FormBooks_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBoxBookUpdate.ResumeLayout(false);
            this.groupBoxBookUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUpdateStoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPagesUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddStock)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox comboBoxBookUpdate;
        private System.Windows.Forms.GroupBox groupBoxBookUpdate;
        private System.Windows.Forms.ComboBox comboUpdateAuthor;
        private System.Windows.Forms.ComboBox comboUpdateGenre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textUpdateBookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownUpdateStoc;
        private System.Windows.Forms.NumericUpDown numericUpDownPagesUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private UC_MyButton UC_MyButtonUpdate;
        private UC_MyButton UC_AddButton;
        private System.Windows.Forms.NumericUpDown numericUpDownAddStock;
        private System.Windows.Forms.NumericUpDown numericUpDownAddPages;
        private System.Windows.Forms.ComboBox comboAddGenre;
        private System.Windows.Forms.ComboBox comboAddAuthor;
        private System.Windows.Forms.TextBox textAddBookName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox comboRemoveBook;
        private System.Windows.Forms.Label label12;
        private UC_MyButton UC_MyButtonDelete;
        private System.Windows.Forms.RichTextBox richTextBoxBook;
    }
}