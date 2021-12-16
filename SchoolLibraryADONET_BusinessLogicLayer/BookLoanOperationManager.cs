using System;
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
                data = myPocketFrameDAL.GetTheData("select l.OperationId, Concat(s.NameOfStudent, ' ', s.Surname) as StudentFullName, b.BookName, l.LoanStarts, l.LoanEnds from LoanBook l inner join Books b on b.BookId = l.BookId inner join Students s on s.Id = l.StudentId");
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
    }
}
