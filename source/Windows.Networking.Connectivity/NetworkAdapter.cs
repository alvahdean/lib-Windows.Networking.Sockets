using System;

namespace Windows.Networking.Connectivity
{
    //
    // Summary:
    //     Represents a network adapter.
    public sealed class NetworkAdapter : INetworkAdapter
    {
        // Summary:
        //     Gets the connection profile currently associated with the network adapter.
        //
        // Returns:
        //     The connection profile associated with this network adapter.
        //public ConnectionProfile GetConnectedProfile();

        // Summary:
        //     Gets a value indicating the network interface type as defined by the Internet
        //     Assigned Names Authority (IANA) for the NetworkAdapter.
        //
        // Returns:
        //     The interface type as defined by the Internet Assigned Names Authority (IANA).
        public uint IanaInterfaceType { get; }

        // Summary:
        //     Gets a value indicating the maximum inbound data transfer rate in bits per second.
        //
        // Returns:
        //     The maximum inbound transfer rate in bits per second.
        public ulong InboundMaxBitsPerSecond { get; }

        // Summary:
        //     Gets the network adapter ID.
        //
        // Returns:
        //     The network adapter ID.
        public Guid NetworkAdapterId { get; }

        // Summary:
        //     Gets the NetworkItem object that represents the connected network.
        //
        // Returns:
        //     The connected network.
        public NetworkItem NetworkItem { get; }

        // Summary:
        //     Gets a value indicating the maximum outbound speed in bits per second.
        //
        // Returns:
        //     The maximum outbound transfer rate in bits per second.
        public ulong OutboundMaxBitsPerSecond { get; }
    }
}
