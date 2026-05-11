namespace AlojamientosDavid
{
    partial class FormularioVerPagos
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
            this.btnVover = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPagosTodas = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Formulario para ver pagos";
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitulo.Location = new System.Drawing.Point(62, 49);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(500, 23);
            this.lblTitulo.TabIndex = 3;
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(12, 88);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(639, 269);
            this.dgv1.TabIndex = 4;
            // 
            // btnVover
            // 
            this.btnVover.BackColor = System.Drawing.Color.Red;
            this.btnVover.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVover.Location = new System.Drawing.Point(687, 49);
            this.btnVover.Name = "btnVover";
            this.btnVover.Size = new System.Drawing.Size(84, 41);
            this.btnVover.TabIndex = 8;
            this.btnVover.Text = "Volver";
            this.btnVover.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Escriba el id del pago para filtar por id:";
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(254, 382);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(100, 22);
            this.txtFiltrar.TabIndex = 10;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(88, 410);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(172, 29);
            this.btnFiltrar.TabIndex = 11;
            this.btnFiltrar.Text = "Ver pago con ese id";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pulsa para ver todos los pagos";
            // 
            // btnPagosTodas
            // 
            this.btnPagosTodas.Location = new System.Drawing.Point(465, 401);
            this.btnPagosTodas.Name = "btnPagosTodas";
            this.btnPagosTodas.Size = new System.Drawing.Size(97, 43);
            this.btnPagosTodas.TabIndex = 13;
            this.btnPagosTodas.Text = "Ver Pagos";
            this.btnPagosTodas.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(669, 270);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(119, 87);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar pago (Seleccione en la lista el pago que quiere eliminar)";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(669, 134);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(119, 101);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar pago (Seleccione el pago que quiera editar en la lista)";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // FormularioVerPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnPagosTodas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtFiltrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVover);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label1);
            this.Name = "FormularioVerPagos";
            this.Text = "FormularioVerPagos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnVover;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPagosTodas;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
    }
}