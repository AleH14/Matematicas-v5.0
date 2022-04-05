/*
 * Creado por SharpDevelop.
 * Usuario: MINEDUCYT
 * Fecha: 13/3/2022
 * Hora: 17:10
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Matematicas_v5
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txta = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.Año = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.class11 = new Matematicas_v5._0.Class1();
            this.class13 = new Matematicas_v5._0.Class1();
            this.class14 = new Matematicas_v5._0.Class1();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txta
            // 
            this.txta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(219)))), ((int)(((byte)(239)))));
            this.txta.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txta.Location = new System.Drawing.Point(186, 183);
            this.txta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txta.Name = "txta";
            this.txta.ShortcutsEnabled = false;
            this.txta.Size = new System.Drawing.Size(116, 28);
            this.txta.TabIndex = 0;
            this.txta.TextChanged += new System.EventHandler(this.TxtaTextChanged);
            this.txta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtaKeyPress);
            // 
            // txt2
            // 
            this.txt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(219)))), ((int)(((byte)(239)))));
            this.txt2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt2.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txt2.Location = new System.Drawing.Point(125, 230);
            this.txt2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(271, 26);
            this.txt2.TabIndex = 1;
            // 
            // Año
            // 
            this.Año.BackColor = System.Drawing.Color.Transparent;
            this.Año.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Año.Location = new System.Drawing.Point(186, 153);
            this.Año.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Año.Name = "Año";
            this.Año.Size = new System.Drawing.Size(147, 27);
            this.Año.TabIndex = 4;
            this.Año.Text = "Ingrese un año:";
            this.Año.Click += new System.EventHandler(this.AñoClick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(148, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 43);
            this.label2.TabIndex = 6;
            this.label2.Text = "Año Bisiesto";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Matematicas_v5._0.Properties.Resources.icons8_minimize_window_1;
            this.pictureBox2.Location = new System.Drawing.Point(466, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Matematicas_v5._0.Properties.Resources.icons8_close_window_1;
            this.pictureBox1.Location = new System.Drawing.Point(504, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 32);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // class11
            // 
            this.class11.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.class11.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.class11.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.class11.BorderRadius = 20;
            this.class11.BorderSize = 0;
            this.class11.FlatAppearance.BorderSize = 0;
            this.class11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.class11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.class11.ForeColor = System.Drawing.Color.White;
            this.class11.Image = global::Matematicas_v5._0.Properties.Resources.icons8_back_to;
            this.class11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.class11.Location = new System.Drawing.Point(186, 349);
            this.class11.Name = "class11";
            this.class11.Size = new System.Drawing.Size(125, 32);
            this.class11.TabIndex = 11;
            this.class11.Text = "Volver";
            this.class11.TextColor = System.Drawing.Color.White;
            this.class11.UseVisualStyleBackColor = false;
            this.class11.Click += new System.EventHandler(this.Class11_Click);
            // 
            // class13
            // 
            this.class13.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.class13.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.class13.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.class13.BorderRadius = 20;
            this.class13.BorderSize = 0;
            this.class13.FlatAppearance.BorderSize = 0;
            this.class13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.class13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.class13.ForeColor = System.Drawing.Color.White;
            this.class13.Image = global::Matematicas_v5._0.Properties.Resources.icons8_broom;
            this.class13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.class13.Location = new System.Drawing.Point(261, 262);
            this.class13.Name = "class13";
            this.class13.Size = new System.Drawing.Size(121, 40);
            this.class13.TabIndex = 25;
            this.class13.Text = "Limpiar";
            this.class13.TextColor = System.Drawing.Color.White;
            this.class13.UseVisualStyleBackColor = false;
            this.class13.Click += new System.EventHandler(this.Class13_Click);
            // 
            // class14
            // 
            this.class14.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.class14.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.class14.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.class14.BorderRadius = 20;
            this.class14.BorderSize = 0;
            this.class14.FlatAppearance.BorderSize = 0;
            this.class14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.class14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.class14.ForeColor = System.Drawing.Color.White;
            this.class14.Image = global::Matematicas_v5._0.Properties.Resources.icons8_equal_sign1;
            this.class14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.class14.Location = new System.Drawing.Point(94, 262);
            this.class14.Name = "class14";
            this.class14.Size = new System.Drawing.Size(138, 40);
            this.class14.TabIndex = 26;
            this.class14.Text = "Calcular";
            this.class14.TextColor = System.Drawing.Color.White;
            this.class14.UseVisualStyleBackColor = false;
            this.class14.Click += new System.EventHandler(this.Class14_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(547, 435);
            this.Controls.Add(this.class14);
            this.Controls.Add(this.class13);
            this.Controls.Add(this.class11);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Año);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txta);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PEapp";
            this.Load += new System.EventHandler(this.MainFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Año;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txta;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private _0.Class1 class11;
        private _0.Class1 class13;
        private _0.Class1 class14;
    }
}
