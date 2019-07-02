namespace Actio.Services.Identity.Services
{
    using System.Threading.Tasks;
    using Actio.Common.Auth;

    public interface IUserService
    {
        Task RegisterAsync(string email, string password, string name);
        Task<JsonWebToken> LoginAsync(string email,string password);
    }
}