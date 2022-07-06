using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using GeneralStoreAPI.Data;
using GeneralStoreAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GeneralStoreAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private GeneralStoreDbContext _db;

        public ProductController(GeneralStoreDbContext db)
        {
            _db = db;
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductEdit newProduct){
            Product product = new Product(){
                Name = newProduct.Name,
                Price = newProduct.Price,
                QuantityInStock = newProduct.QuantityInStock
            };
            _db.Products.Add(product);
            await _db.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts(){
            var products = await _db.Products.ToListAsync();
            // List<RestaurantListItem> restaurantList = restaurants.Select(r => new RestaurantListItem(){
            //     Id = r.Id,
            //     Name = r.Name,
            //     Location = r.Location,
            //     AverageScore = r.AverageScore
            // }).ToList();
            return Ok(products);
        }
    }
}