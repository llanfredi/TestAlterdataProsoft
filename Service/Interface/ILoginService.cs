using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface ILoginService : IBaseService<AuthEntity>
    {
        string Autenticate(string username, string password);
    }
}
