using System;
using System.Collections.Generic;
using System.Text;

namespace _03._28._2022
{
    class Singer
    {
        private string _Name;
        private string _Surname;
        private int _Age;
        public Singer(string name,string surname,int age)
        {
            _Name = name;
            _Surname = surname;
            _Age = age;
        }
        public string Name 
        {
            get
            {
                return _Name;
            }
            set
            {
                if (Name.Length<100)
                {
                    
                    value = _Name;
                }
                else
                {
                    Console.WriteLine("it's false");
                }
            }
        }
        public string Surname
        {
            get
            {
                return _Surname;
            }
            set
            {
                if (Surname.Length < 100)
                {
                    // return _Surname;
                    value = _Surname;
                }
                else
                {
                    Console.WriteLine("it's false");
                }
            } 
        }
        public int age
        {
            get
            {
                return _Age;
            }
            set
            {
                if (value < 170)
                {
                    _Age = value;
                }
                else
                {
                    Console.WriteLine("it's false");
                }
            } 
        }
    } 
}
