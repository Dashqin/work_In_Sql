using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class RectAngular : Figure
    {
        private int _Width;
        private int _Length;
        public RectAngular(int width, int length)
        {

        }
        public int Width
        {
            get
            {
                return _Width;
            }
            set
            {
                if (value>=0)
                {
                    _Width = value;
                }
                else
                {
                    Console.WriteLine("width menfi ola bilmez!");
                }
            }
        }
        public int Length
        {
            get
            {
                return _Length;
            }
            set
            {
                if (value>=0)
                {
                    _Length = value;
                }
                else
                {
                    Console.WriteLine("Length menfi eded ola bilmez!");
                }
            }
        }
        public override void CalcArea()
        {
            //throw new NotImplementedException();
            Console.WriteLine("reactangular ishleyir.");
        }

    }
}
