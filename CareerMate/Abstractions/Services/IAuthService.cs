using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Template.Abstractions.Services
{
    public interface IAuthService
    {
        Task<string> GenerateNewJsonWebToken(string id,string email, IList<string> userRoles);
    }
}
