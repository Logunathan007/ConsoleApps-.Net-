using AutoMapper;
using AutoMapperCheckInWEBApi.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperCheckInWEBApi.Controllers
{
    [ApiController]
    [Route("Api/")]
    public class MapController : ControllerBase
    {
        // GET: MapController
        private IMapper _mapper;
        private IAV view;
        public MapController(IMapper mapper, IAV view)
        {
            _mapper = mapper;
            this.view = view;
        }

        [HttpGet]
        public ActionResult Index()
        {
            Employee emp = new Employee()
            {
                Name = "Logunathan J",
                FirstName = "Logunathan",
                LastName = "J",
                Email = "logu@gmail.com",
                Address = "Theni"
            };
            EmployeeDTO Dto = _mapper.Map<EmployeeDTO>(emp);
            view.print(emp);
            view.print(Dto);

            return Ok();
        }

    }
}
