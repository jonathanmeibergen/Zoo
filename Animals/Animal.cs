using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals
{
    public abstract class Animal
    {
        protected string _name;
        protected int _energy = 100;
        protected int _eat = 25;
        protected int _consume = 2;
        protected bool _alive = true;
        public string Name { get => _name; }
        public virtual int Energy { get => _energy; set => _energy = value; }

        public bool Alive { get; private set; }
        public virtual string AnimalType => this.GetType().Name;

        public Animal(string name)
        {
            _name = name;
        }
        public virtual void Eat() {
            Energy += _eat;
        }
        public virtual void UseEnergy()
        {
            Energy -= _consume;
            if (Energy <= 0)
                this.Die();
        }

        public void Die()
        {
            Alive = false;
        }

    }
}
