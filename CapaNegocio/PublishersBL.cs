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
    public class PublishersBL : Interface.IPublishers
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
        public bool Actualizar(Publishers publishers)
        {
            DataRow fila = datos.TraerDataRow("spActualizarPublishers ", 
                publishers.Id, publishers.Name, publishers.City, publishers.State, publishers.Country);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public bool Agregar(Publishers publishers)
        {
            DataRow fila = datos.TraerDataRow("spAgregarPublishers",
                publishers.Id, publishers.Name, publishers.City, publishers.State, publishers.Country);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarPublishers", texto, criterio);
        }

        public bool Eliminar(string id)
        {
            DataRow fila = datos.TraerDataRow("spEliminarPublishers", id);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarPublishers");
        }
    }
}
