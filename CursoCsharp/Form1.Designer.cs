namespace CursoCsharp
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
            this.lblHolamundo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHolamundo
            // 
            this.lblHolamundo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblHolamundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHolamundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHolamundo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblHolamundo.Location = new System.Drawing.Point(0, 0);
            this.lblHolamundo.Name = "lblHolamundo";
            this.lblHolamundo.Size = new System.Drawing.Size(1114, 770);
            this.lblHolamundo.TabIndex = 0;
            this.lblHolamundo.Text = "Hola Mundo";
            this.lblHolamundo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHolamundo.Click += new System.EventHandler(this.lblHolamundo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 770);
            this.Controls.Add(this.lblHolamundo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHolamundo;
    }
}

