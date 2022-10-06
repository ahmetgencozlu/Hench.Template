using Hench.Template.Domain.Models;
using NetDevPack.Data;

namespace Hench.Template.Domain.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetById(Guid id);
        Task<User> GetByEmail(string email);
        Task<IEnumerable<User>> GetAll();

        void Add(User customer);
        void Update(User customer);
        void Remove(User customer);
    }
}
