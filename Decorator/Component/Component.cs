using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class Component
    {
        private int attack;
        private int speed;
        private int hp;
        private int defence;

        public abstract Component Operation(Component comp);

        public int Attack
        {
            get => attack;
            set => attack = value;
        }

        public int Speed
        {
            get => speed;
            set => speed = value;
        }

        public int Hp
        {
            get => hp;
            set => hp = value;
        }

        public int Defence
        {
            get => defence;
            set => defence = value;
        }
    }
}
