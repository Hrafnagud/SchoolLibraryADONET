
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxBookUpdate = new System.Windows.Forms.GroupBox();
            this.comboBoxBookUpdate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textUpdateBookName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboUpdateGenre = new System.Windows.Forms.ComboBox();
            this.comboUpdateAuthor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownPagesUpdate = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownUpdateStoc = new System.Windows.Forms.NumericUpDown();
            this.UC_MyButtonUpdate = new SchoolLibraryADONET.UC_MyButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBoxBookUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPagesUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUpdateStoc)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 562);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewBooks);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.dataGridViewBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.ReadOnly = true;
            this.dataGridViewBooks.RowHeadersWidth = 51;
            this.dataGridViewBooks.RowTemplate.Height = 24;
            this.dataGridViewBooks.Size = new System.Drawing.Size(970, 512);
            this.dataGridViewBooks.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(992, 529);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Update";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.groupBoxBookUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxBookUpdate.Name = "groupBoxBookUpdate";
            this.groupBoxBookUpdate.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxBookUpdate.Size = new System.Drawing.Size(932, 398);
            this.groupBoxBookUpdate.TabIndex = 1;
            this.groupBoxBookUpdate.TabStop = false;
            this.groupBoxBookUpdate.Text = "groupBox1";
            // 
            // comboBoxBookUpdate
            // 
            this.comboBoxBookUpdate.FormattingEnabled = true;
            this.comboBoxBookUpdate.Location = new System.Drawing.Point(36, 81);
            this.comboBoxBookUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxBookUpdate.Name = "comboBoxBookUpdate";
            this.comboBoxBookUpdate.Size = new System.Drawing.Size(912, 28);
            this.comboBoxBookUpdate.TabIndex = 0;
            this.comboBoxBookUpdate.SelectedIndexChanged += new System.EventHandler(this.comboBoxBookUpdate_SelectedIndexChanged);
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
            // textUpdateBookName
            // 
            this.textUpdateBookName.Location = new System.Drawing.Point(164, 55);
            this.textUpdateBookName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textUpdateBookName.Name = "textUpdateBookName";
            this.textUpdateBookName.Size = new System.Drawing.Size(416, 26);
            this.textUpdateBookName.TabIndex = 1;
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
            // comboUpdateGenre
            // 
            this.comboUpdateGenre.FormattingEnabled = true;
            this.comboUpdateGenre.Location = new System.Drawing.Point(164, 158);
            this.comboUpdateGenre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboUpdateGenre.Name = "comboUpdateGenre";
            this.comboUpdateGenre.Size = new System.Drawing.Size(416, 28);
            this.comboUpdateGenre.TabIndex = 4;
            // 
            // comboUpdateAuthor
            // 
            this.comboUpdateAuthor.FormattingEnabled = true;
            this.comboUpdateAuthor.Location = new System.Drawing.Point(164, 106);
            this.comboUpdateAuthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboUpdateAuthor.Name = "comboUpdateAuthor";
            this.comboUpdateAuthor.Size = new System.Drawing.Size(416, 28);
            this.comboUpdateAuthor.TabIndex = 5;
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
            // numericUpDownPagesUpdate
            // 
            this.numericUpDownPagesUpdate.Location = new System.Drawing.Point(121, 251);
            this.numericUpDownPagesUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownPagesUpdate.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownPagesUpdate.Name = "numericUpDownPagesUpdate";
            this.numericUpDownPagesUpdate.Size = new System.Drawing.Size(159, 26);
            this.numericUpDownPagesUpdate.TabIndex = 8;
            // 
            // numericUpDownUpdateStoc
            // 
            this.numericUpDownUpdateStoc.Location = new System.Drawing.Point(589, 258);
            this.numericUpDownUpdateStoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownUpdateStoc.Name = "numericUpDownUpdateStoc";
            this.numericUpDownUpdateStoc.Size = new System.Drawing.Size(150, 26);
            this.numericUpDownUpdateStoc.TabIndex = 9;
            // 
            // UC_MyButtonUpdate
            // 
            this.UC_MyButtonUpdate.Location = new System.Drawing.Point(11, 308);
            this.UC_MyButtonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.UC_MyButtonUpdate.Name = "UC_MyButtonUpdate";
            this.UC_MyButtonUpdate.Size = new System.Drawing.Size(901, 60);
            this.UC_MyButtonUpdate.TabIndex = 2;
            // 
            // FormBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormBooks";
            this.Text = "FormBooks";
            this.Load += new System.EventHandler(this.FormBooks_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBoxBookUpdate.ResumeLayout(false);
            this.groupBoxBookUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPagesUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUpdateStoc)).EndInit();
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
    }
}