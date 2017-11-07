using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Edad
    {
        public void Edd()
        {
            Console.WriteLine("cual es tu edad");
            int e = int.Parse(Console.ReadLine());
            if (e >= 18)
                Console.WriteLine("eres mayor de edad");
            else
                Console.WriteLine("a un eres legal");
        }
    }
}
