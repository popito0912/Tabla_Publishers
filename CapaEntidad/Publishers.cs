using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Publishers
    {
        //atributos de la clase
        private string id;
        private string name;
        private string city;
        private string state;
        private string country;


        // propiedades
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Country { get => country; set => country = value; }
    }
}
