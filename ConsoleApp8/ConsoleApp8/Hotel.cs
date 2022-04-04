using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    class Hotel
    {
        private Room[] rooms;
        public Hotel(int size)
        { 
            rooms = new Room[size];
        }
        //public int AddRoom()
        //{
        //    return;
        //}
        public Room this[int index]
        {
            get
            {
                return rooms[index];
            }
            set
            {
                rooms[index] = value;
            }
        }

    }
}
