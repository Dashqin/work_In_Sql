using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Square : Figure
    {
        private int _Side;
        public Square(int side)
        {
            _Side = side;
        }
        public int Side 
        {
            get
            {
                return _Side;
            }
            set
            {
                if (value >= 0)
                {
                    _Side = value;
                }
            }
        }
        public override void CalcArea()
        {
            //throw new NotImplementedException();
            Console.WriteLine("square ishleyir");
        }
    }
}
