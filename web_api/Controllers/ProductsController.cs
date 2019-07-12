using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using web_api.Filter;
using web_api.Models;

namespace web_api.Controllers
{
    [BasicAuthenticationAttribute]
    public class ProductsController : ApiController
    {
  
        Product[] products = new Product[]
           {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
           };

 
        [HttpGet, AllowAnonymous]
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

 
        [HttpGet, AllowAnonymous]
        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }


        [HttpGet]
        public IHttpActionResult GetPageRow(int limit, int offset)
        {
            var lstRes = new List<Product>();

            //实际项目中，通过后台取到集合赋值给lstRes变量。这里只是测试。
            lstRes.Add(new Product() { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M });
            lstRes.Add(new Product() { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M });

            var oData = new { total = lstRes.Count, rows = lstRes.Skip(offset).Take(limit).ToList() };
            return new PageResult(oData, Request);
        }


       
    }
}
