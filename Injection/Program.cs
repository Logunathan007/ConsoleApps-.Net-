namespace Injection
{
    public interface Server
    {
        void Print();
    }
    public class Server1 : Server
    {
        public void Print()
        {
            Console.WriteLine("Server 1 is selected");
        }
    }
    public class Server2 : Server
    {
        public void Print()
        {
            Console.WriteLine("Server 2 is selected");
        }
    }

    public class ClientConstructorInjection
    {
        private Server server;
        public ClientConstructorInjection(Server server)
        {
            this.server = server;
        }
        public void Print()
        {
            Console.WriteLine("ClientConstructorInjection Called");
            this.server.Print();
        }
    }
    public class ClientPropertyInjection
    {
        public Server obj { get; set; }
        

        public void Print()
        {
            Console.WriteLine("ClientPropertyInjection Called");
            if(obj != null) 
                obj.Print();
        }
    }

    public class ClientMethodInjection
    {
        private Server Obj;
        public void Method(Server Obj)
        {
            this.Obj = Obj;
            Console.WriteLine("ClientMethodInjection Called");
            this.Obj.Print();
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            Server1 s1 = new Server1();
            Server2 s2 = new Server2();


            /*ClientConstructorInjection cci = new ClientConstructorInjection(s1);
            cci.Print();*/

            /*ClientConstructorInjection cci = new ClientConstructorInjection(s2);
            cci.Print();*/

            /*ClientPropertyInjection cpi = new ClientPropertyInjection();
            cpi.obj = s1;
            cpi.Print();*/

            /*ClientPropertyInjection cpi = new ClientPropertyInjection();
            cpi.obj = s2;
            cpi.Print();*/

            /*ClientMethodInjection cmi = new ClientMethodInjection();
            cmi.Method(s2);*/

            ClientMethodInjection cmi = new ClientMethodInjection();
            cmi.Method(s2);

        }
    }
}
