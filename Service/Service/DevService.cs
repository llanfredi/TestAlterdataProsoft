using Domain.Entities;
using Infrastructure.DB;
using Service.Interface;

namespace Service.Service
{
    public class DevService : BaseService<DevEntity>, IDevService
    {
        public DevService(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
