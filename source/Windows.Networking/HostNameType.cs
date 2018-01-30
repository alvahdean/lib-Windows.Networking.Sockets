//
// Copyright (c) 2017 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using System;

namespace Windows.Networking
{
    /// <summary>
    /// The type of a HostName object.
    /// </summary>
    public enum HostNameType
    {
        /// <summary>
        /// A Bluetooth address. This represents the hardware or media access control (MAC) address for a Bluetooth device.
        /// </summary>
        Bluetooth,

        /// <summary>
        /// A domain name.
        /// </summary>
        DomainName,

        /// <summary>
        /// An IPv4 address.
        /// </summary>
        Ipv4,

        /// <summary>
        /// An IPv6 address.
        /// </summary>
        Ipv6
    }
}
