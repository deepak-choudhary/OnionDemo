using OnionService.Repository;
using OnionService.Data;
namespace OnionService.Service
{
    public class UserProfileService: IUserProfileService
    {
        private IRepository<UserProfile> userProfileRepository;
 
        public UserProfileService(IRepository<UserProfile> userProfileRepository)
        {          
            this.userProfileRepository = userProfileRepository;
        }
 
        public UserProfile GetUserProfile(long id)
        {
            return userProfileRepository.Get(id);
        }
    }
}