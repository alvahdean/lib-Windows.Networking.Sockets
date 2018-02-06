//
// Copyright (c) 2017 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using System;
using System.Runtime.CompilerServices;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
    // This should be a TypedEventHandler "DatagramSocketMessageReceivedEventArgs"
    #pragma warning disable 1591
    public delegate void DatagramSocketMessageReceivedEventHandler(
        DatagramSocket socket,
        DatagramSocketMessageReceivedEventArgs e);

    /// <summary>
    /// Supports network communication using a UDP datagram socket.
    /// </summary>
    public sealed class DatagramSocket : IDatagramSocket, IDisposable //, IDatagramSocket2, IDatagramSocket3
    {
        // this is used as the lock object 
        // a lock is required because multiple threads can access the GpioPin
        private object _syncLock = new object();
        private DatagramSocketMessageReceivedEventHandler _callbacks = null;

        /// <summary>
        /// Creates a new DatagramSocket object.
        /// </summary>
        public DatagramSocket()
        {

        }

        //
        // Summary:
        //     Starts a connect operation on a DatagramSocket to a remote destination specified
        //     by a remote hostname and a remote service name.
        //
        // Parameters:
        //   remoteHostName:
        //     The hostname or IP address of the remote network destination.
        //
        //   remoteServiceName:
        //     The service name or UDP port of the remote network destination.
        //
        // Returns:
        //     An asynchronous connect operation on a DatagramSocket object.
        public bool Connect(HostName remoteHostName, string remoteServiceName)
        {
            return false;
        }

        //
        // Summary:
        //     Starts a connect operation on a DatagramSocket to a remote network destination
        //     specified as an EndpointPair object.
        //
        // Parameters:
        //   endpointPair:
        //     An EndpointPair object that specifies local hostname or IP address, local service
        //     name or UDP port, the remote hostname or remote IP address, and the remote service
        //     name or remote UDP port for the remote network destination.
        //
        // Returns:
        //     An asynchronous connect operation on a DatagramSocket object.
        public bool Connect(EndpointPair endpointPair)
        {
            return false;
        }

        //
        // Summary:
        //     Starts a bind operation on a DatagramSocket to a local service name.
        //
        // Parameters:
        //   localServiceName:
        //     The local service name or UDP port on which to bind the DatagramSocket object.
        //
        // Returns:
        //     An asynchronous bind operation on a DatagramSocket object.
        public bool BindServiceName(string localServiceName)
        {
            return false;
        }

        //
        // Summary:
        //     Starts a bind operation on a DatagramSocket to a local hostname and a local service
        //     name.
        //
        // Parameters:
        //   localHostName:
        //     The local hostname or IP address on which to bind the DatagramSocket object.
        //
        //   localServiceName:
        //     The local service name or UDP port on which to bind the DatagramSocket object.
        //
        // Returns:
        //     An asynchronous bind operation on a DatagramSocket object.
        public bool BindEndpoint(HostName localHostName, string localServiceName)
        {
            return false;
        }

        //
        // Summary:
        //     Joins a DatagramSocket object to a multicast group.
        //
        // Parameters:
        //   host:
        //     The hostname or IP address for the multicast group.
        public void JoinMulticastGroup(HostName host)
        {
        }

        //
        // Summary:
        //     Starts an operation to get an IOutputStream to a remote destination specified
        //     by a remote hostname and a remote service name that can then be used to send
        //     network data.
        //
        // Parameters:
        //   remoteHostName:
        //     The remote hostname or remote IP address.
        //
        //   remoteServiceName:
        //     The remote service name or remote UDP port.
        //
        // Returns:
        //     An IOutputStream that representing the asynchronous operation.
        public IOutputStream GetOutputStream(HostName remoteHostName, string remoteServiceName)
        {
            return null;
        }

        //
        // Summary:
        //     Starts an operation to get an IOutputStream to a remote network destination specified
        //     by an EndpointPair object that can then be used to send network data.
        //
        // Parameters:
        //   endpointPair:
        //     An endpoint pair that represents the local hostname or local IP address, the
        //     local service name or local UDP port, the remote hostname or remote IP address,
        //     and the remote service name or remote UDP port.
        //
        // Returns:
        //     An IOutputStream that represents the asynchronous operation.
        public IOutputStream GetOutputStream(EndpointPair endpointPair)
        {
            return null;
        }

        ////
        //// Summary:
        ////     Starts a bind operation on a DatagramSocket to a local service name and specific
        ////     network interface.
        ////
        //// Parameters:
        ////   localServiceName:
        ////     The local service name or UDP port on which to bind the DatagramSocket object.
        ////
        ////   adapter:
        ////     The network adapter on which to bind the DatagramSocket object.
        ////
        //// Returns:
        ////     An asynchronous bind operation on a DatagramSocket object.
        //public bool BindServiceName(string localServiceName, NetworkAdapter adapter)
        //{
        //    return false;
        //}

        //
        // Summary:
        //     Cancels pending reads and writes over a DatagramSocket object.
        //
        // Returns:
        //     An asynchronous cancel operation on a DatagramSocket object.
        public void CancelIO()
        {
        }

        //// Summary:
        ////     Gets a list of EndpointPair objects based on a remote hostname and remote service
        ////     name that can be used to send datagrams to a remote network destination.
        ////
        //// Parameters:
        ////   remoteHostName:
        ////     The remote hostname or IP address.
        ////
        ////   remoteServiceName:
        ////     The remote service name or UDP port.
        ////
        //// Returns:
        ////     A list of EndpointPair objects.
        //public static IReadOnlyList<EndpointPair> GetEndpointPairs(HostName remoteHostName, string remoteServiceName)
        //{
        //    return null;
        //}

        //// Summary:
        ////     Gets a list of EndpointPair objects based on a remote hostname and remote service
        ////     name and the sort order to be used.
        ////
        //// Parameters:
        ////   remoteHostName:
        ////     The remote hostname or IP address.
        ////
        ////   remoteServiceName:
        ////     The remote service name or UDP port.
        ////
        ////   sortOptions:
        ////     The sort order to use when returning the list.
        ////
        //// Returns:
        ////     A list of EndpointPair objects.

        //public static IReadOnlyList<EndpointPair> GetEndpointPairs(HostName remoteHostName, string remoteServiceName, HostNameSortOptions sortOptions)
        //{
        //    return null;
        //}

        //
        // Summary:
        //     Gets socket control data on a DatagramSocket object.
        //
        // Returns:
        //     Socket control data on a DatagramSocket object.
        public DatagramSocketControl Control { get; }

        // Summary:
        //     Gets socket information on the local and remote hostnames and local and remote
        //     service names for the DatagramSocket object.
        //
        // Returns:
        //     Socket information for the DatagramSocket object.
        public DatagramSocketInformation Information { get; }

        // Summary:
        //     Gets the output stream to write to the remote host.
        //
        // Returns:
        //     A stream of bytes to be written to the remote host in a UDP datagram.
        public IOutputStream OutputStream { get; }

        /// <summary>
        ///  An event that indicates that a message was received on the DatagramSocket object.
        /// </summary>
        public event DatagramSocketMessageReceivedEventHandler MessageReceived
        {
            add
            {
                lock (_syncLock)
                {
                    if (_disposedValue)
                    {
                        throw new ObjectDisposedException();
                    }

                    var callbacksOld = _callbacks;
                    var callbacksNew = (DatagramSocketMessageReceivedEventHandler)Delegate.Combine(callbacksOld, value);

                    try
                    {
                        _callbacks = callbacksNew;
                    }
                    catch
                    {
                        _callbacks = callbacksOld;
                        throw;
                    }
                }
            }

            remove
            {
                lock (_syncLock)
                {
                    if (_disposedValue)
                    {
                        throw new ObjectDisposedException();
                    }

                    var callbacksOld = _callbacks;
                    var callbacksNew = (DatagramSocketMessageReceivedEventHandler)Delegate.Remove(callbacksOld, value);

                    try
                    {
                        _callbacks = callbacksNew;
                    }
                    catch
                    {
                        _callbacks = callbacksOld;
                        throw;
                    }
                }
            }
        }

        #region IDisposable Support

        private bool _disposedValue;

        private void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                }

                DisposeNative();

                _disposedValue = true;
            }
        }

        [MethodImpl(MethodImplOptions.InternalCall)]
        private extern void DisposeNative();

        #pragma warning disable 1591
        ~DatagramSocket()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            lock (_syncLock)
            {
                if (!_disposedValue)
                {
                    Dispose(true);

                    GC.SuppressFinalize(this);
                }
            }
        }

        #endregion

    }
}
