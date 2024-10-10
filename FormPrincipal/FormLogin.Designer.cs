namespace FormPrincipal
{
    partial class FormLogin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panelSignUp = new Panel();
            pictureBoxSignUp = new PictureBox();
            linkLabel2 = new LinkLabel();
            lblExitPanel = new Label();
            textBoxPanelPass = new TextBox();
            textBoxPanelLog = new TextBox();
            panel4 = new Panel();
            panel5 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            label3 = new Label();
            pictureBox6 = new PictureBox();
            btnSignUp = new Button();
            panelLogIn = new Panel();
            pictureBoxLogin = new PictureBox();
            linkSignUp = new LinkLabel();
            lblExit = new Label();
            textBox2Password = new TextBox();
            textBoxUserName = new TextBox();
            panel2 = new Panel();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnLogin = new Button();
            panelSignUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSignUp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panelLogIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSignUp
            // 
            panelSignUp.Controls.Add(pictureBoxSignUp);
            panelSignUp.Controls.Add(linkLabel2);
            panelSignUp.Controls.Add(lblExitPanel);
            panelSignUp.Controls.Add(textBoxPanelPass);
            panelSignUp.Controls.Add(textBoxPanelLog);
            panelSignUp.Controls.Add(panel4);
            panelSignUp.Controls.Add(panel5);
            panelSignUp.Controls.Add(pictureBox4);
            panelSignUp.Controls.Add(pictureBox5);
            panelSignUp.Controls.Add(label3);
            panelSignUp.Controls.Add(pictureBox6);
            panelSignUp.Controls.Add(btnSignUp);
            panelSignUp.Dock = DockStyle.Fill;
            panelSignUp.Location = new Point(0, 0);
            panelSignUp.Name = "panelSignUp";
            panelSignUp.Size = new Size(308, 411);
            panelSignUp.TabIndex = 11;
            panelSignUp.Visible = false;
            // 
            // pictureBoxSignUp
            // 
            pictureBoxSignUp.Image = Properties.Resources.about;
            pictureBoxSignUp.Location = new Point(3, 381);
            pictureBoxSignUp.Name = "pictureBoxSignUp";
            pictureBoxSignUp.Size = new Size(26, 27);
            pictureBoxSignUp.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxSignUp.TabIndex = 24;
            pictureBoxSignUp.TabStop = false;
            pictureBoxSignUp.Click += pictureBoxSignUp_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(112, 345);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(84, 15);
            linkLabel2.TabIndex = 21;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Já tenho conta";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // lblExitPanel
            // 
            lblExitPanel.AutoSize = true;
            lblExitPanel.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExitPanel.Location = new Point(249, 381);
            lblExitPanel.Name = "lblExitPanel";
            lblExitPanel.Size = new Size(39, 19);
            lblExitPanel.TabIndex = 20;
            lblExitPanel.Text = "Sair";
            lblExitPanel.Click += lblExitPanel_Click_1;
            // 
            // textBoxPanelPass
            // 
            textBoxPanelPass.BackColor = Color.LightGreen;
            textBoxPanelPass.BorderStyle = BorderStyle.None;
            textBoxPanelPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPanelPass.Location = new Point(58, 240);
            textBoxPanelPass.Name = "textBoxPanelPass";
            textBoxPanelPass.PasswordChar = '*';
            textBoxPanelPass.PlaceholderText = "Password";
            textBoxPanelPass.Size = new Size(212, 22);
            textBoxPanelPass.TabIndex = 11;
            textBoxPanelPass.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxPanelLog
            // 
            textBoxPanelLog.BackColor = Color.LightGreen;
            textBoxPanelLog.BorderStyle = BorderStyle.None;
            textBoxPanelLog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPanelLog.Location = new Point(58, 170);
            textBoxPanelLog.Name = "textBoxPanelLog";
            textBoxPanelLog.PlaceholderText = "Username";
            textBoxPanelLog.Size = new Size(212, 22);
            textBoxPanelLog.TabIndex = 12;
            textBoxPanelLog.TextAlign = HorizontalAlignment.Center;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(28, 270);
            panel4.Name = "panel4";
            panel4.Size = new Size(236, 1);
            panel4.TabIndex = 18;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(29, 199);
            panel5.Name = "panel5";
            panel5.Size = new Size(236, 1);
            panel5.TabIndex = 19;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(31, 239);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(25, 25);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.user;
            pictureBox5.Location = new Point(32, 168);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(25, 25);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 17;
            pictureBox5.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Tai Le", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(80, 94);
            label3.Name = "label3";
            label3.Size = new Size(146, 41);
            label3.TabIndex = 15;
            label3.Text = "SIGN UP";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.LightGreen;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(110, 12);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(87, 71);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 14;
            pictureBox6.TabStop = false;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.LightGreen;
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = Color.Black;
            btnSignUp.Location = new Point(38, 294);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(236, 36);
            btnSignUp.TabIndex = 13;
            btnSignUp.Text = "SIGN UP";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // panelLogIn
            // 
            panelLogIn.Controls.Add(pictureBoxLogin);
            panelLogIn.Controls.Add(linkSignUp);
            panelLogIn.Controls.Add(lblExit);
            panelLogIn.Controls.Add(textBox2Password);
            panelLogIn.Controls.Add(textBoxUserName);
            panelLogIn.Controls.Add(panel2);
            panelLogIn.Controls.Add(panel1);
            panelLogIn.Controls.Add(pictureBox3);
            panelLogIn.Controls.Add(pictureBox2);
            panelLogIn.Controls.Add(label1);
            panelLogIn.Controls.Add(pictureBox1);
            panelLogIn.Controls.Add(btnLogin);
            panelLogIn.Dock = DockStyle.Fill;
            panelLogIn.Location = new Point(0, 0);
            panelLogIn.Name = "panelLogIn";
            panelLogIn.Size = new Size(308, 411);
            panelLogIn.TabIndex = 12;
            // 
            // pictureBoxLogin
            // 
            pictureBoxLogin.Image = Properties.Resources.about;
            pictureBoxLogin.Location = new Point(3, 381);
            pictureBoxLogin.Name = "pictureBoxLogin";
            pictureBoxLogin.Size = new Size(26, 27);
            pictureBoxLogin.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxLogin.TabIndex = 23;
            pictureBoxLogin.TabStop = false;
            pictureBoxLogin.Click += pictureBoxLogin_Click;
            // 
            // linkSignUp
            // 
            linkSignUp.AutoSize = true;
            linkSignUp.LinkColor = Color.Black;
            linkSignUp.Location = new Point(77, 345);
            linkSignUp.Name = "linkSignUp";
            linkSignUp.Size = new Size(148, 15);
            linkSignUp.TabIndex = 22;
            linkSignUp.TabStop = true;
            linkSignUp.Text = "Não tem conta? Registe-se";
            linkSignUp.LinkClicked += linkSignUp_LinkClicked;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExit.Location = new Point(249, 381);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(39, 19);
            lblExit.TabIndex = 21;
            lblExit.Text = "Sair";
            lblExit.Click += lblExit_Click;
            // 
            // textBox2Password
            // 
            textBox2Password.BackColor = Color.LightGreen;
            textBox2Password.BorderStyle = BorderStyle.None;
            textBox2Password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2Password.Location = new Point(57, 239);
            textBox2Password.Name = "textBox2Password";
            textBox2Password.PasswordChar = '*';
            textBox2Password.PlaceholderText = "Password";
            textBox2Password.Size = new Size(212, 22);
            textBox2Password.TabIndex = 2;
            textBox2Password.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxUserName
            // 
            textBoxUserName.BackColor = Color.LightGreen;
            textBoxUserName.BorderStyle = BorderStyle.None;
            textBoxUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUserName.Location = new Point(58, 168);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.PlaceholderText = "Username";
            textBoxUserName.Size = new Size(212, 22);
            textBoxUserName.TabIndex = 1;
            textBoxUserName.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(29, 270);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 1);
            panel2.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(29, 199);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 1);
            panel1.TabIndex = 20;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(31, 239);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(32, 168);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Tai Le", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(94, 94);
            label1.Name = "label1";
            label1.Size = new Size(125, 41);
            label1.TabIndex = 16;
            label1.Text = "LOG IN";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightGreen;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(110, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightGreen;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(35, 294);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(236, 36);
            btnLogin.TabIndex = 14;
            btnLogin.Text = "LOG IN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(308, 411);
            Controls.Add(panelLogIn);
            Controls.Add(panelSignUp);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            Load += FormLogin_Load;
            panelSignUp.ResumeLayout(false);
            panelSignUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSignUp).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panelLogIn.ResumeLayout(false);
            panelLogIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelSignUp;
        private LinkLabel linkLabel2;
        private Label lblExitPanel;
        private TextBox textBoxPanelPass;
        private TextBox textBoxPanelLog;
        private Panel panel4;
        private Panel panel5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label3;
        private PictureBox pictureBox6;
        private Button btnSignUp;
        private Panel panelLogIn;
        private LinkLabel linkSignUp;
        private Label lblExit;
        private TextBox textBox2Password;
        private TextBox textBoxUserName;
        private Panel panel2;
        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnLogin;
        private PictureBox pictureBoxLogin;
        private PictureBox pictureBoxSignUp;
    }
}