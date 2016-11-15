using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Homework.Models;

namespace Homework.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] cars = new Product[]
        {
           new Product {ID = 1, Make = "Suburu", Model = "WRX", Price = 35.000m },
           new Product {ID = 2, Make = "Audi", Model = "S7", Price = 40.000m },
           new Product {ID = 3, Make = "Aston Martin", Model = "Vanquish", Price = 50.000m },
           new Product {ID = 4, Make = "Honda", Model = "Type R", Price = 35.000m }
        };
        public IEnumerable<Product> GetAllProducts()
        {
            return cars;
        }
        public IHttpActionResult GetProducts(int id)
        {
            var car = cars.SingleOrDefault(p => p.ID == id);

            if (car == null)
                return NotFound();

            return Ok(car);
        }

        public IHttpActionResult GetProductByModel(string cay)
        {
            var car = cars.SingleOrDefault(p => p.Model.ToLower() == cay.ToLower());

            if (car == null)
                return NotFound();

            return Ok(car);
        }
    }
}
