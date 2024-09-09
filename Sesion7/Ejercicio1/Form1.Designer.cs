namespace Ejercicio1
{
    partial class Arreglos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.ListBox();
            this.lblSuma = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.lblPromedio);
            this.groupBox1.Controls.Add(this.lblSuma);
            this.groupBox1.Controls.Add(this.lbAge);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.tbAge);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(665, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Edades";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la edad:";
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(203, 53);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(204, 30);
            this.tbAge.TabIndex = 1;
            this.tbAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAge_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(439, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 45);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Edades registradas:";
            // 
            // lbAge
            // 
            this.lbAge.FormattingEnabled = true;
            this.lbAge.ItemHeight = 25;
            this.lbAge.Location = new System.Drawing.Point(29, 153);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(406, 104);
            this.lbAge.TabIndex = 4;
            // 
            // lblSuma
            // 
            this.lblSuma.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblSuma.Location = new System.Drawing.Point(461, 153);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(193, 62);
            this.lblSuma.TabIndex = 5;
            // 
            // lblPromedio
            // 
            this.lblPromedio.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPromedio.Location = new System.Drawing.Point(461, 240);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(193, 62);
            this.lblPromedio.TabIndex = 6;
            // 
            // Arreglos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 363);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Arreglos";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label lblPromedio;
    }
}

