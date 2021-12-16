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
    }
}
