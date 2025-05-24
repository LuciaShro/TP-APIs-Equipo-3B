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
            nuevoArticulo.Imagen = new Imagen { IDImagen = art.IdImagen };

            gestion.AgregarArticulos(nuevoArticulo);
            
        }

        // PUT: api/CatalogoProductos/5
        public void Put(int id, [FromBody]ArticuloDto arti)
        {
            GestionArticulos gestion = new GestionArticulos();
            Articulo articulo = new Articulo();
            articulo.codArticulo = arti.codArticulo;
            articulo.Nombre = arti.Nombre;
            articulo.Descripcion = arti.Descripcion;
            articulo.Precio = arti.Precio;
            articulo.Marca = new Marca { Id = arti.IdMarca} ;
            articulo.Categoria = new Categoria { Id = arti.IdCategoria } ;
            articulo.IDArticulo = id;

            gestion.ModificarArticulo(articulo);
        }

        // DELETE: api/CatalogoProductos/5
        public void Delete(int id)
        {
            GestionArticulos gestion = new GestionArticulos();
            gestion.EliminarArticulos(id);
        }
    }
}
