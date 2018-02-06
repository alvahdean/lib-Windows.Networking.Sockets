//
// Copyright (c) 2017 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//


namespace Windows.Networking.Connectivity
{
    //
    // Summary:
    //     Represents the association between an IP address and an adapter on the network.
    public sealed class IPInformation : IIPInformation
    {

        // Summary:
        //     Retrieves the network adapter associated with the IP address.
        //
        // Returns:
        //     The associated network adapter.
        public NetworkAdapter NetworkAdapter { get; }

        // Summary:
        //     Retrieves the length of the prefix, or network part of the IP address.
        //
        // Returns:
        //     The length, in bits, of the prefix or network part.
        public byte PrefixLength { get; }
    }
}
