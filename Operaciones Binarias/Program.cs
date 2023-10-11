using System;
using System.Collections.Generic;

namespace Operaciones_Binarias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            binario a = new binario();

            binario b = new binario();

            string opcion;
            bool v = true;

            do
            {
                Console.WriteLine("----- Operaciones -----");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. resta");
                Console.WriteLine("3. Conversión");
                Console.WriteLine("0. Salir");
                Console.WriteLine("-----------------------");
                Console.Write("Selecciona una opción: ");              
                opcion = Console.ReadLine();

               
               

                switch (opcion)
                {
                    case "1":

                        Console.Clear();
                        a.cargar();
                        b.cargar();
                        a.suma(a.lista, b.lista, 0);
                        Console.ReadKey();
                        break;

                    case "2":

                        Console.Clear();
                        a.cargar();
                        b.cargar();
                        a.resta(b.lista, b.numero);
                        Console.ReadKey();
                        break;

                    case "3":

                        Console.Clear();
                        a.cargar();
                        Console.ReadKey();
                        break;

                    case "0":

                        Console.WriteLine("Saliendo del programa...");
                        Console.ReadKey();
                        v = false;
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Por favor, selecciona una opción válida.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }


                


                Console.Clear();

            } while (v == true);
    }
    } 
}
