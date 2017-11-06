namespace Sistema_Facturacion.Formularios
{
    partial class frmbusque_Cliente
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbusque_Cliente));
            this.dgvBusqueda_cliente = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAcentar = new System.Windows.Forms.Button();
            this.fillByIDClienteToolStrip = new System.Windows.Forms.ToolStrip();
            this.iDClienteToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.iDClienteToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByIDClienteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByNombresToolStrip = new System.Windows.Forms.ToolStrip();
            this.nombresToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nombresToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByNombresToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByApellidosToolStrip = new System.Windows.Forms.ToolStrip();
            this.apellidosToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.apellidosToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByApellidosToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.iDClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturacionDataSet = new Sistema_Facturacion.FacturacionDataSet();
            this.clienteTableAdapter = new Sistema_Facturacion.FacturacionDataSetTableAdapters.ClienteTableAdapter();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda_cliente)).BeginInit();
            this.fillByIDClienteToolStrip.SuspendLayout();
            this.fillByNombresToolStrip.SuspendLayout();
            this.fillByApellidosToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturacionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBusqueda_cliente
            // 
            this.dgvBusqueda_cliente.AllowUserToAddRows = false;
            this.dgvBusqueda_cliente.AllowUserToDeleteRows = false;
            this.dgvBusqueda_cliente.AllowUserToOrderColumns = true;
            this.dgvBusqueda_cliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBusqueda_cliente.AutoGenerateColumns = false;
            this.dgvBusqueda_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda_cliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDClienteDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.fechaNacimientoDataGridViewTextBoxColumn,
            this.cupoDataGridViewTextBoxColumn});
            this.dgvBusqueda_cliente.DataSource = this.clienteBindingSource;
            this.dgvBusqueda_cliente.Location = new System.Drawing.Point(12, 92);
            this.dgvBusqueda_cliente.Name = "dgvBusqueda_cliente";
            this.dgvBusqueda_cliente.ReadOnly = true;
            this.dgvBusqueda_cliente.Size = new System.Drawing.Size(745, 265);
            this.dgvBusqueda_cliente.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::Sistema_Facturacion.Properties.Resources.delete__2_;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(668, 372);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 33);
            this.btnCancelar.TabIndex = 7;
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
            this.btnAcentar.Location = new System.Drawing.Point(565, 372);
            this.btnAcentar.Name = "btnAcentar";
            this.btnAcentar.Size = new System.Drawing.Size(79, 33);
            this.btnAcentar.TabIndex = 6;
            this.btnAcentar.Text = "&Aceptar";
            this.btnAcentar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcentar.UseVisualStyleBackColor = true;
            this.btnAcentar.Click += new System.EventHandler(this.btnAcentar_Click);
            // 
            // fillByIDClienteToolStrip
            // 
            this.fillByIDClienteToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iDClienteToolStripLabel,
            this.iDClienteToolStripTextBox,
            this.fillByIDClienteToolStripButton,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.fillByIDClienteToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByIDClienteToolStrip.Name = "fillByIDClienteToolStrip";
            this.fillByIDClienteToolStrip.Size = new System.Drawing.Size(769, 25);
            this.fillByIDClienteToolStrip.TabIndex = 8;
            this.fillByIDClienteToolStrip.Text = "fillByIDClienteToolStrip";
            // 
            // iDClienteToolStripLabel
            // 
            this.iDClienteToolStripLabel.Name = "iDClienteToolStripLabel";
            this.iDClienteToolStripLabel.Size = new System.Drawing.Size(58, 22);
            this.iDClienteToolStripLabel.Text = "IDCliente:";
            // 
            // iDClienteToolStripTextBox
            // 
            this.iDClienteToolStripTextBox.Name = "iDClienteToolStripTextBox";
            this.iDClienteToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByIDClienteToolStripButton
            // 
            this.fillByIDClienteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByIDClienteToolStripButton.Name = "fillByIDClienteToolStripButton";
            this.fillByIDClienteToolStripButton.Size = new System.Drawing.Size(113, 22);
            this.fillByIDClienteToolStripButton.Text = "Filtrar por IDCliente";
            this.fillByIDClienteToolStripButton.Click += new System.EventHandler(this.fillByIDClienteToolStripButton_Click);
            // 
            // fillByNombresToolStrip
            // 
            this.fillByNombresToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombresToolStripLabel,
            this.nombresToolStripTextBox,
            this.fillByNombresToolStripButton,
            this.toolStripSeparator2});
            this.fillByNombresToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillByNombresToolStrip.Name = "fillByNombresToolStrip";
            this.fillByNombresToolStrip.Size = new System.Drawing.Size(769, 25);
            this.fillByNombresToolStrip.TabIndex = 9;
            this.fillByNombresToolStrip.Text = "fillByNombresToolStrip";
            // 
            // nombresToolStripLabel
            // 
            this.nombresToolStripLabel.Name = "nombresToolStripLabel";
            this.nombresToolStripLabel.Size = new System.Drawing.Size(59, 22);
            this.nombresToolStripLabel.Text = "Nombres:";
            // 
            // nombresToolStripTextBox
            // 
            this.nombresToolStripTextBox.Name = "nombresToolStripTextBox";
            this.nombresToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByNombresToolStripButton
            // 
            this.fillByNombresToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByNombresToolStripButton.Name = "fillByNombresToolStripButton";
            this.fillByNombresToolStripButton.Size = new System.Drawing.Size(114, 22);
            this.fillByNombresToolStripButton.Text = "Filtrar por Nombres";
            this.fillByNombresToolStripButton.Click += new System.EventHandler(this.fillByNombresToolStripButton_Click);
            // 
            // fillByApellidosToolStrip
            // 
            this.fillByApellidosToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apellidosToolStripLabel,
            this.apellidosToolStripTextBox,
            this.fillByApellidosToolStripButton,
            this.toolStripSeparator3});
            this.fillByApellidosToolStrip.Location = new System.Drawing.Point(0, 50);
            this.fillByApellidosToolStrip.Name = "fillByApellidosToolStrip";
            this.fillByApellidosToolStrip.Size = new System.Drawing.Size(769, 25);
            this.fillByApellidosToolStrip.TabIndex = 10;
            this.fillByApellidosToolStrip.Text = "fillByApellidosToolStrip";
            // 
            // apellidosToolStripLabel
            // 
            this.apellidosToolStripLabel.Name = "apellidosToolStripLabel";
            this.apellidosToolStripLabel.Size = new System.Drawing.Size(59, 22);
            this.apellidosToolStripLabel.Text = "Apellidos:";
            // 
            // apellidosToolStripTextBox
            // 
            this.apellidosToolStripTextBox.Name = "apellidosToolStripTextBox";
            this.apellidosToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByApellidosToolStripButton
            // 
            this.fillByApellidosToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByApellidosToolStripButton.Name = "fillByApellidosToolStripButton";
            this.fillByApellidosToolStripButton.Size = new System.Drawing.Size(114, 22);
            this.fillByApellidosToolStripButton.Text = "Filtrar por Apellidos";
            this.fillByApellidosToolStripButton.Click += new System.EventHandler(this.fillByApellidosToolStripButton_Click);
            // 
            // iDClienteDataGridViewTextBoxColumn
            // 
            this.iDClienteDataGridViewTextBoxColumn.DataPropertyName = "IDCliente";
            this.iDClienteDataGridViewTextBoxColumn.HeaderText = "ID Cliente";
            this.iDClienteDataGridViewTextBoxColumn.Name = "iDClienteDataGridViewTextBoxColumn";
            this.iDClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            this.nombresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha Nacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            this.fechaNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cupoDataGridViewTextBoxColumn
            // 
            this.cupoDataGridViewTextBoxColumn.DataPropertyName = "Cupo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.cupoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.cupoDataGridViewTextBoxColumn.HeaderText = "Cupo";
            this.cupoDataGridViewTextBoxColumn.Name = "cupoDataGridViewTextBoxColumn";
            this.cupoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.facturacionDataSet;
            // 
            // facturacionDataSet
            // 
            this.facturacionDataSet.DataSetName = "FacturacionDataSet";
            this.facturacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(79, 22);
            this.toolStripButton1.Text = "Quitar Filtros";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // frmbusque_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 417);
            this.Controls.Add(this.fillByApellidosToolStrip);
            this.Controls.Add(this.fillByNombresToolStrip);
            this.Controls.Add(this.fillByIDClienteToolStrip);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAcentar);
            this.Controls.Add(this.dgvBusqueda_cliente);
            this.Name = "frmbusque_Cliente";
            this.Text = "frmbusque_Cliente";
            this.Load += new System.EventHandler(this.frmbusque_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda_cliente)).EndInit();
            this.fillByIDClienteToolStrip.ResumeLayout(false);
            this.fillByIDClienteToolStrip.PerformLayout();
            this.fillByNombresToolStrip.ResumeLayout(false);
            this.fillByNombresToolStrip.PerformLayout();
            this.fillByApellidosToolStrip.ResumeLayout(false);
            this.fillByApellidosToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturacionDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBusqueda_cliente;
        private FacturacionDataSet facturacionDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private FacturacionDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAcentar;
        private System.Windows.Forms.ToolStrip fillByIDClienteToolStrip;
        private System.Windows.Forms.ToolStripLabel iDClienteToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox iDClienteToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByIDClienteToolStripButton;
        private System.Windows.Forms.ToolStrip fillByNombresToolStrip;
        private System.Windows.Forms.ToolStripLabel nombresToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nombresToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByNombresToolStripButton;
        private System.Windows.Forms.ToolStrip fillByApellidosToolStrip;
        private System.Windows.Forms.ToolStripLabel apellidosToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox apellidosToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByApellidosToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}