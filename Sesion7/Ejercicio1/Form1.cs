using Ejercicio1.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Arreglos : Form
    {
        GeneralAge ages = new GeneralAge();
        int index = 0;
        public Arreglos()
        {
            InitializeComponent();
        }

        private void AddElement()
        {
            try
            {
                int age = Convert.ToInt32(tbAge.Text);
                ages.AddElement(age, index);
                index++;
                tbAge.Clear();
                tbAge.Focus();
                ShowAges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Ten cuidado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowAges()
        {
            lbAge.Items.Clear();
            try
            {
                for (int i = 0; i < index; i++)
                {
                    lbAge.Items.Add(ages.GetElement()[(int)i]);
                }
                int sum = ages.GetElement().Sum();
                double average = sum/index;
                lblSuma.Text = "Suma: " + sum;
                lblPromedio.Text = "Promedio: " + average;
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message, "Ten cuidado",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddElement();
        }

        

        private void tbAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AddElement();
            }
        }
    }
}
