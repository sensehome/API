using SenseHome.DataTransferObjects.User;
using System.Threading.Tasks;

namespace SenseHome.Services.Authentication
{
    public interface IAuthenticationService
    {
        Task<UserDto> Authenticate(string username, string password);

    }
}
