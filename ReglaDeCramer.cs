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

    public partial class ReglaDeCramer : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
    (
    int nLeftRect,
    int nTopRect,
    int RightRect,
    int nBottomRect,
    int nWidthEllipse,
    int nHeightEllipse);
        public ReglaDeCramer()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void ReglaDeCramer_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void class11_Click(object sender, EventArgs e)
        {
            segundoFormulario cambioF = new segundoFormulario();
            this.Dispose();
            cambioF.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
                    }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void class12_Click(object sender, EventArgs e)
        {

            //validamos la entrada 
            if (textX1.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en x1", "Error");
                return;
            }
            double x1;
            try
            {
                x1 = Convert.ToDouble(textX1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un valor numerico x1", "Error");
                textX1.Text = "";
                return;
            }

            if (textY1.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en y1", "Error");
                return;
            }
            double y1;
            try
            {
                y1 = Convert.ToDouble(textY1.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un valor numerico y1", "Error");
                textY1.Text = "";
                return;
            }

            if (textR1.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en r1", "Error");
                return;
            }
            double r1;
            try
            {
                r1 = Convert.ToDouble(textR1.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un valor numerico r1", "Error");
                textR1.Text = "";

                return;
            }
            if (textX2.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en x2", "Error");
                return;
            }
            double x2;
            try
            {
                x2 = Convert.ToDouble(textX2.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un valor numerico x2", "Error");
                textX2.Text = "";
                return;
            }
            if (textY2.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en y2", "Error");
                return;
            }
            double y2;
            try
            {
                y2 = Convert.ToDouble(textY2.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un valor numerico y2", "Error");
                textY2.Text = "";
                return;
            }
            if (textR2.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en r2", "Error");
                return;
            }
            double r2;
            try
            {
                r2 = Convert.ToDouble(textR2.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un valor numerico r2", "Error");
                textR2.Text = "";
                textR2.Focus();
                return;
            }

            double x, y;
            Cramer(x1, y1, r1, x2, y2, r2, out y, out x);


            textX.Text = x.ToString();
            textY.Text = y.ToString();

        }

        private void textX2_TextChanged(object sender, EventArgs e)
        {
          
        }
        private void Cramer(double x1, double y1, double r1, double x2, double y2, double r2, out double y, out double x)
        { 
            double resul1,resul2, resul3;
            resul1 = (x1 * y2) - (y1 * x2);
            resul2 = (r1 * y2) - (r2 * y1);
            resul3 = (x1 * r2) - (x2 * r1);
             y = Math.Round(resul3 / resul1,2);
            x = Math.Round(resul2 / resul1,2);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void class13_Click(object sender, EventArgs e)
        {
            textX1.Text = "";
            textY1.Text = "";
            textR1.Text = "";
            textX2.Text = "";
            textY2.Text = "";
            textR2.Text = "";
            textY.Text = "";
            textX.Text = "";
        }
    }
}
