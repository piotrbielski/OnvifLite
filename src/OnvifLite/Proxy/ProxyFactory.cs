using System;
using System.Collections.Generic;
using System.ServiceModel.Channels;
using System.ServiceModel;
using System.Text;
using System.Net;

namespace OnvifLite.Proxy
{
    internal class ProxyFactory
    {
        private readonly CustomBinding _binding;
        private static readonly CustomBinding _staticBinding;

        public ProxyFactory()
        {
            var messageBindingElement = new TextMessageEncodingBindingElement()
            {
                MessageVersion = MessageVersion.CreateVersion(EnvelopeVersion.Soap12, AddressingVersion.WSAddressing10)
            };

            var transportBindingElement = new HttpTransportBindingElement()
            {
                AuthenticationScheme = AuthenticationSchemes.Digest
            };

            _binding = new CustomBinding(messageBindingElement, transportBindingElement);
        }

        public TService Create<TContract, TService>(Uri serviceAddress)
            where TContract : class
            where TService : ClientBase<TContract>, TContract
        {
            EndpointAddress endpointAddress = new EndpointAddress(serviceAddress.ToString());

            var proxy = (TService)Activator.CreateInstance(typeof(TService), _binding, endpointAddress);
            return proxy;
        }
    }
}
