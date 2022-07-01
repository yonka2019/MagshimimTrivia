namespace TriviaClient
{
    public readonly struct Address
    {
        public Address(string ip, int port)
        {
            IP = ip;
            PORT = port;
        }

        public string IP { get; }

        public int PORT { get; }

    }
}
