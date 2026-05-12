namespace AlojamientosDavid
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formularioPrincipalToolStripMenuItem,
            this.verReservasToolStripMenuItem,
            this.verPagosToolStripMenuItem});
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menúToolStripMenuItem.Text = "Menú";
            // 
            // formularioPrincipalToolStripMenuItem
            // 
            this.formularioPrincipalToolStripMenuItem.Name = "formularioPrincipalToolStripMenuItem";
            this.formularioPrincipalToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.formularioPrincipalToolStripMenuItem.Text = "Consultas generales";
            this.formularioPrincipalToolStripMenuItem.Click += new System.EventHandler(this.formularioPrincipalToolStripMenuItem_Click);
            // 
            // verReservasToolStripMenuItem
            // 
            this.verReservasToolStripMenuItem.Name = "verReservasToolStripMenuItem";
            this.verReservasToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.verReservasToolStripMenuItem.Text = "Ver reservas";
            this.verReservasToolStripMenuItem.Click += new System.EventHandler(this.verReservasToolStripMenuItem_Click);
            // 
            // verPagosToolStripMenuItem
            // 
            this.verPagosToolStripMenuItem.Name = "verPagosToolStripMenuItem";
            this.verPagosToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.verPagosToolStripMenuItem.Text = "Ver pagos";
            this.verPagosToolStripMenuItem.Click += new System.EventHandler(this.verPagosToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(333, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPagosToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

