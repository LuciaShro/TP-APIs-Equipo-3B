namespace Actividad2PrograIII
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnArticulos = new System.Windows.Forms.Button();
            this.lblText1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelInicio = new System.Windows.Forms.Panel();
            this.panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.CadetBlue;
            this.panelLateral.Controls.Add(this.btnCategorias);
            this.panelLateral.Controls.Add(this.btnMarcas);
            this.panelLateral.Controls.Add(this.btnArticulos);
            this.panelLateral.Controls.Add(this.lblText1);
            this.panelLateral.Controls.Add(this.pictureBox2);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(207, 703);
            this.panelLateral.TabIndex = 1;
            // 
            // btnCategorias
            // 
            this.btnCategorias.Location = new System.Drawing.Point(12, 359);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(178, 46);
            this.btnCategorias.TabIndex = 6;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnMarcas
            // 
            this.btnMarcas.Location = new System.Drawing.Point(14, 291);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(178, 46);
            this.btnMarcas.TabIndex = 5;
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.UseVisualStyleBackColor = true;
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click);
            // 
            // btnArticulos
            // 
            this.btnArticulos.Location = new System.Drawing.Point(12, 225);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(178, 46);
            this.btnArticulos.TabIndex = 4;
            this.btnArticulos.Text = "Articulos";
            this.btnArticulos.UseVisualStyleBackColor = true;
            this.btnArticulos.Click += new System.EventHandler(this.btnArticulos_Click);
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText1.ForeColor = System.Drawing.SystemColors.Window;
            this.lblText1.Location = new System.Drawing.Point(10, 109);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(184, 22);
            this.lblText1.TabIndex = 3;
            this.lblText1.Text = "Sistema de Gestión";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(201, 131);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panelInicio
            // 
            this.panelInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInicio.Location = new System.Drawing.Point(207, 0);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.Size = new System.Drawing.Size(1182, 703);
            this.panelInicio.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1389, 703);
            this.Controls.Add(this.panelInicio);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.label1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.Panel panelInicio;
    }
}

