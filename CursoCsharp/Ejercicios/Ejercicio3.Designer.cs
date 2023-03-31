namespace CursoCsharp.Ejercicios
{
    partial class Ejercicio3
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblimcresultado = new System.Windows.Forms.Label();
            this.lblcondicionresultado = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.lblcondicion = new System.Windows.Forms.Label();
            this.lblimc = new System.Windows.Forms.Label();
            this.lblaltura = new System.Windows.Forms.Label();
            this.lblpeso = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblejercicio = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblimcresultado);
            this.panel1.Controls.Add(this.lblcondicionresultado);
            this.panel1.Controls.Add(this.btncalcular);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txtaltura);
            this.panel1.Controls.Add(this.txtpeso);
            this.panel1.Controls.Add(this.lblcondicion);
            this.panel1.Controls.Add(this.lblimc);
            this.panel1.Controls.Add(this.lblaltura);
            this.panel1.Controls.Add(this.lblpeso);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 464);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 347);
            this.panel1.TabIndex = 11;
            // 
            // lblimcresultado
            // 
            this.lblimcresultado.AutoSize = true;
            this.lblimcresultado.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimcresultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblimcresultado.Location = new System.Drawing.Point(533, 228);
            this.lblimcresultado.Name = "lblimcresultado";
            this.lblimcresultado.Size = new System.Drawing.Size(25, 28);
            this.lblimcresultado.TabIndex = 19;
            this.lblimcresultado.Text = "-";
            this.lblimcresultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblcondicionresultado
            // 
            this.lblcondicionresultado.AutoSize = true;
            this.lblcondicionresultado.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcondicionresultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblcondicionresultado.Location = new System.Drawing.Point(533, 277);
            this.lblcondicionresultado.Name = "lblcondicionresultado";
            this.lblcondicionresultado.Size = new System.Drawing.Size(25, 28);
            this.lblcondicionresultado.TabIndex = 20;
            this.lblcondicionresultado.Text = "-";
            this.lblcondicionresultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(149)))));
            this.btncalcular.FlatAppearance.BorderSize = 0;
            this.btncalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.ForeColor = System.Drawing.Color.Black;
            this.btncalcular.Location = new System.Drawing.Point(713, 77);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(272, 64);
            this.btncalcular.TabIndex = 18;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(538, 147);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(130, 3);
            this.panel4.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(538, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 3);
            this.panel3.TabIndex = 17;
            // 
            // txtaltura
            // 
            this.txtaltura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.txtaltura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtaltura.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaltura.ForeColor = System.Drawing.Color.White;
            this.txtaltura.Location = new System.Drawing.Point(538, 113);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(130, 28);
            this.txtaltura.TabIndex = 14;
            this.txtaltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtpeso
            // 
            this.txtpeso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.txtpeso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpeso.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpeso.ForeColor = System.Drawing.Color.White;
            this.txtpeso.Location = new System.Drawing.Point(538, 39);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(130, 28);
            this.txtpeso.TabIndex = 15;
            this.txtpeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblcondicion
            // 
            this.lblcondicion.AutoSize = true;
            this.lblcondicion.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcondicion.ForeColor = System.Drawing.Color.White;
            this.lblcondicion.Location = new System.Drawing.Point(302, 277);
            this.lblcondicion.Name = "lblcondicion";
            this.lblcondicion.Size = new System.Drawing.Size(164, 32);
            this.lblcondicion.TabIndex = 21;
            this.lblcondicion.Text = "Condicion=";
            // 
            // lblimc
            // 
            this.lblimc.AutoSize = true;
            this.lblimc.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimc.ForeColor = System.Drawing.Color.White;
            this.lblimc.Location = new System.Drawing.Point(392, 228);
            this.lblimc.Name = "lblimc";
            this.lblimc.Size = new System.Drawing.Size(74, 32);
            this.lblimc.TabIndex = 22;
            this.lblimc.Text = "IMC=";
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaltura.ForeColor = System.Drawing.Color.White;
            this.lblaltura.Location = new System.Drawing.Point(302, 122);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(164, 32);
            this.lblaltura.TabIndex = 23;
            this.lblaltura.Text = "Altura(m)=";
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpeso.ForeColor = System.Drawing.Color.White;
            this.lblpeso.Location = new System.Drawing.Point(317, 48);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(149, 32);
            this.lblpeso.TabIndex = 24;
            this.lblpeso.Text = "Peso(kg)=";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(198)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(0, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1057, 81);
            this.label2.TabIndex = 10;
            this.label2.Text = "Solucion";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblejercicio
            // 
            this.lblejercicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblejercicio.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblejercicio.ForeColor = System.Drawing.Color.White;
            this.lblejercicio.Location = new System.Drawing.Point(0, 0);
            this.lblejercicio.Name = "lblejercicio";
            this.lblejercicio.Size = new System.Drawing.Size(1057, 81);
            this.lblejercicio.TabIndex = 8;
            this.lblejercicio.Text = "Ejercicio 3";
            this.lblejercicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::CursoCsharp.Properties.Resources.Ejercicio_3;
            this.pictureBox1.Location = new System.Drawing.Point(0, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1057, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblejercicio);
            this.Name = "Ejercicio3";
            this.Size = new System.Drawing.Size(1057, 811);
            this.Load += new System.EventHandler(this.Ejercicio3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblejercicio;
        private System.Windows.Forms.Label lblimcresultado;
        private System.Windows.Forms.Label lblcondicionresultado;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.Label lblcondicion;
        private System.Windows.Forms.Label lblimc;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.Label lblpeso;
    }
}
