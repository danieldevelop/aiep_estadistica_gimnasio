using System;

namespace estadistica_gimnasio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String open = "si";
            int totalMujeres = 0;
            int edad = 0;
            char sexo;

            Console.WriteLine("ENCUESTA MAQUINA TROTADORA\n");
            while(open != "no")
            {
                Console.Write("Edad: "); edad = int.Parse(Console.ReadLine());
                Console.Write("Genero: "); sexo = char.Parse(Console.ReadLine());

                if ((edad >= 18 && edad <= 25) && (sexo == 'F' || sexo == 'f'))
                {
                    totalMujeres++;
                }

                Console.Write("Desea continuar si/no: ");
                open = Console.ReadLine();
            }

            Console.WriteLine($"\nLa cantidad mujeres entre 18 y 25 años son: {totalMujeres}");


            Console.WriteLine("\nPresione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
