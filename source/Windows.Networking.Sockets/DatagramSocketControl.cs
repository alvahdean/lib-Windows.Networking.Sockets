//
// Copyright (c) 2017 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

namespace Windows.Networking.Sockets
{
    //
    // Summary:
    //     Provides socket control data on a DatagramSocket object.
    public sealed class DatagramSocketControl : IDatagramSocketControl, IDatagramSocketControl2, IDatagramSocketControl3
    {
        
        // Summary:
        //     Gets or sets the quality of service on a DatagramSocket object.
        //
        // Returns:
        //     The quality of service on a DatagramSocket object. The default is **normal**.
        public SocketQualityOfService QualityOfService { get; set; }
        
        // Summary:
        //     Gets or sets the hop limit on an outbound packet sent to a unicast IP address
        //     by the DatagramSocket object.
        //
        // Returns:
        //     The hop limit on an outbound packet sent by the DatagramSocket object. The default
        //     is 128.
        public byte OutboundUnicastHopLimit { get; set; }

        // Summary:
        //     Gets or sets the size, in bytes, of the buffer used for receiving data on the
        //     DatagramSocket object.
        //
        // Returns:
        //     The size, in bytes, of the buffer used for receiving data on the DatagramSocket
        //     object.
        public uint InboundBufferSizeInBytes { get; set; }

        // Summary:
        //     Gets or sets a Boolean value that specifies whether the DatagramSocket allows
        //     IP datagrams for UDP to be fragmented.
        //
        // Returns:
        //     Whether the DatagramSocket allows datagrams to be fragmented.
        public bool DontFragment { get; set; }

        // Summary:
        //     Gets or sets a Boolean value that specifies whether the DatagramSocket is able
        //     to coexist with other Win32 or WinRT multicast sockets bound to the same address/port.
        //
        // Returns:
        //     Setting this property to **true** enables the DatagramSocket instance to share
        //     its local port with any Win32 sockets that are bound using **SO_REUSEADDR/SO_REUSE_MULTICASTPORT**,
        //     and with any other **DatagramSocket** instances that have **MulticastOnly** set
        //     to true.
        public bool MulticastOnly { get; set; }
    }
}
