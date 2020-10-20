using SenseHome.DataTransferObjects.User;

namespace SenseHome.Services.Mapper
{
    public class MapperProfile : AutoMapper.Profile
    {
        public MapperProfile()
        {
            CreateUserMaps();
            CreateProfileMaps();
            CreateSubscriptionMaps();
        }

        private void CreateUserMaps()
        {
            CreateMap<DomainModels.User, UserDto>();
            CreateMap<UserInsertDto, DomainModels.User>();
            CreateMap<UserUpdateDto, DomainModels.User>();
        }

        private void CreateProfileMaps()
        {

        }

        private void CreateSubscriptionMaps()
        {

        }
    }
}
