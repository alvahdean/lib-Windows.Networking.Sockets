using System;
using Windows.Networking;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
    interface IStreamSocket
    {

        StreamSocketControl Control { get; }
        StreamSocketInformation Information { get; }
        IInputStream InputStream { get; }
        IOutputStream OutputStream { get; }
        bool CancelIO();

        bool Connect(EndpointPair endpointPair);
        bool Connect(HostName remoteHostName, String remoteServiceName);
        bool Connect(HostName remoteHostName, String remoteServiceName, SocketProtectionLevel protectionLevel);

       // bool Connect(HostName remoteHostName, String remoteServiceName, SocketProtectionLevel protectionLevel, NetworkAdapter adapter);

    }
}
