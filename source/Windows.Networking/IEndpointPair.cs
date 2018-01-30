//
// Copyright (c) 2017 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using System;

namespace Windows.Networking
{
    interface IEndpointPair
    {
        HostName LocalHostName { get; set; }
        string LocalServiceName { get; set; }
        HostName RemoteHostName { get; set; }
        string RemoteServiceName { get; set; }
    }
}
