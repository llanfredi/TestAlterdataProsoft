using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DevEntity : EditableEntity
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public Guid IdTipoDev { get; set; }
        public virtual TipoDevEntity TipoDev { get; set; }
    }
}
