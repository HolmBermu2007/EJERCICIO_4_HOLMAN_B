using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_4_HOLMAN_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            auto ve = new auto(1, "chevrolet", "aveo", 5000, 15000, 2017,'s');
            Console.WriteLine("El precio aumetado por el airbag es :{0}", ve.precioestandar());
            moto mo = new moto(1, "toyota", "pulsar", 150, 1500, 2015, 's');
            Console.WriteLine("El precio aumentado por el Sidecar: {0}", mo.precioestandar());
            Console.ReadKey();
        }
    }
}
