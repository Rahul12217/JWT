using IdentityDemo.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace IdentityDemo.Repositories
{
    public interface IAccountRepository
    {
        Task<IdentityResult> SignUpAsync(SignUpModel signUpModel);
        Task<string> LoginAsync(Login login);
    }
}