using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Core;
using WebApplication1.Core.Models;
using WebApplication1.Core.ViewModel;
using WebApplication1.Dto;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductRepostory _productRepository;
        private readonly IMapper _mapper;
        public ProductController(IProductRepostory productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task AddProduct(ProductDto productDto)
        {
            var product = _mapper.Map<ProductDto, Product>(productDto);
            await _productRepository.AddCakeAsync(product);
        }



        [HttpGet]
        public async Task<IActionResult> GetProductAsync()
        {
            IEnumerable<Product> products = await _productRepository.GetAllProducts();
            return  Ok(products);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _productRepository.GetProduct(id);
            return Ok(product) ;
        }


        [HttpPut("{id}")]
        public void UpdateProduct(int id, ProductDto productDto)
        {
            var product = _mapper.Map<ProductDto, Product>(productDto);
            product.Id = id;
            _productRepository.UpdateProduct(id,product);
            //_productRepository.UpdateProduct(id, product );
        }


        [HttpDelete("{id}")]
        public void DeleteProduct(int id)
        {
            _productRepository.Delete(id);
        }
    }
}