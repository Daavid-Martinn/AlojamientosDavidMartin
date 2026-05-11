namespace AlojamientosDavid
{
    partial class FormularioVerReservas
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btnReservasTodas = new System.Windows.Forms.Button();
            this.btnVover = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnInsPago = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Formulario para ver reservas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitulo.Location = new System.Drawing.Point(69, 48);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(500, 23);
            this.lblTitulo.TabIndex = 2;
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(12, 96);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(639, 269);
            this.dgv1.TabIndex = 3;
            // 
            // btnReservasTodas
            // 
            this.btnReservasTodas.Location = new System.Drawing.Point(494, 402);
            this.btnReservasTodas.Name = "btnReservasTodas";
            this.btnReservasTodas.Size = new System.Drawing.Size(97, 43);
            this.btnReservasTodas.TabIndex = 4;
            this.btnReservasTodas.Text = "Ver Reservas";
            this.btnReservasTodas.UseVisualStyleBackColor = true;
            // 
            // btnVover
            // 
            this.btnVover.BackColor = System.Drawing.Color.Red;
            this.btnVover.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVover.Location = new System.Drawing.Point(692, 30);
            this.btnVover.Name = "btnVover";
            this.btnVover.Size = new System.Drawing.Size(84, 41);
            this.btnVover.TabIndex = 7;
            this.btnVover.Text = "Volver";
            this.btnVover.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Escriba el id de la reserva para filtar por id:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(279, 378);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(100, 22);
            this.txtFiltrar.TabIndex = 9;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(128, 409);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(172, 29);
            this.btnFiltrar.TabIndex = 10;
            this.btnFiltrar.Text = "Ver reserva con ese id";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Pulsa para ver todas las reservas";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(669, 96);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(119, 40);
            this.btnInsertar.TabIndex = 13;
            this.btnInsertar.Text = "Insertar reserva";
            this.btnInsertar.UseVisualStyleBackColor = true;
            // 
            // btnInsPago
            // 
            this.btnInsPago.Location = new System.Drawing.Point(669, 249);
            this.btnInsPago.Name = "btnInsPago";
            this.btnInsPago.Size = new System.Drawing.Size(119, 102);
            this.btnInsPago.TabIndex = 14;
            this.btnInsPago.Text = "Insertar pago (Seleccione en la lista la reserva a la que asociara el pago)";
            this.btnInsPago.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(669, 142);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(119, 101);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar reserva (Seleccione la reserva que quiera editar en la lista)";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(669, 369);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(119, 69);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar reserva (Seleccione en la lista)";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // FormularioVerReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsPago);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtFiltrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVover);
            this.Controls.Add(this.btnReservasTodas);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label1);
            this.Name = "FormularioVerReservas";
            this.Text = "FormularioVerReservas";
            this.Load += new System.EventHandler(this.FormularioVerReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnReservasTodas;
        private System.Windows.Forms.Button btnVover;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnInsPago;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}