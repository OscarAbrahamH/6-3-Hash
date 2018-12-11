using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Búsqueda_Hash
{
    class Hash
    {
        public String[] Arreglo; //Declaracion del arreglo
        int Tamaño; //Tamaño

        public void MetodoHash(int Tamaño)
        {
            this.Tamaño = Tamaño;
            Arreglo = new String[Tamaño]; //Se arreglo en tamaño
            for (int i = 0; i < Arreglo.Length; i++)
            {
                Arreglo[i] = "-1";
            }
        }

        public void ProcesoHash(String[] CadenaArray, String[] Arreglo) //Se aplica la funcion hash
        {
            for (int i = 0; i < CadenaArray.Length; i++)
            {
                String Elemento = CadenaArray[i];
                int IndiceArray = int.Parse(Elemento) % 7; //Se identifica el numero
                Console.WriteLine("La posicion es " + IndiceArray + " del elemento " + Elemento); //Se despliega posicion
                while (Arreglo[IndiceArray] != "-1")
                {
                    IndiceArray++;
                    Console.WriteLine("Ocurrio un error"); //Si ahi un error
                    IndiceArray %= Tamaño;
                }
                Arreglo[IndiceArray] = Elemento;
            }
        }

        public String BuscarNumero(string Elemento) //proceso por el cual se buscara el numero 
        {
            int IndiceArray = int.Parse(Elemento) % 7;
            int Contador = 0;
            while (Arreglo[IndiceArray] != "-1") 
            {
                if (Arreglo[IndiceArray] == Elemento) //Siclo para comparar el numero
                {
                    Console.WriteLine(" ");
                    return Arreglo[IndiceArray];
                }
                IndiceArray++;
                IndiceArray %= Tamaño;
                Contador++;
                if (Contador > 7)
                {
                    break;
                }
            }
            return null;
        }

    }
}
