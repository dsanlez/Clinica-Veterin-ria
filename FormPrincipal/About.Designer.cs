namespace FormPrincipal
{
    partial class About
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
            lblNome = new Label();
            lblData = new Label();
            lblVersao = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(168, 73);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(163, 17);
            lblNome.TabIndex = 0;
            lblNome.Text = "Criado por: Diogo Sanlez";
            lblNome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblData.Location = new Point(223, 113);
            lblData.Name = "lblData";
            lblData.Size = new Size(37, 17);
            lblData.TabIndex = 1;
            lblData.Text = "Data";
            // 
            // lblVersao
            // 
            lblVersao.AutoSize = true;
            lblVersao.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblVersao.Location = new Point(223, 154);
            lblVersao.Name = "lblVersao";
            lblVersao.Size = new Size(53, 17);
            lblVersao.TabIndex = 2;
            lblVersao.Text = "Versão ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.linkedin;
            pictureBox1.Location = new Point(3, 221);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 23);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(522, 247);
            Controls.Add(pictureBox1);
            Controls.Add(lblVersao);
            Controls.Add(lblData);
            Controls.Add(lblNome);
            Name = "About";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblData;
        private Label lblVersao;
        private PictureBox pictureBox1;
    }
}