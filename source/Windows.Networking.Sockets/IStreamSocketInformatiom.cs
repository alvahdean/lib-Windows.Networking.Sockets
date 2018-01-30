//
// Copyright (c) 2017 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using System;


namespace Windows.Networking.Sockets
{
    interface IStreamSocketInformatiom
    {
        //BandwidthStatistics BandwidthStatistics { get; }

        HostName LocalAddress { get; }
        string LocalPort { get; }
        SocketProtectionLevel ProtectionLevel { get; }
        HostName RemoteAddress { get; }
        HostName RemoteHostName { get; }
        string RemotePort { get; }
        string RemoteServiceName { get; }

        //RoundTripTimeStatistics RoundTripTimeStatistics { get; }
        //Certificate ServerCertificate { get; }
        //IReadOnlyList<ChainValidationResult> ServerCertificateErrors { get; }
        //SocketSslErrorSeverity ServerCertificateErrorSeverity { get; }
        //IReadOnlyList<Certificate> ServerIntermediateCertificates { get; }
        //IBuffer SessionKey { get; }

    }
}
