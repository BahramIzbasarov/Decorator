using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class HumanWarrior : Decorator
    {
        public HumanWarrior(Human human)
        {
            Attack = 20;
            Speed = 10;
            Hp = 50;
            Defence = 20;
        }



    }
}
