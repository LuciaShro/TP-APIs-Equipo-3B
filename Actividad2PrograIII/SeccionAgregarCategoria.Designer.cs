namespace Actividad2PrograIII
{
    partial class SeccionAgregarCategoria
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
            this.pnlAgregarCategoria = new System.Windows.Forms.Panel();
            this.lblNuevaCategoria = new System.Windows.Forms.Label();
            this.lblAgregarCategoria = new System.Windows.Forms.Label();
            this.txtAgregarCategoria = new System.Windows.Forms.TextBox();
            this.btnAceptarCategoria = new System.Windows.Forms.Button();
            this.btnCancelarCategoria = new System.Windows.Forms.Button();
            this.pnlAgregarCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAgregarCategoria
            // 
            this.pnlAgregarCategoria.BackColor = System.Drawing.Color.CadetBlue;
            this.pnlAgregarCategoria.Controls.Add(this.lblNuevaCategoria);
            this.pnlAgregarCategoria.Location = new System.Drawing.Point(2, 0);
            this.pnlAgregarCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlAgregarCategoria.Name = "pnlAgregarCategoria";
            this.pnlAgregarCategoria.Size = new System.Drawing.Size(1200, 77);
            this.pnlAgregarCategoria.TabIndex = 0;
            // 
            // lblNuevaCategoria
            // 
            this.lblNuevaCategoria.AutoSize = true;
            this.lblNuevaCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblNuevaCategoria.ForeColor = System.Drawing.SystemColors.Window;
            this.lblNuevaCategoria.Location = new System.Drawing.Point(18, 20);
            this.lblNuevaCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuevaCategoria.Name = "lblNuevaCategoria";
            this.lblNuevaCategoria.Size = new System.Drawing.Size(208, 29);
            this.lblNuevaCategoria.TabIndex = 0;
            this.lblNuevaCategoria.Text = "Nueva Categoria";
            // 
            // lblAgregarCategoria
            // 
            this.lblAgregarCategoria.AutoSize = true;
            this.lblAgregarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAgregarCategoria.Location = new System.Drawing.Point(102, 208);
            this.lblAgregarCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgregarCategoria.Name = "lblAgregarCategoria";
            this.lblAgregarCategoria.Size = new System.Drawing.Size(119, 25);
            this.lblAgregarCategoria.TabIndex = 1;
            this.lblAgregarCategoria.Text = "Categoria: ";
            // 
            // txtAgregarCategoria
            // 
            this.txtAgregarCategoria.Location = new System.Drawing.Point(232, 208);
            this.txtAgregarCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAgregarCategoria.Name = "txtAgregarCategoria";
            this.txtAgregarCategoria.Size = new System.Drawing.Size(272, 26);
            this.txtAgregarCategoria.TabIndex = 2;
            // 
            // btnAceptarCategoria
            // 
            this.btnAceptarCategoria.BackColor = System.Drawing.SystemColors.Window;
            this.btnAceptarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarCategoria.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnAceptarCategoria.Location = new System.Drawing.Point(92, 366);
            this.btnAceptarCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAceptarCategoria.Name = "btnAceptarCategoria";
            this.btnAceptarCategoria.Size = new System.Drawing.Size(112, 35);
            this.btnAceptarCategoria.TabIndex = 3;
            this.btnAceptarCategoria.Text = "Aceptar";
            this.btnAceptarCategoria.UseVisualStyleBackColor = false;
            this.btnAceptarCategoria.Click += new System.EventHandler(this.btnAceptarCategoria_Click);
            // 
            // btnCancelarCategoria
            // 
            this.btnCancelarCategoria.BackColor = System.Drawing.SystemColors.Window;
            this.btnCancelarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelarCategoria.Location = new System.Drawing.Point(380, 366);
            this.btnCancelarCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelarCategoria.Name = "btnCancelarCategoria";
            this.btnCancelarCategoria.Size = new System.Drawing.Size(112, 35);
            this.btnCancelarCategoria.TabIndex = 4;
            this.btnCancelarCategoria.Text = "Cancelar";
            this.btnCancelarCategoria.UseVisualStyleBackColor = false;
            this.btnCancelarCategoria.Click += new System.EventHandler(this.btnCancelarCategoria_Click);
            // 
            // SeccionAgregarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 460);
            this.Controls.Add(this.btnCancelarCategoria);
            this.Controls.Add(this.btnAceptarCategoria);
            this.Controls.Add(this.txtAgregarCategoria);
            this.Controls.Add(this.lblAgregarCategoria);
            this.Controls.Add(this.pnlAgregarCategoria);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SeccionAgregarCategoria";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeccionAgregarCategoria";
            this.Load += new System.EventHandler(this.SeccionAgregarCategoria_Load);
            this.pnlAgregarCategoria.ResumeLayout(false);
            this.pnlAgregarCategoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAgregarCategoria;
        private System.Windows.Forms.Label lblNuevaCategoria;
        private System.Windows.Forms.Label lblAgregarCategoria;
        private System.Windows.Forms.TextBox txtAgregarCategoria;
        private System.Windows.Forms.Button btnAceptarCategoria;
        private System.Windows.Forms.Button btnCancelarCategoria;
    }
}