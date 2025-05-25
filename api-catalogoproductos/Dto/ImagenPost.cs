using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dominio;

namespace api_catalogoproductos.Dto
{
    public class ImagenPost
    {
        public int IdProducto { get; set; }
        public List<ImagenDTO> Img { get; set; }
    }
}