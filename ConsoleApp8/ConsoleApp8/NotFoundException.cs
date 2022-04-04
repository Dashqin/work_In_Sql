using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    class NotFoundException : Exception
    {
        public NotFoundException() : base()
        {

        }
        public NotFoundException(string message) : base(message)
        {
           
        }
    }
}
