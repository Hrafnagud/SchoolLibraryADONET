using System;
using System.Collections;
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

        //Insert related operations
        public string CreateInsertQueryAsString(string tableName, Hashtable htData)
        {
            string retVal = string.Empty;
            string fields = "", values = "";
            foreach (var key in htData.Keys)
            {
                string value = htData[key].ToString();
                fields += key + ",";    //field1, field2, field3, (There will be a comma at the end
                values += value + ",";  //same applies for values as well
            }

            //To fix that we can use Trim method.
            fields = fields.TrimEnd(',');
            values = values.TrimEnd(',');

            retVal = "insert into " + tableName + " ("+fields+") values ("+values+")";
            return retVal;
        }

        //Update related operations
        public string CreateUpdateQueryAsString(string tableName, Hashtable htData, string condition)
        {
            string retVal = string.Empty;
            string set = string.Empty;

            foreach (string key in htData.Keys )
            {
                //BookName = 'New Book' --> meaning key and value in htData should be retrieved together
                set += key + "=" + htData[key].ToString() + ",";

            }
            set = set.TrimEnd(',');
            retVal = "update " + tableName + " set " + set + " where " + condition;
            return retVal;
        }

        //Delete related operations
        public string CreateDeleteQueryAsString(string tableName, string condition)
        {
            string retVal = string.Empty;

            retVal = "delete from " + tableName + " where " + condition;

            return retVal;
        }

        //Delete related operations
        public string CreateDeleteQueryAsString(string tableName, Hashtable htData)
        {
            string retVal = string.Empty;
            if (htData.Count == 1)
            {
                foreach (var key in htData)
                {
                    retVal = "delete from " + tableName + " where " + key + "=" + htData[key].ToString();
                }
            }
            else
            {
                string deleteCondition= string.Empty;
                foreach (string key in htData)
                {
                    deleteCondition += key + "=" + htData[key].ToString() + " and ";
                }
                deleteCondition.TrimEnd();

                deleteCondition.TrimEnd('d');
                deleteCondition.TrimEnd('n');
                deleteCondition.TrimEnd('a');

                retVal = "delete from " + tableName + " where " + deleteCondition;
            }

            return retVal;
        }

        //Use ExecutenonQuery with Transaction
        public bool ExecuteTheQueriesWithTransaction(params string[] queries)
        {
            bool retVal = false;
            SqlTransaction myTransaction = null;
            try
            {
                using (mySqlConnection)
                {
                    OpenConnection();
                    myTransaction = mySqlConnection.BeginTransaction();

                    foreach (string item in queries)
                    {
                        mySqlCommand = new SqlCommand(item, mySqlConnection, myTransaction);
                        mySqlCommand.ExecuteNonQuery();
                    }

                    myTransaction.Commit();
                    retVal = true;
                }
            }
            catch (Exception ex)
            {
                myTransaction.Rollback();
                retVal = false;
                throw ex;
            }

            return retVal;
        }

        //Method that processes update and delete queries with ExecuteNonQuery.
        public int ExecuteTheQuery(string myQuery)
        {
            int rowsAffected = 0;

            using (mySqlConnection)
            {
                mySqlCommand = new SqlCommand(myQuery, mySqlConnection);
                OpenConnection();
                rowsAffected = mySqlCommand.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    throw new Exception("Error: Record has not been able to added.");
                }
            }

            return rowsAffected;
        }
    }
}