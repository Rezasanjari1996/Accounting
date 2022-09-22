using Accounting.DAL;
using Accounting.Models;
using Accounting.Repository.IRepository;

namespace Accounting.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public AppDbContext AppDbContext => ContextDB as AppDbContext;

    }
}
