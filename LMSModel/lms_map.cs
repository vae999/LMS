using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LMS.Model
{
    public class LMS_Map
    {
        private int booknumber;

        public int Booknumber
        {
            get { return booknumber; }
            set { booknumber = value; }
        }
        private int usernumber;

        public int Usernumber
        {
            get { return usernumber; }
            set { usernumber = value; }
        }
        private string borrowingdate;

        public string Borrowingdate
        {
            get { return borrowingdate; }
            set { borrowingdate = value; }
        }
        private string returndate;

        public string Returndate
        {
            get { return returndate; }
            set { returndate = value; }
        }
     

        private int flage;

        public int Flage
        {
            get
            {
                return flage;
            }

            set
            {
                flage = value;
            }
        }
        private int number;

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }
    }
}
