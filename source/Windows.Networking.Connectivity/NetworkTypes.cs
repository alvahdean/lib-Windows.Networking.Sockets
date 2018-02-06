//
// Copyright (c) 2017 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using System;

namespace Windows.Networking.Connectivity
{
    //
    // Summary:
    //     Defines the network connection types.
    [Flags]
    public enum NetworkTypes : uint
    {

        // Summary:
        //     No network.
        None = 0,

        // Summary:
        //     Internet.
        Internet = 1,

        // Summary:
        //     Private network.
        PrivateNetwork = 2
    }
}
