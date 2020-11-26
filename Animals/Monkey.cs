using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals
{
    public class Monkey : Animal
    {
        public override string Name => _name;
        public override int Energy { get => _energy;
                                     set => _energy = value; }

        public Monkey(string name) : base(name)
        {}
    }
}
