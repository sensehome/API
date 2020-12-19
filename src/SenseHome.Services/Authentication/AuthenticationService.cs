using AutoMapper;
using SenseHome.Common.Exceptions;
using SenseHome.DataTransferObjects.User;
using SenseHome.Repositories.User;
using System.Threading.Tasks;

namespace SenseHome.Services.Authentication
{
    
        public class AuthenticationService : BaseService, IAuthenticationService
        {
            private readonly IUserRepository userRepository;

            public AuthenticationService(IMapper mapper, IUserRepository userRepository) : base(mapper)
            {
                this.userRepository = userRepository;
            }

            public async Task<UserDto> Authenticate(string username, string password)
            {
                try
                {
                var user = await userRepository.GetByNameAsync(username);
                if (user.Password != password)
                {
                    throw new UnauthorizedException("Incorrect Password");
                }
                return mapper.Map<UserDto>(user);
                }
                catch (NotFoundException notFound)
                {
                    throw new UnauthorizedException(notFound.Message);
                }
            }
        }
    }
