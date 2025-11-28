using System.Net.Http.Headers;

namespace ListaEstudiantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            MostrarMenu();
            Dictionary<int, (int,string, int, string)> listaEstudiantes = new Dictionary<int, (int,string, int, string)>();
            int op = RevisionOp(1, 5);
            while (true)
            {
                switch (op)
                {
                    case 1:
                        AgregarEstudiante(ref listaEstudiantes);
                        break;
                    case 2:
                       
                        break;
                    case 3:
                          break;
                    case 4:
                        break;
                    case 5:
                        return;
                }
            }


        }
        static void MostrarMenu()
        {
            Console.WriteLine("====Sistema de Estudiantes====\n");
            Console.WriteLine("Ingrese la opcion deseada");
            Console.WriteLine("1. Ingresar Estudiante");
            Console.WriteLine("2. Ver lista");
            Console.WriteLine("3. Modificar Estudiante");
            Console.WriteLine("4. Eliminar Estudiante");
            Console.WriteLine("5. Salir");


        }
        static int RevisionOp(int a, int b)
        {
            while (true)
            {
                int opcion;
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    if (opcion >= a && opcion <= b)
                    {
                        return opcion;
                    }
                    else
                    {
                        Console.WriteLine("Opcion fuera de rango...Intente nuevamente");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada invalida. Por favor ingrese un numero entero.");
                }
            }

        }
        static int RevisionNums()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    return numero;
                }
                else
                {
                    Console.WriteLine("Entrada invalida. Por favor ingrese un numero entero.");
                }
            }
        }
        static void AgregarEstudiante(ref Dictionary<int, (int, string, int, string)> listaEstudiantes)
        {
            Console.Clear();
            Console.WriteLine("===Agregar Estudiante===");
            Console.Write("Identidicacion: ");
            int ID = RevisionNums();
            Console.Write("Nombre Completo:");
            string NombreCompleto = Console.ReadLine();
            Console.Write("Edad: ");
            int edad = RevisionNums();
            Console.Write("Carrera: ");
            string Carrera = Console.ReadLine();
            int numEst = listaEstudiantes.Count;
            listaEstudiantes.Add(numEst, (ID, NombreCompleto, edad, Carrera));
            listaEstudiantes.Add(numEst + 1, (8594, "oscar", 23, "meca"));
            foreach (var estudiantes in listaEstudiantes)
            {
                var (IDest, Nombreest, edadest, Carreraest) = estudiantes.Value;
                Console.WriteLine($"{IDest} - {Nombreest} - {edadest} - {Carreraest}");
                Console.ReadKey();
            }
            
        }
    }
}
