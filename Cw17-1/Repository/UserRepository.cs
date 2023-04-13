using Cw17_1.DAl;
using Cw17_1.Models;

namespace Cw17_1.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _appDbContext;
        public UserRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public List<User> GetUsers()
        {
            return _appDbContext.Users.ToList();
        }
        public void Create(User user)
        {
            _appDbContext.Users.Add(user);
            _appDbContext.SaveChanges();
        }
        public User GetUser(int id)
        {
            var user = _appDbContext.Users.FirstOrDefault(u => u.Id == id);
            return user;
        }
        public void Delete(int id)
        {
            var user = _appDbContext.Users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                _appDbContext.Users.Remove(user);
                _appDbContext.SaveChanges();
            }
        }
    }
}
