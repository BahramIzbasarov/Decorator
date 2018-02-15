using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Human : Component
    {
        public Human()
        {
            Attack = 20;
            Speed = 20;
            Hp = 150;
            Defence = 0;
            
        }

        

        public override void Operation(Component comp)
        {
            
        }
    }
}
