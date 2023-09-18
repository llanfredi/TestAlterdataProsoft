using Domain.Entities.Base;

namespace Domain.Entities
{
    public class AuthEntity : EditableEntity
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
