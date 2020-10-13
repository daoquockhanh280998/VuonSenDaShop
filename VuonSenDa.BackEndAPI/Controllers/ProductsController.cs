using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VuonSenDa.ViewModels.Catalog.Products;
using VuonSenDa.ViewModels.Common;
using VuonSenDaShop.Application.Catalog.Products;

namespace VuonSenDa.BackEndAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IPublicProductService _publicProduct;
        private readonly IManageProductService _manageProduct;

        public ProductsController(IPublicProductService PublicProduct, IManageProductService manageProduct)
        {
            _publicProduct = PublicProduct;
            _manageProduct = manageProduct;
        }

        [HttpGet("{languageId}")]
        public async Task<IActionResult> Get(string languageId)
        {
            var products = await _publicProduct.GetAll(languageId);
            return Ok(products);
        }

        [HttpGet("public-mainCategory/{languageId}")]
        public async Task<IActionResult> GetProductMainCategory(string languageId, [FromQuery] GetPublicProductPagingRequest request)
        {
            var products = await _publicProduct.GetALLByMainCategoryID(languageId, request);
            return Ok(products);
        }

        [HttpGet("public-Category/{languageId}")]
        public async Task<IActionResult> GetProductCategory(string languageId, [FromQuery] GetPublicProductPagingRequest request)
        {
            var products = await _publicProduct.GetALLByCategoryID(languageId, request);
            return Ok(products);
        }

        //http://localhost:port/product/1
        [HttpGet("{productId}/{laguageId}")]
        public async Task<IActionResult> GetById(int productId, string laguageId)
        {
            var product = await _manageProduct.GetById(productId, laguageId);
            if (product == null)
                return BadRequest("cannot find product");

            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] ProductCreateRequest request)
        {
            var productId = await _manageProduct.Create(request);
            if (productId == 0)
                return BadRequest();//tức là lỗi 400

            var product = await _manageProduct.GetById(productId, request.LanguageId);

            return CreatedAtAction(nameof(GetById), new { id = productId }, product);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromForm] ProductUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var affectedResult = await _manageProduct.Update(request);
            if (affectedResult == 0)
                return BadRequest();//tức là lỗi 400
            return Ok();
        }

        [HttpDelete("{productId}")]
        public async Task<IActionResult> Delete(int productId)
        {
            var affectedResult = await _manageProduct.Delete(productId);
            if (affectedResult == 0)
                return BadRequest();//tức là lỗi 400
            return Ok();
        }

        [HttpPatch("{productId}/{newPrice}")]
        public async Task<IActionResult> UpdatePrice([FromQuery] int productId, decimal newPrice)
        {
            var isSuccessful = await _manageProduct.UpdatePrice(productId, newPrice);
            if (isSuccessful == false)
                return BadRequest("cannot update Price ");

            return Ok();
        }

        [HttpPatch("{productId}/{addQuantity}")]
        public async Task<IActionResult> UpdateStock([FromQuery] int productId, int addQuantity)
        {
            var isSuccessful = await _manageProduct.UpdateStock(productId, addQuantity);
            if (isSuccessful == false)
                return BadRequest("cannot update stock ");
            return Ok();
        }

        [HttpPost("{productId}/images")]
        public async Task<IActionResult> CreateImage([FromForm] ImageRequest request, int productId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var imageId = await _manageProduct.AddImages(request, productId);
            if (imageId == 0)
                return BadRequest("cannot Add Image ");
            var image = await _manageProduct.GetImageById(imageId);

            return CreatedAtAction(nameof(GetImageById), new { id = imageId }, image);
        }

        [HttpGet("{productId}/images/{imageId}")]
        public async Task<IActionResult> GetImageById(int productId, int imageId)
        {
            var image = await _manageProduct.GetImageById(imageId);
            if (image == null)
                return BadRequest("cannot find product");

            return Ok(image);
        }

        [HttpPut("Images/{imageId}")]
        public async Task<IActionResult> UpdateImage([FromForm] ImageRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _manageProduct.UpdateImages(request);
            if (result == 0)
                return BadRequest("cannot update Image ");
            return Ok();
        }

        [HttpDelete("images/{imageId}")]
        public async Task<IActionResult> RemoveImages(int imageId)
        {
            var affectedResult = await _manageProduct.RemoveImages(imageId);
            if (affectedResult == 0)
                return BadRequest();//tức là lỗi 400
            return Ok();
        }

        [HttpGet("ListImage/{productId}")]
        public async Task<IActionResult> GetListImage(int productId)
        {
            var listImage = await _manageProduct.GetListImage(productId);
            if (listImage == null)
                return BadRequest();

            return Ok(listImage);
        }

        //[HttpPut("ViewCount/{productId}")]
        //public async Task<IActionResult> AddViewCount(int productId)
        //{
        //    var isSuccessful = _manageProduct.AddViewCount(productId);
        //    if (isSuccessful == null)
        //        return BadRequest("cannot Add View Count ");
        //    return Ok();
        //}
    }
}