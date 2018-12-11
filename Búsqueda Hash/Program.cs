using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Búsqueda_Hash
{
    class Program
    {
        static void Main(string[] args)
        {
            Hash figura1 = new Hash();
            string[] Elementos = { "1", "5", "10", "15", "20", "25", "30", "35" };
            figura1.ProcesoHash(Elementos, figura1.Arreglo);
            String Buscar = figura1.BuscarNumero("1");
            if (Buscar == null)
            {
                Console.WriteLine("El elemento " + Buscar + " No se encuentra en la tabla");
            }
            Console.ReadKey();
        }
    }
}
