using System;
using System.Collections.Generic;
using Catalog.Models;
using MongoDB.Driver;

namespace Catalog.Repositories
{
    public class MongoDbItemsRepository : IItemsRepository
    {
        private const string databaseName = "catalog";
        private const string collectioNname = "items";
        private readonly IMongoCollection<Item> itemsCollection;

        public MongoDbItemsRepository(IMongoClient mongoClient)
        {
            IMongoDatabse database = mongoClient.GetDatabase(databaseName);
            itemsCollection = database.GetCollection<Item>(collectionName);
        }

        public void CreateItem(Item item) { }

        public void DeleteItem(Guid id) { }

        public Item GetItem(Guid id) { }

        public IEnumerable<Item> GetItems() { }

        public void UpdateItem(Item item) { }
    }
}
