using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    class Room
    {
        private int ID;
        public Room(int ID)
        {
            this.ID = ID;
            ID++;
        }
        public string Name;
        public int Price;
        public int PersonCapacity;
        public bool IsAvailable = true;
        public string ShowInfo()
        {
            throw new NotImplementedException();
            //this.Price = Price;
            //this.PersonCapacity = PersonCapacity;
            //this.IsAvailable = IsAvailable;
        }
        public override string ToString()
        {
            return ShowInfo();
        }
        public Room()
        {

        }
    }
}
