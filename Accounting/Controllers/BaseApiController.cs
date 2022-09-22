using Accounting.UOW;
using Microsoft.AspNetCore.Mvc;

namespace Accounting.Controllers
{
    public class BaseApiController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        protected BaseApiController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        protected IUnitOfWork UnitOfWork => _unitOfWork;
    }
}
