namespace Actio.Services.Activities.Repositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Actio.Services.Activities.Domain.Models;
    using Actio.Services.Activities.Domain.Repositories;
    using MongoDB.Driver;
    using MongoDB.Driver.Linq;
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IMongoDatabase _database;
        private IMongoCollection<Category> Collection => _database.GetCollection<Category>("Categories");
        public CategoryRepository(IMongoDatabase database)
        {
            _database = database;

        }
        public async Task AddAsync(Category category) => await Collection.InsertOneAsync(category);

        public async Task<IEnumerable<Category>> BrowserAsync() => await Collection.AsQueryable().ToListAsync();

        public async Task<Category> GetAsync(string name) => await Collection.AsQueryable().FirstOrDefaultAsync(x=>x.Name == name.ToLowerInvariant());
    }
}