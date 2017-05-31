using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class DekoratorKuće : StambeniObjekt
    {
        protected StambeniObjekt stambeniObjekt;

        public DekoratorKuće(StambeniObjekt stambeniObjekt)
        {
            this.stambeniObjekt = stambeniObjekt;
        }

        public override string GetTipObjekta()
        {
            return stambeniObjekt.GetTipObjekta();
        }

    }
}
