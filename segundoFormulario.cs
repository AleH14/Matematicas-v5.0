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
    public partial class segundoFormulario : Form
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

        public segundoFormulario()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
           
            
            DialogResult = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes) {
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

        private void SegundoFormulario_Load(object sender, EventArgs e)
        {

        }

        private void Class19_Click(object sender, EventArgs e)
        {
            formularioCreditos cambio = new();
            cambio.Show();
            this.Dispose();
        }

        private void Class13_Click(object sender, EventArgs e)
        {
            ReglaDeCramer cambio = new();
            cambio.Show();
            this.Dispose();
        }

        private void Class15_Click(object sender, EventArgs e)
        {
            Herencia cambio = new();
            cambio.Show();
            this.Dispose();
        }

        private void Class12_Click(object sender, EventArgs e)
        {
            AngulosAgudo cambio = new();
            cambio.Show();
            this.Dispose();
            
            
        }

        private void Class16_Click(object sender, EventArgs e)
        {
            MainForm cambio = new();
            cambio.Show();
            this.Dispose();

        }

        private void Class14_Click(object sender, EventArgs e)
        {
            Cajero cambio = new();
            cambio.Show();
            this.Dispose();
        }

        private void Class17_Click(object sender, EventArgs e)
        {
            Mcm cambio = new();
            cambio.Show();
            this.Dispose();
        }
    }
}
