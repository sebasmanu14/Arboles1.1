using System.Collections.Generic;
using System;

namespace trabajo_numero1.consola
{
    partial class Program
    {
        public static void Main(string[] args)
        {
            Pais pais1 = new Pais
            {
                PaisId = 1,
                Nombre = "Ecuador",
            };

            pais1.Provincias = new List<Provincia>();

            var provincia1 = new Provincia();
            provincia1.Nombre = "Galapagos";

            var provincia2 = new Provincia();
            provincia2.Nombre = "Cuenca";

            var provincia3 = new Provincia();
            provincia3.Nombre = "Napo";

            var provincia4 = new Provincia();
            provincia4.Nombre = "pichincha";

            pais1.Provincias = new List<Provincia>(){
                    provincia1,
                    provincia2,
                    provincia3,
                    provincia4
                };

            var canton1 = new Canton();
            canton1.Nombre = "Isabela";

            var canton2 = new Canton();
            canton2.Nombre = "Giron";

            var canton3 = new Canton();
            canton2.Nombre = "Quijos";

            var canton4 = new Canton();
            canton2.Nombre = "Quito";

            provincia1.Cantones = new List<Canton>();

            provincia1.Cantones.Add(canton1);

            provincia2.Cantones = new List<Canton>();

            provincia2.Cantones.Add(canton2);

            provincia3.Cantones = new List<Canton>();

            provincia3.Cantones.Add(canton3);

            provincia4.Cantones = new List<Canton>();

            provincia4.Cantones.Add(canton4);


            var parroquia1 = new Parroquia();

            parroquia1.Nombre = "Puerto Villamil";

            var parroquia2 = new Parroquia();

            parroquia2.Nombre = "san salvador";

            parroquia1.Habitantes = 3000;

            parroquia2.Habitantes = 2000;

            canton1.Parroquias = new List<Parroquia>();

            canton1.Parroquias.Add(parroquia1);

            canton2.Parroquias = new List<Parroquia>();

            canton2.Parroquias.Add(parroquia2);

            Console.WriteLine($" el resultado de los habitantes totales de las 2 parroquias es:{pais1.ObtenerNumeroDeHabitantes()}");

        }
    }


}
