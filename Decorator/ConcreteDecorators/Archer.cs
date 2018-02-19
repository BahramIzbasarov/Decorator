using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Archer : Decorator
    {
        public Archer(HumanWarrior humanWarrior)
        {
            Attack = 20 + humanWarrior.Attack;
            Defence = 10 + humanWarrior.Defence;
            Speed = humanWarrior.Speed + 20;
            Hp = 50 + humanWarrior.Hp;
        }
    }
}
