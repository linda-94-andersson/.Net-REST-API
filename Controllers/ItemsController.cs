using System.Collections.Generic;
using Catalog.Models;
using Catalog.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers
{   
    [ApiController]
    [Route("[controller]")] // [Route("items")]
    public class ItemsController : ControllerBase
    {
        private readonly InMemItemsRepository repository; 

        public ItemsController()
        {
            repository = new InMemItemsRepository(); 
        }

        // GET /items
        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
            var items = repository.GetItems(); 
            return items; 
        }

        // GET /items/{id}
        [HttpGet("{id}")]
        public Item GetItem(Guid id)
        {
            var item = repository.GetItem(id); 
            return item; 
        }
    }
}