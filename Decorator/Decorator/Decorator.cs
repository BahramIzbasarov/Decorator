using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class Decorator : Component
    {
        public override Component Operation(Component comp)
        {
            Attack += comp.Operation(c);
            return comp;
        }
    }
}
