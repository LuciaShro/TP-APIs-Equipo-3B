namespace Actividad2PrograIII
{
    partial class SeccionAgregarMarca
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
            this.pnlAgregarMarca = new System.Windows.Forms.Panel();
            this.lblAgregrMarca = new System.Windows.Forms.Label();
            this.lblDescripcionMarca = new System.Windows.Forms.Label();
            this.txtDescripcionMarca = new System.Windows.Forms.TextBox();
            this.btnAceptarMarca = new System.Windows.Forms.Button();
            this.btnCancelarMarca = new System.Windows.Forms.Button();
            this.pnlAgregarMarca.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAgregarMarca
            // 
            this.pnlAgregarMarca.BackColor = System.Drawing.Color.CadetBlue;
            this.pnlAgregarMarca.Controls.Add(this.lblAgregrMarca);
            this.pnlAgregarMarca.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAgregarMarca.Location = new System.Drawing.Point(0, 0);
            this.pnlAgregarMarca.Name = "pnlAgregarMarca";
            this.pnlAgregarMarca.Size = new System.Drawing.Size(710, 69);
            this.pnlAgregarMarca.TabIndex = 1;
            // 
            // lblAgregrMarca
            // 
            this.lblAgregrMarca.AutoSize = true;
            this.lblAgregrMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregrMarca.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAgregrMarca.Location = new System.Drawing.Point(21, 20);
            this.lblAgregrMarca.Name = "lblAgregrMarca";
            this.lblAgregrMarca.Size = new System.Drawing.Size(165, 29);
            this.lblAgregrMarca.TabIndex = 1;
            this.lblAgregrMarca.Text = "Nueva Marca";
            // 
            // lblDescripcionMarca
            // 
            this.lblDescripcionMarca.AutoSize = true;
            this.lblDescripcionMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionMarca.Location = new System.Drawing.Point(133, 220);
            this.lblDescripcionMarca.Name = "lblDescripcionMarca";
            this.lblDescripcionMarca.Size = new System.Drawing.Size(79, 25);
            this.lblDescripcionMarca.TabIndex = 11;
            this.lblDescripcionMarca.Text = "Marca:";
            // 
            // txtDescripcionMarca
            // 
            this.txtDescripcionMarca.Location = new System.Drawing.Point(246, 221);
            this.txtDescripcionMarca.Name = "txtDescripcionMarca";
            this.txtDescripcionMarca.Size = new System.Drawing.Size(313, 26);
            this.txtDescripcionMarca.TabIndex = 15;
            // 
            // btnAceptarMarca
            // 
            this.btnAceptarMarca.BackColor = System.Drawing.SystemColors.Window;
            this.btnAceptarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarMarca.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnAceptarMarca.Location = new System.Drawing.Point(213, 316);
            this.btnAceptarMarca.Name = "btnAceptarMarca";
            this.btnAceptarMarca.Size = new System.Drawing.Size(105, 40);
            this.btnAceptarMarca.TabIndex = 19;
            this.btnAceptarMarca.Text = "Aceptar";
            this.btnAceptarMarca.UseVisualStyleBackColor = false;
            this.btnAceptarMarca.Click += new System.EventHandler(this.btnAceptarMarca_Click);
            // 
            // btnCancelarMarca
            // 
            this.btnCancelarMarca.BackColor = System.Drawing.SystemColors.Window;
            this.btnCancelarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelarMarca.Location = new System.Drawing.Point(403, 314);
            this.btnCancelarMarca.Name = "btnCancelarMarca";
            this.btnCancelarMarca.Size = new System.Drawing.Size(102, 42);
            this.btnCancelarMarca.TabIndex = 20;
            this.btnCancelarMarca.Text = "Cancelar";
            this.btnCancelarMarca.UseVisualStyleBackColor = false;
            this.btnCancelarMarca.Click += new System.EventHandler(this.btnCancelarMarca_Click);
            // 
            // SeccionAgregarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 654);
            this.Controls.Add(this.btnCancelarMarca);
            this.Controls.Add(this.btnAceptarMarca);
            this.Controls.Add(this.txtDescripcionMarca);
            this.Controls.Add(this.lblDescripcionMarca);
            this.Controls.Add(this.pnlAgregarMarca);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SeccionAgregarMarca";
            this.Text = "SeccionAgregarMarca";
            this.Load += new System.EventHandler(this.SeccionAgregarMarca_Load);
            this.pnlAgregarMarca.ResumeLayout(false);
            this.pnlAgregarMarca.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAgregarMarca;
        private System.Windows.Forms.Label lblAgregrMarca;
        private System.Windows.Forms.Label lblDescripcionMarca;
        private System.Windows.Forms.TextBox txtDescripcionMarca;
        private System.Windows.Forms.Button btnAceptarMarca;
        private System.Windows.Forms.Button btnCancelarMarca;
    }
}