using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Data;

namespace CapaNegocio.Interface
{
    internal interface IJobs
    {
        DataSet Listar();
        bool Agregar(Jobs jobs);
        bool Eliminar(string id);
        bool Actualizar(Jobs jobs);
        DataSet Buscar(string texto, string criterio);
    }
}
