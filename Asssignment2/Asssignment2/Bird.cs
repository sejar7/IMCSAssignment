using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asssignment2
{   
    class Bird : Pet
    {
        private bool featherclipped;

        public Bird(string petname, string ownername, string color) : base(petname, ownername, color)
        {
            featherclipped = false;
        }

        public bool Clipped()
        {
            return featherclipped;
        }
        public void setclipped()
        {
            featherclipped = true;
        }
        public new string GetpetInfo()
        {
            base.GetpetInfo();
            string petinfo = "";
            if (Clipped())
            {
                petinfo += GetPetName() + "owned by : " + GetOwnerName() + "\n color : " + GetColor() + "\n sex : " + gender + "\n featherclipped : yes";
            }
            else
            {
                petinfo += GetPetName() + "owned by : " + GetOwnerName() + "\n color : " + GetColor() + "\n sex : " + gender + "\n featherclipped : no";
            }

            return petinfo;
        }

    }
}
