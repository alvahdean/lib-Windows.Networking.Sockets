//
// Copyright (c) 2017 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using System;

namespace Windows.Networking.Sockets
{
    /// <summary>
    /// Specifies the level of encryption to use on a StreamSocket object.
    /// </summary>
    public enum SocketProtectionLevel
    {
        /// <summary>
        /// A Bluetooth socket that prefers that encryption be used, but allows a NULL cipher (no encryption) based on the configuration of the target server.
        /// </summary>
        BluetoothEncryptionAllowNullAuthentication,

        /// <summary>
        /// A Bluetooth socket that must use encryption. This value requires encryption and never allows a NULL cipher.
        /// </summary>
        BluetoothEncryptionWithAuthentication,

        /// <summary>
        /// A plain socket with no encryption.
        /// </summary>
        PlainSocket,

        /// <summary>
        /// This value is deprecated 
        /// 
        /// A TCP socket that must use the Secure Sockets Layer (SSL) for encryption. This value requires encryption and never allows a NULL cipher (no encryption).
        /// This value supports the SSL 3.0 and TLS 1.0 protocols and all encryption ciphers installed on the system except the NULL cipher. For domain-joined machines, an administrator can configure additional restrictions on which ciphers are allowed.
        /// This value is marked as deprecated because it is considered insecure since RC4 and other weak ciphers are allowed. Sockets should use Tls10, Tls11, or Tls12 instead unless the target server only supports RC4 or another weak cipher.
        /// </summary>
        Ssl,

        /// <summary>
        /// A TCP socket that must use SSL for encryption. This value supports the SSL 3.0 protocol and all encryption ciphers installed on the system except the NULL cipher. This value allows RC4 and other weak ciphers which are considered insecure. 
        /// For domain-joined machines, an administrator can configure additional restrictions on which ciphers are allowed.
        /// </summary>
        Ssl3AllowWeakEncryption,

        /// <summary>
        /// A TCP socket that prefers to use SSL for encryption. This value prefers that full encryption be used, but allows a NULL cipher (no encryption) based on the server configuration.
        /// This value supports the SSL 3.0 and TLS 1.0 protocols and all encryption ciphers installed on the system including the NULL cipher. For domain-joined machines, an administrator can configure additional restrictions on which ciphers are allowed.
        /// The NULL cipher does no encryption, so this value does not provide confidentiality, but is integrity protected.
        /// </summary>
        SslAllowNullEncryption,

        /// <summary>
        /// A TCP socket that must use SSL for encryption. This value supports the TLS 1.0 protocol and all encryption ciphers installed on the system except RC4, other weak ciphers, and the NULL cipher. 
        /// For domain-joined machines, an administrator can configure additional restrictions on which ciphers are allowed.
        /// </summary>
        Tls10,

        /// <summary>
        /// A TCP socket that must use SSL for encryption. This value supports the TLS 1.1 and TLS 1.0 protocols and all encryption ciphers installed on the system except RC4, other weak ciphers, and the NULL cipher. 
        /// For domain-joined machines, an administrator can configure additional restrictions on which ciphers are allowed.
        /// </summary>
        Tls11,

        /// <summary>
        /// A TCP socket that must use SSL for encryption. This value supports the TLS 1.2, TLS 1.1 and TLS 1.0 protocols and all encryption ciphers installed on the system except RC4, other weak ciphers, and the NULL cipher. 
        /// For domain-joined machines, an administrator can configure additional restrictions on which ciphers are allowed.
        /// </summary>
        Tls12,

        /// <summary>
        /// The protection level is unspecified.
        /// </summary>
        Unspecified
    }
}
