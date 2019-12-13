using OnionService.Data;
using System.Collections.Generic;
 
namespace OnionService.Service
{
    public  interface IUserService
    {
        IEnumerable<User> GetUsers();
        User GetUser(long id);
        void InsertUser(User user);
        void UpdateUser(User user);
        void DeleteUser(long id);
    }
}