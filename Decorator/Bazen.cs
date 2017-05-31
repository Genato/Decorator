using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Bazen : DekoratorKuće
    {
        public Bazen(StambeniObjekt stambeniObjekt) : base(stambeniObjekt)
        {
        }

        public override string GetTipObjekta()
        {
            return stambeniObjekt.GetTipObjekta() + " + bazen";
        }

    }
}
