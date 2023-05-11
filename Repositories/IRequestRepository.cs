using System.Threading.Tasks;
using Unit32_MVC.Models.Db;

namespace Unit32_MVC.Repositories
{
    public interface IRequestRepository
    {
        Task AddRequest(Request request);

        Task<Request[]> GetRequests();
    }
}
