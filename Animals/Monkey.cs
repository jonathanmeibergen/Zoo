using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals
{
    sealed public class Monkey : Animal
    {
        public Monkey(string name) : base(name)
        {
            Energy = 60;
            _eat = 10;
            _consume = 2;
        }
    }
}
