using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ElasticSearchExample.Controllers
{
[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    // GET api/product
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
        return new List<string> { "Mobile Phone", "Laptop", "Books", "Shoes" };
    }
}
}