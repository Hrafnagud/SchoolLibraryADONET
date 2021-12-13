using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolLibraryADONET
{
    public partial class FormAuthors : Form
    {
        public FormAuthors()
        {
            InitializeComponent();
        }
        //Global Area
        //SQLCONNECTION Object: Object we use to connect sql database. Located in Sysem.DataClient namespace.

        SqlConnection connection = new SqlConnection();
        string SQLConnectionString = @"Server=DESKTOP-TUMHS1A;Database=SCHOOLLIBRARY;Trusted_Connection=True;";


        private void FormAuthors_Load(object sender, EventArgs e)
        {
            dataGridViewAuthors.MultiSelect = false;    //Multiple line choice blocked
            dataGridViewAuthors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;    //mouse click over a data cell will chose the whole line

            dataGridViewAuthors.ContextMenuStrip = contextMenuStrip1;

            //We'll retrieve info in grid

            ListAllAuthors();
        }

        private void ListAllAuthors()
        {
            try
            {

                ////providing SQLConnection address.
                //connection.ConnectionString = SQLConnectionString;    //This part seems troublesome, therefore commented.

                //SQLCOMMAND Object: Object that takes our queries and procedures.
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                string query = "select * from Authors where IsPassive = 0 order by AuthorId desc";
                command.CommandText = query;
                OpenConnection();

                //DataSQLADAPTER Object: After the query executed, transaction of the data generated, will be performed by this object. Can be added later or stated in ctor.
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                //adapter.SelectCommand = command;    //or create SqlDataAdapter object without passing command to it's constructor and use this alternative line


                DataTable virtualTable = new DataTable();
                adapter.Fill(virtualTable);

                //Content inside data will be moved to virtual table
                dataGridViewAuthors.DataSource = virtualTable;

                dataGridViewAuthors.Columns["IsPassive"].Visible = false;
                dataGridViewAuthors.Columns["AuthorFullName"].Width = 220;
                dataGridViewAuthors.Columns["RegisterDate"].Width = 150;

                CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error has occured! Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (btnAdd.Text)
            {
                case "Add":
                    try
                    {
                        if (string.IsNullOrEmpty(txtAuthor.Text))
                        {
                            MessageBox.Show("Please provide Author information!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            //Add new author
                            string insertQuery = $"insert into Authors (RegisterDate, AuthorFullName, IsPassive) values ('{EditDate(DateTime.Now)}','{txtAuthor.Text.Trim()}',0)";
                            SqlCommand insertCommand = new SqlCommand(insertQuery, connection);

                            //Open Connection
                            OpenConnection();
                            int rowsAffected = insertCommand.ExecuteNonQuery(); //Returns number of rows affected
                            if (rowsAffected > 0)   //bigger than zero means our achievement is successfully performed
                            {
                                MessageBox.Show("New author has been added to the system");
                                ListAllAuthors();
                            }
                            else
                            {
                                MessageBox.Show("An error has  occured. New author has NOT been added!");
                            }

                            //Close Connection
                            CloseConnection();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An Error has occured in ADD case Block!" + ex.Message);
                    }
                    break;

                case "Edit":
                    try
                    {
                        if (!string.IsNullOrEmpty(txtAuthor.Text))
                        {
                            using (connection)
                            {
                                DataGridViewRow line = dataGridViewAuthors.SelectedRows[0];
                                int authorId = Convert.ToInt32(line.Cells["AuthorId"].Value);
                                string updateQuery = $"Update Authors set AuthorFullName='{txtAuthor.Text.Trim()}' where AuthorId={authorId}";


                                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                                OpenConnection();       //Inside using only open connection required. Close command will be performed, when the lifespan of using ends

                                int rowsAffected = updateCommand.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show($"Author has been updated!");
                                    ListAllAuthors();
                                }
                                else
                                {
                                    MessageBox.Show("Author has not been updated!");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Can not update Author, without a name!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error has occured during editing! " + ex.Message);
                    }
                    Clean();
                    break;

                default:
                    break;
            }
        }

        private void Clean()
        {
            btnAdd.Text = "Add";
            txtAuthor.Clear();
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

        private string EditDate(DateTime myDate)
        {
            string dateString = string.Empty;
            if (myDate != null)
            {
                dateString = myDate.Year + "-" + myDate.Month + "-" + myDate.Day + " " + myDate.Hour + ":" + myDate.Minute + ":" + myDate.Second;
            }

            return dateString;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewAuthors.SelectedRows.Count > 0)
            {
                DataGridViewRow line = dataGridViewAuthors.SelectedRows[0];
                string authorFullName = Convert.ToString(line.Cells["AuthorFullName"].Value);
                btnAdd.Text = "Edit";
                txtAuthor.Text = authorFullName;
            }
            else
            {
                MessageBox.Show("To edit records, you must choose an author from the table!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow chosenLine = dataGridViewAuthors.SelectedRows[0];
            int authorId = (int)chosenLine.Cells["AuthorId"].Value;
            string author = Convert.ToString(chosenLine.Cells["AuthorFullName"].Value);

            //If there are any book belongs to the author, there is an AuthorId keyword. In such a case, deletion shouldn't be performed.
            //We ask user again if they're sure about whether they want to delete or not, then we allow deletion operation

            SqlCommand command = new SqlCommand($"select * from Books where AuthorId = {authorId}", connection);

            command.Connection = connection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);   //Operation to be processed by adapter was given in the adapter's ctor.
            DataTable virtualTable = new DataTable();
            OpenConnection();
            adapter.Fill(virtualTable);
            if (virtualTable.Rows.Count > 0)
            {
                MessageBox.Show($"Author {author} has {virtualTable.Rows.Count.ToString()} book in the table. If you want to remove records of that author, " +
                    $"you should delete all the books related to that author. Please proceed to Book operation page.");
            }
            else
            {
                //No Books. We can remove Author.
                DialogResult response = MessageBox.Show($"Are you sure you want to remove Author {author}?", "CONFIRM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (response == DialogResult.Yes)
                {
                    command.CommandText = $"delete from Authors where AuthorId = @authorID";    //Created new parameter with @authorID
                    command.Parameters.Clear();

                    //Addwith value method: Integrates query, associated with sqlcommand object's commandText attribute, into @authorID
                    command.Parameters.AddWithValue("@authorID", authorId);
                    OpenConnection();
                    int rowAffected = command.ExecuteNonQuery();

                    if (rowAffected > 0)
                    {
                        MessageBox.Show("Record removed successfuly.");
                        ListAllAuthors();
                    }
                    else
                    {
                        MessageBox.Show("ERROR: Record has not been removed!");
                    }

                }
                else
                {
                    MessageBox.Show("Record removal request cancelled!");
                }
            }
        }

        private void deletePassiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //User will think that record has been deleted but actually record will be passive
            try
            {
                using (connection)
                {
                    DataGridViewRow line = dataGridViewAuthors.SelectedRows[0];
                    int authorId = Convert.ToInt32(line.Cells["AuthorId"].Value);
                    string updateQuery = $"Update Authors set IsPassive=1 where AuthorId={authorId}";


                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    OpenConnection();       //Inside using only open connection required. Close command will be performed, when the lifespan of using ends

                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Author has removed!");
                        ListAllAuthors();
                    }
                    else
                    {
                        MessageBox.Show("Author has not been removed!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Record can't be turned to passive state due to an error! " + ex.Message);
            }
        }

        private void deleteAlternativeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Not as functional as above alternatives. Shown just for experience and the reason for that is, using this method, in case of record removal attempt with foreign key,
            //will give an alert message with extensive info which can be considered as dangerous. Data integrity is violated for bad intentions. Which is not OK!
            try
            {
                DataGridViewRow chosenLine = dataGridViewAuthors.SelectedRows[0];
                int authorId = (int)chosenLine.Cells["AuthorId"].Value;
                string author = Convert.ToString(chosenLine.Cells["AuthorFullName"].Value);

               

                SqlCommand command = new SqlCommand($"select * from Books where AuthorId = {authorId}", connection);

                command.Connection = connection;

                    //No Books. We can remove Author.
                    DialogResult response = MessageBox.Show($"Are you sure you want to remove Author {author}?", "CONFIRM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (response == DialogResult.Yes)
                    {
                        command.CommandText = $"delete from Authors where AuthorId = @authorID";    //Created new parameter with @authorID
                        command.Parameters.Clear();

                        //Addwith value method: Integrates query, associated with sqlcommand object's commandText attribute, into @authorID
                        command.Parameters.AddWithValue("@authorID", authorId);
                        OpenConnection();
                        int rowAffected = command.ExecuteNonQuery();

                        if (rowAffected > 0)
                        {
                            MessageBox.Show("Record removed successfuly.");
                            ListAllAuthors();
                        }
                        else
                        {
                            MessageBox.Show("ERROR: Record has not been removed!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Record removal request cancelled!");
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }
    }
}
