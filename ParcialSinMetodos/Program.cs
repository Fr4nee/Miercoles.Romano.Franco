using System;

namespace ParcialSinMetodos
{
	class Program
	{
		static void Main(string[] args)
		{
			int opcion;
			string[] nombre = new string[10];
			string[] apellido = new string[10];
			string[] viajeRealizado = new string[10];
			int[] dni = new int[10];
			int[] km = new int[10];
			int[] precio = new int[10];
			int dineroTotal = 0;
			int kmTotal = 0;
			int dummie;
			string conf;

			do 
			{
				Console.Clear();
				Console.WriteLine("╔════════════════════════════╗");
				Console.WriteLine("║***Bienvenido!***	     ║");
				Console.WriteLine("║1) Dar de alta a un cliente.║");
				Console.WriteLine("║2) Hacer un viaje.          ║");
				Console.WriteLine("║3) Reportes.                ║");
				Console.WriteLine("║4) Salir.                   ║");
				Console.WriteLine("║Elija la opcion que desee...║");
				Console.WriteLine("╚════════════════════════════╝");

				int.TryParse(Console.ReadLine(), out opcion);

				switch (opcion)
				{
					// ********************************
					// *** DAR DE ALTA A UN CLIENTE ***
					// ********************************
					case 1:
						Console.Clear();
						// *** IGRESAR NOMBRE ***
						Console.Write("Ingrese el nombre del nuevo cliente: ");
						for (int i = 0; i < nombre.Length; i++)
						{
							nombre[i] = Console.ReadLine().Trim().ToLower();
							// VALIDACION
							bool validar2 = int.TryParse(nombre[i], out dummie);
							if (nombre[i] == "" || validar2 == true)
							{
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine("ERROR! Ingrese datos validos!");
								Console.ResetColor();
								Console.Write("Ingrese el nombre nuevamente: ");
								nombre[i] = Console.ReadLine().Trim().ToLower();
								validar2 = int.TryParse(nombre[i], out dummie);
							}
							break;
						}
						// *** IGRESAR APELLIDO ***
						Console.Write("Ingrese el apellido del nuevo cliente: ");
						for (int i = 0; i < nombre.Length; i++)
						{
							apellido[i] = Console.ReadLine().Trim().ToLower();
							// VALIDACION
							bool validar2 = int.TryParse(apellido[i], out dummie);
							if (apellido[i] == "" || validar2 == true)
							{
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine("ERROR! Ingrese datos validos");
								Console.ResetColor();
								Console.Write("Ingrese el apellido nuevamente: ");
								apellido[i] = Console.ReadLine().Trim().ToLower();
								validar2 = int.TryParse(apellido[i], out dummie);
							}
							break;
						}
						// *** IGRESAR DNI ***
						Console.Write("Ingrese el DNI del nuevo cliente:");
						for (int i = 0; i < dni.Length; i++)
						{
							bool validar1 = int.TryParse(Console.ReadLine(), out dni[i]);
							// VALIDACION
							if (dni[i] < 8000000 || validar1 == false)
							{
								Console.ForegroundColor = ConsoleColor.Red;
								Console.Write("ERROR!!! Ingrese un DNI valido!");
								Console.ResetColor();
								Console.Write("Ingrese el DNI nuevamente: ");
								int.TryParse(Console.ReadLine(), out dni[i]);
								validar1 = int.TryParse(Console.ReadLine(), out dni[i]);
							}
							Console.ForegroundColor = ConsoleColor.Green;
							Console.WriteLine($"\nEl cliente fue ingresado exitosamente!");
							Console.WriteLine($"{nombre[i]} {apellido[i]} / {dni[i]}");
							Console.ResetColor();
							break;
						}
						Console.WriteLine("\n\nPresiona ENTER para continuar...");
						Console.ReadKey();
						break;


					// **********************
					// *** HACER UN VIAJE ***
					// **********************
					case 2:
						Console.Clear();
						for (int i = 0; i < km.Length; i++)
						{
							Console.Write("Ingrese los Kms estimados: ");
							bool validar3 = int.TryParse(Console.ReadLine(), out km[i]);

							if (km[i] <= 5)
							{
								precio[i] = 150;
							}
							else if (km[i] > 5)
							{
								precio[i] = 150 + ((km[i] - 5) * 35);
							}
							// VALIDACION
							if (validar3 == false || km[i] == 0)
							{
								Console.ForegroundColor = ConsoleColor.Red;
								Console.Write("ERROR!!! Ingrese un valido!");
								Console.ResetColor();
								Console.Write("Ingrese KMs nuevamente: ");
								int.TryParse(Console.ReadLine(), out km[i]);
								validar3 = int.TryParse(Console.ReadLine(), out km[i]);
							}
							Console.ForegroundColor = ConsoleColor.Green;
							Console.WriteLine($"El precio del viaje rondara los: ${precio[i]}");
							Console.ResetColor();
							dineroTotal = dineroTotal + precio[i];
							kmTotal = kmTotal + km[i];
							break;
						}
						Console.WriteLine("\n\nPresiona ENTER para continuar...");
						Console.ReadKey();
						break;


					// ****************
					// *** REPORTES ***
					// ****************
					case 3:
						Console.Clear();
						for (int i = 0; i < nombre.Length; i++)
						{
							Console.WriteLine($"El cliente: {nombre[i]} {apellido[i]} // {dni[i]} realizo un viaje de {km[i]} kms y pago ${precio[i]}\n");
						}
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine($"El dinero total recaudado es ${dineroTotal}");
						Console.WriteLine($"Total de Kilometros recorridos {kmTotal}");
						Console.ResetColor();
						Console.WriteLine("\n\nPresiona ENTER para continuar...");
						Console.ReadKey();
						break;


					// *************
					// *** SALIR ***
					// *************
					case 4:
						Console.WriteLine("¿Seguro desea salir? Presione S / N");
						conf = Console.ReadLine().Trim().ToLower();
						if (conf == "s")
						{
							opcion = 5;
						}
						else if (conf == "n")
						{
							break;
                        }
						else
						{
							Console.ForegroundColor = ConsoleColor.Red;
							Console.WriteLine("ERROR! Opcion incorrecta.");
							Console.ResetColor();
							Console.ReadKey();
						}
						break;


					default:
						Console.Clear();
						Console.WriteLine("Introduce una opcion correcta");
						Console.ReadKey();
						break;
				}
			} while (opcion != 5);

		}
	}
}
