//
// Copyright (c) 2017 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using System;
using System.Runtime.CompilerServices;

using Windows.Networking;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
    /// <summary>
    /// StreamSocket
    /// </summary>
	public class StreamSocket : IStreamSocket, IDisposable
    {
        private StreamSocketControl control = new StreamSocketControl();

        private Int32 socketHandle = -1;
        /// <summary>
        /// Creates a new StreamSocket object.
        /// </summary>
        public StreamSocket()
        {
            socketHandle = SocketNative.socket( (int)socketFamily.AF_INET, (int)SocketType.SOCK_STREAM, (int)SocketProtocol.SOCK_IPPROTO_TCP );
        }


        /// <summary>
        /// Gets socket control data on a StreamSocket object.
        /// </summary>
        /// <remarks>
        /// The Control property gets the StreamSocketControl instance associated with a StreamSocket object.
        /// A StreamSocketControl object is automatically created with the parent StreamSocket object. 
        /// The StreamSocketControl instance can then be used to get or set control data used by the StreamSocket object.
        /// </remarks>
        public StreamSocketControl Control
        {
            get
            {
                return control;
            }
        }


        /// <summary>
        /// Gets socket information on a StreamSocket object.
        /// </summary>
        // public StreamSocketInformation Information { get; }

        /// <summary>
        /// Gets the input stream to read from the remote destination on a StreamSocket object.
        /// </summary>
        /// <remarks>
        /// This property can be used to read incoming data received from the remote network destination on a socket object. 
        /// Incoming data can be read using the IInputStream.ReadAsync method directly or by passing the IInputStream object to other 
        /// objects (DataReader, for example) that accept an IInputStream as a parameter.
        /// </remarks>
        public IInputStream InputStream
        {
            get
            {

                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Gets the output stream to write to the remote host on a StreamSocket object.
        /// </summary>
        /// <remarks>
        /// This property can be used to write outgoing data to be sent to the remote network destination on a socket object. 
        /// Outgoing data can be written using the IOutputStream.WriteAsync method directly or by passing the IOutputStream 
        /// object to other objects (DataWriter, for example) that accept an IOutputStream as a parameter.
        /// </remarks>
        public IOutputStream OutputStream
        {
            get
            {
                throw new NotImplementedException();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        StreamSocketInformation IStreamSocket.Information
        {
            get
            {
                throw new NotImplementedException();
            }
        }


        /// <summary>
        /// Cancels pending reads and writes over a StreamSocket object.
        /// </summary>
        /// <returns></returns>
        public bool CancelIO()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Connect to a remote network destination specified as an EndpointPair object.
        /// </summary>
        /// <param name="endpointPair"></param>
        public void Connect(EndpointPair endpointPair)
        {
            Connect(endpointPair.RemoteHostName, endpointPair.RemoteServiceName);
        }

        /// <summary>
        /// Connect to a remote network destination specified by a remote hostname and a remote service name.
        /// </summary>
        /// <param name="remoteHostName"></param>
        /// <param name="remoteServiceName"></param>
        /// <returns></returns>
        public bool Connect(HostName remoteHostName, String remoteServiceName)
        {
            UInt16 port = ParseServiceName(remoteServiceName);
            UInt32 address = ParseHostName(remoteHostName);

            //Int32 result = NativeSocketConnect(address, port);

            // SocketNative.connect();


            return false;
        }

        /// <summary>
        /// Parse service name which can be a port number or a named service.
        /// We will support only a few named services
        /// </summary>
        /// <param name="ServiceName"></param>
        /// <returns></returns>
        private UInt16 ParseServiceName(String ServiceName)
        {
            UInt16 port;

            try
            {
                return UInt16.Parse(ServiceName);
            }
            catch (Exception) { };

            switch (ServiceName.ToLower())
            {
                case "http": port = 80; break;

                default:
                    throw new ArgumentException();
            }
            return port;
        }


        private UInt32 ParseHostName(HostName hostName)
        {
            if (hostName.Type == HostNameType.Ipv4)
                return Ipv4ToInt(hostName.CanonicalName);


            //TODO
            // Look up Hostname to IP address
            return (UInt32)10000;
        }

        private UInt32 Ipv4ToInt(String ipAddess)
        {
            return 8000;
        }

        /// <summary>
        /// connect to a remote network destination specified as an EndpointPair object and a SocketProtectionLevel enumeration.
        /// </summary>
        /// <param name="remoteHostName"></param>
        /// <param name="remoteServiceName"></param>
        /// <param name="protectionLevel"></param>
        /// <returns></returns>
        public bool Connect(HostName remoteHostName, String remoteServiceName, SocketProtectionLevel protectionLevel)
        {
            switch( remoteHostName.Type )
            {
                case HostNameType.Ipv4:
                    break;

                case HostNameType.DomainName:
                    break;
            }
            throw new NotImplementedException();
        }

        /// <summary>
        /// connect to a remote network destination specified as an EndpointPair object and a SocketProtectionLevel enumeration.
        /// </summary>
        /// <param name="remoteHostName"></param>
        /// <param name="remoteServiceName"></param>
        /// <param name="protectionLevel"></param>
        /// <param name="adapter"></param>
        /// <returns></returns>
        //public bool Connect(HostName remoteHostName, String remoteServiceName, SocketProtectionLevel protectionLevel, NetworkAdapter adapter)
        //{
        //    throw new NotImplementedException();
        //}


        ///// <summary>
        ///// Gets a list of EndpointPair objects based on a remote hostname and remote service name that can be used to send TCP packets to a remote network destination.
        ///// </summary>
        ///// </summary>
        ///// <param name="remoteHostName"></param>
        ///// <param name="remoteServiceName"></param>
        ///// <returns></returns>
        //public static IReadOnlyList<EndpointPair> GetEndpointPairs(HostName remoteHostName, String remoteServiceName)
        //{

        //}

        /// <summary>
        /// Upgrade a connected socket to use SSL on a StreamSocket object.
        /// </summary>
        /// <param name="protectionLevel"></param>
        /// <param name="validationHostName"></param>
        /// <returns></returns>
        public bool UpgradeToSsl(SocketProtectionLevel protectionLevel, HostName validationHostName)
        {
            throw new NotImplementedException();
        }

        bool IStreamSocket.CancelIO()
        {
            throw new NotImplementedException();
        }

        bool IStreamSocket.Connect(EndpointPair endpointPair)
        {
            throw new NotImplementedException();
        }

        bool IStreamSocket.Connect(HostName remoteHostName, string remoteServiceName)
        {
            throw new NotImplementedException();
        }

        bool IStreamSocket.Connect(HostName remoteHostName, string remoteServiceName, SocketProtectionLevel protectionLevel)
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            if (socketHandle >= 0)
            {
                SocketNative.close(socketHandle);
                socketHandle = -1;
            }
        }
    }
}
