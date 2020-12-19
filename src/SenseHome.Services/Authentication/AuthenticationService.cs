using AutoMapper;
using SenseHome.Common.Exceptions;
using SenseHome.DataTransferObjects.Authentication;
using SenseHome.Repositories.User;
using SenseHome.Services.UserExtension;
using System.Threading.Tasks;

namespace SenseHome.Services.Authentication
{
    public class AuthenticationService : BaseService, IAuthenticationService
    {
        private readonly IUserRepository userRepository;
        private readonly IUserExtensionService userExtensionService;

        public AuthenticationService(
            IUserRepository userRepository,
            IUserExtensionService userExtensionService,
            IMapper mapper) : base(mapper)
        {
            this.userRepository = userRepository;
            this.userExtensionService = userExtensionService;
        }

        public async Task<TokenDto> LoginAsync(UserLoginDto credential)
        {
            var user = await userRepository.GetByNameAsync(credential.Name);
            if (user == null)
            {
                throw new UnauthorizedException("No user found with this name");
            }
            if (!userExtensionService.CheckIfUserPasswordIsCorrect(credential.Password, user.Password))
            {
                throw new UnauthorizedException("Incorrect password");
            }
            return userExtensionService.GenerateUserAccessToken(user);
        }
    }
}
