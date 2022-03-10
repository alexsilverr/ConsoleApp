using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero = 0;
            List<int> Numeros = new List<int> { };

     
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine(" El tiempo de Elaboración De cada unidad ");
            Console.WriteLine("-----------------------------------------------");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------");


            if (numero <= 2) Numeros.Add(99);
         

            else Numeros.Add(33);
         
            numero = 0;
            Console.Clear();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Cantidad De Kilogramos De Azucar Que se Necesita Pedir Por Mes  ");
            Console.WriteLine("----------------------------------------------------------------");
            numero = int.Parse(Console.ReadLine());
            if (numero <= 50) Numeros.Add(99);
          
            else Numeros.Add(33);
         
            numero = 0;
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("||Microcentro||Caballito||Flores||Avellaneda||Villa Crespo||Devoto|| ");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Que Zona  Deseas??  ");
            Console.WriteLine("---------------------------------------------------------------------");
            string zona = Console.ReadLine();

            if (zona == "avellaneda" || zona == "flores" || zona == "villa Crespo") Numeros.Add(99);
           
            else Numeros.Add(33);

            int Sum_total = Numeros[0] + Numeros[1] + Numeros[2];
            int total = Sum_total / 3;
            if (total == 77) total = 66;
            if (total == 55) total = 33;
            Console.Clear();
          
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("la  primera seleccion tiene la viabilidad de :"+Numeros[0]+"%");
            Console.WriteLine("la  segunda seleccion tiene la viabilidad de :" + Numeros[1]+"%");
            Console.WriteLine("la  tercera  seleccion tiene la viabilidad de :" + Numeros[2]+"%");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("el resultado de su eleccion es " + total + "% de viable");
            Console.WriteLine("-----------------------------------------------");
       }
    }
}