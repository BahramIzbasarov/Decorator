using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Swordbeard : Decorator
    {
        public Swordbeard(HumanWarrior humanWarrior)
        {
            Attack = 40 + humanWarrior.Attack;
            Defence = 40 + humanWarrior.Defence;
            Speed = humanWarrior.Speed - 10;
            Hp = 50 + humanWarrior.Hp;
        }
    }
}
