using SenseHome.DataTransferObjects.User;

namespace SenseHome.Services.Mapper
{
    public class MapperProfile : AutoMapper.Profile
    {
        public MapperProfile()
        {
            CreateUserMaps();
        }

        private void CreateUserMaps()
        {
            CreateMap<DomainModels.User, UserDto>();
            CreateMap<UserUpsertDto, DomainModels.User>();
        }
    }
}
