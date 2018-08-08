using System;
using System.Collections.Generic;
using System.ServiceModel.Channels;
using System.ServiceModel;
using System.Text;
using System.Net;

namespace OnvifLite.ProxyFactory
{
    internal class ProxyFactory<TContract, TService> 
        where TContract : class
        where TService : ClientBase<TContract>, TContract
    {
        private readonly CustomBinding _binding;

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

        public TContract CreateProxy(EndpointAddress address)
        {
            var proxy = (TContract)Activator.CreateInstance(typeof(TService), _binding, address);
            return proxy;
        }
    }
}
