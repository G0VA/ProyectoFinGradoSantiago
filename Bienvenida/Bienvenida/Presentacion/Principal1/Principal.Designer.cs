namespace Bienvenida.Presentacion.Principal
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnNewPedido = new System.Windows.Forms.Button();
            this.btnModPedido = new System.Windows.Forms.Button();
            this.btnTicket = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEmple = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnLogPedidos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(937, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(207, 33);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "DD/MM/AAAA";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAceptar.Location = new System.Drawing.Point(12, 12);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(131, 64);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Volver";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnNewPedido
            // 
            this.btnNewPedido.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNewPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPedido.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnNewPedido.Location = new System.Drawing.Point(943, 57);
            this.btnNewPedido.Name = "btnNewPedido";
            this.btnNewPedido.Size = new System.Drawing.Size(201, 64);
            this.btnNewPedido.TabIndex = 11;
            this.btnNewPedido.Text = "Nuevo Pedido";
            this.btnNewPedido.UseVisualStyleBackColor = false;
            this.btnNewPedido.Click += new System.EventHandler(this.btnNewPedido_Click);
            // 
            // btnModPedido
            // 
            this.btnModPedido.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnModPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModPedido.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnModPedido.Location = new System.Drawing.Point(943, 145);
            this.btnModPedido.Name = "btnModPedido";
            this.btnModPedido.Size = new System.Drawing.Size(201, 64);
            this.btnModPedido.TabIndex = 12;
            this.btnModPedido.Text = "Modificar Pedido";
            this.btnModPedido.UseVisualStyleBackColor = false;
            this.btnModPedido.Click += new System.EventHandler(this.btnModPedido_Click);
            // 
            // btnTicket
            // 
            this.btnTicket.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTicket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicket.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnTicket.Location = new System.Drawing.Point(943, 370);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(201, 64);
            this.btnTicket.TabIndex = 13;
            this.btnTicket.Text = "Imprimir Ticket";
            this.btnTicket.UseVisualStyleBackColor = false;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnPagar.Location = new System.Drawing.Point(943, 457);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(201, 64);
            this.btnPagar.TabIndex = 14;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnProductos.Location = new System.Drawing.Point(12, 93);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(131, 64);
            this.btnProductos.TabIndex = 15;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.AllowUserToResizeColumns = false;
            this.dgvPedidos.AllowUserToResizeRows = false;
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(185, 164);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(701, 391);
            this.dgvPedidos.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "Empleado";
            // 
            // cbEmple
            // 
            this.cbEmple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEmple.FormattingEnabled = true;
            this.cbEmple.Location = new System.Drawing.Point(229, 82);
            this.cbEmple.Name = "cbEmple";
            this.cbEmple.Size = new System.Drawing.Size(121, 21);
            this.cbEmple.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(438, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 26);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(412, 82);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(158, 20);
            this.txtCliente.TabIndex = 19;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnLimpiar.Location = new System.Drawing.Point(751, 70);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(135, 51);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.Location = new System.Drawing.Point(609, 50);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(102, 83);
            this.btnFiltrar.TabIndex = 21;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnLogPedidos
            // 
            this.btnLogPedidos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogPedidos.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnLogPedidos.Location = new System.Drawing.Point(943, 228);
            this.btnLogPedidos.Name = "btnLogPedidos";
            this.btnLogPedidos.Size = new System.Drawing.Size(201, 64);
            this.btnLogPedidos.TabIndex = 23;
            this.btnLogPedidos.Text = "Log Pedidos";
            this.btnLogPedidos.UseVisualStyleBackColor = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1206, 623);
            this.Controls.Add(this.btnLogPedidos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEmple);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.btnModPedido);
            this.Controls.Add(this.btnNewPedido);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Shown += new System.EventHandler(this.mostrar);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnNewPedido;
        private System.Windows.Forms.Button btnModPedido;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEmple;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnLogPedidos;
    }
}