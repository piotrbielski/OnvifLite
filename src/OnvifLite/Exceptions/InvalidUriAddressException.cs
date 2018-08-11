using System;
using System.Collections.Generic;
using System.Text;

namespace OnvifLite.Exceptions
{
    public class InvalidUriAddressException : Exception
    {
        public InvalidUriAddressException()
            : base("Invalid URI address.")
        {
        }

        public InvalidUriAddressException(string message)
            : base(message)
        {
        }

        public InvalidUriAddressException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
