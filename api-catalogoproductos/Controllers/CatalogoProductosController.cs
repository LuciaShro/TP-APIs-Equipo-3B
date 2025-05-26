using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dominio;
using Gestion;
using api_catalogoproductos.Dto;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;

namespace api_catalogoproductos.Controllers
{
    public class CatalogoProductosController : ApiController
    {
        // GET: api/CatalogoProductos
        [HttpGet]
        [Route("api/CatalogoProductos")]
        public IEnumerable<Articulo> Get()
        {
            GestionArticulos articulos = new GestionArticulos();
            return articulos.listar();
        }

        // GET: api/CatalogoProductos/5
        public HttpResponseMessage Get(int id)
        {
            GestionArticulos articulos = new GestionArticulos();
            try
            {
                Articulo articulo = articulos.BuscarArticuloPorId(id);

                if (articulo == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, $"Artículo con ID {id} no encontrado.");
                }

                return Request.CreateResponse(HttpStatusCode.OK, articulo);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Ocurrió un error inesperado al buscar el artículo.");
            }
        }

        // POST: api/CatalogoProductos
        [HttpPost]
        [Route("api/CatalogoProductos")]
        public HttpResponseMessage Post([FromBody]ArticuloDto art)
        {
            try
            {
                GestionArticulos gestion = new GestionArticulos();
                GestionCategoria gestionCategoria = new GestionCategoria();
                GestionMarca gestionMarca = new GestionMarca();

                if (art == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "El objeto ArticuloDto es null.");
                }

                Categoria categoria = gestionCategoria.listarCategoria().Find(x => x.Id == art.IdCategoria);
                Marca marca = gestionMarca.listarMarca().Find(x => x.Id == art.IdMarca);

                if (categoria == null)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "La categoria no existe.");

                if (marca == null)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "La marca no existe.");

                Articulo nuevoArticulo = new Articulo();

                nuevoArticulo.Nombre = art.Nombre;
                nuevoArticulo.Descripcion = art.Descripcion;
                //nuevoArticulo.IDArticulo = art.IDArticulo; no se agrega porque es autoincremental
                nuevoArticulo.codArticulo = art.codArticulo;
                nuevoArticulo.Precio = art.Precio;
                nuevoArticulo.Categoria = new Categoria { Id = art.IdCategoria };
                nuevoArticulo.Marca = new Marca { Id = art.IdMarca };
                //nuevoArticulo.Imagen = new Imagen { IDImagen = art.IdImagen };

                if (nuevoArticulo.Precio <= 0)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "El precio no puede ser 0 o negativo.");
                }
                else
                {
                    gestion.AgregarArticulos(nuevoArticulo);
                    return Request.CreateResponse(HttpStatusCode.OK, "Artículo creado con éxito.");
                }
            }
            catch (Exception ex) {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Ocurrió un error inesperado.");
            }

        }

        // agregar imagen al producto
        [HttpPost]
        [Route("api/CatalogoProductos/AgregarImagen")]
        public HttpResponseMessage PostImagen([FromBody]ImagenPost imgPost)
        {
            if (imgPost == null || imgPost.Img == null || !imgPost.Img.Any())
            {
               return Request.CreateResponse(HttpStatusCode.BadRequest, "No estamos recibiendo imagenes para continuar");
            }
            GestionImagen gestionImagen = new GestionImagen();
            GestionArticulos articulos = new GestionArticulos();

            int idArticulo = imgPost.IdProducto;

            Articulo articulo = articulos.listar().Find(x => x.IDArticulo == idArticulo);

            if (articulo== null)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "El id articulo no existe");
            }
            
            foreach (var imagen in imgPost.Img)
            {
                Imagen image = new Imagen();
                image.Articulo = new Articulo() { IDArticulo = idArticulo };
                image.ImagenURL = imagen.Url;


                gestionImagen.AgregarImagen(image, idArticulo);
            }

            return Request.CreateResponse(HttpStatusCode.OK, "Imagen agregada exitosamente.");
        }

        // PUT: api/CatalogoProductos/5
        public HttpResponseMessage Put(int id, [FromBody]ArticuloDto arti)
        {
            GestionArticulos gestion = new GestionArticulos();

            try
            {
                Articulo articulo = new Articulo();
                Articulo articulo2 = gestion.BuscarArticuloPorId(id);


                if (articulo2 == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, $"Artículo con ID {id} no encontrado.");
                }


                if (arti == null || arti.codArticulo == null || arti.Nombre == null || arti.Descripcion == null || arti.ImagenURL == null || arti.Precio < 0 || arti.IdMarca <= 0 || arti.IdCategoria <= 0)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "No estamos recibiendo los parametros correctos para continuar");
                }

                articulo.codArticulo = arti.codArticulo;
                articulo.Nombre = arti.Nombre;
                articulo.Descripcion = arti.Descripcion;
                articulo.Precio = arti.Precio;
                articulo.Marca = new Marca { Id = arti.IdMarca };
                articulo.Categoria = new Categoria { Id = arti.IdCategoria };
                articulo.IDArticulo = id;
                articulo.Imagen = new Imagen { ImagenURL = arti.ImagenURL };

                gestion.ModificarArticulo(articulo);
                return Request.CreateResponse(HttpStatusCode.OK, "Articulo modificado exitosamente.");

            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE: api/CatalogoProductos/5
        public HttpResponseMessage Delete(int id)
        {
            
            GestionArticulos gestion = new GestionArticulos();

            try
            {
                Articulo articulo = gestion.BuscarArticuloPorId(id);

                if (articulo == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, $"Artículo con ID {id} no encontrado.");
                }

                gestion.EliminarArticulos(id);
                return Request.CreateResponse(HttpStatusCode.OK, "Eliminado exitosamente.");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Ocurrió un error inesperado al eliminar el artículo.");
            }

            
        }
    }
}
