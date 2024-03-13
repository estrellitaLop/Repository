using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    public class EmpleadoRepositoryArchivo : IEmpleadosRepository
    {
       private string _nombreArchivo;
        public EmpleadoRepositoryArchivo(string nombreArchivo)
        {
            _nombreArchivo = nombreArchivo;
        }
        public void GuardarTodos(List<Empleados> empleados)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(_nombreArchivo))
                {
                    foreach (Empleados empleado in empleados)
                    {
                        sw.WriteLine($"{empleado.Nombre}, {empleado.Edad},{empleado.Puesto}");

                    }
                }
            }
            catch (IOException e)
            {

                Console.WriteLine($"Error al escribir en el archivo" +
                   $"{e.Message}");
            }
        }   


        public List<Empleados> ObtenerTodos()
        {
            List<Empleados> empleados = new List<Empleados>();

            try
            {
                using (StreamReader sr =
            new StreamReader(_nombreArchivo))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] datos = linea.Split(',');
                        Empleados empleado = new Empleados
                        {
                            Nombre = datos[0],
                            Edad = Convert.ToInt32(datos[1]),
                            Puesto=datos[2],
                        };
                        empleados.Add(empleado);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error al leer el archivo" +
                    e.Message);
            }

            return empleados;
        }
    }
}
