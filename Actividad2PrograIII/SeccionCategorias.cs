using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Gestion;

namespace Actividad2PrograIII
{
    public partial class SeccionCategorias : Form
    {
        private List<Categoria> ListaCategorias;
        public SeccionCategorias()
        {
            InitializeComponent();
            Text = "Categorias";
        }

        private void SeccionCategorias_Load(object sender, EventArgs e)
        {
            cargar();

        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            SeccionAgregarCategoria agregarCat = new SeccionAgregarCategoria();
            agregarCat.ShowDialog();
            cargar();
        }

        private void cargar()
        {
            GestionCategoria categoria = new GestionCategoria();
            ListaCategorias = categoria.listarCategoria();
            dgvCategorias.DataSource = categoria.listarCategoria();
            dgvCategorias.Columns["Id"].Visible = false;
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            Categoria seleccionada;
            if(dgvCategorias.CurrentRow != null)
            {
                seleccionada = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;

                SeccionAgregarCategoria editarCat = new SeccionAgregarCategoria(seleccionada);
                editarCat.ShowDialog();
                cargar();
            }
            else
            {
                MessageBox.Show("Selecciona una Categoria para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarCategoriaFisico_Click(object sender, EventArgs e)
        {

            GestionCategoria categoria = new GestionCategoria();
            Categoria seleccionado;


            try
            {
                if(dgvCategorias.CurrentRow != null)
                {
                    DialogResult resultado = MessageBox.Show("¿Estas seguro que queres eliminar esta categoría?", "Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                        categoria.eliminarCategoria(seleccionado.Id);
                        cargar();
                    }
                }
               else
                {
                    MessageBox.Show("Selecciona una Categoria para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnFiltrarCategoria_Click(object sender, EventArgs e)
        {
        }

        private void txtboxFiltrarCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtboxFiltrarCategoria_TextChanged(object sender, EventArgs e)
        {
            List<Categoria> listaFiltrada;
            string filtro = txtboxFiltrarCategoria.Text;

            if (filtro != "")
            {
                listaFiltrada = ListaCategorias.FindAll(c => c.Nombre.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = ListaCategorias;
            }


            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = listaFiltrada;
        }
    }
}
