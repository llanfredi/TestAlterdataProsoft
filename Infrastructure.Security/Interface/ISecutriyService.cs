using Domain.Entities;

namespace Infrastructure.Security.Interface
{
    public interface ISecurityService
    {
        string GenereateToken(AuthEntity authEntity);
    }
}
