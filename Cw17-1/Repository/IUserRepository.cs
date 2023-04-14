using Cw17_1.Models;

namespace Cw17_1.Repository
{
    public interface IUserRepository
    {
        List<User> GetUsers();
        void Create(User user);
        User GetUser(int id);
        void Delete(int id);
        void Edit(User user);
    }
}