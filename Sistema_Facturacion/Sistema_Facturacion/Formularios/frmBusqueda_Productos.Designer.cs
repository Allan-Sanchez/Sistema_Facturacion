namespace Sistema_Facturacion.Formularios
{
    partial class frmBusqueda_Productos
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAcentar = new System.Windows.Forms.Button();
            this.rbtnIdproducto = new System.Windows.Forms.RadioButton();
            this.rbtnDescripcion = new System.Windows.Forms.RadioButton();
            this.txtFiltro_Busqueda = new System.Windows.Forms.TextBox();
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::Sistema_Facturacion.Properties.Resources.delete__2_;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(407, 374);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 33);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAcentar
            // 
            this.btnAcentar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAcentar.Image = global::Sistema_Facturacion.Properties.Resources.checkmark;
            this.btnAcentar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAcentar.Location = new System.Drawing.Point(305, 374);
            this.btnAcentar.Name = "btnAcentar";
            this.btnAcentar.Size = new System.Drawing.Size(79, 33);
            this.btnAcentar.TabIndex = 4;
            this.btnAcentar.Text = "&Aceptar";
            this.btnAcentar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcentar.UseVisualStyleBackColor = true;
            this.btnAcentar.Click += new System.EventHandler(this.btnAcentar_Click);
            // 
            // rbtnIdproducto
            // 
            this.rbtnIdproducto.AutoSize = true;
            this.rbtnIdproducto.Checked = true;
            this.rbtnIdproducto.Location = new System.Drawing.Point(12, 23);
            this.rbtnIdproducto.Name = "rbtnIdproducto";
            this.rbtnIdproducto.Size = new System.Drawing.Size(82, 17);
            this.rbtnIdproducto.TabIndex = 0;
            this.rbtnIdproducto.TabStop = true;
            this.rbtnIdproducto.Text = "ID &Producto";
            this.rbtnIdproducto.UseVisualStyleBackColor = true;
            this.rbtnIdproducto.CheckedChanged += new System.EventHandler(this.rbtnIdproducto_CheckedChanged);
            // 
            // rbtnDescripcion
            // 
            this.rbtnDescripcion.AutoSize = true;
            this.rbtnDescripcion.Location = new System.Drawing.Point(114, 23);
            this.rbtnDescripcion.Name = "rbtnDescripcion";
            this.rbtnDescripcion.Size = new System.Drawing.Size(81, 17);
            this.rbtnDescripcion.TabIndex = 1;
            this.rbtnDescripcion.Text = "&Descripcion";
            this.rbtnDescripcion.UseVisualStyleBackColor = true;
            this.rbtnDescripcion.CheckedChanged += new System.EventHandler(this.rbtnDescripcion_CheckedChanged);
            // 
            // txtFiltro_Busqueda
            // 
            this.txtFiltro_Busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltro_Busqueda.Location = new System.Drawing.Point(216, 20);
            this.txtFiltro_Busqueda.Name = "txtFiltro_Busqueda";
            this.txtFiltro_Busqueda.Size = new System.Drawing.Size(251, 20);
            this.txtFiltro_Busqueda.TabIndex = 2;
            this.txtFiltro_Busqueda.TextChanged += new System.EventHandler(this.txtFiltro_Busqueda_TextChanged);
            // 
            // dgvBusqueda
            // 
            this.dgvBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda.Location = new System.Drawing.Point(22, 86);
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.ReadOnly = true;
            this.dgvBusqueda.Size = new System.Drawing.Size(457, 242);
            this.dgvBusqueda.TabIndex = 3;
            // 
            // frmBusqueda_Productos
            // 
            this.AcceptButton = this.btnAcentar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(498, 419);
            this.Controls.Add(this.dgvBusqueda);
            this.Controls.Add(this.txtFiltro_Busqueda);
            this.Controls.Add(this.rbtnDescripcion);
            this.Controls.Add(this.rbtnIdproducto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAcentar);
            this.Name = "frmBusqueda_Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Busqueda Productos";
            this.Load += new System.EventHandler(this.frmBusqueda_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAcentar;
        private System.Windows.Forms.RadioButton rbtnIdproducto;
        private System.Windows.Forms.RadioButton rbtnDescripcion;
        private System.Windows.Forms.TextBox txtFiltro_Busqueda;
        private System.Windows.Forms.DataGridView dgvBusqueda;
    }
}