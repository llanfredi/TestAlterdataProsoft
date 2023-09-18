using Domain.Entities;
using Infrastructure.DB;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class TipoDevService : BaseService<TipoDevEntity>, ITipoDevService
    {
        public TipoDevService(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
