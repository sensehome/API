﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SenseHome.DataTransferObjects.User;
using SenseHome.Repositories.User;

namespace SenseHome.Services.User
{
    public class UserService : BaseService, IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IMapper mapper, IUserRepository userRepository) : base(mapper)
        {
            this.userRepository = userRepository;
        }

        public async Task<bool> AddLog(string id)
        {
            // TODO: last connected
            return await userRepository.AddLog(id, DateTime.Now);
        }

        public async Task<UserDto> CreateUserAsync(UserUpsertDto userDto)
        {
            var userToCreate = mapper.Map<DomainModels.User>(userDto);
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

        public IEnumerable<UserDto> GetConnectedUsers()
        {
            var queryable = userRepository.GetAsQueryable();
            var users = queryable.Where(u => u.IsConnected);
            return mapper.Map<IEnumerable<UserDto>>(users);
        }

        public Task<UserDto> GetUserAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<UserDto> UpdateAsync(UserUpsertDto user)
        {
            var userToUpdate = mapper.Map<DomainModels.User>(user);
            var updatedUser = await userRepository.UpdateAsync(userToUpdate);
            return mapper.Map<UserDto>(updatedUser);
        }
    }
}
