using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate box = new Calculate(5,5,5);

            var Surface = box.Get_size()[0];
            var Volume  = box.Get_size()[1];

            Console.WriteLine("The surface of box {0}", Surface);
            Console.WriteLine("The area of box {0}", Volume);

            Console.ReadKey();
        }
    }
}
