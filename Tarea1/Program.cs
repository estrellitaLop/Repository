using Tarea1;

string archivoEmpleados = "empleados.txt";

IEmpleadosRepository empleadosRepository = new EmpleadoRepositoryArchivo(archivoEmpleados);

GestorEmpleados gestorEmpleados = new GestorEmpleados(empleadosRepository);

gestorEmpleados.AgregarEmpleados(new Empleados { Nombre= "Maria" , Edad=34, Puesto="Cocinera"} );
gestorEmpleados.AgregarEmpleados(new Empleados { Nombre= "Pedro", Edad=60, Puesto="Administrador" });

Console.WriteLine("Mostrar a todos los Empleados");

foreach( var empleado  in gestorEmpleados.ObtenerTodosLosEmpleados())
{
    Console.WriteLine($"Nombre: {empleado.Nombre} , Edad: {empleado.Edad}, Puesto: {empleado.Puesto}");
}