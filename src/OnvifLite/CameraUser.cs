using System;
using System.Collections.Generic;
using System.Text;

namespace OnvifLite
{
    public class CameraUser
    {
        public string Login { get; private set; }
        public string Password { get; private set; }

        public CameraUser(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
