using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Gestion;
using static System.Net.Mime.MediaTypeNames;
using System.Configuration;
using System.Globalization;

namespace Actividad2PrograIII
{
    public partial class SeccionAgregarArtcs : Form
    {

        private Articulo articulo = null;
        private OpenFileDialog archivo = null;
        public SeccionAgregarArtcs()
        {
            InitializeComponent();
        }

        public SeccionAgregarArtcs(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar articulo";
        }

        private void btnCancelarArt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarArt_Click(object sender, EventArgs e)
        {
            //Articulo art = new Articulo();
            GestionArticulos gestion = new GestionArticulos();
            GestionCategoria cat = new GestionCategoria();
            GestionMarca marca = new GestionMarca();

            try
            {
                if (validarCampos())
                    return;
                if (articulo == null)
                   articulo = new Articulo();
                articulo.codArticulo = txbCodigoArt.Text;
                articulo.Nombre = txbNombreARt.Text;
                articulo.Descripcion = txbDescArt.Text;
                //articulo.Precio = decimal.Parse(txbPrecioArt.Text);
                articulo.Precio = decimal.Parse(txbPrecioArt.Text.Replace(".", ""));
                articulo.Marca = (Marca)txtMarcaArt.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Imagen = new Imagen();
                articulo.Imagen.ImagenURL = txbImgArt.Text;

                cargarImagen(txbImgArt.Text);

                if (articulo.IDArticulo != 0)
                {
                    gestion.ModificarArticulo(articulo);
                    MessageBox.Show("Modificado exitosamente");
                    Close();
                }
                else
                {
                    gestion.AgregarArticulos(articulo);
                    MessageBox.Show("Agregado exitosamente");
                }

                // guardar imagen si la levantó localmente

                if (archivo != null && !txbImgArt.Text.ToUpper().Contains("HTTP"))
                {
                    if (!Directory.Exists(ConfigurationManager.AppSettings["images-folder"])) 
                    {
                        Directory.CreateDirectory(ConfigurationManager.AppSettings["images-folder"]);
                    }
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName, true);
                }

                Close();
      

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void SeccionAgregarArtcs_Load(object sender, EventArgs e)
        {
            GestionArticulos art = new GestionArticulos();
            GestionCategoria cat = new GestionCategoria();
            GestionMarca marca = new GestionMarca();

            
            try
            { 
                cboCategoria.DataSource = cat.listarCategoria();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Nombre";
                txtMarcaArt.DataSource = marca.listarMarca();
                txtMarcaArt.ValueMember = "Id";
                txtMarcaArt.DisplayMember = "Nombre";

                txtMarcaArt.SelectedIndex = -1;
                cboCategoria.SelectedIndex = -1;

                if (articulo != null)
                {
                    txbCodigoArt.Text = articulo.codArticulo;
                    txbNombreARt.Text = articulo.Nombre;
                    txbDescArt.Text = articulo.Descripcion;
                    //txbPrecioArt.Text = articulo.Precio.ToString(C"0.00", CultureInfo.InvariantCulture);
                    txbPrecioArt.Text = articulo.Precio.ToString("#,0", CultureInfo.InvariantCulture);
                    //txbPrecioArt.Text = articulo.Precio.ToString();
                    txtMarcaArt.Text = articulo.Marca.Id.ToString();
                    //txbImgArt.Text = articulo.Marca.Id.ToString();
                    txbImgArt.Text = articulo.Imagen.ImagenURL;
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                    txtMarcaArt.SelectedValue = articulo.Marca.Id;
                    cargarImagen(articulo.Imagen.ImagenURL);
                    


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pboAgregar.Load(imagen);
            }
            catch (Exception)
            {
                pboAgregar.Load("https://media.istockphoto.com/id/1415203156/es/vector/p%C3%A1gina-de-error-icono-vectorial-de-p%C3%A1gina-no-encontrada-en-el-dise%C3%B1o-de-estilo-de-l%C3%ADnea.jpg?s=612x612&w=0&k=20&c=nss_aWPtTb0hpc4oiGfFs_PGfihrNwVX06wxkWVkBfQ=");
            }
        }

        private void txbImgArt_Leave(object sender, EventArgs e)
        {
            cargarImagen(txbImgArt.Text);
        }

        private bool validarCampos()
        {
            if(cboCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione una categoria.");
                return true;
            }
            if(txtMarcaArt.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione una marca");
                return true;
            }

            if (string.IsNullOrEmpty(txbCodigoArt.Text) || string.IsNullOrEmpty(txbNombreARt.Text) || string.IsNullOrEmpty(txbCodigoArt.Text) ||
                string.IsNullOrEmpty(txbDescArt.Text) || string.IsNullOrEmpty(txbPrecioArt.Text))
            {
                MessageBox.Show("Hay campos vacios.");
                return true;
            }
            string precioTexto = txbPrecioArt.Text.Replace(".", "");

            if (!decimal.TryParse(precioTexto, out _))
            {
                MessageBox.Show("Ingreso inválido. El precio debe contener solo números y puntos como separadores de miles.");
                return true;
            }


            return false;
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK) 
            {
               txbImgArt.Text = archivo.FileName;
               cargarImagen(archivo.FileName);

                // guardar la imagen
                //File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);

            }
        }
    }
}
