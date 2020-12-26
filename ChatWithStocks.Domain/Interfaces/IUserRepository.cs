using ChatWithStocks.Domain.Models;
using System.Threading.Tasks;

namespace ChatWithStocks.Domain.Interfaces
{
    public interface IUserRepository
    {
        void Add(User user);
        Task<User> GetByLoginAndPassword(string login, string password);
    }
}
