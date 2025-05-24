using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Gestion
{
    public class GestionImagen
    {
        // agregar imagen

        public void AgregarImagen (Imagen imagen, int idArticulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("INSERT INTO IMAGENES (IDArticulo,ImagenUrl) VALUES (@IDArticulo, @ImagenURL)");
                datos.setearParametro("@IDArticulo", idArticulo);
                datos.setearParametro("@ImagenURL", imagen.ImagenURL);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

        // modificar imagen

        public bool ModificarImagen(Imagen imagen)
        { 
            return false;
        
        }

        // eliminar imagen

         public bool EliminarImagen (int idImagen)
        {
            return false;
        }
    }
}
