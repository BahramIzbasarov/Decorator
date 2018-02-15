using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h = new Human();
            HumanWarrior hw = new HumanWarrior(h);
            Swordbeard sb = new Swordbeard(hw);
            HumanWarrior hw2 = new HumanWarrior(h);
            Swordbeard sb2 = new Swordbeard(hw2);

            h.Operation();
        }
    }
}
