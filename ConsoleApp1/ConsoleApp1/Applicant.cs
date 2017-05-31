using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class Applicant
    {
        string firstname;
        string lastname;
        string phonenumber;
        public Applicant(string firstname, string lastname, string phonenumber)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.phonenumber = phonenumber;
        }
    }
}
