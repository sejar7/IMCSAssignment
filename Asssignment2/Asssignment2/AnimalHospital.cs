﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Asssignment2
{
    class AnimalHospital
    {
        List<Dog> dogList = new List<Dog>();
        List<Cat> catList = new List<Cat>();
        List<Bird> birdList = new List<Bird>();
        StreamReader sr;
        public AnimalHospital(string inputFile)
        {
            string line = "";
             sr = new StreamReader("inputfile.txt");
            while ((line = sr.ReadLine()) != "END")
            {
                string[] lineContents = line.Split(',');
                if (lineContents[0].Equals("DOG"))
                {
                    string petName = lineContents[1];
                    string ownerName = lineContents[2];
                    string color = lineContents[3];
                    string size = lineContents[4];

                    Dog dog = new Dog(petName, ownerName, color, size);
                    dog.SetBoardStart(2, 5, 2005);
                    dog.SetBoardEnd(7,6,2017);
                    dogList.Add(dog);
                }
                else if (lineContents[0].Equals("CAT"))
                {
                    lineContents = line.Split(',');
                    if (lineContents[0].Equals("CAT"))
                    {
                        string petName = lineContents[1];
                        string ownerName = lineContents[2];
                        string color = lineContents[3];
                        string hairLength = lineContents[4];



                        Cat cat = new Cat(petName, ownerName, color, hairLength);
                        catList.Add(cat);

                    }
                }
                else if (lineContents[0].Equals("BIRD"))
                {
                    lineContents = line.Split(',');
                    if (lineContents[0].Equals("BIRD"))
                    {
                        string petName = lineContents[1];
                        string ownerName = lineContents[2];
                        string color = lineContents[3];
                        Bird bird = new Bird(petName, ownerName, color);
                        birdList.Add(bird);

                    }
                }
            }

            sr.Close();
        }


        public void PrintPetInfoByName(string name)
        {
            for (int i = 0; i < dogList.Count; i++)
            {
                if (dogList.ElementAt(i).GetPetName().Equals(name))
                    Console.WriteLine(dogList.ElementAt(i).GetpetInfo());
            }
            //traversing cat list;
            for (int i = 0; i < catList.Count; i++)
            {
                if (catList.ElementAt(i).GetPetName().Equals(name))
                    Console.WriteLine(catList.ElementAt(i).GetpetInfo());
            }
            //traversing bird elements
            for (int i = 0; i < birdList.Count; i++)
            {
                if (birdList.ElementAt(i).GetPetName().Equals(name))
                    Console.WriteLine(birdList.ElementAt(i).GetpetInfo());
            }
        }

        public void PrintPetInfoByOwner(string name)
        {
            //for traversing dog list
            for (int i = 0; i < dogList.Count; i++)
            {
                if (dogList.ElementAt(i).GetOwnerName().Equals(name))
                    Console.WriteLine(dogList.ElementAt(i).GetpetInfo());
            }
            //for traversing cat list
            for (int i = 0; i < catList.Count; i++)
            {
                if (catList.ElementAt(i).GetOwnerName().Equals(name))
                    Console.WriteLine(catList.ElementAt(i).GetpetInfo());
            }
            //for traversing Bird list
            for (int i = 0; i < birdList.Count; i++)
            {
                if (birdList.ElementAt(i).GetOwnerName().Equals(name))
                    Console.WriteLine(birdList.ElementAt(i).GetpetInfo());
            }
        }

        public void PrintPetsBoarding(int month, int day, int year)
        {
            for (int i = 0; i < dogList.Count; i++)
            {
                if (dogList.ElementAt(i).Boarding(month, day, year))
                {
                    Console.WriteLine(dogList.ElementAt(i).GetpetInfo());
                }
            }
        }

        ~AnimalHospital()
        {

            sr.Close();
        }
    }
}
