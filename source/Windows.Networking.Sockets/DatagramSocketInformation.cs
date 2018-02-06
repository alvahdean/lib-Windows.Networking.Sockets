//
// Copyright (c) 2017 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

namespace Windows.Networking.Sockets
{
    /// <summary>
    /// Provides socket information on a DatagramSocket object.
    /// </summary>
    public sealed class DatagramSocketInformation : IDatagramSocketInformation
    {
        /// <summary>
        /// The local IP address associated with a DatagramSocket object.
        /// </summary>
        /// <value>The local hostname or IP address.
        /// </value>
        public HostName LocalAddress { get; }

        // Summary:
        //     The local service name or UDP port number associated with a DatagramSocket.
        //
        // Returns:
        //     The local service name or UDP port number.
        public string LocalPort { get; }

        // Summary:
        //     The IP address of the remote network destination associated with a DatagramSocket
        //     object.
        //
        // Returns:
        //     The IP address of the remote network destination.
        public HostName RemoteAddress { get; }

        // Summary:
        //     The UDP port number of the remote network destination associated with a DatagramSocket
        //     object.
        //
        // Returns:
        //     The UDP port number of the remote network destination.
        public string RemotePort { get; }
    }
}
