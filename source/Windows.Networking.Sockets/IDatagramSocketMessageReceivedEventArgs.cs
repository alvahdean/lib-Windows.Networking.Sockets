//
// Copyright (c) 2017 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
    internal interface IDatagramSocketMessageReceivedEventArgs
    {
        DataReader GetDataReader();

        IInputStream GetDataStream();

        HostName LocalAddress { get; }

        HostName RemoteAddress { get; }

        string RemotePort { get; }
    }
}
