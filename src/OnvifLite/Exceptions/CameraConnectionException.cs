using System;
using System.Collections.Generic;
using System.Text;

namespace OnvifLite.Exceptions
{
    public class CameraConnectionException : Exception
    {
        public CameraConnectionException()
            : base("An unknown error occurred while connecting to the camera. Check the endpoint address and the user credential.")
        {
        }

        public CameraConnectionException(string message)
            : base(message)
        {
        }

        public CameraConnectionException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
