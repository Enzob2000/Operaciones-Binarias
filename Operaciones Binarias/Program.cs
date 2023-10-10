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

            a.cargar();
            b.cargar();
            a.resta(b.lista,a.lista,b.numero,a.numero);
            







        }
    }
}
