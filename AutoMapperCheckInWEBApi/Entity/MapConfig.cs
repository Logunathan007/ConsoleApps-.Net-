using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace AutoMapperCheckInWEBApi.Entity
{
    public class MapConfig : Profile
    {
        public MapConfig()
        {
            Console.WriteLine("Map Config is worked");
            CreateMap<Employee, EmployeeDTO>();
        }
    }
}
