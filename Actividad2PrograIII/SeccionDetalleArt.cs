using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Gestion;

namespace Actividad2PrograIII
{
    public partial class SeccionDetalleArt : Form
    {
        private Articulo articulo = null;

        public SeccionDetalleArt()
        {
            InitializeComponent();
        }

        public SeccionDetalleArt(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void SeccionDetalleArt_Load(object sender, EventArgs e)
        {
            GestionArticulos gestionArticulos = new GestionArticulos();
            GestionCategoria cat = new GestionCategoria();
            GestionMarca marca = new GestionMarca();

            try
            {
                cmbCatDetalle.DataSource = cat.listarCategoria();
                cmbCatDetalle.ValueMember = "Id";
                cmbCatDetalle.DisplayMember = "Nombre";
                cmbMarcaDet.DataSource = marca.listarMarca();
                cmbMarcaDet.ValueMember = "Id";
                cmbMarcaDet.DisplayMember = "Nombre";

                if (articulo != null)
                {
                    txtboxId.Text = articulo.IDArticulo.ToString();
                    txtboxCod.Text = articulo.codArticulo;
                    txtboxNombre.Text = articulo.Nombre;
                    txtboxDesc.Text = articulo.Descripcion;
                    txtboxPrecio.Text = articulo.Precio.ToString();
                    cmbCatDetalle.SelectedValue = articulo.Categoria.Id;
                    cmbMarcaDet.SelectedValue = articulo.Marca.Id;
                }

                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) {}

        private void btnCloseDet_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
