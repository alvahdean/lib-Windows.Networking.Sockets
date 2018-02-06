//
// Copyright (c) 2017 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using System;

namespace Windows.Networking.Connectivity
{
    internal interface INetworkAdapter
    {
        //ConnectionProfile GetConnectedProfile();

        uint IanaInterfaceType { get; }

        ulong InboundMaxBitsPerSecond { get; }

        Guid NetworkAdapterId { get; }

        NetworkItem NetworkItem { get; }

        ulong OutboundMaxBitsPerSecond { get; }
    }
}
