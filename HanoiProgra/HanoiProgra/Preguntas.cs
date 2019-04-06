using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Preguntabase {
	class sin_titulo
{
    static void Main(string[] args)
    {
        int num;
        do
        {
            Console.WriteLine("¿Que lenguaje no es orientado a objetos?");
            Console.WriteLine("1 = Java");
            Console.WriteLine("2 = PHP");
            Console.WriteLine("3 = HTML");
            num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Correcto");
                    break;
                case 2:
                    Console.WriteLine("incorrecto");
                    break;
                case 3:
                    Console.WriteLine("Correcta");
                    break;
                default:
                        Console.WriteLine("Ingrese un numero valido");
                        break;
                    

            }
            if (num > 1)
            {
                Console.WriteLine("Usted ingreso un numero incorrecto, por favor ingrese uno valido");
            }
        } while (num != 1);
    }

}
}
