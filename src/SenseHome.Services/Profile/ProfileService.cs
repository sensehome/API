using System.Threading.Tasks;
using AutoMapper;
using SenseHome.DataTransferObjects.Profile;
using SenseHome.Repositories.Profile;

namespace SenseHome.Services.Profile
{
    public class ProfileService : BaseService, IProfileService
    {
        private readonly IProfileRepository profileRepository;

        public ProfileService(IMapper mapper, IProfileRepository profileRepository) : base(mapper)
        {
            this.profileRepository = profileRepository;
        }

        public async Task<ProfileDto> CreateProfileAsync(ProfileUpsertDto profile)
        {
            var profileToCreate = mapper.Map<DomainModels.Profile>(profile);
            var createdProfile = await profileRepository.CreateAsync(profileToCreate);
            return mapper.Map<ProfileDto>(createdProfile);
        }

        public async Task<ProfileDto> GetProfileByUserIdAsync(string userId)
        {
            var profile = await profileRepository.GetByUserIdAsync(userId);
            return mapper.Map<ProfileDto>(profile);
        }

        public async Task<ProfileDto> UpdateProfileAsync(ProfileUpsertDto profile)
        {
            var profileToUpdate = mapper.Map<DomainModels.Profile>(profile);
            var updatedProfile = await profileRepository.UpdateAsync(profileToUpdate);
            return mapper.Map<ProfileDto>(updatedProfile);
        }
    }
}
