//
// Copyright (c) 2017 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using System;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
    //
    // Summary:
    //     Provides data for a MessageReceived event on a DatagramSocket.
    public sealed class DatagramSocketMessageReceivedEventArgs : IDatagramSocketMessageReceivedEventArgs
    {
        //
        // Summary:
        //     Gets a DataReader object to read incoming data received from the remote network
        //     destination on a DatagramSocket object.
        //
        // Returns:
        //     A DataReader object to read incoming data received from the remote network destination
        //     on a DatagramSocket object.
        public DataReader GetDataReader()
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Gets an IInputStream object that represents a sequential stream of bytes to be
        //     read as a message from the remote network destination on a DatagramSocket object.
        //
        // Returns:
        //     An IInputStream object that represents a sequential stream of bytes to be read
        //     as a message.
        public IInputStream GetDataStream()
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Gets the local IP address associated with a DatagramSocket when a message was
        //     received.
        //
        // Returns:
        //     The local IP address where the message was received by the DatagramSocket.
        public HostName LocalAddress { get; }
        //
        // Summary:
        //     Gets the IP address of the remote sender of the datagram on the DatagramSocket
        //     when a message is received.
        //
        // Returns:
        //     The IP address of the remote network destination when the message is received
        //     on a DatagramSocket.
        public HostName RemoteAddress { get; }
        //
        // Summary:
        //     Gets the UDP port number of the remote sender of the datagram received on the
        //     DatagramSocket.
        //
        // Returns:
        //     The UDP port number of the remote network destination when a message is received
        //     on a DatagramSocket.
        public string RemotePort { get; }
    }
}
