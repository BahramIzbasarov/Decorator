using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Rider : Decorator
    {
        public Rider(Swordbeard swordbeard)
        {
            Attack = swordbeard.Attack - 10;
            Speed = 40 + swordbeard.Speed;
            Hp = 200 + swordbeard.Hp;
            Defence = 100 + swordbeard.Defence;
        }
    }
}
