using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace TriviaClient
{
    public class TriviaMessage
    {
        private string content;

        public TriviaMessage()
        {
            Code = default;
            Length = default;
            content = default;
        }
        public TriviaMessage(string message) // split joined message
        {
            Code = message[0];
            Length = message.Substring(1, 4);
            content = message.Substring(5);
        }

        public TriviaMessage(int code, string content)
        {
            Code = code;
            Content = content;
        }

        /// <summary>
        /// Message code [CODE][length][content]
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// Content length [code][LENGTH][content]
        /// </summary>
        public string Length { get; private set; }

        /// <summary>
        /// Content his-selfs [code][length][CONTENT]
        /// </summary>
        public string Content
        {
            get => content;
            set
            {
                content = value;
                Length = ByteArrayToHexString(BitConverter.GetBytes(content.Length).Reverse().ToArray());
            }
        }

        /// <summary>
        /// joins all message information into one string, which ready to be sent
        /// </summary>
        /// <returns>joined string, ready to be sent to the server</returns>
        public override string ToString()
        {
            return Code.ToString("X") + Length + content;
        }

        /// <summary>
        /// parses the json serialized content into deserialized dictionary
        /// </summary>
        /// <returns>dictionary of str,str</returns>
        public Dictionary<string, string> ToDict()
        {
            return JsonConvert.DeserializeObject<Dictionary<string, string>>(content);
        }

        public Dictionary<string, object> ToMultiDict()
        {
            content = content.Trim('\0');
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return (Dictionary<string, object>)serializer.Deserialize<object>(content);
        }

        /// <summary>
        /// Converts array of bytes into one hexa string
        /// </summary>
        /// <param name="ba">bytes array</param>
        /// <returns>hexa string which made from the bytes array</returns>
        public static string ByteArrayToHexString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2); // multiply by 2 - hex is two chars
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }
    }
}
