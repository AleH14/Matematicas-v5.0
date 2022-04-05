using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Matematicas_v5._0
{
    public partial class AngulosAgudo : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
      (
      int nLeftRect,
      int nTopRect,
      int RightRect,
      int nBottomRect,
      int nWidthEllipse,
      int nHeightEllipse
      );

        public AngulosAgudo()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
    

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            //*** Varibles ***************
            double cateto_B, cateto_C;

            //******************************************************** Validaciones ************************************************************************

            //*** catetoB ***************
            if (catetoB.Text == String.Empty)
            {
                MessageBox.Show("No deje espacios en blanco en cateto B", "Error");
                catetoB.Text = "";
                errorProvider1.SetError(catetoB, "No deje espacios en blanco");
                catetoB.Focus();
                return;
            }
            try
            {
                cateto_B = double.Parse(catetoB.Text);
                errorProvider1.Clear();
   
            }
            catch
            {
                MessageBox.Show("Digite valores numericos en cateto B", "Error");
                errorProvider1.SetError(catetoB, "Digite valores numericos en cateto B");
                catetoB.Text = "";
                catetoB.Focus();
                return;
            }

            //*** catetoC ***************
            if (catetoC.Text == String.Empty)
            {
                MessageBox.Show("No deje espacios en blanco en cateto C", "Error");
                errorProvider1.SetError(catetoC, "Digite valores numericos en cateto C");
                catetoC.Text = "";
                catetoC.Focus();
                return;
            }
            try
            {
                 cateto_C = double.Parse(catetoC.Text);
                errorProvider1.Clear();
            }
            catch
            {
                MessageBox.Show("Digite valores numericos en cateto C", "Error");
                errorProvider1.SetError(catetoC, "Digite valores numericos en cateto C");
                catetoC.Focus();
                catetoC.Text = "";
                return;
            }

            //******************************************************** Calcular ************************************************************************
            double valorB = Calcular_B(cateto_B, cateto_C);
            double valorC = Calcular_C(cateto_B, cateto_C);

            lb1.Text = valorB.ToString();
            lb2.Text = valorC.ToString();
        }

        static double Calcular_B(double b, double c)
        {
            double n1 = b / c;
            double n2 = Math.Atan(n1)* (180 / Math.PI);
            return Math.Round(n2,2);
        }

        static double Calcular_C(double b, double c)
        {
            double n1 = c / b;
            double n2 = Math.Atan(n1) * (180 / Math.PI);
            return Math.Round(n2,2);
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            catetoB.Text = "";
            catetoC.Text = "";
            lb1.Text = 0.ToString();
            lb2.Text = 0.ToString();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
      
        }



        private void PictureBox3_Click(object sender, EventArgs e)
        {
            
            DialogResult = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;

            }
            else if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void Class11_Click(object sender, EventArgs e)
        {
            segundoFormulario cambioF = new();
            this.Dispose();
            cambioF.Show();
        }
    }
}
