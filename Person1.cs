using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Person1
    {
        string fName;
        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }
        string lName;
        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }
        System.DateTime bDate;
        public DateTime BDate
        {
            get { return bDate; }
            set { bDate = value; }
        }
        public int IntDtime
        {
            get
            {
                return Convert.ToInt32(bDate);
            }
            set
            {
                bDate = Convert.ToDateTime(value);
            }
        }
        public Person1 (string fName, string lName, DateTime bDate)
        {
            FName = fName;
            LName = lName;
            BDate = bDate;
        }
        public Person1()
        {
            fName = "Sergiy";
            fName = "Sokolow";
            bDate = new DateTime(2000, 12, 12);
        }
        public virtual string ToShortString()
        {
            return ($"firat name ={fName} lasr name= {lName}");
        }
        public override string ToString()
        {
            return ($"{ToShortString()}, birth day={bDate}");
        }
    }
}
