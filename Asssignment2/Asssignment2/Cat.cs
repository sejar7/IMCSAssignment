using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asssignment2
{
    class Cat : Pet, IBoardable
    {
        DateTime startDate;
        DateTime endDate;
        private string hairlength;

        public Cat(string petName, string ownerName, string color, string hairLength) : base(petName, ownerName, color)
        {
            hairlength = hairLength;
        }
        public string Gethairlength()
        {
            string hairlength;
            hairlength = "short";
            return hairlength;

        }
        public new string GetpetInfo()
        {
            base.GetpetInfo();
            string petinfo = "";
            petinfo += "CAT:\n" + GetPetName() + "owned by : " + GetOwnerName() + "\n color : " + GetColor()
                + "\n Sex : Spayed"+ "\n hair : " + hairlength;
            return petinfo;
        }
        public void SetBoardStart(int month, int day, int year)// implementation from interface
        {
            startDate = new DateTime(year, month, day);
        }

        public void SetBoardEnd(int month, int day, int year)
        {
            endDate = new DateTime(year, month, day);
        }

        public bool Boarding(int month, int day, int year)
        {

            return true;
        }

    }
}
