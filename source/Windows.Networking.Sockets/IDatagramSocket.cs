//
// Copyright (c) 2017 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using System;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
    internal interface IDatagramSocket : IDisposable
    {
        bool Connect(HostName remoteHostName, string remoteServiceName);

        bool Connect(EndpointPair endpointPair);

        //IAsyncAction BindServiceNameAsync(string localServiceName);

        bool BindEndpoint(HostName localHostName, string localServiceName);

        void JoinMulticastGroup(HostName host);

        IOutputStream GetOutputStream(HostName remoteHostName, string remoteServiceName);

        IOutputStream GetOutputStream(EndpointPair endpointPair);

        DatagramSocketControl Control { get; }

        DatagramSocketInformation Information { get; }

        IOutputStream OutputStream { get; }

        event DatagramSocketMessageReceivedEventHandler MessageReceived;
    }
}
