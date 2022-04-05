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
    public partial class Herencia : Form
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
        public Herencia()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void Herencia_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
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


        private void Class12_Click(object sender, EventArgs e)
        {

            //validamos la entrada 
            if (textHere.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor", "Error");
                return;
            }
            double x1;
            try
            {
                x1 = Convert.ToDouble(textHere.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un valor numerico", "Error");
                textHere.Text = "";
                return;
            }

            Herenci(x1, out double juan, out double luis, out double rosa, out double abogado);
            textJuan.Text = juan.ToString();
            textLuis.Text = luis.ToString();
            textRosa.Text = rosa.ToString();
            textAboga.Text = abogado.ToString();
        }
        private static void Herenci(double x1, out double juan,out  double luis,out  double rosa, out double abogado)
        {
            juan = Math.Round(x1 / 3, 2);
            luis = Math.Round((4 * x1) / 9, 2);
            rosa = Math.Round((2*x1)/9,2);
            abogado = Math.Round((juan*0.05)+(luis*0.05)+(rosa*0.03));
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Class13_Click(object sender, EventArgs e)
        {
            textHere.Text = "";
            textRosa.Text = "";
            textJuan.Text = "";
            textLuis.Text = "";
            textAboga.Text = "";
        }
    }
}
