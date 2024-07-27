namespace DepandancyInjection
{
    public interface Server
    {
        public void print();
    }

    public class Server1 : Server
    {
        public void print()
        {
            Console.WriteLine("Server 1.");
        }
    }

    public class Server2 : Server
    {
        public void print()
        {
            Console.WriteLine("Server 2.");
        }
    }

    public class Client
    {
        private Server server;
        public Client(Server server)
        {
            this.server = server;
        }

        public void ClientMethod()
        {
            Console.WriteLine("Client is called");
            this.server.print();
        }
    }

    public class ConstructorInjection
    {

        static void Main(string[] args)
        {
            Server1 s1 = new Server1();
            Server1 s2 = new Server1();

            Client client = new Client(s1);
            client.ClientMethod();
        }
    }
}
