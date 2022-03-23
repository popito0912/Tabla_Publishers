using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato;
using CapaEntidad;

namespace CapaNegocio
{
    public class StoresBL : Interface.IStores
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


        public bool Actualizar(Stores stores)
        {
            DataRow fila = datos.TraerDataRow("spActualizarstores ",
                 stores.Id, stores.Name, stores.Address, stores.City, stores.State, stores.Zip);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public bool Agregar(Stores stores)
        {
            DataRow fila = datos.TraerDataRow("spAgregarstores",
                stores.Id, stores.Name, stores.Address, stores.City, stores.State, stores.Zip);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarstores", texto, criterio);
        }

        public bool Eliminar(string id)
        {
            DataRow fila = datos.TraerDataRow("spEliminarstores", id);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarstores");
        }
    }
}
