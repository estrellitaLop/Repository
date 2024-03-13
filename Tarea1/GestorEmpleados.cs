using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    public class GestorEmpleados
    {
        private IEmpleadosRepository _repository;

        public GestorEmpleados(IEmpleadosRepository repository)
        {
            _repository = repository;
        }

        public List<Empleados> ObtenerTodosLosEmpleados()
        {
            return _repository.ObtenerTodos();

        }
        public void AgregarEmpleados(Empleados empleado)
        {
            List<Empleados> empleados = _repository.ObtenerTodos();
            empleados.Add(empleado);
            _repository.GuardarTodos(empleados);
        }
    }
}
