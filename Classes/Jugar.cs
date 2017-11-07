using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
   public class Jugar
    {
        public void Juego()
        {
            Console.WriteLine("que quieres jugar futbol o videojuegos");
            string j =(Console.ReadLine());
            if (j == "futbol")
            {
                Console.WriteLine("esta bien jugaremos futbol");
              
            }
            if (j == "videojuegos")
            {
                Console.WriteLine("jugaremos videojuegos");
            }
            else
                Console.WriteLine("no podemos jugar eso Dx");

        }
    }
}
