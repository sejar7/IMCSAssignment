using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Object> applicantslist = new List<Object>();
            Console.WriteLine("Enter First name");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter Last name");
            string lastname = Console.ReadLine();
            Console.WriteLine("Enter Phone Number");
            string phonenumber = Console.ReadLine();
            Applicant client1 = new Applicant(firstname, lastname, phonenumber);
            applicantslist.Add(client1);

            Console.WriteLine("List of Applicants");
            foreach(Object applicant in applicantslist)
            {
                Console.WriteLine(applicant);
            }

            Console.ReadLine();
        }
    }
}
