using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Dvorište : DekoratorKuće
    {
        public Dvorište(StambeniObjekt stambeniObjekt) : base(stambeniObjekt)
        {
        }

        public override string GetTipObjekta()
        {
            return stambeniObjekt.GetTipObjekta() + " + dvorište";
        }

    }
}
