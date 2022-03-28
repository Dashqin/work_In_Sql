using System;
using System.Collections.Generic;
using System.Text;

namespace _03._28._2022
{
    class Song
    {
        private string _Name;
        private string _Genre;
        private Singer _Singer;
        public string Name 
        {
            get
            {
                return _Name;
            }
            set
            {
                if (Name.Length < 100)
                {

                    value = _Name;
                }
                else
                {
                    Console.WriteLine("it's false");
                }
            }
        }
        public string Genre 
        {
            get
            {
                return _Genre;
            }
            set
            {
                if(value == "pop"||value == "rock"||value == "jazz"||value == "techno")
                {
                    value = _Genre;
                }
                else
                {
                    Console.WriteLine("it's false");
                }
            }
        }
        public void AddRating(params int [] retings)
        {
           
        }
        public void GetAvarageRating(params int[] retings)
        {
            int sum = 0;
            int say = 0;
            for(int i = 0; i < retings.Length - 1; i++)
            {
                sum += i;
                say++;
            }
            Console.WriteLine(sum / say);
        }
    }
}
