namespace FormPrincipal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBoxLogo = new PictureBox();
            mainPanel = new Panel();
            lblUser = new Label();
            lblData = new Label();
            lblHoras = new Label();
            panel7 = new Panel();
            sideBarContainer = new FlowLayoutPanel();
            panel2 = new Panel();
            label1 = new Label();
            menuButton = new PictureBox();
            panel8 = new Panel();
            btnHome = new Button();
            panel1 = new Panel();
            btnClientes = new Button();
            panel3 = new Panel();
            btnAnimal = new Button();
            panel4 = new Panel();
            btnMedicos = new Button();
            panel5 = new Panel();
            btnConsultas = new Button();
            panel6 = new Panel();
            btnAbout = new Button();
            sideBarTimer = new System.Windows.Forms.Timer(components);
            timerHoras = new System.Windows.Forms.Timer(components);
            panel9 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panel7.SuspendLayout();
            sideBarContainer.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            panel8.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(282, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(435, 49);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxLogo.TabIndex = 2;
            pictureBoxLogo.TabStop = false;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(184, 129);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1096, 499);
            mainPanel.TabIndex = 2;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(919, 28);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(65, 25);
            lblUser.TabIndex = 10;
            lblUser.Text = "label3";
            // 
            // lblData
            // 
            lblData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblData.ImageAlign = ContentAlignment.MiddleRight;
            lblData.Location = new Point(57, 13);
            lblData.Name = "lblData";
            lblData.Size = new Size(112, 21);
            lblData.TabIndex = 11;
            lblData.Text = "DD:MM:YYYY";
            lblData.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblHoras
            // 
            lblHoras.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblHoras.AutoSize = true;
            lblHoras.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoras.ImageAlign = ContentAlignment.MiddleRight;
            lblHoras.Location = new Point(57, 46);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(90, 21);
            lblHoras.TabIndex = 10;
            lblHoras.Text = "HH:MM:SS";
            lblHoras.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel7
            // 
            panel7.Controls.Add(pictureBoxLogo);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(184, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(1096, 49);
            panel7.TabIndex = 7;
            // 
            // sideBarContainer
            // 
            sideBarContainer.BackColor = Color.LightGreen;
            sideBarContainer.Controls.Add(panel2);
            sideBarContainer.Controls.Add(panel8);
            sideBarContainer.Controls.Add(panel1);
            sideBarContainer.Controls.Add(panel3);
            sideBarContainer.Controls.Add(panel4);
            sideBarContainer.Controls.Add(panel5);
            sideBarContainer.Controls.Add(panel6);
            sideBarContainer.Dock = DockStyle.Left;
            sideBarContainer.Location = new Point(0, 0);
            sideBarContainer.MaximumSize = new Size(184, 639);
            sideBarContainer.MinimumSize = new Size(57, 639);
            sideBarContainer.Name = "sideBarContainer";
            sideBarContainer.Size = new Size(184, 639);
            sideBarContainer.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(menuButton);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(181, 126);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(68, 39);
            label1.Name = "label1";
            label1.Size = new Size(70, 30);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            // 
            // menuButton
            // 
            menuButton.Image = (Image)resources.GetObject("menuButton.Image");
            menuButton.Location = new Point(14, 42);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(28, 27);
            menuButton.SizeMode = PictureBoxSizeMode.Zoom;
            menuButton.TabIndex = 0;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnHome);
            panel8.Location = new Point(3, 135);
            panel8.Name = "panel8";
            panel8.Size = new Size(197, 33);
            panel8.TabIndex = 9;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.LightGreen;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.Black;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(-17, -7);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(30, 0, 0, 0);
            btnHome.Size = new Size(230, 49);
            btnHome.TabIndex = 6;
            btnHome.Text = "       Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClientes);
            panel1.Location = new Point(3, 174);
            panel1.Name = "panel1";
            panel1.Size = new Size(197, 33);
            panel1.TabIndex = 6;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.LightGreen;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = Color.Black;
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(-17, -7);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(30, 0, 0, 0);
            btnClientes.Size = new Size(230, 49);
            btnClientes.TabIndex = 6;
            btnClientes.Text = "       Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click_1;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnAnimal);
            panel3.Location = new Point(3, 213);
            panel3.Name = "panel3";
            panel3.Size = new Size(197, 33);
            panel3.TabIndex = 5;
            // 
            // btnAnimal
            // 
            btnAnimal.BackColor = Color.LightGreen;
            btnAnimal.FlatStyle = FlatStyle.Flat;
            btnAnimal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnimal.ForeColor = Color.Black;
            btnAnimal.Image = Properties.Resources._9035065_paw_icon;
            btnAnimal.ImageAlign = ContentAlignment.MiddleLeft;
            btnAnimal.Location = new Point(-17, -7);
            btnAnimal.Name = "btnAnimal";
            btnAnimal.Padding = new Padding(30, 0, 0, 0);
            btnAnimal.Size = new Size(230, 49);
            btnAnimal.TabIndex = 6;
            btnAnimal.Text = "       Animais";
            btnAnimal.TextAlign = ContentAlignment.MiddleLeft;
            btnAnimal.UseVisualStyleBackColor = false;
            btnAnimal.Click += btnAnimal_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnMedicos);
            panel4.Location = new Point(3, 252);
            panel4.Name = "panel4";
            panel4.Size = new Size(197, 33);
            panel4.TabIndex = 7;
            // 
            // btnMedicos
            // 
            btnMedicos.BackColor = Color.LightGreen;
            btnMedicos.FlatStyle = FlatStyle.Flat;
            btnMedicos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMedicos.ForeColor = Color.Black;
            btnMedicos.Image = (Image)resources.GetObject("btnMedicos.Image");
            btnMedicos.ImageAlign = ContentAlignment.MiddleLeft;
            btnMedicos.Location = new Point(-17, -7);
            btnMedicos.Name = "btnMedicos";
            btnMedicos.Padding = new Padding(30, 0, 0, 0);
            btnMedicos.Size = new Size(230, 49);
            btnMedicos.TabIndex = 6;
            btnMedicos.Text = "       Médicos";
            btnMedicos.TextAlign = ContentAlignment.MiddleLeft;
            btnMedicos.UseVisualStyleBackColor = false;
            btnMedicos.Click += btnMedicos_Click_1;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnConsultas);
            panel5.Location = new Point(3, 291);
            panel5.Name = "panel5";
            panel5.Size = new Size(197, 33);
            panel5.TabIndex = 8;
            // 
            // btnConsultas
            // 
            btnConsultas.BackColor = Color.LightGreen;
            btnConsultas.FlatStyle = FlatStyle.Flat;
            btnConsultas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultas.ForeColor = Color.Black;
            btnConsultas.Image = (Image)resources.GetObject("btnConsultas.Image");
            btnConsultas.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultas.Location = new Point(-17, -7);
            btnConsultas.Name = "btnConsultas";
            btnConsultas.Padding = new Padding(30, 0, 0, 0);
            btnConsultas.Size = new Size(230, 49);
            btnConsultas.TabIndex = 6;
            btnConsultas.Text = "       Consultas";
            btnConsultas.TextAlign = ContentAlignment.MiddleLeft;
            btnConsultas.UseVisualStyleBackColor = false;
            btnConsultas.Click += btnConsultas_Click_2;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnAbout);
            panel6.Location = new Point(3, 330);
            panel6.Name = "panel6";
            panel6.Size = new Size(197, 33);
            panel6.TabIndex = 9;
            // 
            // btnAbout
            // 
            btnAbout.BackColor = Color.LightGreen;
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAbout.ForeColor = Color.Black;
            btnAbout.Image = (Image)resources.GetObject("btnAbout.Image");
            btnAbout.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbout.Location = new Point(-17, -7);
            btnAbout.Name = "btnAbout";
            btnAbout.Padding = new Padding(30, 0, 0, 0);
            btnAbout.Size = new Size(230, 49);
            btnAbout.TabIndex = 6;
            btnAbout.Text = "       About";
            btnAbout.TextAlign = ContentAlignment.MiddleLeft;
            btnAbout.UseVisualStyleBackColor = false;
            btnAbout.Click += btnAbout_Click_1;
            // 
            // sideBarTimer
            // 
            sideBarTimer.Interval = 30;
            sideBarTimer.Tick += sideBarTimer_Tick;
            // 
            // timerHoras
            // 
            timerHoras.Tick += timerHoras_Tick;
            // 
            // panel9
            // 
            panel9.BackColor = Color.LightGreen;
            panel9.Controls.Add(pictureBox1);
            panel9.Controls.Add(lblUser);
            panel9.Controls.Add(lblHoras);
            panel9.Controls.Add(lblData);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(184, 49);
            panel9.Name = "panel9";
            panel9.Size = new Size(1096, 80);
            panel9.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user64;
            pictureBox1.Location = new Point(863, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 628);
            Controls.Add(mainPanel);
            Controls.Add(panel9);
            Controls.Add(panel7);
            Controls.Add(sideBarContainer);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panel7.ResumeLayout(false);
            sideBarContainer.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            panel8.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBoxLogo;
        private Panel mainPanel;
        private FlowLayoutPanel sideBarContainer;
        private Panel panel2;
        private Panel panel3;
        private Button btnAnimal;
        private Panel panel1;
        private Button btnClientes;
        private Panel panel4;
        private Button btnMedicos;
        private Panel panel5;
        private Button btnConsultas;
        private PictureBox menuButton;
        private Label label1;
        private System.Windows.Forms.Timer sideBarTimer;
        private Panel panel6;
        private Button btnAbout;
        private Panel panel7;
        private Label lblUser;
        private Label lblHoras;
        private System.Windows.Forms.Timer timerHoras;
        private Label lblData;
        private Panel panel9;
        private Panel panel8;
        private Button btnHome;
        private PictureBox pictureBox1;
    }
}
