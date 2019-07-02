namespace Actio.Services.Activities.Domain.Repositories
{
    using System;
    using System.Threading.Tasks;
    using Activities.Domain.Models;
    public interface IActivityRepository
    {
         Task<Activity> GetAsync(Guid id);
         Task AddAsync(Activity activity);
    }
}