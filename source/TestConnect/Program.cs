using System;
using System.Threading;
using System.Diagnostics;
using Windows.Devices.Gpio;
using Windows.Networking.Sockets;
using Windows.Networking;
using Windows.Storage.Streams;

namespace TestConnect
{
    public class Program
    {
        public static void Main()
        {
            while (!Debugger.IsAttached) { Thread.Sleep(100); }    // Wait for debugger (only needed for debugging session)
            Console.WriteLine("Program started");                  // You can remove this line once it outputs correctly on the console

            Thread.Sleep(200);
            Console.WriteLine("Program started");                  // You can remove this line once it outputs correctly on the console
            GpioPin pin = GpioController.GetDefault().OpenPin(27);
            pin.SetDriveMode(GpioPinDriveMode.Output);
            pin.Write(GpioPinValue.High);

            try
            {
                ListenTestUWP(pin);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
                // Do whatever please you with the exception caught
            }
            finally    // Enter the infinite loop in all cases
            {
                while (true)
                {
                    pin.Write(GpioPinValue.Low);
                    Thread.Sleep(200);
                    pin.Write(GpioPinValue.High);
                    Thread.Sleep(200);
                }
            }
        }

        static void PinPulse(GpioPin pin, int timeMs)
        {
            pin.Write(GpioPinValue.Low);
            Thread.Sleep(timeMs);
            pin.Write(GpioPinValue.High);
        }


        static void ListenTestUWP(GpioPin pin)
        {
            DatagramSocket listener = new DatagramSocket();
            listener.MessageReceived += MessageReceived; ;

            listener.BindEndpoint(new HostName("localhost"), "6501");


            DatagramSocket socket = new DatagramSocket();

            try
            {
                // Connect to the server (by default, the listener we created in the previous step).
                socket.Connect(new HostName("192.168.110.100"), "3333");
            }
            catch (Exception exception)
            {
                // If this is an unknown status it means that the error is fatal and retry will likely fail.
                //if (SocketError.GetStatus(exception.HResult) == SocketErrorStatus.Unknown)
                //{
                //    throw;
                //}
            }

            // Create a DataWriter if we did not create one yet. Otherwise use one that is already cached.
            DataWriter writer = new DataWriter(socket.OutputStream);

            // Prepare the message to be sent. Writing data to the writer will just store data in memory.
            string stringToSend = "Hello";
            writer.WriteString(stringToSend);


            // Write the locally buffered data to the network.
            try
            {
                writer.Store();
                //SendOutput.Text = "\"" + stringToSend + "\" sent successfully.";
            }
            catch (Exception exception)
            {
                // If this is an unknown status it means that the error if fatal and retry will likely fail.
                //if (SocketError.GetStatus(exception.HResult) == SocketErrorStatus.Unknown)
                //{
                //    throw;
                //}
            }

        }

        private static void MessageReceived(DatagramSocket socket, DatagramSocketMessageReceivedEventArgs eventArguments)
        {
            try
            {
                // Interpret the incoming datagram's entire contents as a string.
                uint stringLength = eventArguments.GetDataReader().UnconsumedBufferLength;
                string receivedMessage = eventArguments.GetDataReader().ReadString(stringLength);

                Console.WriteLine("Received data from remote peer: \"" +
                    receivedMessage + "\"");
            }
            catch (Exception exception)
            {
                //SocketErrorStatus socketError = SocketError.GetStatus(exception.HResult);
                //if (socketError == SocketErrorStatus.ConnectionResetByPeer)
                //{
                //    // This error would indicate that a previous send operation resulted in an 
                //    // ICMP "Port Unreachable" message.
                //    NotifyUserFromAsyncThread(
                //        "Peer does not listen on the specific port. Please make sure that you run step 1 first " +
                //        "or you have a server properly working on a remote server.",
                //        NotifyType.ErrorMessage);
                //}
                //else if (socketError != SocketErrorStatus.Unknown)
                //{
                //    NotifyUserFromAsyncThread(
                //        "Error happened when receiving a datagram: " + socketError.ToString(),
                //        NotifyType.ErrorMessage);
                //}
                //else
                //{
                //    throw;
                //}
            }
        }
    }
}
