using ekzApi.Enums;
using ekzApi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ekzApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return Enum.GetNames(typeof(Category)).ToList();
        }
    }
}
