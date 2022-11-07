using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController: ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly StoreContext _dbContext;

        public ProductsController(ILogger<ProductsController> logger, StoreContext dbContext )
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Product>>> GetProducts(){
            IList<Product> products = await _dbContext.Products.ToListAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id){
            return await _dbContext.Products.FindAsync(id);
        }

        [HttpGet("{skip}/{take}")]
        public async Task<ActionResult<IList<Product>>> GetProductsPaging(int skip, int take) {
            IList<Product> products = await _dbContext.Products.Skip(skip).Take(take).ToListAsync();
            return Ok(products);
        }

        


    }
}