using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Jobs
    {
        //atributos de la clase
        private string id;
        private string descripcion;
        private string Min;
        private string Max;

        public string Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Min1 { get => Min; set => Min = value; }
        public string Max1 { get => Max; set => Max = value; }
    }
}
