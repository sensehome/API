using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using SenseHome.Common.Exceptions;
using SenseHome.DataTransferObjects.User;
using SenseHome.Repositories.User;
using SenseHome.Services.UserExtension;

namespace SenseHome.Services.User
{
    public class UserService : BaseService, IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IUserExtensionService userExtensionService;

        public UserService(
            IUserRepository userRepository,
            IUserExtensionService userExtensionService,
            IMapper mapper) : base(mapper)
        {
            this.userRepository = userRepository;
            this.userExtensionService = userExtensionService;
        }

        public async Task<bool> AddLog(string id)
        {
            return await userRepository.AddLog(id, DateTime.Now);
        }

        public async Task<UserDto> CreateUserAsync(UserInsertDto userDto)
        {
            var existingUser = await userRepository.GetByNameOrDefaultAsync(userDto.Name);
            if(existingUser != null)
            {
                throw new BadRequestException("a user already exist with this name");
            }
            var userToCreate = mapper.Map<DomainModels.User>(userDto);
            userToCreate.Password = userExtensionService.GetUserHashedPassword(userDto.Password);
            var createdUser = await userRepository.CreateAsync(userToCreate);
            return mapper.Map<UserDto>(createdUser);
        }

        public async Task<bool> DeleteAsync(string id)
        {
            return await userRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<UserDto>> GetAllAsync()
        {
            var users = await userRepository.GetAllAsync();
            return mapper.Map<IEnumerable<UserDto>>(users);
        }

        public Task<UserDto> GetUserByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<UserDto> UpdateAsync(UserUpdateDto user)
        {
            var userToUpdate = mapper.Map<DomainModels.User>(user);
            var updatedUser = await userRepository.UpdateAsync(userToUpdate);
            return mapper.Map<UserDto>(updatedUser);
        }


    }
}