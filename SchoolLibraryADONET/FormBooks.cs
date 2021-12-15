using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolLibraryADONET
{
    public partial class FormBooks : Form
    {
        public FormBooks()
        {
            InitializeComponent();
        }

        string SQLConnectionString = "Server=DESKTOP-TUMHS1A;Database=SCHOOLLIBRARY;Trusted_Connection=True;";
        SqlConnection connection = new SqlConnection();

        private void FormBooks_Load(object sender, EventArgs e)
        {
            //Grid Configurations
            dataGridViewBooks.MultiSelect = false;
            dataGridViewBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BringAllBooksToGridWithView();

            UC_MyButtonUpdate.myButton.Text = "Update";
            UC_MyButtonUpdate.myButton.Click += new EventHandler(btn_BookUpdate);

            //Update combobox to be filled
            UpdateTabGroupboxClean();
            BringAllBooksToComboBox();
            BringAllAuthorsToComboBox();
            BringAllGenresToComboBox();

            tabControl1.Click += new EventHandler(tabControl1_Click);

            UC_AddButton.myButton.Text = "Add Book";
            UC_AddButton.myButton.Click += new EventHandler(btn_AddBook);

            UC_MyButtonDelete.myButton.Text = "Remove Book";
            UC_MyButtonDelete.myButton.Click += new EventHandler(btn_RemoveBook);


        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            BringAllBooksToGridWithView();
            BringAllBooksToComboBox();
            UpdateTabGroupboxPassiveClean();
            AddTabCleanAllControls();
            DeleteTabCleanAllControls();
        }

        private void UpdateTabGroupboxPassiveClean()
        {
            comboBoxBookUpdate.SelectedIndex = -1;
            UpdateTabGroupboxClean();
            groupBoxBookUpdate.Enabled = false;
        }

        private void UpdateTabGroupboxActiveClean()
        {
            groupBoxBookUpdate.Enabled = true;
            UpdateTabGroupboxClean();
        }

        private void DeleteTabCleanAllControls()
        {
            comboRemoveBook.SelectedIndex = 1;
            comboRemoveBook.Text = "Choose a book..";
            richTextBoxBook.Clear();
        }

        private void AddTabCleanAllControls()
        {
            textAddBookName.Clear();
            comboAddAuthor.Text = "Add Author..";
            comboAddGenre.Text = "Add Genre..";
            comboAddGenre.SelectedIndex = -1;
            comboAddAuthor.SelectedIndex = -1;
            numericUpDownAddPages.Value = 0;
            numericUpDownAddStock.Value = 0;
        }

        private void BringAllGenresToComboBox()
        {
            try
            {
                using (connection)
                {
                    SqlCommand command = new SqlCommand("select * from Genre order by GenreName", connection);
                    OpenConnection();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable virtualTable = new DataTable();
                    adapter.Fill(virtualTable);
                    
                    comboUpdateGenre.DisplayMember = "GenreName";
                    comboUpdateGenre.ValueMember = "GenreId";
                    comboUpdateGenre.DataSource = virtualTable;
                    comboUpdateGenre.SelectedIndex = -1;

                    comboAddGenre.DisplayMember = "GenreName";
                    comboAddGenre.ValueMember = "GenreId";
                    comboAddGenre.DataSource = virtualTable;
                    comboAddGenre.SelectedIndex = -1;
                    comboAddGenre.Text = "Select Genre..";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured! " + ex.Message);
            }
        }

        private void BringAllAuthorsToComboBox()
        {
            try
            {
                using (connection)
                {
                    SqlCommand command = new SqlCommand("select * from Authors order by AuthorFullName", connection);
                    OpenConnection();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable virtualTable = new DataTable();
                    adapter.Fill(virtualTable);
                    comboUpdateAuthor.DisplayMember = "AuthorFullName";
                    comboUpdateAuthor.ValueMember = "AuthorId";
                    comboUpdateAuthor.DataSource = virtualTable;
                    comboUpdateAuthor.SelectedIndex = -1;

                    comboAddAuthor.DisplayMember = "AuthorFullName";
                    comboAddAuthor.ValueMember = "AuthorId";
                    comboAddAuthor.DataSource = virtualTable;
                    comboAddAuthor.SelectedIndex = -1;
                    comboAddAuthor.Text = "Choose an Author";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured! " + ex.Message);
            }
        }

        private void BringAllBooksToComboBox()
        {
            try
            {
                using (connection)
                {
                    SqlCommand command = new SqlCommand("Select * from Books where IsPassive=0 order by BookName", connection);
                    OpenConnection();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable virtualTable = new DataTable();
                    adapter.Fill(virtualTable);
                    comboBoxBookUpdate.DisplayMember = "BookName";
                    comboBoxBookUpdate.ValueMember = "BookId";
                    comboBoxBookUpdate.DataSource = virtualTable;
                    comboBoxBookUpdate.SelectedIndex = -1;

                    comboRemoveBook.DisplayMember = "BookName";
                    comboRemoveBook.ValueMember = "BookId";
                    comboRemoveBook.DataSource = virtualTable;
                    comboRemoveBook.SelectedIndex = -1;
                    comboRemoveBook.Text = "Choose a book..";
                    CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error has occured! " + ex.Message);
            }
        }

        private void ComboChosenBookInfoFill(int bookId)
        {
            try
            {
                using (connection)
                {
                    SqlCommand command = new SqlCommand($"select * from Books b left join Genre g on b.GenreId = g.GenreId left join Authors a on a.AuthorId = b.AuthorId where b.BookId={bookId}", connection);
                    OpenConnection();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        textUpdateBookName.Text = reader["BookName"].ToString();
                        numericUpDownPagesUpdate.Value = (int)reader["Pages"];
                        numericUpDownUpdateStoc.Value = (int)reader["Stock"];
                        if (string.IsNullOrEmpty(reader["GenreId"].ToString()))
                        {
                            comboUpdateGenre.SelectedIndex = -1;
                            comboUpdateGenre.Text = "Choose Genre..";

                        }
                        else
                        {
                            comboUpdateGenre.SelectedValue = (int)reader["GenreId"];
                        }

                        comboUpdateAuthor.SelectedValue = (int)reader["AuthorId"];
                    }
                    CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error has occured. " + ex.Message);
            }
        }

        private void btn_BookUpdate(object sender, EventArgs e)
        {
            //If author has not chosen, book name not written, stock and pages less than 0 warning
            if (string.IsNullOrEmpty(textUpdateBookName.Text.Trim()))
            {
                MessageBox.Show("Enter a book name please!", "WARNING", MessageBoxButtons.OK);
                UpdateTabGroupboxPassiveClean();
            }
            else if(numericUpDownPagesUpdate.Value <= 0)
            {
                MessageBox.Show("Page number must be greater than to zero!", "WARNING", MessageBoxButtons.OK);
                UpdateTabGroupboxPassiveClean();
            }

            else if (numericUpDownUpdateStoc.Value <= 0)
            {
                MessageBox.Show("Stock must be greater than zero!", "WARNING", MessageBoxButtons.OK);
                UpdateTabGroupboxPassiveClean();
            }

            else if (comboUpdateAuthor.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose an author!", "WARNING", MessageBoxButtons.OK);
                UpdateTabGroupboxPassiveClean();
            }
            else
            {
                object genreIdState = (int)comboUpdateGenre.SelectedValue < 0 ? null : comboUpdateGenre.SelectedValue;
                string updateSQLQuery = $"update Books set BookName = '{textUpdateBookName.Text.Trim()}', GenreId={genreIdState.ToString()}, AuthorId={comboUpdateAuthor.SelectedValue}, Stock={numericUpDownUpdateStoc.Value}, Pages={numericUpDownPagesUpdate.Value} where BookId={comboBoxBookUpdate.SelectedValue}";

                SqlCommand command = new SqlCommand(updateSQLQuery, connection);
                OpenConnection();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Content belongs to {comboBoxBookUpdate.SelectedItem} has been updated.");
                }
                else
                {
                    MessageBox.Show($"ERROR: Content belongs to {comboBoxBookUpdate.SelectedItem} has not been updated!");
                }
            }
        }

        private void btn_AddBook(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textAddBookName.Text.Trim()))
                {
                    MessageBox.Show("Book name must be provided!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddTabCleanAllControls();
                }
                else if (numericUpDownAddPages.Value <= 0)
                {
                    MessageBox.Show("Pages must be greater than zero!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddTabCleanAllControls();
                }
                else if (numericUpDownAddStock.Value <= 0)
                {
                    MessageBox.Show("Stock must be greater than zero!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddTabCleanAllControls();
                }
                else if (comboAddAuthor.SelectedIndex < 0)
                {
                    MessageBox.Show("Author of the book must be chosen!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddTabCleanAllControls();
                }
                else
                {
                    using (connection)
                    {
                        //Adding will be done with an sql procedure.
                        SqlCommand command = new SqlCommand($"SP_AddBook", connection);
                        command.CommandType = CommandType.StoredProcedure;
                        //Add parameters.

                        //First approach
                        //SqlParameter bookNameParameter = new SqlParameter();
                        //bookNameParameter.Value = "@BookName";

                        //Second approach
                        command.Parameters.AddWithValue("@registerDate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        command.Parameters.AddWithValue("@bookName", textAddBookName.Text.Trim());  //much more easier.
                        command.Parameters.AddWithValue("@pages", numericUpDownAddPages.Value);
                        command.Parameters.AddWithValue("@genreId", (int)comboAddGenre.SelectedValue);
                        command.Parameters.AddWithValue("@authorId", (int)comboAddAuthor.SelectedValue);
                        command.Parameters.AddWithValue("@stock", numericUpDownAddStock.Value);
                        OpenConnection();

                        int recentlyAddedBookId = Convert.ToInt32(command.ExecuteScalar()); //Procedure selects (returns) one and only value (scope_identity). 
                        //To receive that only returned value, ExecuteScalar() method can be used.
                        if (recentlyAddedBookId > 0)
                        {
                            MessageBox.Show($"New book has been added. \nBookID: {recentlyAddedBookId}");
                            AddTabCleanAllControls();
                        }
                        else
                        {
                            MessageBox.Show("It seems no book has been added recently!", "WARNING", MessageBoxButtons.OK);
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error has occured during adding book to the system!" + ex.Message);
            }
        }

        private void btn_RemoveBook(object sender, EventArgs e)
        {
            try
            {
                DialogResult response = MessageBox.Show("Would you like to hide record instead of deleting?","WARNING", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);

                if (response == DialogResult.Yes)
                {
                    //Record will be hidden, not removed from db
                    SqlCommand command = new SqlCommand($"update Books set IsPassive=1 where BookId={comboRemoveBook.SelectedValue.ToString()}", connection);
                    OpenConnection();
                    int rowsAffected = command.ExecuteNonQuery();
                    if(rowsAffected > 0)
                    {
                        MessageBox.Show("Book has been removed from the list.");
                    }
                    else
                    {
                        MessageBox.Show("An error has occured during removal of the book selected!");
                    }
                }

                else if (response == DialogResult.No)
                {
                    SqlCommand command = new SqlCommand($"select * from Books b inner join LoanBook l on b.BookId = l.BookId " +
                        $"where b.BookId = {comboRemoveBook.SelectedValue.ToString()}", connection);
                    OpenConnection();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    //Object that can contain more than one datatable.
                    DataSet dataset = new DataSet();
                    adapter.Fill(dataset);
                    if ((int)dataset.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("Book has been loaned. You can't remove loaned book! Book should be removed from loaned books management!");
                    }
                    else
                    {
                        //Book is not loaned. Can be removed!
                        command = new SqlCommand("delete from Books where BookId = @bookId", connection);
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@bookId", comboRemoveBook.SelectedValue.ToString());
                        OpenConnection();
                        int rowsAffected = command.ExecuteNonQuery();
                        if(rowsAffected > 0)
                        {
                            MessageBox.Show("Record has been deleted!");
                            DeleteTabCleanAllControls();
                        }
                        else
                        {
                            MessageBox.Show("Error has occured during deletion!");
                        }
                    }

                    CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured during deletion! " + ex.Message );
            }
        }

        private void BringAllBooksToGridWithView()
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from View_BookAuthorGenre where IsPassive = 0";
                OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable virtualTable = new DataTable();
                adapter.Fill(virtualTable);
                dataGridViewBooks.DataSource = virtualTable;
                dataGridViewBooks.Columns["IsPassive"].Visible = false;
                CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while books are being listed. " + ex.Message);
            }
        }

        private void OpenConnection()
        {
            try
            {
                //If connection is not open, let's do so.
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = SQLConnectionString;
                    connection.Open();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error occured while connection is being opened! " + ex.Message);
            }
        }

        private void CloseConnection()
        {
            try
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured while connection is being shut down! " + ex.Message);
            }
        }

        private void comboBoxBookUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBookUpdate.DataSource != null & comboBoxBookUpdate.SelectedIndex >= 0)
            {
                UpdateTabGroupboxActiveClean();
                int chosenAuthorId = (int)comboBoxBookUpdate.SelectedValue;
                UpdateTabGroupboxClean();
                ComboChosenBookInfoFill(chosenAuthorId);
            }
            else
            {
                UpdateTabGroupboxPassiveClean();
            }
        }

        private void UpdateTabGroupboxClean()
        {
            textUpdateBookName.Clear();
            numericUpDownPagesUpdate.Value = 0;
            numericUpDownUpdateStoc.Value = 0;
            comboUpdateAuthor.SelectedIndex = -1;
            comboUpdateAuthor.Text = "Choose Author";
            comboUpdateGenre.SelectedIndex = -1;
            comboUpdateGenre.Text = "Choose Genre";
        }

        private void comboRemoveBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Chosen book details will be written into richtext.
            //Let's perform that task with dataset.
            try
            {
                if (comboRemoveBook.SelectedIndex >= 0)
                {
                    using (connection)
                    {
                        SqlCommand command = new SqlCommand($"select * from Books b left join Genre g on b.GenreId=g.GenreId left join Authors a on b.AuthorId=a.AuthorId where BookId={comboRemoveBook.SelectedValue}", connection);
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        OpenConnection();
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "Books");

                        string bookDetails = dataSet.Tables["Books"].Rows[0]["BookName"].ToString() + "\n" +
                            dataSet.Tables["Books"].Rows[0]["GenreName"].ToString() + "\n" +
                            dataSet.Tables["Books"].Rows[0]["AuthorFullName"].ToString();

                        command = new SqlCommand($"select * from View_LoanedBooks where BookId={comboRemoveBook.SelectedValue}", connection);
                        object loanedBooksQuantity = command.ExecuteScalar();
                        loanedBooksQuantity = loanedBooksQuantity == null ? 0 : loanedBooksQuantity;
                        bookDetails += $"\n{loanedBooksQuantity} of this book has been loaned.";
                        richTextBoxBook.Text = bookDetails;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error has occured! " + ex.Message);
            }
        }
    }
}
