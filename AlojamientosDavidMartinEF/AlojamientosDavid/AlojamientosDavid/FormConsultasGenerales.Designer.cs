namespace AlojamientosDavid
{
    partial class FormConsultasGenerales
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
            this.btnAlojamientos = new System.Windows.Forms.Button();
            this.btnUnidades = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnVover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulario para ver datos generales";
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitulo.Location = new System.Drawing.Point(102, 56);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(500, 23);
            this.lblTitulo.TabIndex = 1;
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(12, 94);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 24;
            this.dgv1.Size = new System.Drawing.Size(639, 269);
            this.dgv1.TabIndex = 2;
            // 
            // btnAlojamientos
            // 
            this.btnAlojamientos.Location = new System.Drawing.Point(666, 131);
            this.btnAlojamientos.Name = "btnAlojamientos";
            this.btnAlojamientos.Size = new System.Drawing.Size(97, 43);
            this.btnAlojamientos.TabIndex = 3;
            this.btnAlojamientos.Text = "Ver Alojamientos";
            this.btnAlojamientos.UseVisualStyleBackColor = true;
            this.btnAlojamientos.Click += new System.EventHandler(this.btnAlojamientos_Click);
            // 
            // btnUnidades
            // 
            this.btnUnidades.Location = new System.Drawing.Point(666, 204);
            this.btnUnidades.Name = "btnUnidades";
            this.btnUnidades.Size = new System.Drawing.Size(97, 45);
            this.btnUnidades.TabIndex = 4;
            this.btnUnidades.Text = "Ver Uds De Alojamiento";
            this.btnUnidades.UseVisualStyleBackColor = true;
            this.btnUnidades.Click += new System.EventHandler(this.btnUnidades_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(666, 276);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(97, 34);
            this.btnClientes.TabIndex = 5;
            this.btnClientes.Text = "Ver Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnVover
            // 
            this.btnVover.Location = new System.Drawing.Point(286, 386);
            this.btnVover.Name = "btnVover";
            this.btnVover.Size = new System.Drawing.Size(84, 41);
            this.btnVover.TabIndex = 6;
            this.btnVover.Text = "Volver";
            this.btnVover.UseVisualStyleBackColor = true;
            this.btnVover.Click += new System.EventHandler(this.btnVover_Click);
            // 
            // FormConsultasGenerales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVover);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnUnidades);
            this.Controls.Add(this.btnAlojamientos);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label1);
            this.Name = "FormConsultasGenerales";
            this.Text = "FormConsultasGenerales";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnAlojamientos;
        private System.Windows.Forms.Button btnUnidades;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnVover;
    }
}