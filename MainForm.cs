/*
 * Creado por SharpDevelop.
 * Usuario: MINEDUCYT
 * Fecha: 13/3/2022
 * Hora: 17:10
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Matematicas_v5._0;

namespace Matematicas_v5
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
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
		public MainForm()
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
		
		void Button1Click(object sender, EventArgs e)
		{
			
			
			//Declaracion de variables
			int año;
			string mensaje;
			
			//leer variable
			año = Convert.ToInt32(txta.Text);
			
			// determinar 
			if (año % 4==0)
				//si la respuesta es positivo
				mensaje = "El año " +año+" es bisiesto";
			else
				//respuesta negativa
				mensaje = ("El año "+ año + " no es bisiesto");
			
			//escribir mensaje
			txt2.Text = mensaje;
		}
		
		
		void TxtaKeyPress(object sender, KeyPressEventArgs e)
		{
			
	}
		//validacion de campo vacio
		
		void MainFormLoad(object sender, EventArgs e)
		{
			class14.Enabled= false;
		}
		private void Validarvacio(){
			var vr = !String.IsNullOrEmpty(txta.Text);
			class14.Enabled = vr;
				
		}
		//metodo
		
		void TxtaTextChanged(object sender, EventArgs e)
		{
			Validarvacio();
		}
		
		void AñoClick(object sender, EventArgs e)
		{
			
		}
		//borrar
		
		void Button3Click(object sender, EventArgs e)
		{
			Borrar();
		}
		public void Borrar(){
			txta.Clear();
			txt2.Clear();
			
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

        
        private void Class13_Click(object sender, EventArgs e)
        {
			Borrar();
		}

        private void Class14_Click(object sender, EventArgs e)
        {
			//Declaracion de variables
			if (txta.Text == "")
			{
				MessageBox.Show("Debe ingresar un año", "Error");
				return;
			}
			int año ;
			try
			{
				año = Convert.ToInt32(txta.Text);
			}
			catch (Exception)
			{
				MessageBox.Show("Debe ingresar un año", "Error");
				txta.Text = "";
				return;
			}


			string mensaje;

			//leer variable


			// determinar 
			if (año % 4 == 0)
				//si la respuesta es positivo
				mensaje = "El año " + año + " es bisiesto";
			else
				//respuesta negativa
				mensaje = ("El año " + año + " no es bisiesto");

			//escribir mensaje
			txt2.Text = mensaje;
		}
    }
	}
