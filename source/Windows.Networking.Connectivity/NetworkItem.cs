//
// Copyright (c) 2017 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using System;

namespace Windows.Networking.Connectivity
{
    //
    // Summary:
    //     Represents a connected network.
    public sealed class NetworkItem : INetworkItem
    {
        //
        // Summary:
        //     Gets a NetworkTypes value indicating the network type for a NetworkItem.
        //
        // Returns:
        //     The type of a network.
        public NetworkTypes GetNetworkTypes()
        {
            throw new NotImplementedException();
        }

        //
        // Summary:
        //     Gets the network ID.
        //
        // Returns:
        //     The network ID.
        public Guid NetworkId { get; }
    }
}
