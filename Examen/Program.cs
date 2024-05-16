using Examen;

Asignatura asignatura = new Asignatura();

try
{
    Console.Write("Ingrese nombre del alumno: ");
    string nombreAlumno = Console.ReadLine();

    Console.Write("Ingrese número de cuenta: ");
    string numeroCuenta = Console.ReadLine();

    Console.Write("Ingrese email: ");
    string email = Console.ReadLine();

    Console.Write("Ingrese nota del primer parcial: ");
    int n1 = int.Parse(Console.ReadLine());

    Console.Write("Ingrese nota del segundo parcial: ");
    int n2 = int.Parse(Console.ReadLine());

    Console.Write("Ingrese nota del tercer parcial: ");
    int n3 = int.Parse(Console.ReadLine());

    Console.Write("Ingrese nombre de la asignatura: ");
    string nombreAsignatura = Console.ReadLine();

    Console.Write("Ingrese horario: ");
    string horario = Console.ReadLine();

    Console.Write("Ingrese nombre del docente: ");
    string nombreDocente = Console.ReadLine();

    if (n1 > 30 || n2 > 30 || n3 > 40)
        throw new Exception("Nota fuera de rango");

    asignatura.Imprimir();
}
catch (Exception e)
{
    Console.WriteLine("Error: " + e.Message);
}
    