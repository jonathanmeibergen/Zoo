using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals
{
    public class Elephant : Animal
    {
        public override string Name { get; }
        public override int Energy { get; set; }
        Elephant(string name) : base(name)
        {
            _eat = 50;
        }
    }
}
