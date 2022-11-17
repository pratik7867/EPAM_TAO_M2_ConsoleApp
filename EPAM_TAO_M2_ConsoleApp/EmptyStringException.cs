using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_TAO_M2_ConsoleApp
{
    class EmptyStringException : Exception
    {
        public EmptyStringException(string Message) : base(Message)
        {

        }
    }
}
