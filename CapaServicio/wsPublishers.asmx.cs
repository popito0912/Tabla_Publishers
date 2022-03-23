using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using CapaNegocio;
using CapaEntidad;
using System.Data;

namespace CapaServicio
{
    /// <summary>
    /// Descripción breve de wsPublishers
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsPublishers : System.Web.Services.WebService
    {

        [WebMethod(Description ="Listar Publishers")]
        public DataSet ListarPublishers()
        {
            PublishersBL publishers = new PublishersBL();
            return publishers.Listar();
        }

        [WebMethod(Description = "Agregar Publishers")]
        public string[] AgregarPublishers(string Id, string Name, string City, string State, string Country)
        {
            PublishersBL publishersBL = new PublishersBL();
            Publishers publishers = new Publishers();
            publishers.Id = Id;
            publishers.Name = Name;
            publishers.City = City;
            publishers.State = State;
            publishers.Country = Country;
            string[] valores = new string[2];
            valores[0] = publishersBL.Agregar(publishers).ToString();
            valores[1] = publishersBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Actualizar Publishers")]
        public string[] ActualizarPublishers(string Id, string Name, string City, string State, string Country)
        {
            PublishersBL publishersBL = new PublishersBL();
            Publishers publishers = new Publishers();
            publishers.Id = Id;
            publishers.Name = Name;
            publishers.City = City;
            publishers.State = State;
            publishers.Country = Country;
            string[] valores = new string[2];
            valores[0] = publishersBL.Actualizar(publishers).ToString();
            valores[1] = publishersBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Eliminar Publishers")]
        public string[] EliminarPublishers(string id)
        {
            PublishersBL publishersBL = new PublishersBL();
            string[] valores = new string[2];
            valores[0] = publishersBL.Eliminar(id).ToString();
            valores[1] = publishersBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Buscar Publishers")]
        public DataSet BuscarPublishers(string texto, string criterio)
        {
            PublishersBL escuela = new PublishersBL();
            return escuela.Buscar(texto, criterio);
        }
        //-------------------------------------- STORES ------------------------------------//
        [WebMethod(Description = "Listar Stores")]
        public DataSet ListarStores()
        {
            StoresBL stores = new StoresBL();
            return stores.Listar();
        }

        [WebMethod(Description = "Agregar Stores")]
        public string[] AgregarStores(string Id, string Name, string Address, string City, string State, string Zip)
        {
            StoresBL storesBL = new StoresBL();
            Stores stores = new Stores();
            stores.Id = Id;
            stores.Name = Name;
            stores.Address = Address;
            stores.City = City;
            stores.State = State;
            stores.Zip = Zip;
            string[] valores = new string[2];
            valores[0] = storesBL.Agregar(stores).ToString();
            valores[1] = storesBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Eliminar Stores")]
        public string[] EliminarStores(string id)
        {
            StoresBL storesBL = new StoresBL();
            string[] valores = new string[2];
            valores[0] = storesBL.Eliminar(id).ToString();
            valores[1] = storesBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Actualizar Stores")]
        public string[] ActualizarStores(string Id, string Name, string Address, string City, string State, string Zip)
        {
            StoresBL storesBL = new StoresBL();
            Stores stores = new Stores();
            stores.Id = Id;
            stores.Name = Name;
            stores.Address = Address;
            stores.City = City;
            stores.State = State;
            stores.Zip = Zip;
            string[] valores = new string[2];
            valores[0] = storesBL.Actualizar(stores).ToString();
            valores[1] = storesBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Buscar stores")]
        public DataSet BuscarStores(string texto, string criterio)
        {
            StoresBL stores = new StoresBL();
            return stores.Buscar(texto, criterio);
        }

        //-------------------------------------- JOBS ------------------------------------//
        [WebMethod(Description = "Listar Jobs")]
        public DataSet ListarJobs()
        {
            JobsBL jobs = new JobsBL();
            return jobs.Listar();
        }

        [WebMethod(Description = "Agregar Jobs")]
        public string[] AgregarJobs(string Id, string Descripcion, string Min1, string Max1)
        {
            JobsBL jobsBL = new JobsBL();
            Jobs jobs = new Jobs();
            jobs.Id = Id;
            jobs.Descripcion = Descripcion;
            jobs.Min1 = Min1;
            jobs.Max1 = Max1;
            
            string[] valores = new string[2];
            valores[0] = jobsBL.Agregar(jobs).ToString();
            valores[1] = jobsBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Eliminar Jobs")]
        public string[] EliminarJobs(string id)
        {
            JobsBL jobsBL = new JobsBL();
            string[] valores = new string[2];
            valores[0] = jobsBL.Eliminar(id).ToString();
            valores[1] = jobsBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Actualizar Jobs")]
        public string[] ActualizarJobs(string Id, string Descripcion, string Min1, string Max1)
        {
            JobsBL jobsBL = new JobsBL();
            Jobs jobs = new Jobs();
            jobs.Id = Id;
            jobs.Descripcion = Descripcion;
            jobs.Min1 = Min1;
            jobs.Max1 = Max1;
            string[] valores = new string[2];
            valores[0] = jobsBL.Actualizar(jobs).ToString();
            valores[1] = jobsBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Buscar Jobs")]
        public DataSet BuscarJobs(string texto, string criterio)
        {
            JobsBL jobs = new JobsBL();
            return jobs.Buscar(texto, criterio);
        }
    }
}
