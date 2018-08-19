using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;

namespace OnvifLite.Proxy
{
    internal interface IProxyFactory
    {
        TService Create<TContract, TService>(Uri serviceAddress)
            where TContract : class
            where TService : ClientBase<TContract>, TContract;
    }
}
