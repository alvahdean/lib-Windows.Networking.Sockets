using System;

namespace Windows.Networking.Sockets
{
    /// <summary>
    /// Provides socket information on a StreamSocket object.
    /// </summary>
    /// <remarks>
    /// The StreamSocketInformation class provides information about a StreamSocket. This class retrieves information on a 
    /// StreamSocket and can be called any time after the StreamSocket has been created.
    /// A StreamSocketInformation object is automatically created with the parent StreamSocket object. The 
    /// StreamSocket.Information property provides access to the associated StreamSocketInformation object.
    /// </remarks>
    public sealed class StreamSocketInformation : IStreamSocketInformatiom
    {
        private HostName localAddress;
        private string localPort;
        private SocketProtectionLevel protectionLevel;
        private HostName remoteAddress;
        private HostName remoteHostName;
        private string remotePort;
        private string remoteServiceName;

        ///// <summary>
        ///// Gets bandwidth information for network data transfer on a StreamSocket object.
        ///// </summary>
        //public BandwidthStatistics BandwidthStatistics { get; }

        /// <summary>
        /// Gets the local IP address associated with a StreamSocket object.
        /// </summary>
        public HostName LocalAddress
        {
            get { return localAddress; }
        }

        /// <summary>
        /// Get the TCP port number associated with a StreamSocket.
        /// </summary>
        public string LocalPort
        {
            get { return localPort; }
        }

        /// <summary>
        /// Gets the protection level that represents the integrity and encryption set on a StreamSocket object.
        /// </summary>
        public SocketProtectionLevel ProtectionLevel
        {
            get { return protectionLevel; }
        }

        /// <summary>
        /// public HostName RemoteAddress { get; }
        /// </summary>
        public HostName RemoteAddress
        {
            get { return remoteAddress; }
        }


        /// <summary>
        /// public HostName RemoteHostName { get; }
        /// </summary>
        /// <remarks>
        /// The RemoteHostName property represents the remote hostname or IP address for the remote network destination associated with a StreamSocket object. 
        /// The remote hostname or IP address that a StreamSocket object connects to is passed in the remoteHostName parameter to the ConnectAsync method on the StreamSocket.
        /// The RemoteHostName property can be one of the following:
        /// <list type="bullet">
        /// <item>The name of the local host that can be resolved by the Domain Name System (DNS) or by another namespace provider.</item>
        /// <item>A string that contains an IPv4 or an IPv6 network address of the local host. An IPv4 address string is in dotted-decimal 
        /// notation ("192.168.1.111", for example). An IPv6 address is in hexadecimal notation ("21DA:00D3:0010:2F3B:02AA:00FF:FE28:9C5A", 
        /// for example). When this property is the "localhost" string, this represents all loopback addresses on the local computer.</item>
        /// </list>
        /// <para>The RemoteServiceName property represents the remote service name or TCP port number for the remote network destination associated with a StreamSocket object.</para>
        /// <pare>After a connection is established, the RemoteAddress property contains the IP address and the RemotePort property contains the TCP port number of the remote endpoint for the socket connection.</pare>
        /// </remarks>
        public HostName RemoteHostName
        {
            get { return remoteHostName; }
        }


        /// <summary>
        /// Get the TCP port number or service name of the remote network destination associated with a StreamSocket object.
        /// </summary>
        /// <value> string
        /// The TCP port number of the remote network endpoint after a connection is established.
        /// </value>
        /// <remarks>
        /// <para>The RemoteHostName property represents the remote hostname or IP address for the remote network destination 
        /// associated with a StreamSocket object. The RemoteServiceName property represents the remote service name or TCP port 
        /// number for the remote network destination associated with a StreamSocket object. The RemoteHostName and 
        /// RemoteServiceName properties are passed to the ConnectAsync method on the StreamSocket to establish a connection.</para>
        /// 
        /// <para>After a connection is established, the RemoteAddress property contains the IP address and the RemotePort property contains 
        /// the TCP port number of the remote endpoint for the socket connection.Before a connection is established, the 
        /// RemoteAddress property is null and the RemotePort property contains an empty string.</para>
        /// </remarks>
        public string RemotePort
        {
            get { return remotePort; }
        }

        /// <summary>
        /// Get the service name or TCP port number of the remote network destination associated with a StreamSocket object.
        /// </summary>
        public string RemoteServiceName
        {
            get { return remoteServiceName; }
        }


        ///// <summary>
        /////Gets round trip time information for a StreamSocket object.
        ///// </summary>
        //public RoundTripTimeStatistics RoundTripTimeStatistics { get; }

        ///// <summary>
        ///// Gets the certificate from the server when making an SSL connection with a StreamSocket.
        ///// </summary>
        //public Certificate ServerCertificate { get; }

        ///// <summary>
        ///// Gets the list of errors that occurred making an SSL connection with a StreamSocket.
        ///// </summary>
        //public IReadOnlyList<ChainValidationResult> ServerCertificateErrors { get; }

        ///// <summary>
        ///// Gets the category of an error that occurred making an SSL connection with a StreamSocket.
        ///// </summary>
        //public SocketSslErrorSeverity ServerCertificateErrorSeverity { get; }

        ///// <summary>
        ///// Gets the intermediate certificates sent by the server during SSL negotiation when making an SSL connection with a StreamSocket.
        ///// </summary>
        //public IReadOnlyList<Certificate> ServerIntermediateCertificates { get; }

        ///// <summary>
        ///// public IBuffer SessionKey { get; }
        ///// </summary>
        //public IBuffer SessionKey { get; }

    }
}
