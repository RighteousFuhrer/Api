using ekzApi.Enums;
using ekzApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ekzApi.Controllers
{
    [Route("api/Expenses/Stats/Time")]
    [ApiController]
    public class TimeStatController : ControllerBase
    {
        private readonly Context _context;

        public TimeStatController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public Dictionary<int, double> Get()
        {
            var res = new Dictionary<int, double>();
            var tesst= DateTime.Parse("2022-12-09T13:42:09.417").Month;
            var sum = _context.Expenses.ToList().Aggregate(0.0, (acc, next) => acc + next.Cost);
            foreach (int m in Enum.GetValues(typeof(Month)))
            {
                res.Add(m, _context.Expenses.ToList().Where(e => (int)e.Time.Month-1 == m).Aggregate(0.0, (acc, next) => acc + next.Cost));
            }


            return res;
        }
    }
}
