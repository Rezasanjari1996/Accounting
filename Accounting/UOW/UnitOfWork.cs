using Accounting.DAL;
using Accounting.Repository;
using Accounting.Repository.IRepository;

namespace Accounting.UOW
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            UserRepository = new UserRepository(_context);
        }
        public IUserRepository UserRepository { get; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public AppDbContext GetDbContext()
        {
            return _context;
        }
    }
}
