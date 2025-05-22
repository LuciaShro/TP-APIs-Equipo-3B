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
    public partial class SeccionAgregarCategoria : Form
    {

        private Categoria categoria = null;
        public SeccionAgregarCategoria()
        {
            InitializeComponent();
            
        }

        public SeccionAgregarCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            Text = "Modificar Categoria";
        }
        private void btnCancelarCategoria_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarCategoria_Click(object sender, EventArgs e)
        {
            GestionCategoria gestionCat = new GestionCategoria();
            try
            {
                if(categoria== null)
                    categoria = new Categoria();


                categoria.Nombre = txtAgregarCategoria.Text;


                if (categoria.Id != 0)
                {
                    gestionCat.modificarCategoria(categoria);
                    MessageBox.Show("Modificado Exitosamente");
                }

                else
                {
                    gestionCat.agregarCategoria(categoria);
                    MessageBox.Show("Agregado Exitosamente");
                }

                Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SeccionAgregarCategoria_Load(object sender, EventArgs e)
        {

            try
            {
                if (categoria != null)
                {
                    
                    txtAgregarCategoria.Text = categoria.Nombre;
                    
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
