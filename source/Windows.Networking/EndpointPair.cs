//
// Copyright (c) 2017 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using System;

namespace Windows.Networking
{
    /// <summary>
    /// Provides data for the local endpoint and remote endpoint for a network connection used by network apps.
    /// </summary>
    /// <remarks>
    /// The EndpointPair class is used to initialize and provide data for an endpoint pair used in network apps. The EndpointPair object provides data for the local endpoint and remote endpoint for a network connection. The EndpointPair object is used by many classes in other related namespaces for network apps. These include the following:
    /// - Many classes in the Windows.Networking.Sockets namespace using sockets.Methods on the DatagramSocket and StreamSocket classes can be used to establish network connections and transfer data using an EndpointPair object.
    /// - The NetworkInformation class in the Windows.Networking.Connectivity namespace.An endpoint consists of two elements:
    /// - The hostname or IP address.
    /// - The service name or the TCP or UDP port number.An endpoint pair consists of two elements:
    /// - The local endpoint.
    /// - The remote endpoint.If the local hostname is null for the local endpoint before a network connection is established by a client app, then the system will automatically provide the local IP address for the app to use.
    /// 
    /// If the local service name is an empty string for the local endpoint before a network connection is established by a client app, then the system will automatically provide a TCP or UDP port for the app to use.
    /// </remarks>
    public class EndpointPair : IEndpointPair
    {
        private HostName localHostName;
        private string   localServiceName;
        private HostName remoteHostName;
        private string remoteServiceName;

        /// <summary>
        /// Creates a new EndpointPair object.
        /// </summary>
        /// <param name="localHostName">The local hostname or IP address for the EndpointPair object.</param>
        /// <param name="localServiceName">The local service name or the local TCP or UDP port number for the EndpointPair object.</param>
        /// <param name="remoteHostName">The remote hostname or IP address for the EndpointPair object.</param>
        /// <param name="remoteServiceName">The remote service name or the remote TCP or UDP port number for the EndpointPair object.</param>
        public EndpointPair(HostName localHostName, String localServiceName, HostName remoteHostName, String remoteServiceName)
        {
            LocalHostName = localHostName;
            LocalServiceName = localServiceName;
            RemoteHostName = remoteHostName;
            RemoteServiceName = remoteServiceName;
        }

        /// <summary>
        /// Get or set the local hostname for the EndpointPair object.
        /// </summary>
        public HostName LocalHostName {
            get
            {
                return localHostName;
            }
            set
            {
                localHostName = value;
            }
        }

        /// <summary>
        /// Get or set the local service name for the EndpointPair object.
        /// </summary>
        public string LocalServiceName
        {
            get
            {
                return localServiceName;
            }
            set
            {
                localServiceName = value;
            }
        }

        /// <summary>
        /// Get or set the remote hostname for the EndpointPair object.
        /// </summary>
        public HostName RemoteHostName
        { 
            get
            {
                    return remoteHostName;
            }
            set
            {
                remoteHostName = value;
            }
        }

        /// <summary>
        /// Get or set the remote service name for the EndpointPair object.
        /// </summary>
        public string RemoteServiceName
        {
            get
            {
                return remoteServiceName;
            }
            set
            {
                remoteServiceName = value;
            }
        }
    }
}
