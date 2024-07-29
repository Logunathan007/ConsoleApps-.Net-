namespace AutoMapperCheckInWEBApi.Entity
{
    public interface IAV
    {
        void print(Employee e);
        void print(EmployeeDTO e);
    }
    public class Add_VIew : IAV
    {

        public void print(EmployeeDTO refer)
        {
            if (refer != null)
            {
                Console.WriteLine(refer.Name + " " + refer.Email);
            }
        }
        public void print(Employee refer)
        {
            if (refer != null)
            {
                Console.WriteLine(refer.Name + " " + refer.Email + " " + refer.Address);
            }
        }
    }
}
