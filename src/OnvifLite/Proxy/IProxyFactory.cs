using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.Text;

[assembly: InternalsVisibleTo("OnvifLiteTest")]

namespace OnvifLite.Proxy
{
    internal interface IProxyFactory
    {
        TContract Create<TContract, TService>(Uri serviceAddress)
            where TContract : class
            where TService : ClientBase<TContract>, TContract;
    }
}
