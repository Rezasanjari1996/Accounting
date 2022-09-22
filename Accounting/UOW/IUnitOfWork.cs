using Accounting.DAL;
using Accounting.Repository.IRepository;

namespace Accounting.UOW
{
    public interface IUnitOfWork:IDisposable
    {
        IUserRepository UserRepository { get; }
        int Complete();

        AppDbContext GetDbContext();
    }
}
