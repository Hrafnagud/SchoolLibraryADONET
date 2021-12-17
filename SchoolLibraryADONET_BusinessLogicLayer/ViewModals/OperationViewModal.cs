using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibraryADONET_BusinessLogicLayer.ViewModals
{
    public class OperationViewModal
    {
        public string StudentFullName { get; set; }
        public string BookName { get; set; }
        public int OperationId { get; set; }
        public int BookId { get; set; }
        public int StudentId { get; set; }
        public DateTime LoanStarts { get; set; }
        public DateTime LoanEnds { get; set; }
        public bool IsReturned { get; set; }
        private string _isReturnedString = "";

        public string IsReturnedString
        {
            get
            {
                if (IsReturned)
                {
                    _isReturnedString = "Yes";
                }
                else
                {
                    _isReturnedString = "No";
                }
                return _isReturnedString;
            }
        }

    }
}
