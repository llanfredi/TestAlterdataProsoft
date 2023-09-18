
using Domain.Entities;
using Infrastructure.DB;
using Infrastructure.Security;
using Infrastructure.Security.Interface;
using Microsoft.Extensions.Configuration;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class LoginService : BaseService<AuthEntity>, ILoginService
    {
        private readonly ISecurityService _security;
        private readonly IConfiguration _configuration;

        public LoginService(ApplicationDbContext applicationDbContext, ISecurityService security, IConfiguration configuration) 
            : base(applicationDbContext)
        {
            _security = security;
            _configuration = configuration;
        }

        public string Autenticate(string username, string password)
        {
            var newPassword = Crypt.EncryptString(_configuration.GetSection("Security").GetSection("Secret").Value, password);

            var auth = base.GetByFilter(x => x.Login == username && x.Senha == newPassword);

            if (!auth.Any())
                return "Usuário e/ou senha inválidos";

            var token = _security.GenereateToken(auth.First());

            return token;
        }
    }
}
