using System;
using System.Collections.Generic;
using System.Text;
using OnvifLite.CameraState;

namespace OnvifLite.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class CameraStateAttribute : Attribute
    {
        private readonly CameraStateEnum _state;

        public CameraStateEnum State => _state;

        public CameraStateAttribute(CameraStateEnum state)
        {
            _state = state;
        }
    }
}
