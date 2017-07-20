using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LMS.Model
{
    public class LMS_Admin
    {
        private int adminnumber;

        public int Adminnumber
        {
            get { return adminnumber; }
            set { adminnumber = value; }
        }
        private string adminuid;

        public string Adminuid
        {
            get { return adminuid; }
            set { adminuid = value; }
        }
        private string adminpwd;

        public string Adminpwd
        {
            get { return adminpwd; }
            set { adminpwd = value; }
        }
        private string adminname;

        public string Adminname
        {
            get { return adminname; }
            set { adminname = value; }
        }
    }
}
