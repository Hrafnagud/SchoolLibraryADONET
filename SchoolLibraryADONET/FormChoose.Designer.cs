
namespace SchoolLibraryADONET
{
    partial class FormChoose
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
            this.UC_MyButton_FormBooks = new SchoolLibraryADONET.UC_MyButton();
            this.uC_MyButton2 = new SchoolLibraryADONET.UC_MyButton();
            this.SuspendLayout();
            // 
            // UC_MyButton_FormBooks
            // 
            this.UC_MyButton_FormBooks.Location = new System.Drawing.Point(285, 113);
            this.UC_MyButton_FormBooks.Name = "UC_MyButton_FormBooks";
            this.UC_MyButton_FormBooks.Size = new System.Drawing.Size(218, 78);
            this.UC_MyButton_FormBooks.TabIndex = 0;
            // 
            // uC_MyButton2
            // 
            this.uC_MyButton2.Location = new System.Drawing.Point(285, 245);
            this.uC_MyButton2.Name = "uC_MyButton2";
            this.uC_MyButton2.Size = new System.Drawing.Size(218, 78);
            this.uC_MyButton2.TabIndex = 1;
            // 
            // FormChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uC_MyButton2);
            this.Controls.Add(this.UC_MyButton_FormBooks);
            this.Name = "FormChoose";
            this.Text = "FormChoose";
            this.Load += new System.EventHandler(this.FormChoose_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UC_MyButton UC_MyButton_FormBooks;
        private UC_MyButton uC_MyButton2;
    }
}