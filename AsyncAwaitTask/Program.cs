namespace AsyncAwaitTask
{
    public class MainClass
    {
        public async Task fun1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write(i + " ");
                await Task.Delay(1);
            }
        }

        public async Task fun2()
        {
            for (int i = 100; i > 0; i--)
            {
                Console.Write(i + " ");
                await Task.Delay(1);
            }
        }

        public async Task AsyncMethod(MainClass mc)
        {
            Console.WriteLine("Called");
            await mc.fun1();
            Console.WriteLine("fun1 completed");
            mc.fun2();
            Console.WriteLine("fun2 completed");
        }

        public static void Main(string[] args)
        {
            MainClass mc = new MainClass();
            Task.Run(() => mc.AsyncMethod(mc)).Wait();  // Run the async method
        }
    }
}
