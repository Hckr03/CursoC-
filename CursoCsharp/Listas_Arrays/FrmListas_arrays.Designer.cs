namespace CursoCsharp.Listas
{
    partial class FrmListas_arrays
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
            this.listDatos = new System.Windows.Forms.ListView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.panelNumerico = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPantalla = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupbox.SuspendLayout();
            this.panelNumerico.SuspendLayout();
            this.SuspendLayout();
            // 
            // listDatos
            // 
            this.listDatos.HideSelection = false;
            this.listDatos.Location = new System.Drawing.Point(9, 73);
            this.listDatos.Name = "listDatos";
            this.listDatos.Size = new System.Drawing.Size(306, 559);
            this.listDatos.TabIndex = 1;
            this.listDatos.UseCompatibleStateImageBehavior = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.btnAgregar.FlatAppearance.BorderSize = 2;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregar.Location = new System.Drawing.Point(325, 73);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(151, 89);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.listDatos);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 656);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listas - Array";
            // 
            // groupbox
            // 
            this.groupbox.Controls.Add(this.txtPantalla);
            this.groupbox.Controls.Add(this.panelNumerico);
            this.groupbox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox.ForeColor = System.Drawing.Color.White;
            this.groupbox.Location = new System.Drawing.Point(542, 36);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(489, 656);
            this.groupbox.TabIndex = 3;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "Teclado numerico";
            // 
            // panelNumerico
            // 
            this.panelNumerico.Controls.Add(this.button1);
            this.panelNumerico.Location = new System.Drawing.Point(23, 122);
            this.panelNumerico.Name = "panelNumerico";
            this.panelNumerico.Size = new System.Drawing.Size(446, 511);
            this.panelNumerico.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtPantalla
            // 
            this.txtPantalla.Location = new System.Drawing.Point(24, 66);
            this.txtPantalla.Name = "txtPantalla";
            this.txtPantalla.Size = new System.Drawing.Size(444, 31);
            this.txtPantalla.TabIndex = 1;
            // 
            // FrmListas_arrays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1173, 718);
            this.Controls.Add(this.groupbox);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmListas_arrays";
            this.Text = "FmrListas";
            this.Load += new System.EventHandler(this.FrmListas_arrays_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            this.panelNumerico.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listDatos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel panelNumerico;
        private System.Windows.Forms.TextBox txtPantalla;
    }
}