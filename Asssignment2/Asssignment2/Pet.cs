using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asssignment2
{
    class Pet
    {
        private string petName;
        private string ownerName;
        private string colour;
        protected int gender;

        public Pet(string petname, string ownername, string color) // Pet Class Constructor
        {
            petName = petname;
            ownerName = ownername;
            colour = color;

        }

        public string GetPetName()
        {
            return petName;
        }

        public string GetOwnerName()
        {
            return ownerName;
        }

        public string GetColor()
        {
            return colour;

        }

        public void SetGender(int sexid)
        {
            this.gender = sexid;
        }


        public string GetGender()
        {
            if (gender == 1)
            {
                return "male";

            }
            else if (gender == 0)
            {
                return "female";
            }
            else return "Undefined";
        }

        public string GetpetInfo()
        {

            string returndata = "";
            returndata += "PET:\n" + petName + "owned by : " + ownerName + "\n color : " + colour + "\n sex : " + gender;
            return returndata;


        }
    }
}
