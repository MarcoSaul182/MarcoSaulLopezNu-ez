using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividades.Modelo.Cinema
{
    class MockObjetos
    {
        public static Sala[] coleccionSalas()
        {
            Sala[] colSalas = new Sala[5]; //Tamaño de la sala
            colSalas[0] = new Sala();
            colSalas[1] = new Sala(200);
            colSalas[2] = new Sala(200, "Sala A");
            colSalas[3] = new Sala(200, "Sala B");
            colSalas[4] = new Sala(200, "Sala C");

            return colSalas;
        }

        public List<Empleado> coleccionEmpleados()
        {
            List<Empleado> coleccionEmpleados = new List<Empleado>();
            Persona person1 = new Persona();


            Empleado emp1 = new Empleado();
            coleccionEmpleados.Add(emp1);

            for (int i=1; i <= 100; i++)
            {
                coleccionEmpleados.Add(new Empleado());
            }

            return coleccionEmpleados;
        }
    }
}
