using System;
using System.Collections.Generic;
using Catalog.Models;

namespace Catalog.Repositories
{
    public class MongoDbItemsRepository : IItemsRepository
    {
        public MongoDbItemsRepository()
        {
            
        }

        public void CreateItem(Item item) { }

        public void DeleteItem(Guid id) { }

        public Item GetItem(Guid id) { }

        public IEnumerable<Item> GetItems() { }

        public void UpdateItem(Item item) { }
    }
}
