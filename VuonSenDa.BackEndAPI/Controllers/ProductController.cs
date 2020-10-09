using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VuonSenDaShop.Application.Catalog.Products;

namespace VuonSenDa.BackEndAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IPublicProductService _IPPS;
        public ProductController(IPublicProductService IPPS)
        {
            _IPPS = IPPS;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await _IPPS.GetAll();
            return Ok(products);
        }
    }
}
