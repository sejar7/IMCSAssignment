using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalHospital animal = new AnimalHospital("name");
            Console.WriteLine(" Welsome to PET Hospital Care");
            


            int choice;
            do
            {
                Console.WriteLine("\n****************************");
                Console.WriteLine("1. Search by Pet Name");
                Console.WriteLine("2. Search by owner Name");
                Console.WriteLine("Search by Boarding Date");
                Console.WriteLine("Exit");
                Console.WriteLine("****************************\n");
                Console.WriteLine("please enter the choice");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the name of pet you want to search: ");
                        string petName = Console.ReadLine();
                        animal.PrintPetInfoByName(petName);
                        //PetTypeChoice(input.GetChoice("Enter choice"));
                        break;

                    case 2:
                        Console.Write("Enter the name of owner you want to search: ");
                        string ownerName = Console.ReadLine();
                        animal.PrintPetInfoByOwner(ownerName);
                        break;

                    case 3:
                        Console.Write("Enter day : ");
                        int day = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Month : ");
                        int month = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter year : ");
                        int year = Convert.ToInt32(Console.ReadLine());
                        animal.PrintPetsBoarding(month, day, year);
                        break;


                    case 4:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Write("\n\nNot a valid selection. Press any key to return");
                        Console.ReadKey(true);
                        break;

                }
            } while (choice != 4);
        }
    }

}





