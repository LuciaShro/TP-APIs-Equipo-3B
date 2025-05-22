namespace Actividad2PrograIII
{
    partial class SeccionMarca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMarcas = new System.Windows.Forms.Panel();
            this.lblMarcas = new System.Windows.Forms.Label();
            this.lblBuscarMarca = new System.Windows.Forms.Label();
            this.txtBoxBusMarca = new System.Windows.Forms.TextBox();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.btnEditarMarca = new System.Windows.Forms.Button();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.panelMarcas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMarcas
            // 
            this.panelMarcas.BackColor = System.Drawing.Color.CadetBlue;
            this.panelMarcas.Controls.Add(this.lblMarcas);
            this.panelMarcas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMarcas.Location = new System.Drawing.Point(0, 0);
            this.panelMarcas.Name = "panelMarcas";
            this.panelMarcas.Size = new System.Drawing.Size(1200, 74);
            this.panelMarcas.TabIndex = 1;
            // 
            // lblMarcas
            // 
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.Font = new System.Drawing.Font("Myanmar Text", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMarcas.Location = new System.Drawing.Point(4, 9);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Size = new System.Drawing.Size(197, 71);
            this.lblMarcas.TabIndex = 2;
            this.lblMarcas.Text = "MARCAS";
            // 
            // lblBuscarMarca
            // 
            this.lblBuscarMarca.AutoSize = true;
            this.lblBuscarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarMarca.Location = new System.Drawing.Point(101, 122);
            this.lblBuscarMarca.Name = "lblBuscarMarca";
            this.lblBuscarMarca.Size = new System.Drawing.Size(100, 29);
            this.lblBuscarMarca.TabIndex = 2;
            this.lblBuscarMarca.Text = "Buscar:";
            // 
            // txtBoxBusMarca
            // 
            this.txtBoxBusMarca.Location = new System.Drawing.Point(207, 126);
            this.txtBoxBusMarca.Name = "txtBoxBusMarca";
            this.txtBoxBusMarca.Size = new System.Drawing.Size(205, 26);
            this.txtBoxBusMarca.TabIndex = 7;
            this.txtBoxBusMarca.TextChanged += new System.EventHandler(this.txtBoxBusMarca_TextChanged);
            this.txtBoxBusMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxBusMarca_KeyPress);
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMarcas.Location = new System.Drawing.Point(106, 181);
            this.dgvMarcas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMarcas.MultiSelect = false;
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.RowHeadersWidth = 62;
            this.dgvMarcas.RowTemplate.Height = 28;
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(796, 322);
            this.dgvMarcas.TabIndex = 14;
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMarca.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnAgregarMarca.Location = new System.Drawing.Point(106, 547);
            this.btnAgregarMarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(216, 49);
            this.btnAgregarMarca.TabIndex = 20;
            this.btnAgregarMarca.Text = "Agregar";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // btnEditarMarca
            // 
            this.btnEditarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarMarca.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnEditarMarca.Location = new System.Drawing.Point(405, 547);
            this.btnEditarMarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditarMarca.Name = "btnEditarMarca";
            this.btnEditarMarca.Size = new System.Drawing.Size(216, 49);
            this.btnEditarMarca.TabIndex = 21;
            this.btnEditarMarca.Text = "Editar";
            this.btnEditarMarca.UseVisualStyleBackColor = true;
            this.btnEditarMarca.Click += new System.EventHandler(this.btnEditarMarca_Click);
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMarca.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnEliminarMarca.Location = new System.Drawing.Point(686, 547);
            this.btnEliminarMarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(216, 49);
            this.btnEliminarMarca.TabIndex = 22;
            this.btnEliminarMarca.Text = "Eliminar";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // SeccionMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 669);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.btnEditarMarca);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.dgvMarcas);
            this.Controls.Add(this.txtBoxBusMarca);
            this.Controls.Add(this.lblBuscarMarca);
            this.Controls.Add(this.panelMarcas);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SeccionMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeccionMarca";
            this.Load += new System.EventHandler(this.SeccionMarca_Load);
            this.panelMarcas.ResumeLayout(false);
            this.panelMarcas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMarcas;
        private System.Windows.Forms.Label lblBuscarMarca;
        private System.Windows.Forms.TextBox txtBoxBusMarca;
        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnEditarMarca;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Label lblMarcas;
    }
}