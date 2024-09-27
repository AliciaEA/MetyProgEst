namespace Estructuras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.btnAgregarValores = new System.Windows.Forms.Button();
            this.dgvPuntos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor de x:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor de y:";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(121, 23);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(100, 26);
            this.tbX.TabIndex = 2;
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(121, 67);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(100, 26);
            this.tbY.TabIndex = 3;
            this.tbY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbY_KeyPress);
            // 
            // btnAgregarValores
            // 
            this.btnAgregarValores.Location = new System.Drawing.Point(72, 127);
            this.btnAgregarValores.Name = "btnAgregarValores";
            this.btnAgregarValores.Size = new System.Drawing.Size(109, 53);
            this.btnAgregarValores.TabIndex = 4;
            this.btnAgregarValores.Text = "Agregar Valores";
            this.btnAgregarValores.UseVisualStyleBackColor = true;
            this.btnAgregarValores.Click += new System.EventHandler(this.btnAgregarValores_Click);
            this.btnAgregarValores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnAgregarValores_KeyPress);
            // 
            // dgvPuntos
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MingLiU-ExtB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Red;
            this.dgvPuntos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuntos.Location = new System.Drawing.Point(306, 23);
            this.dgvPuntos.Name = "dgvPuntos";
            this.dgvPuntos.RowHeadersWidth = 62;
            this.dgvPuntos.RowTemplate.Height = 28;
            this.dgvPuntos.Size = new System.Drawing.Size(637, 428);
            this.dgvPuntos.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 554);
            this.Controls.Add(this.dgvPuntos);
            this.Controls.Add(this.btnAgregarValores);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Button btnAgregarValores;
        private System.Windows.Forms.DataGridView dgvPuntos;
    }
}

