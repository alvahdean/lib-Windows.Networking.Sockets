//
// Copyright (c) 2017 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using System;

namespace Windows.Networking.Sockets
{
    /// <summary>
    /// Specifies the quality of service for a DatagramSocket or StreamSocket object.
    /// </summary>
    public enum SocketQualityOfService
    {
        /// <summary>
        /// Low latency quality of service commonly used for audio.
        /// </summary>
        LowLatency,

        /// <summary>
        /// Normal quality of service.
        /// </summary>
        Normal
    }
}
