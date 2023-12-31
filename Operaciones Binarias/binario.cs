﻿using System;
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

        public int nbinario { get; set; }

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
            bool validacion;

            do
            {
                 validacion= false;

                try
                {
                    Console.Write("El numero  que desea convertir a binario: ");
                    this.numero = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                }catch(Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine("'Error':Solo se permiten numeros positivos");
                    Console.ReadKey();
                    Console.Clear();
                    validacion= true;
                }



            } while (validacion== true);

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

            
            this.nbinario = Convert.ToInt32(string.Join("",listas)); 
            this.tamano = listas.Count;
            this.lista = listas;

            Console.WriteLine("La conversion binario de " + numero+" es "+nbinario);
            Console.WriteLine();
            
        }

        public List<int> suma(List<int> lista1, List<int> lista2,int final)
        {  
            
            List<int> resultado = new List<int>();           
            int prueba=0;
            int residuo = 0;
            
           ( lista1,lista2 )= completar(lista1, lista2);

            for (int i = lista1.Count- 1; i >= 0; i--)
            {
                
                prueba = 0;

                prueba = lista1[i] + lista2[i] + residuo;

                

                if (prueba == 2 & i == 0 & (final==0 || final==1))
                {

                    resultado.Insert(0,0);
                    resultado.Insert(0,1);
                    
                }
                else if (prueba == 3 & i ==0  & (final==0 || final == 1))
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

            if (final == 0) {

                Console.WriteLine("la suma binaria de " + String.Join("", lista1) + " mas " + String.Join("", lista2) + " es " + num);

            }


            return resultado;

        }

        public void resta(List<int> lista2,int num2)
        {
            List<int> lista1 = new List<int>();
            List<int> negar = new List<int>();
            List<int> multi = new List<int>() { 1} ;
            List<int> cambio = new List<int>();

            lista1 = lista;

            if (num2>numero) { cambio = lista2; lista2 = lista1 ; lista1 = cambio; }

            (lista1, lista2) = completar(lista1, lista2);

            for (int i =lista2.Count-1;i>=0; i--)
            {

                if (lista2[i] == 0)
                {
                    negar.Insert(0,1);
                }
                else
                {
                    negar.Insert(0,0);

                }


            }
            
             multi = suma(negar,multi, 1);
           
             multi = suma(lista1, multi, 2);

             int num =Convert.ToInt32(string.Join("", multi));

            Console.WriteLine("la resta binaria de " + String.Join("", lista1) + " menos " + String.Join("", lista2) + " es " + num);



        }

        public static(List<int>,List<int>) completar(List<int>lista1,List<int> lista2)
        {
            if (lista1.Count > lista2.Count)
            {

                for (int i = lista2.Count; i < lista1.Count; i++)
                {
                    lista2.Insert(0, 0);
                }
            }

            if (lista2.Count > lista1.Count)
            {

                for (int i = lista1.Count; i < lista2.Count; i++)
                {

                    lista1.Insert(0, 0);
                }
            }
            return (lista1,lista2);
        }



    }
}
