using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato;

namespace CapaNegocio
{
    public class JobsBL : Interface.IJobs
    {

        //Atributo que devuelve el mensaje del PA
        private string mensaje;

        // Propiedad de solo lectura
        public string Mensaje
        {
            get { return mensaje; }
        }

        //utilizar los archivos cs de la capa datos
        Datos datos = new DatosSQL();

        public bool Actualizar(Jobs jobs)
        {
            DataRow fila = datos.TraerDataRow("spActualizarJobs",
                jobs.Id, jobs.Descripcion, jobs.Min1, jobs.Max1);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public bool Agregar(Jobs jobs)
        {
            DataRow fila = datos.TraerDataRow("spAgregarJobs",
                jobs.Id, jobs.Descripcion, jobs.Min1, jobs.Max1);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarJobs", texto, criterio);
        }

        public bool Eliminar(string id)
        {
            DataRow fila = datos.TraerDataRow("spEliminarJobs", id);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarJobs");
        }
    }
}
