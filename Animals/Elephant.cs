using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals
{
    public class Elephant : Animal
    {
        public Elephant(string name) : base(name)
        {
            _eat = 50;
        }
    }
}
