using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LMS.Model
{
    public class LMS_Category
    {
        private int categoryid;

        public int Categoryid
        {
            get { return categoryid; }
            set { categoryid = value; }
        }
        private string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }
    }
}
