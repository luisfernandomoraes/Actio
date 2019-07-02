namespace Actio.Services.Activities.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Actio.Services.Activities.Domain.Models;
    using Actio.Services.Activities.Domain.Repositories;
    using MongoDB.Driver;
    using MongoDB.Driver.Linq;

    public class ActivityRepository : IActivityRepository
    {
        private readonly IMongoDatabase _database;
        private IMongoCollection<Activity> Collection => _database.GetCollection<Activity>("Activities");
        public ActivityRepository(IMongoDatabase database)
        {
            _database = database;

        }
        public async Task AddAsync(Activity activity) => await Collection.InsertOneAsync(activity);

        public async Task<IEnumerable<Activity>> BrowserAsyn() => await Collection.AsQueryable().ToListAsync();

        public async Task<Activity> GetAsync(Guid id) => await Collection.AsQueryable().FirstOrDefaultAsync(x => x.Id == id);
    }
}