using Microsoft.AspNetCore.Mvc;
using QuotesCollector.QuotesAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuotesCollector.QuotesAPI.Controllers
{
    [Route("api/quotes")]
    public class QuotesController : Controller
    {
        [HttpGet]
        public async Task<IEnumerable<Quote>> GetAsync()
        {
            return new[]
            {
                new Quote() { Name = "Stop waiting for life to be easy (To the bone)" }
            };
        }

        [HttpPost]
        public void Post([FromBody]Quote quote)
        {
        }
    }
}
