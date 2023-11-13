using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
        int opcion = 0;

        do
        {
            Menu();
            Console.Write("Ingresar una opcion (1 - 3): ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        AsignarSalario();
                        break;
                    case 2:
                        MostrarDiasSemana();
                        break;
                    case 3:
                        
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Por favor vuelve a ingrese un número válido de los que estan disponibles.");
            }
        } while (opcion != 3); 
    }


    static void Menu()
    {
        Console.WriteLine("\n*************Menu Principal*************");
        Console.WriteLine("1. Asignacion de salarios a empleados");
        Console.WriteLine("2. Listado de dias de la semana");
        Console.WriteLine("3. Salir del Pograma...");
        Console.WriteLine("*********Fin del Menu Principal*********\n");
    }

    static void AsignarSalario()
    {
        List<string?> nombres = new List<string?>();
        List<double> salarios = new List<double>();

        for(int i = 1; i <=6; i++)
        {
            Console.Write($"\nIngrese el nombre del empleado #{i}: ");
            string? nombre = Convert.ToString(Console.ReadLine());
            nombres.Add(nombre);

            Console.Write($"Ingrese el salario del empleado {nombre}: $");
            double salario = Convert.ToDouble(Console.ReadLine());
            salarios.Add(salario);
        }

        Console.WriteLine("Asignacion de salarios completada... \nDetalles: ");

        for (int i = 0; i < nombres.Count; i++)
        {
            Console.WriteLine($"{nombres[i]}: ${salarios[i]}");
        }

    }

    enum DiasSemana
    {
        Lunes,
        Martes,
        Miercoles,
        Jueves,
        Viernes,
        Sabado,
        Domingo
    }

    static void MostrarDiasSemana()
    {
        foreach(DiasSemana dia in Enum.GetValues(typeof(DiasSemana)))
        {
            if(dia == DiasSemana.Domingo)
            {
                Console.WriteLine($"\n{dia}: !Dia de descanso!");
            }
            else
            {
                Console.WriteLine($"\n{dia}: Dia de trabajo.");
            }
        }
    }


  }
}