using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID___Help_Lone
{
    abstract class Character
    {
        public virtual void Die()
        {
            Console.WriteLine("I'm dying");
        }

        public virtual void Fight()
        {
            Console.WriteLine("I'm fighting");
        }

        public virtual void Heal()
        {
            Console.WriteLine("I'm healing");
        }
    }
}
