namespace Ejercicio1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbNombres = new System.Windows.Forms.ComboBox();
            this.cmbNombres2 = new System.Windows.Forms.ComboBox();
            this.btnMover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // tbNombre
            // 
            this.tbNombre.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tbNombre.Location = new System.Drawing.Point(133, 32);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(346, 36);
            this.tbNombre.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.Image = global::Ejercicio1.Properties.Resources.Agregar;
            this.btnAgregar.Location = new System.Drawing.Point(520, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(65, 57);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbNombres
            // 
            this.cmbNombres.FormattingEnabled = true;
            this.cmbNombres.Location = new System.Drawing.Point(133, 99);
            this.cmbNombres.Name = "cmbNombres";
            this.cmbNombres.Size = new System.Drawing.Size(346, 32);
            this.cmbNombres.TabIndex = 3;
            this.cmbNombres.Text = "Selecciona...";
            // 
            // cmbNombres2
            // 
            this.cmbNombres2.FormattingEnabled = true;
            this.cmbNombres2.Location = new System.Drawing.Point(133, 244);
            this.cmbNombres2.Name = "cmbNombres2";
            this.cmbNombres2.Size = new System.Drawing.Size(346, 32);
            this.cmbNombres2.TabIndex = 4;
            // 
            // btnMover
            // 
            this.btnMover.Location = new System.Drawing.Point(123, 164);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(356, 46);
            this.btnMover.TabIndex = 5;
            this.btnMover.Text = "Mover todos los elementos";
            this.btnMover.UseVisualStyleBackColor = true;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(650, 466);
            this.Controls.Add(this.btnMover);
            this.Controls.Add(this.cmbNombres2);
            this.Controls.Add(this.cmbNombres);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbNombres;
        private System.Windows.Forms.ComboBox cmbNombres2;
        private System.Windows.Forms.Button btnMover;
    }
}

