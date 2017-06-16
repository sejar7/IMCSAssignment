using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asssignment2
{
    class Dog : Pet, IBoardable
    {
        private string size;
        DateTime startDate;
        DateTime endDate;
        public Dog(string petName, string ownerName, string color, string size) : base(petName, ownerName, color)
        {
            this.size = size;
            Console.WriteLine("Dog instance created");
        }

        public string Getsize()
        {
            return size;

        }
        public new string GetpetInfo()
        {
            string petinfo = "";
            petinfo += "Dog:\n" + GetPetName() + "owned by : " + GetOwnerName() +
               "\n Sex : Spayed" + "\n color : " + GetColor() + "\n size : " + size;
            return petinfo;
        }
        public void SetBoardStart(int month, int day, int year)
        {
            startDate = new DateTime(year, month, day);
        }

        public void SetBoardEnd(int month, int day, int year)
        {
            endDate = new DateTime(year, month, day);
        }

        public bool Boarding(int month, int day, int year)
        {
            DateTime givenDate = new DateTime(year, month, day);
            if (givenDate >= startDate && givenDate <= endDate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
