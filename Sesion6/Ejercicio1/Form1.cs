using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void agregarNombre()
        {
            string nombre = tbNombre.Text.Trim();
            if(string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("No puede estar vacio","Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNombre.Text = "";
                tbNombre.Focus();
                return;
            }
            cmbNombres.Items.Add(nombre);
            tbNombre.Text = "";
            tbNombre.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            agregarNombre();


        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            int cant = cmbNombres.Items.Count;
            foreach (var item in cmbNombres.Items)
            {
                cmbNombres2.Items.Add(item);
            }

        }
    }
}
