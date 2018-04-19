using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService4
{
    public class DoctorUser
    {
        private string doctorname;
        private string doctorCNIC;
        private string hospitalname;
        private string doctordate;

        public string Doctorname
        {
            get { return doctorname; }
            set { doctorname = value; }
        }
        public string DoctorCNIC
        {
            get { return doctorCNIC; }
            set { doctorCNIC = value; }
        }
        public string Hospitalname
        {
            get { return hospitalname; }
            set { hospitalname = value; }
        }
        public string Doctordate
        {
            get { return doctordate; }
            set { doctordate = value; }
        }
        
    }
}