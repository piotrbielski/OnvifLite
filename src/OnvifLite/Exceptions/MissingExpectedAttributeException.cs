using System;
using System.Collections.Generic;
using System.Text;

namespace OnvifLite.Exceptions
{
    public class MissingExpectedAttributeException : Exception
    {
        public MissingExpectedAttributeException()
            : base("Attribute not found.")
        {
        }

        public MissingExpectedAttributeException(string message)
            : base(message)
        {
        }

        public MissingExpectedAttributeException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
