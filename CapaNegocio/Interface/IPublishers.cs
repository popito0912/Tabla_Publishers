using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Data;

namespace CapaNegocio.Interface
{
    internal interface IPublishers
    {
        DataSet Listar();
        bool Agregar(Publishers publishers);
        bool Eliminar(string id);
        bool Actualizar(Publishers publishers);
        DataSet Buscar(string texto, string criterio);
    }
}
