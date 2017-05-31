using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Garaža : DekoratorKuće
    {
        public Garaža(StambeniObjekt stambeniObjekt) : base(stambeniObjekt)
        {
        }

        public override string GetTipObjekta()
        {
            return stambeniObjekt.GetTipObjekta() + " + garaža";
        }
    }
}
