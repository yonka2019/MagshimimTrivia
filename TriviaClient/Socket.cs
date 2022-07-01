using System;
using System.Configuration;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace TriviaClient
{
    public static class Socket
    {
        private static readonly TcpClient clientSocket = new TcpClient();

        /// <summary>
        /// Checks if the any user logged (no logged user -> no logged)
        /// </summary>
        public static bool IsLogged => LoggedUser != null;

        /// <summary>
        /// returns the current logged user
        /// </summary>
        public static string LoggedUser { get; set; } = null;

        /// <summary>
        /// returns formatted string of logged user >> "Logged as USERNAME"
        /// </summary>
        public static string LoggedUserFormatted => IsLogged ? $" (Logged as {LoggedUser})" : "";

        /// <summary>
        /// True if the server active (on the port), either - false
        /// </summary>
        public static bool Connected { get; set; }

        /// <summary>
        /// Returns server connected address
        /// </summary>
        public static Address ServerAddress { get; } = new Address(ConfigurationManager.AppSettings["server_ip"], int.Parse(ConfigurationManager.AppSettings["port"]));

        static Socket()
        {
            try
            {
                clientSocket.Connect(ServerAddress.IP, ServerAddress.PORT);
            }
            catch
            {
                Connected = false;
                return;
            }
            Connected = true;
        }

        /// <summary>
        /// Sends message to the active socket
        /// </summary>
        /// <param name="msg">Message to send</param>
        /// <returns>True if Successfully sent, either - false</returns>
        public static bool SendMsg(string msg)
        {
            try
            {
                NetworkStream stream = clientSocket.GetStream();
                byte[] outStream = Encoding.ASCII.GetBytes(msg);

                stream.Write(outStream, 0, outStream.Length);
                stream.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Receive message from the active socket
        /// </summary>
        /// <returns>The received message from the server</returns>
        public static string RecvMsg()
        {
            try
            {
                NetworkStream stream = clientSocket.GetStream();
                byte[] inStream = new byte[8192];

                stream.Read(inStream, 0, 8192);
                return Encoding.ASCII.GetString(inStream);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Receive message from the active socket server only if the response code matching, if not, wait for the right message.
        /// </summary>
        /// <param name="responseCode">response code which should be matched</param>
        /// <returns>The received message from server</returns>
        public static string RecvMsgByResponse(params int[] responseTypes)
        {
            string recvMsg;
            TriviaMessage response;

            do
            {
                recvMsg = RecvMsg();
                response = new TriviaMessage(recvMsg);
                if (response.Code == (int)TriviaResponse.ERROR)
                {
                    MessageBox.Show(TriviaProtocol.FormatResponseByMessage(recvMsg), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

            } while (!responseTypes.Contains(response.Code)); // wait for the right message

            return recvMsg;
        }
    }
}
