using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LMS.Model
{
    public class LMS_Book
    {
        private int booknumber;

        public int Booknumber
        {
            get { return booknumber; }
            set { booknumber = value; }
        }
        private string bookname;

        public string Bookname
        {
            get { return bookname; }
            set { bookname = value; }
        }
        private string bookisbn;

        public string Bookisbn
        {
            get { return bookisbn; }
            set { bookisbn = value; }
        }
        private int bookcategoryid;

        public int Bookcategoryid
        {
            get { return bookcategoryid; }
            set { bookcategoryid = value; }
        }
        private string bookauthor;

        public string Bookauthor
        {
            get { return bookauthor; }
            set { bookauthor = value; }
        }
        private string bookpress;

        public string Bookpress
        {
            get { return bookpress; }
            set { bookpress = value; }
        }
        private int bookquantity;

        public int Bookquantity
        {
            get { return bookquantity; }
            set { bookquantity = value; }
        }
    }
}
