using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion;
using Dominio;

namespace Actividad2PrograIII
{
    
    public partial class SeccionArticulos : Form
    {
        private List<Articulo> listaArticulo;
        public SeccionArticulos()
        {
            InitializeComponent();
            Text = "Articulos";
        }

        private void SeccionArticulos_Load(object sender, EventArgs e)
        {
            Cargar();
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Categoria");
        }

        private void Cargar()
        {
            GestionArticulos gestion = new GestionArticulos();
            listaArticulo = gestion.listar(); //DataSourse -> grilla de datos
            dgvArticulos.DataSource = listaArticulo;
            ocultarColumnas();
            dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "C2";
            cargarImagen(listaArticulo[0].Imagen.ImagenURL);
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Imagen"].Visible = false;
            dgvArticulos.Columns["IDArticulo"].Visible = false;
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.Imagen.ImagenURL);
            }
        }

        private void cargarImagen (string imagen)
        {
            try
            {
                pictureBoxArt.Load(imagen);
            }
            catch (Exception ex)
            {
                pictureBoxArt.Load("https://media.istockphoto.com/id/1415203156/es/vector/p%C3%A1gina-de-error-icono-vectorial-de-p%C3%A1gina-no-encontrada-en-el-dise%C3%B1o-de-estilo-de-l%C3%ADnea.jpg?s=612x612&w=0&k=20&c=nss_aWPtTb0hpc4oiGfFs_PGfihrNwVX06wxkWVkBfQ=");
            }
        }

        private void btnAgregarArt_Click(object sender, EventArgs e)
        {
            SeccionAgregarArtcs alta = new SeccionAgregarArtcs();
            alta.ShowDialog();
            Cargar();
        }

        private void btnEditarArt_Click(object sender, EventArgs e)
        {

            Articulo seleccionado; 
            if (dgvArticulos.CurrentRow != null)
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                SeccionAgregarArtcs editar = new SeccionAgregarArtcs(seleccionado);
                editar.ShowDialog();
                Cargar();
            }
            else
            {
                MessageBox.Show("Selecciona un articulo para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnEliminarArt_Click(object sender, EventArgs e)
        {
            GestionArticulos GestionArt = new GestionArticulos();
            Articulo seleccionado;
            try
            {
                if(dgvArticulos.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿Estas seguro que deseas eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                        GestionArt.EliminarArticulos(seleccionado.IDArticulo);
                        Cargar();
                    }

                }
                else
                {
                    MessageBox.Show("Selecciona un articulo para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // continuar con filtrar 
        private void btnFiltroArt_Click(object sender, EventArgs e)
        {
            
        }

        private void txtBoxBuscarArt_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaArtFiltrada;
            string filtro = txtBoxBuscarArt.Text;

            if (filtro!= "")
            {
                listaArtFiltrada = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaArtFiltrada = listaArticulo;
            }



            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaArtFiltrada;
            ocultarColumnas();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();

                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
 
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

            GestionArticulos gestion = new GestionArticulos();

            try
            {
                if (validaciones())
                    return;
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFlitro.Text;
                dgvArticulos.DataSource = gestion.Filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            
        }

        private void btnDetalleArt_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;

            if(dgvArticulos.CurrentRow != null)
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                SeccionDetalleArt detalle = new SeccionDetalleArt(seleccionado);
                detalle.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecciona un artículo para ver el detalle.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private bool validaciones()
        {
            if (cboCampo.SelectedItem == null && cboCriterio.SelectedItem == null && string.IsNullOrEmpty(txtFlitro.Text))
            {
                MessageBox.Show("Los campos se encuentran vacios para filtrar. Completalos para continuar.");
                return true;
            }

            if(cboCampo.SelectedItem == null)
            {
                MessageBox.Show("Campo se encuentra vacio. Completa para continuar");
                return true;
            }

            if(cboCriterio.SelectedItem == null)
            {
                MessageBox.Show("Criterio se encuentra vacio. Completa para continuar");
                return true;
            }

            if (string.IsNullOrEmpty(txtFlitro.Text))
            {
                MessageBox.Show("Completa el filtro para continuar");
                return true;
            }


            return false;
        }

        private void btnLimpiarArt_Click(object sender, EventArgs e)
        {
            GestionArticulos gestion = new GestionArticulos();

            dgvArticulos.DataSource = gestion.Filtrar("", "", " ");
            txtFlitro.Text = "";
            txtBoxBuscarArt.Text = "";
            Cargar();

        }

        //private void MostrarDetalleArticulo()
        //{
        //    Articulo seleccionado;
        //    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
        //    SeccionDetalleArt detalle = new SeccionDetalleArt(seleccionado);
        //    detalle.ShowDialog();
        //}
    }
}
