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
    public partial class Mcm : Form
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
        public Mcm()
        {

            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void class11_Click(object sender, EventArgs e)
        {
            segundoFormulario cambioF = new();
            this.Dispose();
            cambioF.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void class12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en espacio 1", "Error");
                return;
            }
            int n1;
            
            try
            {
                n1 = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un valor numerico C", "Error");
                textBox1.Text = "";
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en valor 2", "Error");
                return;
            }
            int n2;
            try
            {
                n2 = Convert.ToInt32(textBox2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un valor numerico en valor 2", "Error");
                textBox2.Text = "";
                return;
            }
            int  vn1, vn2, mcm = 1, div = 2;

            n1 = Math.Abs(n1);
            n2 = Math.Abs(n2);
            vn1 = n1;
            vn2 = n2;

            while (div <= n1 || div <= n2)
            {

                while ((div <= n1 && n1 % div == 0) || (div <= n2 && n2 % div == 0))
                {

                    mcm = mcm * div;

                    if ((div <= n1 && n1 % div == 0))
                        n1 = n1 / div;
                    if ((div <= n2 && n2 % div == 0))
                        n2 = n2 / div;
                }
                div = div + 1;
            }
            String men;
            men = "El M.C.M entre " + vn1 + " y " + vn2 + " es: "+mcm;
            textBox3.Text = men;
        }

        private void class13_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
