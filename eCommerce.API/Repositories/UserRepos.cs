using eCommerce.Models;

namespace eCommerce.API.Repositories
{
    public class UserRepos : IUserRepos
    {
        public static List<User> _db = new List<User>();

        public List<User> Get()
        {
            return _db;
        }
        public User Get(int id)
        {
            return _db.Find(x => x.Id == id)!;
        }
        public void Add(User user)
        {
            _db.Add(user);
        }
        public void Delete(int id)
        {
            _db.Remove(Get(id));
        }
        public void Update(User user)
        {
            _db.Remove(Get(user.Id));
            _db.Add(user);
        }
    }
}
