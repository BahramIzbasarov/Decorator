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
            Attack = 20 + human.Attack;
            Speed = 10 + human.Speed;
            Hp = 50 + human.Hp;
            Defence = 20 + human.Defence;
        }



    }
}
