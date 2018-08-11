using System;
using System.Collections.Generic;
using System.Text;

namespace OnvifLite.Exceptions
{
    public class IncorrectCameraStateException : Exception
    {
        public IncorrectCameraStateException()
            : base("Incorrect camera state.")
        {
        }

        public IncorrectCameraStateException(string message)
            : base(message)
        {
        }

        public IncorrectCameraStateException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
