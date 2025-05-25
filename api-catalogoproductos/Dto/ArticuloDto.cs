using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dominio;

namespace api_catalogoproductos.Dto
{

    public class ArticuloDto
    {
        private int _idArticulo;
        private string _codArticulo;
        private string _nombre;
        private string _descripcion;
        private decimal _precio;

        public int IDArticulo { get { return _idArticulo; } set { _idArticulo = value; } }

        public string codArticulo { get { return _codArticulo; } set { _codArticulo = value; } }

        public string Nombre { get { return _nombre; } set { _nombre = value; } }

        public string Descripcion { get { return _descripcion; } set { _descripcion = value; } }

        public decimal Precio
        {
            get { return _precio; }
            set
            {
                if (value >= 0)
                    _precio = value;
            }

        }

        public int IdMarca { get; set; }

        public int IdCategoria { get; set; }

        //public int IdImagen { get; set; }

        public string ImagenURL { get; set; }


    }
}