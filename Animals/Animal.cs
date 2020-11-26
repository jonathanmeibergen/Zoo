using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals
{
    public abstract class Animal
    {
        protected int _energy = 100;
        protected string _name;
        public abstract string Name { get; }
        public abstract int Energy { get; set; }

        public Animal(string name)
        {
            _name = name; 
        }
        public virtual void Eat() {
            Energy += 25;
        }
    }
}
