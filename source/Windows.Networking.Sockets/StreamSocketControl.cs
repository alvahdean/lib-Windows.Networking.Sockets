//
// Copyright (c) 2017 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using System;

namespace Windows.Networking.Sockets
{
    /// <summary>
    /// Provides socket control data on a StreamSocket object.
    /// </summary>
    public class StreamSocketControl
    {
        private bool keepAlive;
        private SocketProtectionLevel minProtectionLevel;
        private bool noDelay;
        private uint outboundBufferSizeInBytes;
        private byte outboundUnicastHopLimit;
        private SocketQualityOfService qualityOfService;
        private bool serializeConnectionAttempts;


        /// <summary>
        /// Gets or sets the client SSL/TLS certificate that will be sent to the server if the server requests a client certificate.
        /// </summary>
      //  public Certificate ClientCertificate { get; set; }

        /// <summary>
        /// Get a vector of SSL server errors to ignore when making an SSL connection with a StreamSocket.
        /// </summary>
       // public IList<ChainValidationResult> IgnorableServerCertificateErrors { get; }

        /// <summary>
        /// A value that indicates whether keep-alive packets are sent to the remote destination on a StreamSocket object.
        /// </summary>
        /// <remarks>
        /// When this property is true, the StreamSocket sends keep-alive packets when no data or acknowledgment packets have been received for the TCP connection within an interval.
        /// When a StreamSocket is created, the default value for this property is false.
        /// This property may be set before the StreamSocket is connected.After the StreamSocket is connected, setting the property will result in an error.
        /// For more detailed information, see the SO_KEEPALIVE socket option in the Windows Sockets documentation.
        /// </remarks>
        public bool KeepAlive
        {
            get
            {
                return keepAlive;
            }
            set
            {
                keepAlive = value;
            }
        }

        /// <summary>
        /// Constrains the TLS protocol version that will be negotiated when the developer uses the ConnectAsync() or UpgradeToSslAsync() methods that require TLS.
        /// </summary>
        public SocketProtectionLevel MinProtectionLevel
        {
            get
            {
                return minProtectionLevel;
            }
            set
            {
                minProtectionLevel = value;
            }
        }

        /// <summary>
        /// A value that indicates whether the Nagle algorithm is used on a StreamSocket object.
        /// </summary>
        /// <remarks>
        /// The NoDelay property controls whether Nagle's algorithm is enabled or disabled on a StreamSocket object. The default value for the NoDelay property is true.
        /// Nagle's algorithm is a technique to improving the efficiency of TCP/IP networks by reducing the number of packets that are needed to be sent over the network. The algorithm tries to deal with problems caused by an application that repeatedly emits data in small chunks. A TCP packet has a 40-byte header (20 bytes for IP and 20 bytes for TCP). So if an app sends only 4 bytes in a packet, the overhead on the packet data is very large. This can occur for a remote access protocol (telnet or secure shell, for example) where most key presses may generate only a single byte or two of data that is transmitted immediately. Over a slow link, many of these packets may be in transit over the network at the same time. Nagle's algorithm works by combining a number of small outgoing messages, and sending them all at once.When there is a sent packet for which the sender has received no acknowledgment, the sender keeps buffering output until it has a full packet's worth of output. This allows the output to be sent all at once. The impact of applying Nagle's algorithm is to increase the bandwidth at the expense of latency.A well-written app that buffers sends internally should not need to use Nagle's algorithm.
        /// When this property is true, the StreamSocket will disable Nagle's algorithm on the TCP connection. This setting reduces the potential delays when sending small messages. When a StreamSocket is created, the default value for this property is true.
        /// When this property is false, the StreamSocket will enable Nagle's algorithm on the TCP connection. This setting can increase the bandwidth at the expense of latency, but should only be used with caution. There are some adverse side effects possible when Nagle's algorithm is enabled and certain other TCP optimizations are also used.
        /// This property may be set before the StreamSocket is connected.After the StreamSocket is connected, setting the property will result in an error.
        /// This property sets the value of the TCP_NODELAY socket option on the TCP socket used by the StreamSocket.
        /// </remarks>
        public bool NoDelay
        {
            get
            {
                return noDelay;
            }
            set
            {
                noDelay = value;
            }
        }

        /// <summary>
        /// The size, in bytes, of the send buffer to be used for sending data on a StreamSocket object.
        /// </summary>
        /// <remarks>
        /// The size, in bytes, of the send buffer to be used for sending data.
        /// 
        /// The OutboundBufferSizeInBytes property sets the value of the SO_SNDBUF socket option on the TCP socket used by the StreamSocket. The default value is the local computer's default send buffer size. This value varies based on the system memory size. For more detailed information, see SOL_SOCKET Socket Options in the Windows Sockets documentation.
        /// For most apps, this property should not be set since this disables TCP send auto-tuning by the system on this StreamSocket object. With TCP send auto-tuning disabled, network throughput is often worse especially on a connections with high latency.So this property should only be used in very specific situations.
        /// The OutboundBufferSizeInBytes property must be set before the StreamSocket is connected.Setting this property after the StreamSocket is connected has no effect.
        /// </remarks>
        public uint OutboundBufferSizeInBytes
        {
            get
            {
                return outboundBufferSizeInBytes;
            }
            set
            {
                outboundBufferSizeInBytes = value;
            }
        }

        /// <summary>
        /// The hop limit on an outbound packet sent to a unicast IP address by the StreamSocket object.
        /// </summary>
        /// <value>The hop limit on an outbound packet sent by the StreamSocket object. The default is 128.</value>
        /// <remarks>
        /// This value indicates the hop limit that is set on an outbound TCP packet sent to a unicast IP address using the StreamSocket object. This property is used to set the Time to Live (TTL) field in an IPv4 packet header. This property is used to set the Hop Limit field in an IPv6 header. The default value for this property is 128.
        /// This property may be set before the StreamSocket is connected.After the StreamSocket is connected, setting this property will result in an error.
        /// Setting the OutboundUnicastHopLimit may not have an effect if the system doesn't support setting the TTL.
        /// </remarks>>
        public byte OutboundUnicastHopLimit
        {
            get
            {
                return outboundUnicastHopLimit;
            }
            set
            {
                outboundUnicastHopLimit = value;
            }
        }

        /// <summary>
        /// The quality of service on a StreamSocket object.
        /// </summary>
        /// <remarks>
        /// This property indicates the quality of service that StreamSocket object should provide. The default value is normal.
        /// When the property is set to a value other than normal, the socket will follow a policy to provide the specified quality of service.When the property is set to lowLatency, the priority of the thread that handles read completions is increased.The lowLatency value would commonly be used for audio or similar apps that are timing sensitive.This property is not normally set for other apps.
        /// This property may be set before the StreamSocket is connected.After the StreamSocket is connected, setting this property will result in an error.
        /// </remarks>
        public SocketQualityOfService QualityOfService
        {
            get
            {
                return qualityOfService;
            }
            set
            {
                qualityOfService = value;
            }
        }


        /// <summary>
        /// A value that indicates whether, when multiple connection attempts are being made, the attempts are made in parallel or serially.
        /// </summary>
        /// <remarks>
        /// When true, at most one connection attempt will be active at one time on this StreamSocket. Default value is false.
        /// 
        /// In certain circumstances, the Windows runtime might attempt to establish a connection using multiple methods in parallel. For example, when StreamSocket attempts a connection and a proxy is detected on the network, 
        /// it attempts both a direct connection to the specified IP address, and an HTTP CONNECT request (which will connect via the proxy) in parallel. The first connection to succeed is the one that is used by the StreamSocket object. 
        /// While this works well in most cases, it causes problems with some servers in the case where both connection attempts succeed. 
        /// If your app is using StreamSocket to connect to a server where the parallel connection method causes problems on the server, you should set SerializeConnectionAttempts to true before connecting. 
        /// This will ensure that at most one TCP connection attempt is ongoing at any given time, and that only a single connection is used.
        /// Your code must set this property before you call ConnectAsync to attempt to connect.Changing this property value after ConnectAsync has been called results in an exception being thrown.
        /// Note that serializing the connection logic can make establishing the connection take longer.
        /// </remarks>
        public bool SerializeConnectionAttempts
        {
            get
            {
                return serializeConnectionAttempts;
            }
            set
            {
                serializeConnectionAttempts = value;
            }
        }
    }
}
