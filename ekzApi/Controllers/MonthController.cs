using ekzApi.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ekzApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonthController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return Enum.GetNames(typeof(Month)).ToList();
        }
    }
}
