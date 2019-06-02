namespace Bienvenida.Presentacion.Pedidos
{
    partial class MostrarPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarPedidos));
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEmple = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.N_Pedido = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.datesss = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.ckDate = new System.Windows.Forms.CheckBox();
            this.ckFacturado = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ckPagado = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
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
            this.dgvPedidos.Location = new System.Drawing.Point(76, 151);
            this.dgvPedidos.MultiSelect = false;
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(701, 391);
            this.dgvPedidos.TabIndex = 17;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnVolver.Location = new System.Drawing.Point(76, 560);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(131, 64);
            this.btnVolver.TabIndex = 18;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnDetalles
            // 
            this.btnDetalles.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalles.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDetalles.Location = new System.Drawing.Point(646, 560);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(131, 64);
            this.btnDetalles.TabIndex = 19;
            this.btnDetalles.Text = "Detalles Pedido";
            this.btnDetalles.UseVisualStyleBackColor = false;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "Empleado";
            // 
            // cbEmple
            // 
            this.cbEmple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEmple.FormattingEnabled = true;
            this.cbEmple.Location = new System.Drawing.Point(76, 41);
            this.cbEmple.Name = "cbEmple";
            this.cbEmple.Size = new System.Drawing.Size(121, 21);
            this.cbEmple.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 26);
            this.label3.TabIndex = 23;
            this.label3.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(77, 111);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(130, 20);
            this.txtCliente.TabIndex = 22;
            // 
            // N_Pedido
            // 
            this.N_Pedido.AutoSize = true;
            this.N_Pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N_Pedido.Location = new System.Drawing.Point(229, 9);
            this.N_Pedido.Name = "N_Pedido";
            this.N_Pedido.Size = new System.Drawing.Size(116, 26);
            this.N_Pedido.TabIndex = 25;
            this.N_Pedido.Text = "N_Pedido";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(234, 41);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(111, 20);
            this.txtId.TabIndex = 24;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.Location = new System.Drawing.Point(534, 41);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(102, 83);
            this.btnFiltrar.TabIndex = 26;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(234, 111);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(111, 20);
            this.date.TabIndex = 27;
            // 
            // datesss
            // 
            this.datesss.AutoSize = true;
            this.datesss.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datesss.Location = new System.Drawing.Point(229, 82);
            this.datesss.Name = "datesss";
            this.datesss.Size = new System.Drawing.Size(77, 26);
            this.datesss.TabIndex = 28;
            this.datesss.Text = "Fecha";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnLimpiar.Location = new System.Drawing.Point(642, 57);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(135, 51);
            this.btnLimpiar.TabIndex = 29;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // ckDate
            // 
            this.ckDate.AutoSize = true;
            this.ckDate.Location = new System.Drawing.Point(330, 91);
            this.ckDate.Name = "ckDate";
            this.ckDate.Size = new System.Drawing.Size(15, 14);
            this.ckDate.TabIndex = 30;
            this.ckDate.UseVisualStyleBackColor = true;
            this.ckDate.CheckedChanged += new System.EventHandler(this.ckDateCambio);
            // 
            // ckFacturado
            // 
            this.ckFacturado.AutoSize = true;
            this.ckFacturado.Location = new System.Drawing.Point(491, 35);
            this.ckFacturado.Name = "ckFacturado";
            this.ckFacturado.Size = new System.Drawing.Size(15, 14);
            this.ckFacturado.TabIndex = 32;
            this.ckFacturado.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 26);
            this.label2.TabIndex = 31;
            this.label2.Text = "Facturado";
            // 
            // ckPagado
            // 
            this.ckPagado.AutoSize = true;
            this.ckPagado.Location = new System.Drawing.Point(491, 101);
            this.ckPagado.Name = "ckPagado";
            this.ckPagado.Size = new System.Drawing.Size(15, 14);
            this.ckPagado.TabIndex = 34;
            this.ckPagado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(367, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 26);
            this.label4.TabIndex = 33;
            this.label4.Text = "Pagado";
            // 
            // MostrarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(858, 629);
            this.Controls.Add(this.ckPagado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ckFacturado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ckDate);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.datesss);
            this.Controls.Add(this.date);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.N_Pedido);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEmple);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvPedidos);
            this.Name = "MostrarPedidos";
            this.Text = "MostrarPedidos";
            this.Shown += new System.EventHandler(this.MostrarPedidos_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEmple;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label N_Pedido;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label datesss;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.CheckBox ckDate;
        private System.Windows.Forms.CheckBox ckFacturado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckPagado;
        private System.Windows.Forms.Label label4;
    }
}