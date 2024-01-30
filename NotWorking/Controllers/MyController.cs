using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace NotWorking.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyController : ControllerBase
    {
        private readonly IMapper _mapper;

        public MyController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet(Name = "Get")]
        public void Get()
        {
            Guid id = Guid.NewGuid();

            //mapping to an interface does not work in this project
            //AutoMapper.AutoMapperMappingException: 'Cannot create interface Working.IDestinationInterface'
            IDestinationInterface destinationInterface = _mapper.Map<IDestinationInterface>(id);
        }
    }


}
