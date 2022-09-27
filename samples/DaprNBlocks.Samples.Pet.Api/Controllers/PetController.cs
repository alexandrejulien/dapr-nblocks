using Microsoft.AspNetCore.Mvc;
using Moq;

namespace DaprNBlocks.Samples.Pet.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PetController : ControllerBase
    {

        private readonly ILogger<PetController> _logger;

        public PetController(ILogger<PetController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Pet")]
        public IEnumerable<Pet> Get()
        {
            return Mock.Of<List<Pet>>();
        }
    }
}