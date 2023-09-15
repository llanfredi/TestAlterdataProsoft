using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configuration.Configuration
{
    public class ApplicationConfiguration
    {
        public static ApplicationConfiguration Current { get;private set; }

        public string Solution { get; set; } = null;
        public string Name { get; set; } = null;
        public string Version { get; set; } = null;

        public ApplicationConfiguration() 
        {
            Current = this;
        }
    }
}
