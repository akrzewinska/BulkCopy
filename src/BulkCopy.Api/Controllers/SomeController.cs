using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BulkCopy.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
       
        [HttpGet]
        public IEnumerable<string> Get()
        {
           return new string[] {"Some","Test"};
        } 
    }
}
