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
            UpdateTabClean();
            BringAllBooksToComboBox();
            BringAllAuthorsToComboBox();
            BringAllGenresToComboBox();

            tabControl1.Click += new EventHandler(tabControl1_Click);
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            BringAllBooksToGridWithView();
            BringAllBooksToComboBox();
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
                    SqlCommand command = new SqlCommand("Select * from Books order by BookName", connection);
                    OpenConnection();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable virtualTable = new DataTable();
                    adapter.Fill(virtualTable);
                    comboBoxBookUpdate.DisplayMember = "BookName";
                    comboBoxBookUpdate.ValueMember = "BookId";
                    comboBoxBookUpdate.DataSource = virtualTable;
                    comboBoxBookUpdate.SelectedIndex = -1;
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
            if (numericUpDownPagesUpdate.Value <= 0 || 
                numericUpDownUpdateStoc.Value <= 0 || 
                comboUpdateAuthor.SelectedIndex < 0 ||
                string.IsNullOrEmpty(textUpdateBookName.Text.Trim()))
            {
                MessageBox.Show("Missing information.. Provide correct information");
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

        private void BringAllBooksToGridWithView()
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from View_BookAuthorGenre";
                OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable virtualTable = new DataTable();
                adapter.Fill(virtualTable);
                dataGridViewBooks.DataSource = virtualTable;
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
                int chosenAuthorId = (int)comboBoxBookUpdate.SelectedValue;
                UpdateTabClean();
                ComboChosenBookInfoFill(chosenAuthorId);
            }
            else
            {
                UpdateTabClean();
            }
        }

        private void UpdateTabClean()
        {
            textUpdateBookName.Clear();
            numericUpDownPagesUpdate.Value = 0;
            numericUpDownUpdateStoc.Value = 0;
            comboUpdateAuthor.SelectedIndex = -1;
            comboUpdateAuthor.Text = "Choose Author";
            comboUpdateGenre.SelectedIndex = -1;
            comboUpdateGenre.Text = "Choose Genre";
        }
    }
}
