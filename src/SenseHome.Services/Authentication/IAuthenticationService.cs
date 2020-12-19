using SenseHome.DataTransferObjects.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SenseHome.Services.Authentication
{
    public interface IAuthenticationService
    {
        Task<UserDto> Authenticate(string username, string password);
    }
}
