using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dominio;
using Gestion;

namespace api_catalogoproductos.Controllers
{
    public class CatalogoProductosController : ApiController
    {
        // GET: api/CatalogoProductos
        public IEnumerable<Articulo> Get()
        {
            GestionArticulos articulos = new GestionArticulos();
            return articulos.listar();
        }

        // GET: api/CatalogoProductos/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CatalogoProductos
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/CatalogoProductos/5
        public void Put(int id, [FromBody]Articulo arti)
        {
            GestionArticulos gestion = new GestionArticulos();
            Articulo articulo = new Articulo();
            articulo.codArticulo = arti.codArticulo;
            articulo.Nombre = arti.Nombre;
            articulo.Descripcion = arti.Descripcion;
            articulo.Precio = arti.Precio;
            articulo.Marca = new Marca { Nombre = arti.Marca} ;
            articulo.Categoria = new Categoria { Nombre = arti.Categoria } ;
            articulo.IDArticulo = id;

            gestion.ModificarArticulo(articulo);
        }

        // DELETE: api/CatalogoProductos/5
        public void Delete(int id)
        {
        }
    }
}
