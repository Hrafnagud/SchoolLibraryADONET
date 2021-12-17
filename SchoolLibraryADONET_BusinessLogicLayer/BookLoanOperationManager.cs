using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolLibraryADONET_DataAccessLayer;

namespace SchoolLibraryADONET_BusinessLogicLayer
{
    public class BookLoanOperationManager
    {
        MyPocketFrameDAL myPocketFrameDAL = new MyPocketFrameDAL("DESKTOP-TUMHS1A", "SCHOOLLIBRARY", "", "");

        public DataTable BringAllBooks()
        {
            try
            {
                DataTable data = new DataTable();
                data = myPocketFrameDAL.GetTheData("Books", "*", "IsPassive=0");
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable BringAllStudents()
        {
            try
            {
                DataTable data = new DataTable();
                data = myPocketFrameDAL.GetTheData("Students", "Id, concat(NameOfStudent, ' ', Surname) as StudentFullName, Gender, Class, DateOfBirth, IsPassive ", "IsPassive=0");
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable BringDataToGrid()
        {
            try
            {
                DataTable data = new DataTable();
                data = myPocketFrameDAL.GetTheData("select l.OperationId, l.BookId, Concat(s.NameOfStudent, ' ', s.Surname) as StudentFullName, b.BookName, l.LoanStarts, l.LoanEnds from LoanBook l inner join Books b on b.BookId = l.BookId inner join Students s on s.Id = l.StudentId");
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int BringBookStock(int bookId)
        {
            
            try
            {
                int bookQuantity = 0;
                object data = myPocketFrameDAL.GetTheDataByExecuteScalar($"select Stock from Books where BookId={bookId}");

                if (data != null)
                {
                    bookQuantity = Convert.ToInt32(data);
                }

                return bookQuantity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool RegisterBookLoan(string tableName, Hashtable htData)
        {
            bool isRegistered = false;
            try
            {
                //Retrieving stock quantity
                object stockQuantity = myPocketFrameDAL.GetTheDataByExecuteScalar($"select Stock from Books where BookId={htData["BookId"].ToString()}");

                if (stockQuantity != null)
                {
                    stockQuantity = (int)stockQuantity - 1;
                    string updateQuery = $"Update Books set Stock={stockQuantity} where BookId={htData["BookId"]}";

                    //Loan
                    string insertQuery = myPocketFrameDAL.CreateInsertQueryAsString(tableName, htData);
                    isRegistered = myPocketFrameDAL.ExecuteTheQueriesWithTransaction(insertQuery, updateQuery);
                }
                else
                {
                    throw new Exception("Since stock quantity information can't not be provided, error has occured!");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return isRegistered;
        }

        public bool ReturnLoanedBook(string tableName, int loanId, int bookId)
        {
            bool isReturned = false;
            try
            {
                //stock
                object stockQuantity = myPocketFrameDAL.GetTheDataByExecuteScalar($"select Stock from Books where BookId={bookId}");
                if (stockQuantity != null)
                {
                    stockQuantity = (int)stockQuantity + 1;
                    string[] myQueries = new string[2];
                    myQueries[0] = $"update Books set Stock = {stockQuantity} where BookId = {bookId}";

                    //To use CreateUpdateAsString, creating a hashtable.
                    //If that is not wanted, second query can be added like it was above.
                    //myQueries[1] = $"update LoanBook set isReturned=1, LoanEnds= '" + DateTime.Now.ToString(yyyy-MM-dd HH:mm:ss)"'where LoanId= {loanId}";

                    Hashtable htData = new Hashtable();
                    string endDate = $"'{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}'";
                    htData.Add("isReturned", "1");
                    htData.Add("LoanEnds", endDate);
                    string myCondition = $"OperationId={loanId}";
                    myQueries[1] = myPocketFrameDAL.CreateUpdateQueryAsString("LoanBook", htData, myCondition);
                    isReturned = myPocketFrameDAL.ExecuteTheQueriesWithTransaction(myQueries);

                }
                else
                {
                    throw new Exception("Error has occured due to stock quantity information can't be obtained.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return isReturned;
        }
    }
}
