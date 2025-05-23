using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dominio;
using Gestion;
using api_catalogoproductos.Dto;

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
        public void Post([FromBody]ArticuloDto art)
        {
            GestionArticulos gestion = new GestionArticulos();
            Articulo nuevoArticulo = new Articulo();
            nuevoArticulo.Nombre = art.Nombre;
            nuevoArticulo.Descripcion = art.Descripcion;
            nuevoArticulo.IDArticulo = art.IDArticulo;
            nuevoArticulo.codArticulo = art.codArticulo;
            nuevoArticulo.Precio = art.Precio;
            nuevoArticulo.Categoria = new Categoria { Id = art.IdCategoria };
            nuevoArticulo.Marca = new Marca { Id = art.IdMarca };

            gestion.AgregarArticulos(nuevoArticulo);
            
        }

        // PUT: api/CatalogoProductos/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CatalogoProductos/5
        public void Delete(int id)
        {
            GestionArticulos gestion = new GestionArticulos();
            gestion.EliminarArticulos(id);
        }
    }
}
