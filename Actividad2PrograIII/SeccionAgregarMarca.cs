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
    public partial class SeccionAgregarMarca : Form
    {
        private Marca marca = null;

        public Marca Marca { get; set; }

        public SeccionAgregarMarca()
        {
            InitializeComponent();
        }

        public SeccionAgregarMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
            Text = "Modificar Marca";
        }

        private void btnCancelarMarca_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarMarca_Click(object sender, EventArgs e)
        {
            //Marca nuevamarca = new Marca();
            GestionMarca gestion = new GestionMarca();
            try
            {
                if(marca == null)
                    marca = new Marca();

                marca.Nombre=txtDescripcionMarca.Text;

                if(marca.Id != 0)
                {
                    gestion.ModificarMarca(marca);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    gestion.Agregar(marca);
                    MessageBox.Show("Nueva marca agregada exitosamente");
                }
                    
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void SeccionAgregarMarca_Load(object sender, EventArgs e)
        {
            if (marca != null)
            {
                txtDescripcionMarca.Text = marca.Nombre;
            }
        }
    }
}
