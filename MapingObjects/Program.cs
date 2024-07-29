using AutoMapper;
namespace MapingObjects
{
    public class Source
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Destination
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Source, Destination>());
            var mapper = config.CreateMapper();

            var source = new Source { Id = 1, Name = "John Doe" };
            var destination = mapper.Map<Destination>(source);

            Console.WriteLine($"Id: {destination.Id}, Name: {destination.Name}");
            Console.WriteLine("Hello, World!");
        }
    }

}
