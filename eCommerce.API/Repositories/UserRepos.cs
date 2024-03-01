using eCommerce.API.Database;
using eCommerce.Models;

namespace eCommerce.API.Repositories
{
    public class UserRepos : IUserRepos
    {
        private readonly eCommerceContext _db;
        public UserRepos(eCommerceContext db) 
        {
            _db = db;
        }

        public List<User> Get()
        {
            return _db.Users.OrderBy(x => x.Id).ToList();
        }
        public User Get(int id)
        {
            return _db.Users.Find(id)!;
        }
        public void Add(User user)
        {
            //unit of works
            _db.Users.Add(user);
            _db.SaveChanges();
        }
        public void Delete(int id)
        {
            _db.Users.Remove(Get(id));
            _db.SaveChanges();
        }
        public void Update(User user)
        {
            _db.Users.Update(user);
            _db.SaveChanges();
        }
    }
}
