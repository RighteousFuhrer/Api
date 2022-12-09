using ekzApi.Enums;
using ekzApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ekzApi.Controllers
{
    [Route("api/Expenses/Stats/Categories")]
    [ApiController]
    public class CategoriesStatController : ControllerBase

    {
        private readonly Context _context;

        public CategoriesStatController(Context context)
        {
            _context = context;
        }
        [HttpGet]
        public Dictionary<int, double> Get()
        {
            var res = new Dictionary<int, double>();
            var sum = _context.Expenses.ToList().Aggregate(0.0, (acc, next) => acc + next.Cost);
            foreach(int c in Enum.GetValues(typeof(Category)))
            {
                res.Add(c, _context.Expenses.ToList().Where(e => (int)e.Category == c).Aggregate(0.0, (acc, next) => acc + next.Cost) / sum * 100);
            }


            return res;
        }
    }
}
