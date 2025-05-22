using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad2PrograIII
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
            Text = "Inicio";
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new SeccionArticulos());

            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(SeccionArticulos))
                    return;
            }
            
            SeccionArticulos ventana = new SeccionArticulos();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new SeccionCategorias());

            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(SeccionCategorias)) 
                return;
            }

            SeccionCategorias ventana = new SeccionCategorias();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new SeccionMarca());

            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(SeccionMarca))
                    return;
            }

            SeccionMarca ventana = new SeccionMarca();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void AbrirFormulario(Form formularioHijo)
        {
            if (panelInicio.Controls.Count > 0)
               panelInicio.Controls.RemoveAt(0);

            formularioHijo.TopLevel = false; 
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;

            panelInicio.Controls.Add(formularioHijo);
            panelInicio.Tag = formularioHijo;

            formularioHijo.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
