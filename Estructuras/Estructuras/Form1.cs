using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructuras
{
    public partial class Form1 : Form
    {
        struct Punto

        {
            public int X { get; set; }
            public int Y { get; set; }

            public Punto(int x, int y)
            {
                X = x;
                Y = y;
            }

            public string Mostrar()
            {
                return $"X = {X}, Y = {Y}";
            }

        }

        //Variables
        const int MAX = 10;
        Punto[] puntos = new Punto[MAX];
        int i = 0;

        public Form1()
        {
            InitializeComponent();

        }

        private void btnAgregarValores_Click(object sender, EventArgs e)
        {
            AgregarElementos();

        }

        public void Limpiar()
        {
            tbX.Clear();
            tbY.Clear();
            tbX.Focus();
        }
        private void AgregarElementos()
        {
            try
            {
                //Convertimos los valores
                int x = Convert.ToInt32(tbX.Text);
                int y = Convert.ToInt32(tbY.Text);
                Punto punto = new Punto(x, y);

                if (i < MAX)
                {
                    //Agregamos los puntos al arreglo
                    puntos[i] = punto;
                    i++;
                    Limpiar();
                }
                else
                {
                    //Por si esta lleno el arreglo
                    MessageBox.Show("Ya no se pueden agregar más puntos", "Puntos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                //En caso de errores
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            ShowData();

        }
        private void ShowData()
        {
            dgvPuntos.DataSource = null;
            dgvPuntos.DataSource = puntos;

        }

        private void tbY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AgregarElementos();
            }
        }

        private void btnAgregarValores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AgregarElementos();
            }
        }
    }
}
