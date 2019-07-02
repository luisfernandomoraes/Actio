namespace Actio.Services.Activities.Domain.Repositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Actio.Services.Activities.Domain.Models;

    public interface ICategoryRepository
    {
        Task<Category> GetAsync(string name);
        Task<IEnumerable<Category>> BrowserAsync();
        Task AddAsync(Category category);
    }
}