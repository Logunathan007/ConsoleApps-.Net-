namespace IndexersCheck
{
    public class StoreClass
    {
        private string[] arr = new string[10];
        
        public string this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
    }
    public class MainClass
    {
        public static void Main(string[] args)
        {
            StoreClass sc = new StoreClass();
            sc[0] = "Hello";
            sc[0].Dump();
        }
    }
}