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
            public int X;
            public int Y;

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
            //Limpiamos el datagridview para que no se repitan datos
            dgvPuntos.Rows.Clear();
            if (dgvPuntos.Columns.Count == 0)
            {
                dgvPuntos.Columns.Add("X", "X");//Agregamos columna X
                dgvPuntos.Columns.Add("Y", "Y");//Agregamos columna Y
            }

            for (int i = 0; i < MAX; i++)
            {
                if (puntos[i].X != 0 && puntos[i].Y != 0)
                {
                    dgvPuntos.Rows.Add(puntos[i].X, puntos[i].Y);
                    //Agregamos una fila, y en cada columna agregamos los valores de X y Y
                }
            }


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
