using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkLegion.API.Flooder
{
    public struct FlooderTargets
    {
        public string target;

        public string abouts;

        public string aboutsType;
        public FlooderTargets(string target, string abouts, string aboutsType)
        {
            this.target = target;
            this.abouts = abouts;
            this.aboutsType = aboutsType;
        }
    }
}
