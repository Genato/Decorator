using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ObičnaKuća : StambeniObjekt
    {
        public override string GetTipObjekta()
        {
            return "obična kuća";
        }
    }
}
