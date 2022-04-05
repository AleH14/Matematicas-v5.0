/*
 * Creado por SharpDevelop.
 * Usuario: MINEDUCYT
 * Fecha: 29/3/2022
 * Hora: 20:05
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Matematicas_v5._0;

namespace Matematicas_v5
{
	/// <summary>
	/// Description of cajero.
	/// </summary>
	public partial class Cajero : Form
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
		public Cajero()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		//int monto;
		
		
			
		
		
		void Btn1Click(object sender, EventArgs e)
		{
			if (can.Text == "")
			{
				MessageBox.Show("Debe ingresar un valor en este campo", "Error");
				return;
			}
			int monto;
			try
			{
				monto = Convert.ToInt32(can.Text);
			}
			catch (Exception)
			{
				MessageBox.Show("Debe ingresar un valor numerico ", "Error");
				can.Text = "";
				return;
			}
			

int uno , cinco, diez, veinte, cien ;
		monto = Convert.ToInt16(can.Text);
		
		
	if(monto>=100)
			{
				cien = monto/100;
				textBox5.Text= (cien+ " billetes de $100");
				monto %= 100;
			}
			
			if(monto>=20)
			{
				veinte = monto/20;
				textBox4.Text= (veinte+ " billetes de $20");
				monto%=20;
			}
			if(monto>=10)
			{
				diez = monto/10;
				textBox3.Text= (diez+" billetes de $10");
				monto%=10;
			}

			if(monto>=5)
			{
				cinco = monto/5;
				textBox2.Text= (cinco+" billetes de $5");
				monto%=5;
			}
			if(monto>=1)
			{
				uno = monto/1;
				textBox1.Text= (uno+ " billetes de $1 ");
			}
			
			
		
		
			}	
		public void Borrar(){
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
			textBox5.Clear();
			can.Clear();
		}
		
		void GroupBox1Enter(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
		Borrar();	
		}
		
		
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		//Validacion de campos vacios
		
		void CajeroLoad(object sender, EventArgs e)
		{
			btn1.Enabled= false;
		}
		private void Validarvacio(){
			var vr = !String.IsNullOrEmpty(can.Text);
			btn1.Enabled = vr;
				
		}
		
		void CanTextChanged(object sender, EventArgs e)
		{
			// metodo
			Validarvacio();
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
    }
	}

