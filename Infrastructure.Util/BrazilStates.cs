using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Util
{
    public static class BrazilStates
    {
        private static readonly string[] _states =  {"AC","AL","AP","AM","BA","CE","ES","GO","MA","MT","MS","MG","PA","PB","PR","PE","PI","RJ","RN","RS","RO","RR","SC","SP","SE","TO","DF"};

        public static bool IsInState(string state) 
        {
            return _states.Contains(state);
        }
    }
}
