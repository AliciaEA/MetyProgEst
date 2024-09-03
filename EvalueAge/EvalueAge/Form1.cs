using EvalueAge.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvalueAge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            
            Evaluation evaluacion = new Evaluation();

            try
            {
                int age = Convert.ToInt32(tbEdad.Text);
                age = Convert.ToInt32(tbEdad.Text);
                lblAnswer.Text = $"Tienes {age} años. {evaluacion.EvaluarEdad(age)}";
                tbEdad.Text = "";
                tbEdad.Focus();
            }
            catch (Exception ex)
            {
                lblAnswer.Text = ex.Message;
                return;
            }


        }
    }
}
