namespace FormPrincipal
{
    partial class FormVerPets
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxPets;
        private Label lblIdPet;
        private Label lblNomePet;
        private Label lblEspeciePet;
        private Label lblDataNascimentoPet;        
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxConsultas;
        private System.Windows.Forms.Label label5;
        private Label lblConsultas;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerPets));
            listBoxPets = new ListBox();
            lblIdPet = new Label();
            lblNomePet = new Label();
            lblEspeciePet = new Label();
            lblDataNascimentoPet = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            listBoxConsultas = new ListBox();
            label5 = new Label();
            lblConsultas = new Label();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // listBoxPets
            // 
            listBoxPets.FormattingEnabled = true;
            listBoxPets.ItemHeight = 17;
            listBoxPets.Location = new Point(26, 85);
            listBoxPets.Name = "listBoxPets";
            listBoxPets.Size = new Size(237, 208);
            listBoxPets.TabIndex = 0;
            listBoxPets.SelectedIndexChanged += listBoxPets_SelectedIndexChanged;
            // 
            // lblIdPet
            // 
            lblIdPet.AutoSize = true;
            lblIdPet.Font = new Font("Segoe UI", 9.75F);
            lblIdPet.Location = new Point(414, 24);
            lblIdPet.Name = "lblIdPet";
            lblIdPet.Size = new Size(20, 17);
            lblIdPet.TabIndex = 1;
            lblIdPet.Text = "ID";
            // 
            // lblNomePet
            // 
            lblNomePet.AutoSize = true;
            lblNomePet.Font = new Font("Segoe UI", 9.75F);
            lblNomePet.Location = new Point(414, 61);
            lblNomePet.Name = "lblNomePet";
            lblNomePet.Size = new Size(44, 17);
            lblNomePet.TabIndex = 2;
            lblNomePet.Text = "Nome";
            // 
            // lblEspeciePet
            // 
            lblEspeciePet.AutoSize = true;
            lblEspeciePet.Font = new Font("Segoe UI", 9.75F);
            lblEspeciePet.Location = new Point(414, 98);
            lblEspeciePet.Name = "lblEspeciePet";
            lblEspeciePet.Size = new Size(52, 17);
            lblEspeciePet.TabIndex = 3;
            lblEspeciePet.Text = "Espécie";
            // 
            // lblDataNascimentoPet
            // 
            lblDataNascimentoPet.AutoSize = true;
            lblDataNascimentoPet.Font = new Font("Segoe UI", 9.75F);
            lblDataNascimentoPet.Location = new Point(414, 135);
            lblDataNascimentoPet.Name = "lblDataNascimentoPet";
            lblDataNascimentoPet.Size = new Size(77, 17);
            lblDataNascimentoPet.TabIndex = 4;
            lblDataNascimentoPet.Text = "Nascimento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(300, 27);
            label1.Name = "label1";
            label1.Size = new Size(22, 17);
            label1.TabIndex = 5;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(300, 63);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 6;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(300, 99);
            label3.Name = "label3";
            label3.Size = new Size(53, 17);
            label3.TabIndex = 7;
            label3.Text = "Espécie";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(300, 135);
            label4.Name = "label4";
            label4.Size = new Size(81, 17);
            label4.TabIndex = 8;
            label4.Text = "Nascimento";
            // 
            // listBoxConsultas
            // 
            listBoxConsultas.FormattingEnabled = true;
            listBoxConsultas.ItemHeight = 17;
            listBoxConsultas.Location = new Point(300, 204);
            listBoxConsultas.Name = "listBoxConsultas";
            listBoxConsultas.Size = new Size(235, 89);
            listBoxConsultas.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(300, 170);
            label5.Name = "label5";
            label5.Size = new Size(68, 17);
            label5.TabIndex = 10;
            label5.Text = "Consultas";
            // 
            // lblConsultas
            // 
            lblConsultas.Location = new Point(0, 0);
            lblConsultas.Name = "lblConsultas";
            lblConsultas.Size = new Size(100, 23);
            lblConsultas.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(76, 36);
            label6.Name = "label6";
            label6.Size = new Size(128, 21);
            label6.TabIndex = 11;
            label6.Text = "Pets do Cliente:";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(30, 29);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // FormVerPets
            // 
            BackColor = Color.LightGreen;
            ClientSize = new Size(571, 321);
            Controls.Add(pictureBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(listBoxConsultas);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblDataNascimentoPet);
            Controls.Add(lblEspeciePet);
            Controls.Add(lblNomePet);
            Controls.Add(lblIdPet);
            Controls.Add(listBoxPets);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Name = "FormVerPets";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pets do Cliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private PictureBox pictureBox3;
    }
}