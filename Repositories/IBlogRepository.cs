using System.Threading.Tasks;
using Unit32_MVC.Models.Db;

namespace Unit32_MVC.Repositories
{
    public interface IBlogRepository
    {
        Task AddUser(User user);

        Task<User[]> GetUsers();
    }
}
