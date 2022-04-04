using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    class NotAvailableException : Exception
    {
        public NotAvailableException() : base()
        {
        }
        public NotAvailableException(string message) : base(message)
        {
        }
    }
}
