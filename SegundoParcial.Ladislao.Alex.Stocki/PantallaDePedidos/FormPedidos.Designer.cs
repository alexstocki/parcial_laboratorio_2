namespace PantallaDePedidos
{
    partial class FormPedidos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregarAlPedido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirmarPedido = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTipoEntrega = new System.Windows.Forms.Label();
            this.cbTipoEntrega = new System.Windows.Forms.ComboBox();
            this.txtboxNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblDireccionEntrega = new System.Windows.Forms.Label();
            this.txtboxDireccion = new System.Windows.Forms.TextBox();
            this.dgvPedidoNuevo = new System.Windows.Forms.DataGridView();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.lblPedido = new System.Windows.Forms.Label();
            this.lblProductos = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvPedidosListos = new System.Windows.Forms.DataGridView();
            this.dgvPedidosEnPreparacion = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosListos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosEnPreparacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarAlPedido
            // 
            this.btnAgregarAlPedido.Location = new System.Drawing.Point(894, 40);
            this.btnAgregarAlPedido.Name = "btnAgregarAlPedido";
            this.btnAgregarAlPedido.Size = new System.Drawing.Size(149, 42);
            this.btnAgregarAlPedido.TabIndex = 1;
            this.btnAgregarAlPedido.Text = "Agregar al pedido";
            this.btnAgregarAlPedido.UseVisualStyleBackColor = true;
            this.btnAgregarAlPedido.Click += new System.EventHandler(this.btnAgregarAlPedido_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "EN PREPARACION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "LISTO PARA RETIRAR";
            // 
            // btnConfirmarPedido
            // 
            this.btnConfirmarPedido.Location = new System.Drawing.Point(894, 276);
            this.btnConfirmarPedido.Name = "btnConfirmarPedido";
            this.btnConfirmarPedido.Size = new System.Drawing.Size(149, 42);
            this.btnConfirmarPedido.TabIndex = 1;
            this.btnConfirmarPedido.Text = "Confirmar Pedido";
            this.btnConfirmarPedido.UseVisualStyleBackColor = true;
            this.btnConfirmarPedido.Click += new System.EventHandler(this.btnConfirmarPedido_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTipoEntrega);
            this.panel1.Controls.Add(this.cbTipoEntrega);
            this.panel1.Controls.Add(this.txtboxNombreCliente);
            this.panel1.Controls.Add(this.lblNombreCliente);
            this.panel1.Controls.Add(this.lblDireccionEntrega);
            this.panel1.Controls.Add(this.txtboxDireccion);
            this.panel1.Controls.Add(this.dgvPedidoNuevo);
            this.panel1.Controls.Add(this.dgvProductos);
            this.panel1.Controls.Add(this.lblPedido);
            this.panel1.Controls.Add(this.lblProductos);
            this.panel1.Controls.Add(this.btnConfirmarPedido);
            this.panel1.Controls.Add(this.btnAgregarAlPedido);
            this.panel1.Location = new System.Drawing.Point(12, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 329);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTipoEntrega
            // 
            this.lblTipoEntrega.AutoSize = true;
            this.lblTipoEntrega.Location = new System.Drawing.Point(894, 99);
            this.lblTipoEntrega.Name = "lblTipoEntrega";
            this.lblTipoEntrega.Size = new System.Drawing.Size(89, 15);
            this.lblTipoEntrega.TabIndex = 7;
            this.lblTipoEntrega.Text = "Tipo de entrega";
            // 
            // cbTipoEntrega
            // 
            this.cbTipoEntrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoEntrega.FormattingEnabled = true;
            this.cbTipoEntrega.Location = new System.Drawing.Point(894, 127);
            this.cbTipoEntrega.Name = "cbTipoEntrega";
            this.cbTipoEntrega.Size = new System.Drawing.Size(149, 23);
            this.cbTipoEntrega.TabIndex = 8;
            // 
            // txtboxNombreCliente
            // 
            this.txtboxNombreCliente.Location = new System.Drawing.Point(894, 237);
            this.txtboxNombreCliente.Name = "txtboxNombreCliente";
            this.txtboxNombreCliente.Size = new System.Drawing.Size(149, 23);
            this.txtboxNombreCliente.TabIndex = 6;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(894, 219);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(89, 15);
            this.lblNombreCliente.TabIndex = 7;
            this.lblNombreCliente.Text = "Nombre cliente";
            // 
            // lblDireccionEntrega
            // 
            this.lblDireccionEntrega.AutoSize = true;
            this.lblDireccionEntrega.Location = new System.Drawing.Point(894, 166);
            this.lblDireccionEntrega.Name = "lblDireccionEntrega";
            this.lblDireccionEntrega.Size = new System.Drawing.Size(57, 15);
            this.lblDireccionEntrega.TabIndex = 7;
            this.lblDireccionEntrega.Text = "Direccion";
            // 
            // txtboxDireccion
            // 
            this.txtboxDireccion.Location = new System.Drawing.Point(894, 184);
            this.txtboxDireccion.Name = "txtboxDireccion";
            this.txtboxDireccion.Size = new System.Drawing.Size(149, 23);
            this.txtboxDireccion.TabIndex = 6;
            // 
            // dgvPedidoNuevo
            // 
            this.dgvPedidoNuevo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidoNuevo.Location = new System.Drawing.Point(474, 40);
            this.dgvPedidoNuevo.Name = "dgvPedidoNuevo";
            this.dgvPedidoNuevo.ReadOnly = true;
            this.dgvPedidoNuevo.RowHeadersVisible = false;
            this.dgvPedidoNuevo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidoNuevo.Size = new System.Drawing.Size(414, 278);
            this.dgvPedidoNuevo.TabIndex = 3;
            this.dgvPedidoNuevo.Text = "dataGridView4";
            this.dgvPedidoNuevo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidoNuevo_CellContentClick);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(5, 40);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(463, 278);
            this.dgvProductos.TabIndex = 3;
            this.dgvProductos.Text = "dataGridView3";
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(425, 10);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(48, 15);
            this.lblPedido.TabIndex = 4;
            this.lblPedido.Text = "PEDIDO";
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Location = new System.Drawing.Point(5, 10);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(41, 15);
            this.lblProductos.TabIndex = 4;
            this.lblProductos.Text = "MENU";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvPedidosListos);
            this.panel2.Controls.Add(this.dgvPedidosEnPreparacion);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1048, 231);
            this.panel2.TabIndex = 5;
            // 
            // dgvPedidosListos
            // 
            this.dgvPedidosListos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidosListos.Location = new System.Drawing.Point(530, 22);
            this.dgvPedidosListos.Name = "dgvPedidosListos";
            this.dgvPedidosListos.ReadOnly = true;
            this.dgvPedidosListos.RowHeadersVisible = false;
            this.dgvPedidosListos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidosListos.Size = new System.Drawing.Size(513, 198);
            this.dgvPedidosListos.TabIndex = 3;
            this.dgvPedidosListos.Text = "dataGridView2";
            // 
            // dgvPedidosEnPreparacion
            // 
            this.dgvPedidosEnPreparacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidosEnPreparacion.Location = new System.Drawing.Point(5, 22);
            this.dgvPedidosEnPreparacion.Name = "dgvPedidosEnPreparacion";
            this.dgvPedidosEnPreparacion.ReadOnly = true;
            this.dgvPedidosEnPreparacion.RowHeadersVisible = false;
            this.dgvPedidosEnPreparacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidosEnPreparacion.Size = new System.Drawing.Size(519, 198);
            this.dgvPedidosEnPreparacion.TabIndex = 3;
            this.dgvPedidosEnPreparacion.Text = "dataGridView1";
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 596);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormPedidos";
            this.Text = "Agregar al pedido";
            this.Load += new System.EventHandler(this.FormPedidos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosListos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosEnPreparacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarAlPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirmarPedido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvPedidoNuevo;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridView dgvPedidosListos;
        private System.Windows.Forms.DataGridView dgvPedidosEnPreparacion;
        private System.Windows.Forms.Label lblDireccionEntrega;
        private System.Windows.Forms.TextBox txtboxDireccion;
        private System.Windows.Forms.Label lblTipoEntrega;
        private System.Windows.Forms.ComboBox cbTipoEntrega;
        private System.Windows.Forms.TextBox txtboxNombreCliente;
        private System.Windows.Forms.Label lblNombreCliente;
    }
}

