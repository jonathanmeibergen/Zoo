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
        public abstract string Name { get; }
        public abstract int Energy { get; set; }
        public Animal(string name)
        {
            _name = name; 
        }
        public virtual string AnimalType()
        {
            return this.GetType().ToString();
        }
        public virtual void Eat() {
            Energy += _eat;
        }
    }
}
