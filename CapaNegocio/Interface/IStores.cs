using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Data;

namespace CapaNegocio.Interface
{
    internal interface IStores
    {
        DataSet Listar();
        bool Agregar(Stores stores);
        bool Eliminar(string id);
        bool Actualizar(Stores stores);
        DataSet Buscar(string texto, string criterio);
    }
}
