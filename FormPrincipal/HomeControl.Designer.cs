namespace FormPrincipal
{
    partial class HomeControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeControl));
            lblNmrMedicos = new Label();
            lblNmrClientes = new Label();
            lblNmrAnimais = new Label();
            lblNmrConsultas = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox5 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNmrMedicos
            // 
            lblNmrMedicos.AutoSize = true;
            lblNmrMedicos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNmrMedicos.Location = new Point(174, 316);
            lblNmrMedicos.Name = "lblNmrMedicos";
            lblNmrMedicos.Size = new Size(86, 25);
            lblNmrMedicos.TabIndex = 0;
            lblNmrMedicos.Text = "Medicos";
            // 
            // lblNmrClientes
            // 
            lblNmrClientes.AutoSize = true;
            lblNmrClientes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNmrClientes.Location = new Point(172, 234);
            lblNmrClientes.Name = "lblNmrClientes";
            lblNmrClientes.Size = new Size(81, 25);
            lblNmrClientes.TabIndex = 1;
            lblNmrClientes.Text = "Clientes";
            // 
            // lblNmrAnimais
            // 
            lblNmrAnimais.AutoSize = true;
            lblNmrAnimais.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNmrAnimais.Location = new Point(172, 153);
            lblNmrAnimais.Name = "lblNmrAnimais";
            lblNmrAnimais.Size = new Size(82, 25);
            lblNmrAnimais.TabIndex = 2;
            lblNmrAnimais.Text = "Animais";
            // 
            // lblNmrConsultas
            // 
            lblNmrConsultas.AutoSize = true;
            lblNmrConsultas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNmrConsultas.Location = new Point(176, 394);
            lblNmrConsultas.Name = "lblNmrConsultas";
            lblNmrConsultas.Size = new Size(98, 25);
            lblNmrConsultas.TabIndex = 3;
            lblNmrConsultas.Text = "Consultas";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(125, 387);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(125, 146);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.user64;
            pictureBox4.Location = new Point(125, 229);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(43, 38);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(125, 309);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(626, 124);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(482, 394);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(106, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(893, 55);
            panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(4, 9);
            label1.Name = "label1";
            label1.Size = new Size(257, 37);
            label1.TabIndex = 0;
            label1.Text = "Registos da Clínica";
            // 
            // HomeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(lblNmrConsultas);
            Controls.Add(lblNmrAnimais);
            Controls.Add(lblNmrClientes);
            Controls.Add(lblNmrMedicos);
            Controls.Add(pictureBox5);
            Name = "HomeControl";
            Size = new Size(1096, 499);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNmrMedicos;
        private Label lblNmrClientes;
        private Label lblNmrAnimais;
        private Label lblNmrConsultas;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private Panel panel1;
        private Label label1;
    }
}
