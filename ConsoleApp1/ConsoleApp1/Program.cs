using System;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int edad, año;

            Console.WriteLine("Ingrese su año de nacimiento");
            año = int.Parse(Console.ReadLine());

            edad = DateTime.Today.Year - año;


            Console.WriteLine("Su edad es: " + edad);
         

           
        }
    }
}
