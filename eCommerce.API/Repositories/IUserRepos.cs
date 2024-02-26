using eCommerce.Models;

namespace eCommerce.API.Repositories
{
    public interface IUserRepos
    {
        List<User> Get();
        User Get(int id);
        void Add(User user);
        void Update(User user);
        void Delete(int id);
    }
}
