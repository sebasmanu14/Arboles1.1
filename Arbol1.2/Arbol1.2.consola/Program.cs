using System;

namespace Arbol1._2.consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Nodo Raiz = new Nodo
            {
                Valor = "*",
                Hijos =
                {
                    new Nodo
                    {
                       Valor = "+",
                       Hijos =
                       {
                            new Nodo
                            {
                               Valor = "8"
                            },
                            new Nodo
                            {
                               Valor = "5"
                            }
                       }
                    },
                    new Nodo
                    {
                       Valor = "-",
                       Hijos =
                       {
                            new Nodo
                            {
                               Valor = "7"
                            },
                            new Nodo
                            {
                               Valor = "4"
                            }
                       }
                    }
                }
            };

            // resultado esperado
            // => (8 + 5) * (7 - 4) = 39
            // => * (+ 8 5) (- 7 4) = 39
            // => (8 5 +)  (7 4 - ) * = 39

            ManejadorArbol manejadorArbol = new ManejadorArbol();
            Console.WriteLine(manejadorArbol.ImprimirArbolInfijo(Raiz));
            Console.WriteLine(manejadorArbol.ImprimirArbolPrefijo(Raiz));
            Console.WriteLine(manejadorArbol.ImprimirArbolPosfijo(Raiz));
            
            Console.WriteLine(manejadorArbol.ImprimirArbol(Raiz, Notacion.Posfijo));
        }
    }

}