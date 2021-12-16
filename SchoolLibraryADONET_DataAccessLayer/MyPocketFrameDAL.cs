using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibraryADONET_DataAccessLayer
{
    //Class library (.NET Framework) Project chosen. Class1 class deleted. MyPocketFrame DAL (DataLayerAccess) class created!
    public class MyPocketFrameDAL
    {
        //If connection type is npt windows authentication but rather server authentication, userid and password will be required as well. 
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }


        private string _sqlConnectionString;
        public string SQLConnectionString 
        {
            get
            {
                return _sqlConnectionString;
            }
        }

        private SqlConnection mySqlConnection = new SqlConnection();
        private SqlCommand mySqlCommand = new SqlCommand();
        private SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter();

        public MyPocketFrameDAL(string serverName, string databaseName, string userId, string password)
        {
            ServerName = serverName;
            DatabaseName = databaseName;
            UserId = userId;
            Password = password;

            if (string.IsNullOrEmpty(ServerName) || string.IsNullOrEmpty(DatabaseName))
            {
                throw new Exception("SQL connection string must have server name and database name!");
            }

            else if (string.IsNullOrEmpty(userId) && string.IsNullOrEmpty(Password))    //Windows Authentication
            {
                _sqlConnectionString = @"Server=" + ServerName + ";Database=" + DatabaseName + ";Trusted_Connection=True";
            }
            else    //Server Authentication
            {
                _sqlConnectionString = @"Data Source= " + ServerName + ";Initial Catalog=" + DatabaseName + ";Persist Security Info=True;User ID=" + UserId + ";Password=" + Password;
            }
        }
        
        public DataTable GetTheData(string tableName, string fieldName, string condition)
        {
            //returnValue --> retVal
            DataTable retVal = new DataTable();
            string queryString = "";
            if (string.IsNullOrEmpty(condition))
            {
                queryString = "Select " + fieldName + " from " + tableName;
            }
            else
            {
                queryString = "select " + fieldName + " from " + tableName + " where " + condition;
            }

            using (mySqlConnection)
            {
                mySqlCommand = new SqlCommand(queryString, mySqlConnection);
                OpenConnection();
                mySqlDataAdapter = new SqlDataAdapter(mySqlCommand);
                mySqlDataAdapter.Fill(retVal);
            }
            return retVal;
        }

        public DataTable GetTheData(string query)
        {
            DataTable retVal = new DataTable();

            using (mySqlConnection)
            {
                mySqlCommand = new SqlCommand(query, mySqlConnection);
                OpenConnection();
                mySqlDataAdapter = new SqlDataAdapter(mySqlCommand);
                mySqlDataAdapter.Fill(retVal);
            }
            return retVal;
        }

        public void OpenConnection()
        {
            try
            {
                if (mySqlConnection.State != ConnectionState.Open)
                {
                    mySqlConnection.ConnectionString = SQLConnectionString;
                    mySqlConnection.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (mySqlConnection.State != ConnectionState.Closed)
                {
                    mySqlConnection.Close();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public object GetTheDataByExecuteScalar(string query)
        {
            object retVal = null;

            using (mySqlConnection)
            {
                mySqlCommand = new SqlCommand(query, mySqlConnection);
                OpenConnection();
                retVal = mySqlCommand.ExecuteScalar();
            }

            return retVal;
        }
    }
}