namespace GestionTareasPendientes
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
            this.txtTarea = new System.Windows.Forms.TextBox();
            this.btnEliminarTarea = new System.Windows.Forms.Button();
            this.lstTareas = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpiarLista = new System.Windows.Forms.Button();
            this.btnAgregarTarea = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTarea
            // 
            this.txtTarea.Location = new System.Drawing.Point(57, 20);
            this.txtTarea.Name = "txtTarea";
            this.txtTarea.Size = new System.Drawing.Size(486, 22);
            this.txtTarea.TabIndex = 0;
            this.txtTarea.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnEliminarTarea
            // 
            this.btnEliminarTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEliminarTarea.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTarea.Location = new System.Drawing.Point(208, 410);
            this.btnEliminarTarea.Name = "btnEliminarTarea";
            this.btnEliminarTarea.Size = new System.Drawing.Size(188, 56);
            this.btnEliminarTarea.TabIndex = 3;
            this.btnEliminarTarea.Text = "Eliminar Tarea";
            this.btnEliminarTarea.UseVisualStyleBackColor = false;
            this.btnEliminarTarea.Click += new System.EventHandler(this.btnEliminarTarea_Click);
            // 
            // lstTareas
            // 
            this.lstTareas.FormattingEnabled = true;
            this.lstTareas.ItemHeight = 16;
            this.lstTareas.Location = new System.Drawing.Point(57, 115);
            this.lstTareas.Name = "lstTareas";
            this.lstTareas.Size = new System.Drawing.Size(486, 276);
            this.lstTareas.TabIndex = 2;
            this.lstTareas.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnLimpiarLista);
            this.panel1.Controls.Add(this.btnAgregarTarea);
            this.panel1.Controls.Add(this.lstTareas);
            this.panel1.Controls.Add(this.btnEliminarTarea);
            this.panel1.Controls.Add(this.txtTarea);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 572);
            this.panel1.TabIndex = 4;
            // 
            // btnLimpiarLista
            // 
            this.btnLimpiarLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLimpiarLista.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarLista.Location = new System.Drawing.Point(208, 475);
            this.btnLimpiarLista.Name = "btnLimpiarLista";
            this.btnLimpiarLista.Size = new System.Drawing.Size(188, 56);
            this.btnLimpiarLista.TabIndex = 5;
            this.btnLimpiarLista.Text = "Limpiar Lista";
            this.btnLimpiarLista.UseVisualStyleBackColor = false;
            this.btnLimpiarLista.Click += new System.EventHandler(this.btnLimpiarLista_Click);
            // 
            // btnAgregarTarea
            // 
            this.btnAgregarTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAgregarTarea.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTarea.Location = new System.Drawing.Point(208, 48);
            this.btnAgregarTarea.Name = "btnAgregarTarea";
            this.btnAgregarTarea.Size = new System.Drawing.Size(188, 50);
            this.btnAgregarTarea.TabIndex = 4;
            this.btnAgregarTarea.Text = "Agregar Tarea";
            this.btnAgregarTarea.UseVisualStyleBackColor = false;
            this.btnAgregarTarea.Click += new System.EventHandler(this.btnAgregarTarea_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GestionTareasPendientes.Properties.Resources.gestor_de_fondos__1_;
            this.pictureBox2.Location = new System.Drawing.Point(11, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(87, 61);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestionTareasPendientes.Properties.Resources.gestor_de_archivos;
            this.pictureBox1.Location = new System.Drawing.Point(-11, 425);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 131);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(588, 568);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Gestion Tareas Pendientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTarea;
        private System.Windows.Forms.Button btnEliminarTarea;
        private System.Windows.Forms.ListBox lstTareas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAgregarTarea;
        private System.Windows.Forms.Button btnLimpiarLista;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

