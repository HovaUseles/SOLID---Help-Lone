using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID___Help_Lone
{
    internal interface IMagicWielder
    {
        public void ThrowFrostNova()
        {
            Console.WriteLine("I'm throwing my frost nova");
        }
        public void ThrowMagicMisile()
        {
            Console.WriteLine("I'm throwing a magic misile");
        }
    }
}
