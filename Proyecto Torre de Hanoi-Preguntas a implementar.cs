

using System;

namespace TorreHanoi {
	class preguntas {

		static void Main(string[] args) {
			int num;
			int num2;
			do {
				Console.WriteLine("Escoja el numero de una materia para comenzar");
				Console.WriteLine(" 1) Ciencias");
				Console.WriteLine(" 2) Historia");
				Console.WriteLine(" 3) Programacion");
				Console.WriteLine(" 4) Redes");
				num = int.Parse(Console.ReadLine());
				if (num==1) {
					Console.WriteLine("Usted Eligio Ciencias");
					Console.WriteLine("Ahora vamos a comenzar con las preguntas");
					// Aqui random va agarrar un  numero al azar del 1-3";
					num2 = int.Parse(Console.ReadLine());
					switch (num2) {
					case 1:
						// aqui van las preguntas de ciencias
						break;
					case 2:
						// aqui van las preguntas ciencias
						break;
					case 3:
						// aqui van las preguntas ciencias
						break;
					}
				}
				if (num==2) {
					Console.WriteLine("Usted Eligio Historia");
				}
				if (num==3) {
					Console.WriteLine("Usted Eligio Programacion");
				}
				if (num==4) {
					Console.WriteLine("Usted Eligio Redes");
				}
				if (num<1 || num>5) {
					Console.WriteLine("El dato que ingreso es invalido");
					Console.WriteLine("Por favor intentelo de nuevo");
				}
			} while (!(num>=1 && num<=5));
		}

	}

}

