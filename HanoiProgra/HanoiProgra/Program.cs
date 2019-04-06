using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiProgra
{
    class Inicio
    {

        static void main (string[] args)
        {
            int cant_movs;
            int discos;
            int disco_a_mover;
            int i;
            int j;
            bool puede_mover;
            int t1;
            int t2;
            int[,] torres = new int[3, 10];
            int[] cant_discos = new int[3];
            // pedir y validar cuantos discos colocar en la primer torre
            Console.WriteLine("Ingrese el nro de discos (2-8):");
            discos = int.Parse(Console.ReadLine());
            while (discos < 2 || discos > 8)
            {
                Console.WriteLine("El numero de discos debe ser mayor a 1 y menor a 8:");
                discos = int.Parse(Console.ReadLine());
            }
            if (discos == 2)
            {
                // inicializar los datos
                cant_discos[0] = discos;
                cant_discos[1] = 0;
                cant_discos[2] = 0;
                for (i = 1; i <= discos; i++)
                {
                    torres[0, i - 1] = discos - i + 1;
                }

                cant_movs = 0;
                // mientras no esten todos los discos en la tercer torre, el juego sigue
                while (cant_discos[2] != discos)
                {
                    Console.Clear();
                    // dibujar las tres torres
                    for (i = 1; i <= 3; i++)
                    {
                        Console.WriteLine("Torre " + i);
                        if (cant_discos[i - 1] == 0)
                        {
                            Console.WriteLine("");
                        }
                        else
                        {
                            // recorrer los discos de la torre, de arriba hacia abajo
                            for (j = cant_discos[i - 1]; j >= 1; j--)
                            {
                                // dibujar cada disco
                                switch (torres[i - 1, j - 1])
                                {
                                    case 1:

                                        Console.WriteLine("Fragmento 1");
                                        Console.WriteLine("namespace HelloNameSpace");
                                        Console.WriteLine(" {");
                                        Console.WriteLine(" public class HelloWorld");
                                        Console.WriteLine(" {");
                                        Console.WriteLine("static void Main(string[] args)");
                                        break;
                                    case 2:
                                        Console.WriteLine("Fragmento 2");
                                        Console.WriteLine("{");
                                        Console.WriteLine("Console.WriteLine(", "Hola Mundo!", ");");
                                        Console.WriteLine("}");
                                        Console.WriteLine("}");
                                        Console.WriteLine("}");
                                        Console.WriteLine("");
                                        break;
                                }
                            }
                        }
                        Console.WriteLine("   ----------------------------------");
                        Console.WriteLine("");
                    }
                    // solicitar movimiento
                    Console.WriteLine("Mover desde la torre: ");
                    t1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("hacia la torre: ");
                    t2 = int.Parse(Console.ReadLine());
                    // controlar que el nro de torre sea valido
                    if (t1 < 1 || t1 > 3 || t2 < 1 || t2 > 3)
                    {
                        Console.WriteLine("Movimiento invalido");
                        Console.ReadKey();
                    }
                    else
                    {
                        // controlar que la torre 1 tengo al menos un disco
                        if (cant_discos[t1 - 1] == 0)
                        {
                            Console.WriteLine("Movimiento invalido");
                            Console.ReadKey();
                        }
                        else
                        {
                            // obtener tamanio del disco que se quiere mover
                            disco_a_mover = torres[t1 - 1, cant_discos[t1 - 1] - 1];
                            puede_mover = true;
                            // controlar que la torre dos no tenga discos o tenga solo discos mas grandes
                            if (cant_discos[t2 - 1] != 0)
                            {
                                if (torres[t2 - 1, cant_discos[t2 - 1] - 1] < disco_a_mover)
                                {
                                    puede_mover = false;
                                }
                            }
                            // si paso todos los controles, mover
                            if (puede_mover)
                            {
                                cant_movs = cant_movs + 1;
                                cant_discos[t2 - 1] = cant_discos[t2 - 1] + 1;
                                torres[t2 - 1, cant_discos[t2 - 1] - 1] = disco_a_mover;
                                cant_discos[t1 - 1] = cant_discos[t1 - 1] - 1;
                            }
                            else
                            {
                                Console.WriteLine("Movimiento invalido");
                                Console.ReadKey();
                            }
                        }
                    }
                }

                // mostrar resultado
                Console.Clear();
                Console.WriteLine("Juego finalizado en " + cant_movs + " movimientos!");
            }
            //Segundo Codigo
            if (discos == 3)
            {
                // inicializar los datos
                cant_discos[0] = discos;
                cant_discos[1] = 0;
                cant_discos[2] = 0;
                for (i = 1; i <= discos; i++)
                {
                    torres[0, i - 1] = discos - i + 1;
                }

                cant_movs = 0;
                // mientras no esten todos los discos en la tercer torre, el juego sigue
                while (cant_discos[2] != discos)
                {
                    Console.Clear();
                    // dibujar las tres torres
                    for (i = 1; i <= 3; i++)
                    {
                        Console.WriteLine("Torre " + i);
                        if (cant_discos[i - 1] == 0)
                        {
                            Console.WriteLine("");
                        }
                        else
                        {
                            // recorrer los discos de la torre, de arriba hacia abajo
                            for (j = cant_discos[i - 1]; j >= 1; j--)
                            {
                                // dibujar cada disco
                                switch (torres[i - 1, j - 1])
                                {
                                    case 1:
                                        Console.WriteLine("Fragmento 1");
                                        Console.WriteLine("namespace Reloj_digital_I ");
                                        Console.WriteLine(" {");
                                        Console.WriteLine("public partial class Form1 : Form");
                                        Console.WriteLine(" {");
                                        Console.WriteLine("  public Form1()");
                                        Console.WriteLine(" {");
                                        Console.WriteLine("  InitializeComponent();");
                                        Console.WriteLine(" }");
                                        Console.WriteLine(");");
                                        break;
                                    case 2:
                                        Console.WriteLine("Fragmento 2");
                                        Console.WriteLine("private void Form1_Load(object sender, EventArgs e) ");
                                        Console.WriteLine("{");
                                        Console.WriteLine("}");
                                        Console.WriteLine("  private void timer1_Tick(object sender, EventArgs e) ");
                                        Console.WriteLine("{");
                                        Console.WriteLine("");
                                        break;
                                    case 3:
                                        Console.WriteLine("Fragmento 3");
                                        Console.WriteLine(" label1.Text = DateTime.Now.ToLongTimeString(); ");
                                        Console.WriteLine(" label2.Text = DateTime.Now.ToShortDateString();");
                                        Console.WriteLine("label3.Text = DateTime.Now.ToString", "(", "dddd", ")", ";", "");
                                        Console.WriteLine("}");
                                        Console.WriteLine("}");
                                        Console.WriteLine("}");
                                        break;
                                }
                            }
                        }
                        Console.WriteLine("   ----------------------------------");
                        Console.WriteLine("");
                    }
                    // solicitar movimiento
                    Console.WriteLine("Mover desde la torre: ");
                    t1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("hacia la torre: ");
                    t2 = int.Parse(Console.ReadLine());
                    // controlar que el nro de torre sea valido
                    if (t1 < 1 || t1 > 3 || t2 < 1 || t2 > 3)
                    {
                        Console.WriteLine("Movimiento invalido");
                        Console.ReadKey();
                    }
                    else
                    {
                        // controlar que la torre 1 tengo al menos un disco
                        if (cant_discos[t1 - 1] == 0)
                        {
                            Console.WriteLine("Movimiento invalido");
                            Console.ReadKey();
                        }
                        else
                        {
                            // obtener tamaño del disco que se quiere mover
                            disco_a_mover = torres[t1 - 1, cant_discos[t1 - 1] - 1];
                            puede_mover = true;
                            // controlar que la torre dos no tenga discos o tenga solo discos mas grandes
                            if (cant_discos[t2 - 1] != 0)
                            {
                                if (torres[t2 - 1, cant_discos[t2 - 1] - 1] < disco_a_mover)
                                {
                                    puede_mover = false;
                                }
                            }
                            // si paso todos los controles, mover
                            if (puede_mover)
                            {
                                cant_movs = cant_movs + 1;
                                cant_discos[t2 - 1] = cant_discos[t2 - 1] + 1;
                                torres[t2 - 1, cant_discos[t2 - 1] - 1] = disco_a_mover;
                                cant_discos[t1 - 1] = cant_discos[t1 - 1] - 1;
                            }
                            else
                            {
                                Console.WriteLine("Movimiento invalido");
                                Console.ReadKey();
                            }
                        }
                    }
                }

                // mostrar resultado
                Console.Clear();
                Console.WriteLine("Juego finalizado en " + cant_movs + " movimientos!");
            }
            //Tercer Codigo codigo
            if (discos == 4)
            {
                // inicializar los datos
                cant_discos[0] = discos;
                cant_discos[1] = 0;
                cant_discos[2] = 0;
                for (i = 1; i <= discos; i++)
                {
                    torres[0, i - 1] = discos - i + 1;
                }

                cant_movs = 0;
                // mientras no esten todos los discos en la tercer torre, el juego sigue
                while (cant_discos[2] != discos)
                {
                    Console.Clear();
                    // dibujar las tres torres
                    for (i = 1; i <= 3; i++)
                    {
                        Console.WriteLine("Torre " + i);
                        if (cant_discos[i - 1] == 0)
                        {
                            Console.WriteLine("");
                        }
                        else
                        {
                            // recorrer los codigos de la torre, de arriba hacia abajo
                            for (j = cant_discos[i - 1]; j >= 1; j--)
                            {

                                switch (torres[i - 1, j - 1])
                                {
                                    case 1:
                                        Console.WriteLine("Fragmento 1");
                                        Console.WriteLine("namespace calculadora");
                                        Console.WriteLine(" {");
                                        Console.WriteLine("class Program");
                                        Console.WriteLine(" {");
                                        Console.WriteLine("static int suma(int a, int b)");
                                        Console.WriteLine(" {");
                                        Console.WriteLine("int suma = a + b;");
                                        Console.WriteLine(" return suma;");
                                        Console.WriteLine("}");
                                        Console.WriteLine("static int resta(int a, int b)");
                                        Console.WriteLine("{");
                                        Console.WriteLine("int resta = a - b;");
                                        Console.WriteLine("return resta;");

                                        break;
                                    case 2:
                                        Console.WriteLine("Fragmento 2");
                                        Console.WriteLine("}");
                                        Console.WriteLine(" static int multiplicacion(int a, int b)");
                                        Console.WriteLine("{");
                                        Console.WriteLine("int multi = a * b;");
                                        Console.WriteLine("return multi;");
                                        Console.WriteLine("}");
                                        Console.WriteLine("static int division(int a, int b)");
                                        Console.WriteLine("{");
                                        Console.WriteLine("int divi = a / b;");
                                        Console.WriteLine("return divi;");
                                        Console.WriteLine("}");
                                        Console.WriteLine("static void Main(string[] args)");
                                        Console.WriteLine("{");

                                        break;
                                    case 3:
                                        Console.WriteLine("Fragmento 3");
                                        Console.WriteLine("int a, b;");
                                        Console.WriteLine(" Console.Write(", "\n", " + ", "Introduce el 1er número: ", ");");
                                        Console.WriteLine("a = int.Parse(Console.ReadLine());");
                                        Console.WriteLine("Console.Write(", "\n", "+ ", "Introduce el 2do número: ", ");");
                                        Console.WriteLine("b = int.Parse(Console.ReadLine());");
                                        Console.WriteLine(" Console.Write(", "\n", " + ", "Seleccione una opción: ", " + ", "\n", " + ", "\n", ");");
                                        Console.WriteLine("Console.Write(", "\n", "+ ", "     1º) Suma", " + ", "\n", " + ", "     2º) Resta", " + ", "\n", " + ", "     3º) Multiplicación", " + ", "\n", " + ", "     4º) División", " + ", "\n", " + ", "     5º) Salir del Programa", " + ", "\n", " + ", "\n", ");");
                                        Console.WriteLine("switch (Console.Read())");
                                        Console.WriteLine("{");
                                        Console.WriteLine(" case '1': Console.Write(", "\n", " + ", "    Suma = ", " + suma(a,b));");
                                        Console.WriteLine("break;");
                                        Console.WriteLine("case '2': Console.Write(", "\n", " + ", "    Resta = ", " + resta(a, b));");
                                        Console.WriteLine("break;");
                                        break;
                                    case 4:
                                        Console.WriteLine("Fragmento 4");
                                        Console.WriteLine("  case '3': Console.Write(", "\n", " + ", "    Multiplicación = ", " + multiplicacion(a, b));");
                                        Console.WriteLine("break;");
                                        Console.WriteLine("case '4': Console.Write(", "\n", " + ", "    División = ", " + division(a, b));");
                                        Console.WriteLine("break;");
                                        Console.WriteLine(" case '5': Console.Write(", "\n", " + ", "      °º¤ø,¸¸, ø¤º°`°º¤ø,¸(Hasta la próxima)¸,ø¤º°`°º¤ø,¸,ø¤º°", ");");
                                        Console.WriteLine("break;");
                                        Console.WriteLine("}");
                                        Console.WriteLine("Console.ReadKey();");
                                        Console.WriteLine("}");
                                        Console.WriteLine("}");
                                        Console.WriteLine("}");
                                        break;
                                }
                            }
                        }
                        Console.WriteLine("   ----------------------------------");
                        Console.WriteLine("");
                    }
                    // solicitar movimiento
                    Console.WriteLine("Mover desde la torre: ");
                    t1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("hacia la torre: ");
                    t2 = int.Parse(Console.ReadLine());
                    // controlar que el nro de torre sea valido
                    if (t1 < 1 || t1 > 3 || t2 < 1 || t2 > 3)
                    {
                        Console.WriteLine("Movimiento invalido");
                        Console.ReadKey();
                    }
                    else
                    {
                        // controlar que la torre 1 tengo al menos un disco
                        if (cant_discos[t1 - 1] == 0)
                        {
                            Console.WriteLine("Movimiento invalido");
                            Console.ReadKey();
                        }
                        else
                        {
                            // obtener tamanio del disco que se quiere mover
                            disco_a_mover = torres[t1 - 1, cant_discos[t1 - 1] - 1];
                            puede_mover = true;
                            // controlar que la torre dos no tenga discos o tenga solo discos mas grandes
                            if (cant_discos[t2 - 1] != 0)
                            {
                                if (torres[t2 - 1, cant_discos[t2 - 1] - 1] < disco_a_mover)
                                {
                                    puede_mover = false;
                                }
                            }
                            // si paso todos los controles, mover
                            if (puede_mover)
                            {
                                cant_movs = cant_movs + 1;
                                cant_discos[t2 - 1] = cant_discos[t2 - 1] + 1;
                                torres[t2 - 1, cant_discos[t2 - 1] - 1] = disco_a_mover;
                                cant_discos[t1 - 1] = cant_discos[t1 - 1] - 1;
                            }
                            else
                            {
                                Console.WriteLine("Movimiento invalido");
                                Console.ReadKey();
                            }
                        }
                    }
                }

                // mostrar resultado
                Console.Clear();
                Console.WriteLine("Juego finalizado en " + cant_movs + " movimientos!");
            }
            //Cuarto Codigo
            if (discos == 5)
            {
                // inicializar los datos
                cant_discos[0] = discos;
                cant_discos[1] = 0;
                cant_discos[2] = 0;
                for (i = 1; i <= discos; i++)
                {
                    torres[0, i - 1] = discos - i + 1;
                }

                cant_movs = 0;
                // mientras no esten todos los discos en la tercer torre, el juego sigue
                while (cant_discos[2] != discos)
                {
                    Console.Clear();
                    // dibujar las tres torres
                    for (i = 1; i <= 3; i++)
                    {
                        Console.WriteLine("Torre " + i);
                        if (cant_discos[i - 1] == 0)
                        {
                            Console.WriteLine("");
                        }
                        else
                        {
                            // recorrer los codigos de la torre, de arriba hacia abajo
                            for (j = cant_discos[i - 1]; j >= 1; j--)
                            {

                                switch (torres[i - 1, j - 1])
                                {
                                    case 1:
                                        Console.WriteLine("Fragmento 1");
                                        Console.WriteLine("namespace Aprender");
                                        Console.WriteLine("{");
                                        Console.WriteLine("class Program");
                                        Console.WriteLine("{");
                                        Console.WriteLine("static void Main(string[] args)");
                                        Console.WriteLine("{");
                                        Console.WriteLine(" int peso;");
                                        Console.WriteLine("Double altura;");
                                        Console.WriteLine("Double imc;");
                                        Console.WriteLine("Double preimc;");
                                        Console.WriteLine("dynamic nombre;");
                                        Console.WriteLine("Console.WriteLine(", "Calculador de IMC(Indice de Masa Corporal) v.1.0 \n", ");");
                                        Console.WriteLine("Console.WriteLine(", "Oprima cualquier tecla para continuar", ");");
                                        Console.WriteLine("Console.ReadKey();");
                                        Console.WriteLine("Console.Clear();");
                                        Console.WriteLine("Console.WriteLine(", "¿Como te llamas ? ", "); ");
                                        Console.WriteLine("");
                                        break;
                                    case 2:
                                        Console.WriteLine("Fragmnto 2");
                                        Console.WriteLine("nombre = Convert.ToString(Console.ReadLine()); ");
                                        Console.WriteLine("Console.Clear();");
                                        Console.WriteLine("Console.WriteLine(", "Hola ", " + nombre + , Escriba su peso en kg: ", ");");
                                        Console.WriteLine(" peso = Convert.ToInt16(Console.ReadLine());");
                                        Console.WriteLine("Console.Clear();");
                                        Console.WriteLine(" Console.WriteLine(", "Ahora escriba su altura en metros:", "); ");
                                        Console.WriteLine("altura = Convert.ToDouble(Console.ReadLine());");
                                        Console.WriteLine("Console.Clear();");
                                        Console.WriteLine("reimc = Convert.ToDouble(altura * altura);");
                                        Console.WriteLine("imc = Convert.ToDouble(peso / preimc);");
                                        Console.WriteLine("if (imc > 40 && imc < 50)");
                                        Console.WriteLine("{");
                                        Console.WriteLine(" Console.WriteLine(", "Mala noticia ", " + nombre + ", "!, Padeces de obesidad morbida, Tu riesgo en salud es extremadamente alto\n", ");");
                                        Console.WriteLine("Console.WriteLine(", "Gracias por utilizar la calculadora de IMC", ");");
                                        Console.WriteLine("Console.WriteLine(", "CC\n", ");");
                                        Console.WriteLine(" Console.WriteLine(", "Presiona cualquier letra para salir", ");");
                                        Console.WriteLine("Console.ReadKey();");
                                        break;
                                    case 3:
                                        Console.WriteLine("Fragmento 3");
                                        Console.WriteLine("}");
                                        Console.WriteLine("else if (imc > 35 && imc < 40)");
                                        Console.WriteLine("{");
                                        Console.WriteLine(" Console.WriteLine(", "Mala noticia ", " + nombre + ", "!, Padeces de obesidad nivel 2, Tu riesgo en salud es muy alto\n", ");");
                                        Console.WriteLine("Console.WriteLine(", "CC\n", ");");
                                        Console.WriteLine("Console.WriteLine(", "Presiona cualquier letra para salir", ");");
                                        Console.WriteLine("Console.ReadKey();");
                                        Console.WriteLine("}");
                                        Console.WriteLine(" else if (imc > 30 && imc < 35)");
                                        Console.WriteLine("{");
                                        Console.WriteLine("Console.WriteLine(", "Mala noticia ", " + nombre + ", ", Padeces de obesidad nivel 1, Tu riesgo en salud es alto\n", ");");
                                        Console.WriteLine("Console.WriteLine(", " CC\n", ");");
                                        Console.WriteLine("Console.WriteLine(", "Presiona cualquier letra para salir", ");");
                                        Console.WriteLine("Console.ReadKey();");
                                        Console.WriteLine("}");

                                        break;
                                    case 4:
                                        Console.WriteLine("Fragmento 4");
                                        Console.WriteLine("else if (imc > 25 && imc < 30)");
                                        Console.WriteLine("{");
                                        Console.WriteLine("Console.WriteLine(", "Intemedia noticia ", " + nombre + ", ", Padeces de sobrepeso, Tu riesgo en salud es moderado\n", ");");
                                        Console.WriteLine("Console.WriteLine(", "CC\n", ");");
                                        Console.WriteLine("Console.WriteLine(", "Presiona cualquier letra para salir", ");");
                                        Console.WriteLine("Console.ReadKey();");
                                        Console.WriteLine("}");
                                        Console.WriteLine("else if (imc > 20 && imc < 25)");
                                        Console.WriteLine("{");
                                        Console.WriteLine("Console.WriteLine(", "Buena noticia ", " + nombre + ", "!, Padeces de peso saludable, No corres algun riesco en tu salud\n", ");");
                                        Console.WriteLine("Console.WriteLine(", "CC\n", ");");
                                        Console.WriteLine("Console.WriteLine(", "Presiona cualquier letra para salir", ");");
                                        Console.WriteLine("Console.ReadKey();");
                                        Console.WriteLine("}");
                                        Console.WriteLine("else if (imc > 5 && imc < 20)");
                                        break;
                                    case 5:
                                        Console.WriteLine("Fragmento 5");
                                        Console.WriteLine("{");
                                        Console.WriteLine("Console.WriteLine(", "Mala Noticia noticia ", " + nombre + ,", "!, Tu peso no es saludable, Estas muy delgado corres peligro\n", ");");
                                        Console.WriteLine("Console.WriteLine(", "CC\n", ");");
                                        Console.WriteLine("Console.WriteLine(", "Presiona cualquier letra para salir", ");");
                                        Console.WriteLine("Console.ReadKey();");
                                        Console.WriteLine("}");
                                        Console.WriteLine("else");
                                        Console.WriteLine("{");
                                        Console.WriteLine("Console.WriteLine(", "Algo paso mal, Por favor asegurate seguir las instrucciones o agrega valores logicos\n", ");");
                                        Console.WriteLine("Console.WriteLine(", "Por favor, Comunicate con el creador para solucionar esto", ");");//osease io :v
                                        Console.WriteLine("Console.WriteLine(", "Email: rodi48656@gmail.com", ");");
                                        Console.WriteLine("Console.WriteLine(", "CC", ");");
                                        Console.WriteLine("Console.WriteLine(", "Presiona cualquier letra para salir", ");");
                                        Console.WriteLine("Console.ReadKey();");
                                        Console.WriteLine("}");
                                        Console.WriteLine("}");
                                        Console.WriteLine("}");
                                        Console.WriteLine("}");
                                        break;
                                }
                            }
                        }
                        Console.WriteLine("   ----------------------------------");
                        Console.WriteLine("");
                    }
                    // solicitar movimiento
                    Console.WriteLine("Mover desde la torre: ");
                    t1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("hacia la torre: ");
                    t2 = int.Parse(Console.ReadLine());
                    // controlar que el nro de torre sea valido
                    if (t1 < 1 || t1 > 3 || t2 < 1 || t2 > 3)
                    {
                        Console.WriteLine("Movimiento invalido");
                        Console.ReadKey();
                    }
                    else
                    {
                        // controlar que la torre 1 tengo al menos un disco
                        if (cant_discos[t1 - 1] == 0)
                        {
                            Console.WriteLine("Movimiento invalido");
                            Console.ReadKey();
                        }
                        else
                        {
                            // obtener tamanio del disco que se quiere mover
                            disco_a_mover = torres[t1 - 1, cant_discos[t1 - 1] - 1];
                            puede_mover = true;
                            // controlar que la torre dos no tenga discos o tenga solo discos mas grandes
                            if (cant_discos[t2 - 1] != 0)
                            {
                                if (torres[t2 - 1, cant_discos[t2 - 1] - 1] < disco_a_mover)
                                {
                                    puede_mover = false;
                                }
                            }
                            // si paso todos los controles, mover
                            if (puede_mover)
                            {
                                cant_movs = cant_movs + 1;
                                cant_discos[t2 - 1] = cant_discos[t2 - 1] + 1;
                                torres[t2 - 1, cant_discos[t2 - 1] - 1] = disco_a_mover;
                                cant_discos[t1 - 1] = cant_discos[t1 - 1] - 1;
                            }
                            else
                            {
                                Console.WriteLine("Movimiento invalido");
                                Console.ReadKey();
                            }
                        }
                    }
                }

                // mostrar resultado
                Console.Clear();
                Console.WriteLine("Juego finalizado en " + cant_movs + " movimientos!");
            }
        }
    }       
}