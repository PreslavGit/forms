using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAAS
{
    public class Student
    {
        private int fnumber;
        private int specialtyId;
        private string specialtyName;
        private string fname;
        private string mname;
        private string lname;
        private string address;
        private int phone;
        private string email;
        public int FNumber { get { return fnumber; } set { fnumber = value; } }
        public int SpecialtyId { get { return specialtyId; } set { specialtyId = value; } }
        public string SpecialtyName { get { return specialtyName; } set { specialtyName = value; } }
        public string FName { get { return fname; } set { fname = value; } }
        public string MName { get { return mname; } set { mname = value; } }
        public string LName { get { return lname; } set { lname = value; } }
        public string Address { get { return address; } set { address = value; } }
        public int Phone { get { return phone; } set { phone = value; } }
        public string Email { get { return email; } set { email = value; } }
    }
}