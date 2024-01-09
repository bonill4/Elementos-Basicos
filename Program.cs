using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoC_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int edad = 23;
            edad += 4;
            Console.WriteLine("Mi edad es de " + edad + " años");
            Console.WriteLine($"Tengo una edad de {++edad} años");
            */

            /*int edadPersona1;
            int edadPersona2;
            int edadPersona3;
            int edadPersona4;

            edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 27;

            Console.WriteLine(edadPersona4);
            */

            //------------------------------CONVERSIÓN EXPLICITA-----------------------------------------------------
            //casting, cambiar tipo de variable
            double temperatura = 34.5;

            int temChapel;

            temChapel = (int)temperatura;

            //---------------------------------CONVERSIÓN IMPLÍCITA----------------------------------
            //cambiar valor entre tipo compatibles con diferente alcance
            //int habitantesCiudad = 10000000;

            //long habitantesCiudad2018 = habitantesCiudad;

            //Console.WriteLine(habitantesCiudad2018);

            //--------------------------COVERTIR DE TEXTO A NUMERO----------------------
            //int.parse()
            //double.parse()

            //Console.WriteLine("Introduce el primer nuemro");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Introduce el segundo nuemro");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine($"El resultado es {num1 + num2}");

            //--------------------------CONSTANTE----------------------
            //const int VALOR = 5; //La constante sebera tener el nombre en mayuscula
            //const int VALOR2 = 7;

            //Console.WriteLine("El valor de la constante es: {1}", VALOR, VALOR2);

            //--------------------------CALCULAR AREA DE CIRCULA----------------------
            const double PI = 3.1416;

            Console.WriteLine("Introduce la medida del radio");

            double radio = double.Parse(Console.ReadLine());

            double area = Math.Pow(radio, 2) * PI;

            Console.WriteLine($"El area del circulo es: {area}");
        }
    }
}