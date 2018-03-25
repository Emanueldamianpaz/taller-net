using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			
			Console.WriteLine("Ingrese un numero");

			Console.WriteLine("1. Realizar un programa de consola que permita ingresar el nombre y apellido por separado, con estos datos debe imprimir un mensaje con el nombre completo.");
			Console.WriteLine("2. Realizar un programa de consola que permita ingresar el nombre y la edad, con estos datos debe imprimir un mensaje diciendo si es mayor de edad o no.");
			Console.WriteLine("3. Realizar un programa de consola que permita ingresar un numero y calcule la suma de todos los numeros enteros anteriores");
			Console.WriteLine("4. Realizar un programa de consola que permita ingresar 2 valores y encuentr el maximo comun divisor");
			Console.WriteLine("5. Realizar un programa de consola que permita ingresar numeros y que termine de pedir numeros cuando se ingresa 0 y calcule el promedio de todos los ingresados");

			int option = int.Parse(Console.ReadLine());

			switch (option) {
				case 1:
					string name = Console.ReadLine();
					string last_name = Console.ReadLine();

					Console.WriteLine(name + " " + last_name);
					break;
				case 2:
					string name1= Console.ReadLine();
					int age = int.Parse(Console.ReadLine());

                    if (age >= 1){
                        Console.WriteLine("Es mayor de edad");
                    }else{
                        Console.WriteLine("Es mayor de edad");
                    };

					break;
				case 3:
					int numberMax = int.Parse(Console.ReadLine());
					int aux = 0;
					for (int i = 0; i < numberMax; i++){
						aux += i;
					}
					Console.WriteLine("Sumatoria: "+aux);

					break;
                case 4:

                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());

                    int a = Math.Max(num1, num2);
                    int b = Math.Min(num1, num2);
                    int res;

                    do{
                        res = b;
                        b = a % b; 
                        a = res; 
                    } while (b != 0);

                    Console.WriteLine("El M.C.D. entre " + num1 + " y " + num2 + " es: " + res);

                    break;
                case 5:

                    int count = 0;
                    int acum = 0;
                    int aux1 = int.Parse(Console.ReadLine());

                    do{
                        aux1 = int.Parse(Console.ReadLine());
                        acum += aux1;

                        count++;
                    } while (aux1 != 0);

                    double average = Convert.ToDouble(acum) / Convert.ToDouble(count);

                    Console.WriteLine("Promedio: "+average);

                    break;
			}

            Console.ReadKey();


		}
	}
}
