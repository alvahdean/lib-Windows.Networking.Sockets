//
// Copyright (c) 2017 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using System;
using Windows.Networking.Connectivity;

namespace Windows.Networking
{
    /// <summary>
    /// Provides data for a hostname or an IP address.
    /// </summary>
    public class HostName
    {
        private string _canonicalName;
        private string _displayName;
        private string _rawName;
        private HostNameType _hostNameType;

        /// <summary>
        /// Creates a new HostName object from a string that contains a hostname or an IP address.
        /// </summary>
        /// <remarks>
        /// This constructor creates a new HostName object. The hostName parameter can contain a hostname or an IP address. A HostName object can be used for a local hostname or a remote hostname.
        /// The hostName parameter can contain one of the following:
        ///     -The name of a host that can be resolved by the Domain Name System(DNS) or by another namespace provider.
        ///     -The name of a host that matches a string in the following file on the local computer: %WINDIR%\system32\drivers\etc\hosts
        ///     -A string that contains an IPv4 or an IPv6 network address of the host.An IPv4 address string is in dotted-decimal notation("192.168.1.111", for example). An IPv6 address is in hexadecimal notation("21DA:00D3:0010:2F3B:02AA:00FF:FE28:9C5A", for example). If the hostName parameter is the "localhost" string, this represents all loopback addresses on the local computer.
        ///
        /// The NetworkInformation.GetHostNames method in the Windows.Networking.Connectivity namespace can be used to retrieve a list of host names or IP addresses associated with the local machine.One of these hostnames or IP addresses can then be used for the hostName parameter.
        /// The constructor will fail if the hostName parameter is null or contains an empty string.
        /// </remarks>
        /// <param name="hostName"></param>
        public HostName(String hostName)
        {
            _rawName = hostName ?? throw new ArgumentNullException("hostName"); ;
            _canonicalName = _displayName = RawName;

            if (hostName[0] >= '0' && hostName[0] <= '9')
                _hostNameType = HostNameType.Ipv4;
            else
                _hostNameType = HostNameType.DomainName;
        }

        #region Properties

        /// <summary>
        /// Gets the canonical name for the HostName object.
        /// </summary>
        public string CanonicalName => _canonicalName;

        /// <summary>
        /// Gets the display name for the HostName object.
        /// </summary>
        public string DisplayName => _displayName;

        /// <summary>
        /// Gets the IPInformation object for a local IP address assigned to a HostName object.
        /// </summary>
        /// <value>
        /// The IPInformation object for the IP address.
        /// </value>
        public IPInformation IPInformation { get; }

        /// <summary>
        /// Gets the original string used to construct the HostName object.
        /// </summary>
        public string RawName => _rawName;

        /// <summary>
        /// Gets the HostNameType of the HostName object.
        /// </summary>
        public HostNameType Type => _hostNameType;

        #endregion

        #region Methods

        /// <summary>
        /// Compares two strings to determine if they represent the same hostname.
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns>int
        ///  The return value indicates the lexicographic relation of value1 to value2.If the two parameters represent the same canonical hostname, then zero is returned.If value1 is less than value2, the return value is less than zero.If value1 is greater than value2, the return vale is greater than zero.
        ///  </returns>
        ///  <remarks>
        ///  The Compare method is used to compare two strings to determine if the strings represent the same hostname. 
        ///  This method compares canonical names created from the value1 and value2 parameters to determine the value to return.
        /// </remarks>
        public static int Compare(String value1, String value2)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Determines whether the specified HostName object has an equivalent value to the current HostName object.
        /// </summary>
        /// <param name="hostName">A HostName object that is compared with the current HostName.</param>
        /// <returns>A Boolean value that indicates whether the specified HostName object is equal to the current HostName object.</returns>
        /// <remarks>
        /// The Equals method determines whether the HostName object specified by the hostName parameter is the same instance of the current HostName object.
        /// The IsEqual method determines whether the HostName object specified by the hostName parameter has an equivalent value to the current HostName object. 
        /// Two HostName objects are considered to have the equivalent value if the CanonicalName property has the same value.
        /// </remarks>
        public bool IsEqual(HostName hostName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a string that represents the HostName object.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return RawName;
        }
        #endregion

    }
}
