using OnionService.Data;
namespace OnionService.Service
{
    public interface IUserProfileService
    {
          UserProfile GetUserProfile(long id);
    }
}