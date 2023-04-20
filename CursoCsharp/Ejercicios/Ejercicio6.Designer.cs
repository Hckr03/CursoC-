namespace CursoCsharp.Ejercicios
{
    partial class Ejercicio6
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
            this.lblEjercicio6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.txtPantalla = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.panelNumerico = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAC = new System.Windows.Forms.Button();
            this.btnPorcentaje = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEjercicio6
            // 
            this.lblEjercicio6.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEjercicio6.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjercicio6.ForeColor = System.Drawing.Color.White;
            this.lblEjercicio6.Location = new System.Drawing.Point(0, 0);
            this.lblEjercicio6.Name = "lblEjercicio6";
            this.lblEjercicio6.Size = new System.Drawing.Size(224, 760);
            this.lblEjercicio6.TabIndex = 0;
            this.lblEjercicio6.Text = "Ejercicio 6";
            this.lblEjercicio6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CursoCsharp.Properties.Resources.iphone;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.lblNum1);
            this.panel1.Controls.Add(this.lblOperacion);
            this.panel1.Controls.Add(this.btnCopiar);
            this.panel1.Controls.Add(this.txtPantalla);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.panelNumerico);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(224, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 760);
            this.panel1.TabIndex = 1;
            // 
            // lblNum1
            // 
            this.lblNum1.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.ForeColor = System.Drawing.Color.White;
            this.lblNum1.Location = new System.Drawing.Point(204, 119);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(311, 32);
            this.lblNum1.TabIndex = 6;
            this.lblNum1.Text = "0";
            this.lblNum1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNum1.Visible = false;
            // 
            // lblOperacion
            // 
            this.lblOperacion.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOperacion.Location = new System.Drawing.Point(204, 169);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(311, 32);
            this.lblOperacion.TabIndex = 5;
            this.lblOperacion.Text = "0";
            this.lblOperacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblOperacion.Visible = false;
            // 
            // btnCopiar
            // 
            this.btnCopiar.BackgroundImage = global::CursoCsharp.Properties.Resources.copiar;
            this.btnCopiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCopiar.FlatAppearance.BorderSize = 0;
            this.btnCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiar.ForeColor = System.Drawing.Color.White;
            this.btnCopiar.Location = new System.Drawing.Point(202, 249);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(30, 30);
            this.btnCopiar.TabIndex = 0;
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // txtPantalla
            // 
            this.txtPantalla.BackColor = System.Drawing.Color.Black;
            this.txtPantalla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPantalla.Font = new System.Drawing.Font("Consolas", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPantalla.ForeColor = System.Drawing.Color.White;
            this.txtPantalla.Location = new System.Drawing.Point(261, 219);
            this.txtPantalla.Name = "txtPantalla";
            this.txtPantalla.ReadOnly = true;
            this.txtPantalla.Size = new System.Drawing.Size(254, 79);
            this.txtPantalla.TabIndex = 2;
            this.txtPantalla.Text = "0";
            this.txtPantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnDiv);
            this.flowLayoutPanel2.Controls.Add(this.btnMulti);
            this.flowLayoutPanel2.Controls.Add(this.btnRestar);
            this.flowLayoutPanel2.Controls.Add(this.btnSumar);
            this.flowLayoutPanel2.Controls.Add(this.btnIgual);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(441, 307);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(74, 389);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // btnDiv
            // 
            this.btnDiv.BackgroundImage = global::CursoCsharp.Properties.Resources.btn1;
            this.btnDiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDiv.FlatAppearance.BorderSize = 0;
            this.btnDiv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDiv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiv.ForeColor = System.Drawing.Color.White;
            this.btnDiv.Location = new System.Drawing.Point(3, 3);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(70, 70);
            this.btnDiv.TabIndex = 2;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.BackgroundImage = global::CursoCsharp.Properties.Resources.btn1;
            this.btnMulti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMulti.FlatAppearance.BorderSize = 0;
            this.btnMulti.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMulti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMulti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMulti.ForeColor = System.Drawing.Color.White;
            this.btnMulti.Location = new System.Drawing.Point(3, 79);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(70, 70);
            this.btnMulti.TabIndex = 2;
            this.btnMulti.Text = "X";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.BackgroundImage = global::CursoCsharp.Properties.Resources.btn1;
            this.btnRestar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestar.FlatAppearance.BorderSize = 0;
            this.btnRestar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRestar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRestar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestar.ForeColor = System.Drawing.Color.White;
            this.btnRestar.Location = new System.Drawing.Point(3, 155);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(70, 70);
            this.btnRestar.TabIndex = 2;
            this.btnRestar.Text = "-";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // btnSumar
            // 
            this.btnSumar.BackgroundImage = global::CursoCsharp.Properties.Resources.btn1;
            this.btnSumar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSumar.FlatAppearance.BorderSize = 0;
            this.btnSumar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSumar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSumar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSumar.ForeColor = System.Drawing.Color.White;
            this.btnSumar.Location = new System.Drawing.Point(3, 231);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(70, 70);
            this.btnSumar.TabIndex = 2;
            this.btnSumar.Text = "+";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.BackgroundImage = global::CursoCsharp.Properties.Resources.btn1;
            this.btnIgual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIgual.FlatAppearance.BorderSize = 0;
            this.btnIgual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIgual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIgual.ForeColor = System.Drawing.Color.White;
            this.btnIgual.Location = new System.Drawing.Point(3, 307);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(70, 70);
            this.btnIgual.TabIndex = 2;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // panelNumerico
            // 
            this.panelNumerico.Location = new System.Drawing.Point(202, 390);
            this.panelNumerico.Name = "panelNumerico";
            this.panelNumerico.Size = new System.Drawing.Size(234, 306);
            this.panelNumerico.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAC);
            this.flowLayoutPanel1.Controls.Add(this.btnPorcentaje);
            this.flowLayoutPanel1.Controls.Add(this.btnOff);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(202, 307);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(234, 77);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnAC
            // 
            this.btnAC.BackgroundImage = global::CursoCsharp.Properties.Resources.btn2;
            this.btnAC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAC.FlatAppearance.BorderSize = 0;
            this.btnAC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAC.ForeColor = System.Drawing.Color.White;
            this.btnAC.Location = new System.Drawing.Point(3, 3);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(70, 70);
            this.btnAC.TabIndex = 0;
            this.btnAC.Text = "AC";
            this.btnAC.UseVisualStyleBackColor = true;
            this.btnAC.Click += new System.EventHandler(this.btnAC_Click);
            // 
            // btnPorcentaje
            // 
            this.btnPorcentaje.BackgroundImage = global::CursoCsharp.Properties.Resources.btn2;
            this.btnPorcentaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPorcentaje.FlatAppearance.BorderSize = 0;
            this.btnPorcentaje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPorcentaje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPorcentaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorcentaje.ForeColor = System.Drawing.Color.White;
            this.btnPorcentaje.Location = new System.Drawing.Point(79, 3);
            this.btnPorcentaje.Name = "btnPorcentaje";
            this.btnPorcentaje.Size = new System.Drawing.Size(70, 70);
            this.btnPorcentaje.TabIndex = 0;
            this.btnPorcentaje.Text = "%";
            this.btnPorcentaje.UseVisualStyleBackColor = true;
            this.btnPorcentaje.Click += new System.EventHandler(this.btnPorcentaje_Click);
            // 
            // btnOff
            // 
            this.btnOff.BackgroundImage = global::CursoCsharp.Properties.Resources.btn2;
            this.btnOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOff.FlatAppearance.BorderSize = 0;
            this.btnOff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOff.ForeColor = System.Drawing.Color.White;
            this.btnOff.Location = new System.Drawing.Point(155, 3);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(70, 70);
            this.btnOff.TabIndex = 1;
            this.btnOff.Text = "Off";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // Ejercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEjercicio6);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Ejercicio6";
            this.Size = new System.Drawing.Size(1003, 760);
            this.Load += new System.EventHandler(this.Ejercicio6_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEjercicio6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.TextBox txtPantalla;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.FlowLayoutPanel panelNumerico;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAC;
        private System.Windows.Forms.Button btnPorcentaje;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblOperacion;
    }
}
