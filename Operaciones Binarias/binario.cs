using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Operaciones_Binarias
{
    internal class binario
    {
        public int numero { get; set; }

        public int tamano { get; set; }

        public string nbinario { get; set; }

        public List<int> lista { get; set; }


        public binario()
        {
            this.numero = numero;

            this.tamano = tamano;

            this.nbinario = nbinario;

            this.lista = lista;

        }

        public void cargar()
        {
            Console.WriteLine("numero de que desea convertir a binario");

            numero = int.Parse(Console.ReadLine());

            conversion();
        }



        public void conversion()
        {
            int n = numero;
          
            int a = 0;
            List<int> listas = new List<int>();


            do
            {

                a = n % 2;

                listas.Insert(0, a);

                n = n / 2;


               


            } while (n != 0);

            
            this.nbinario =string.Join("",listas) ;
            this.tamano = listas.Count;
            this.lista = listas;

        }

        public List<int> suma(List<int> lista1, List<int> lista2,int final)
        {
            List<int> resultado = new List<int>();
            int longitud = 0;
           
            int prueba=0;
            int residuo = 0;

            if (lista1.Count > lista2.Count)
            {
                longitud = lista1.Count;
                for (int i = lista2.Count; i < lista1.Count; i++)
                {
                    lista2.Insert(0, 0);
                }
            }

            if (lista2.Count > lista1.Count)
            {
                longitud = lista2.Count;
                for (int i = lista1.Count; i < lista2.Count; i++)
                {

                    lista1.Insert(0, 0);
                }
            }

            
            for (int i = lista1.Count- 1; i >= 0; i--)
            {
                
                prueba = 0;

                prueba = lista1[i] + lista2[i] + residuo;

                

                if (prueba == 2 & i == 0 & final==0 )
                {

                    resultado.Insert(0,0);
                    resultado.Insert(0,1);
                    
                }
                else if (prueba == 3 & i ==0  & final==0)
                {

                    resultado.Insert(0,1);
                    resultado.Insert(0,1);
                    

                }
                else if (prueba == 0)
                {
                    residuo = 0;

                    resultado.Insert(0,0);
                }
                else if (prueba == 1)
                {
                    residuo = 0;

                    resultado.Insert(0,1);

                }
                else if (prueba == 2)
                {

                    residuo = 1;
                    resultado.Insert(0,0);

                }
                else if (prueba == 3)
                {
                    residuo = 1;
                    resultado.Insert(0,1);

                }



            }

            int num = Convert.ToInt32(string.Join("", resultado));

            return resultado;

        }


        public List<int> resta(List<int>lista3)
        {
            List<int> final = new List<int>();
            List<int> negar = new List<int>();
            int residuo = 0;
            List<int> sumar = new List<int>() ;
            List<int> resultado = new List<int>();

            sumar.Add(1);

            for (int i =lista3.Count-1;i>=0; i--)
            {

                if (lista3[i] == 0)
                {
                    negar.Insert(0,1);
                }
                else
                {
                    negar.Insert(0,0);

                }


            }
            
             resultado = suma(negar,sumar, 0);
           
             final = suma(lista, resultado, 1);

            int num =Convert.ToInt32(string.Join("", final));

            Console.WriteLine(num);
            return final;







        }
    }
}
