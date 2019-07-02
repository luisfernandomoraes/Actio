namespace Actio.Api.Repositories
{
    using System.Threading.Tasks;
    using Actio.Api.Models;
    using System;
    using System.Collections.Generic;

    public interface IActivityRepository
    {
        Task<Activity> GetAsync(Guid id);
        Task AddAsync(Activity activity);
        Task<IEnumerable<Activity>> BrowseAsync(Guid userId);
    }
}