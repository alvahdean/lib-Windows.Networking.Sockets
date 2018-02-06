//
// Copyright (c) 2017 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using System;

namespace Windows.Networking.Connectivity
{
    internal interface INetworkItem
    {
        NetworkTypes GetNetworkTypes();

        Guid NetworkId { get; }
    }
}
