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
        public string Name { get => _name; }
        public virtual int Energy { get => _energy; set => _energy = value; }
        public virtual string AnimalType => this.GetType().Name;
        public virtual string AnimalTypePlural { get; }
        public Animal(string name)
        {
            _name = name; 
        }
        public virtual void Eat() {
            Energy += _eat;
        }
    }
}
