namespace FormPrincipal
{
    partial class AnimalControl
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
            lblNomePet = new Label();
            lblEspecie = new Label();
            lblDataNascimento = new Label();
            lblClienteID = new Label();
            textBoxNomePet = new TextBox();
            textBoxEspecie = new TextBox();
            btnNovoPet = new Button();
            cmbCliente = new ComboBox();
            listBoxPets = new ListBox();
            btnApagarPet = new Button();
            btnEditarPet = new Button();
            textBoxIdPet = new TextBox();
            ID = new Label();
            textBoxFiltrarPets = new TextBox();
            labelFiltarPets = new Label();
            panel3 = new Panel();
            btnDadosDono = new Button();
            dateTimePickerDataNascimento = new DateTimePicker();
            panel2 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            labelProcuarCliente = new Label();
            cmbFiltrarAnimais = new ComboBox();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNomePet
            // 
            lblNomePet.AutoSize = true;
            lblNomePet.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomePet.Location = new Point(122, 179);
            lblNomePet.Name = "lblNomePet";
            lblNomePet.Size = new Size(49, 17);
            lblNomePet.TabIndex = 0;
            lblNomePet.Text = "Nome:";
            // 
            // lblEspecie
            // 
            lblEspecie.AutoSize = true;
            lblEspecie.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEspecie.Location = new Point(122, 233);
            lblEspecie.Name = "lblEspecie";
            lblEspecie.Size = new Size(57, 17);
            lblEspecie.TabIndex = 1;
            lblEspecie.Text = "Espécie:";
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataNascimento.Location = new Point(122, 287);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(137, 17);
            lblDataNascimento.TabIndex = 2;
            lblDataNascimento.Text = "Data de Nascimento:";
            // 
            // lblClienteID
            // 
            lblClienteID.AutoSize = true;
            lblClienteID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClienteID.Location = new Point(122, 341);
            lblClienteID.Name = "lblClienteID";
            lblClienteID.Size = new Size(46, 17);
            lblClienteID.TabIndex = 3;
            lblClienteID.Text = "Dono:";
            // 
            // textBoxNomePet
            // 
            textBoxNomePet.Location = new Point(266, 177);
            textBoxNomePet.Name = "textBoxNomePet";
            textBoxNomePet.Size = new Size(173, 23);
            textBoxNomePet.TabIndex = 2;
            // 
            // textBoxEspecie
            // 
            textBoxEspecie.Location = new Point(266, 232);
            textBoxEspecie.Name = "textBoxEspecie";
            textBoxEspecie.Size = new Size(173, 23);
            textBoxEspecie.TabIndex = 3;
            // 
            // btnNovoPet
            // 
            btnNovoPet.BackColor = Color.White;
            btnNovoPet.FlatAppearance.BorderColor = Color.White;
            btnNovoPet.FlatStyle = FlatStyle.Flat;
            btnNovoPet.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovoPet.Location = new Point(14, 7);
            btnNovoPet.Name = "btnNovoPet";
            btnNovoPet.Size = new Size(129, 60);
            btnNovoPet.TabIndex = 8;
            btnNovoPet.Text = "Registar Pet";
            btnNovoPet.UseVisualStyleBackColor = false;
            btnNovoPet.Click += btnNovoPet_Click;
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(266, 342);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(173, 23);
            cmbCliente.TabIndex = 5;
            // 
            // listBoxPets
            // 
            listBoxPets.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxPets.FormattingEnabled = true;
            listBoxPets.ItemHeight = 17;
            listBoxPets.Location = new Point(623, 190);
            listBoxPets.Name = "listBoxPets";
            listBoxPets.ScrollAlwaysVisible = true;
            listBoxPets.Size = new Size(370, 191);
            listBoxPets.TabIndex = 10;
            listBoxPets.SelectedIndexChanged += listBoxPets_SelectedIndexChanged;
            // 
            // btnApagarPet
            // 
            btnApagarPet.BackColor = Color.White;
            btnApagarPet.FlatAppearance.BorderColor = Color.White;
            btnApagarPet.FlatStyle = FlatStyle.Flat;
            btnApagarPet.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnApagarPet.Location = new Point(163, 7);
            btnApagarPet.Name = "btnApagarPet";
            btnApagarPet.Size = new Size(129, 60);
            btnApagarPet.TabIndex = 11;
            btnApagarPet.Text = "Apagar Pet";
            btnApagarPet.UseVisualStyleBackColor = false;
            btnApagarPet.Click += btnApagarPet_Click;
            // 
            // btnEditarPet
            // 
            btnEditarPet.BackColor = Color.White;
            btnEditarPet.FlatAppearance.BorderColor = Color.White;
            btnEditarPet.FlatStyle = FlatStyle.Flat;
            btnEditarPet.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnEditarPet.Location = new Point(312, 7);
            btnEditarPet.Name = "btnEditarPet";
            btnEditarPet.Size = new Size(129, 60);
            btnEditarPet.TabIndex = 12;
            btnEditarPet.Text = "Editar Pet";
            btnEditarPet.UseVisualStyleBackColor = false;
            btnEditarPet.Click += btnEditarPet_Click;
            // 
            // textBoxIdPet
            // 
            textBoxIdPet.Enabled = false;
            textBoxIdPet.Location = new Point(266, 122);
            textBoxIdPet.Name = "textBoxIdPet";
            textBoxIdPet.ReadOnly = true;
            textBoxIdPet.Size = new Size(114, 23);
            textBoxIdPet.TabIndex = 1;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ID.Location = new Point(122, 125);
            ID.Name = "ID";
            ID.Size = new Size(74, 17);
            ID.TabIndex = 14;
            ID.Text = "ID Animal:";
            // 
            // textBoxFiltrarPets
            // 
            textBoxFiltrarPets.Location = new Point(696, 142);
            textBoxFiltrarPets.Name = "textBoxFiltrarPets";
            textBoxFiltrarPets.Size = new Size(227, 23);
            textBoxFiltrarPets.TabIndex = 6;
            textBoxFiltrarPets.TextChanged += textBoxFiltrarPets_TextChanged;
            // 
            // labelFiltarPets
            // 
            labelFiltarPets.AutoSize = true;
            labelFiltarPets.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFiltarPets.Location = new Point(444, 237);
            labelFiltarPets.Name = "labelFiltarPets";
            labelFiltarPets.Size = new Size(0, 17);
            labelFiltarPets.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGreen;
            panel3.Controls.Add(btnNovoPet);
            panel3.Controls.Add(btnDadosDono);
            panel3.Controls.Add(btnApagarPet);
            panel3.Controls.Add(btnEditarPet);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 425);
            panel3.Name = "panel3";
            panel3.Size = new Size(1096, 74);
            panel3.TabIndex = 17;
            // 
            // btnDadosDono
            // 
            btnDadosDono.BackColor = Color.White;
            btnDadosDono.FlatAppearance.BorderColor = Color.White;
            btnDadosDono.FlatStyle = FlatStyle.Flat;
            btnDadosDono.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDadosDono.Location = new Point(461, 6);
            btnDadosDono.Name = "btnDadosDono";
            btnDadosDono.Size = new Size(129, 60);
            btnDadosDono.TabIndex = 18;
            btnDadosDono.Text = "Dados Dono";
            btnDadosDono.UseVisualStyleBackColor = false;
            btnDadosDono.Click += btnDadosDono_Click;
            // 
            // dateTimePickerDataNascimento
            // 
            dateTimePickerDataNascimento.CalendarTitleBackColor = Color.LightGreen;
            dateTimePickerDataNascimento.Location = new Point(266, 287);
            dateTimePickerDataNascimento.Name = "dateTimePickerDataNascimento";
            dateTimePickerDataNascimento.Size = new Size(173, 23);
            dateTimePickerDataNascimento.TabIndex = 4;
            dateTimePickerDataNascimento.Value = new DateTime(2024, 6, 25, 0, 0, 0, 0);
            // 
            // panel2
            // 
            panel2.BackColor = Color.Green;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(583, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(438, 42);
            panel2.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(11, 5);
            label2.Name = "label2";
            label2.Size = new Size(181, 30);
            label2.TabIndex = 0;
            label2.Text = "Pesquisar Animal";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(70, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(418, 42);
            panel1.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 5);
            label1.Name = "label1";
            label1.Size = new Size(228, 30);
            label1.TabIndex = 0;
            label1.Text = "Registar Novo Animal";
            // 
            // labelProcuarCliente
            // 
            labelProcuarCliente.AutoSize = true;
            labelProcuarCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProcuarCliente.Location = new Point(693, 105);
            labelProcuarCliente.Name = "labelProcuarCliente";
            labelProcuarCliente.Size = new Size(97, 17);
            labelProcuarCliente.TabIndex = 23;
            labelProcuarCliente.Text = "Pesquisar por:";
            // 
            // cmbFiltrarAnimais
            // 
            cmbFiltrarAnimais.FormattingEnabled = true;
            cmbFiltrarAnimais.Location = new Point(802, 103);
            cmbFiltrarAnimais.Name = "cmbFiltrarAnimais";
            cmbFiltrarAnimais.Size = new Size(121, 23);
            cmbFiltrarAnimais.TabIndex = 24;
            // 
            // AnimalControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cmbFiltrarAnimais);
            Controls.Add(labelProcuarCliente);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dateTimePickerDataNascimento);
            Controls.Add(labelFiltarPets);
            Controls.Add(textBoxFiltrarPets);
            Controls.Add(ID);
            Controls.Add(textBoxIdPet);
            Controls.Add(listBoxPets);
            Controls.Add(cmbCliente);
            Controls.Add(textBoxEspecie);
            Controls.Add(textBoxNomePet);
            Controls.Add(lblClienteID);
            Controls.Add(lblDataNascimento);
            Controls.Add(lblEspecie);
            Controls.Add(lblNomePet);
            Controls.Add(panel3);
            Name = "AnimalControl";
            Size = new Size(1096, 499);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomePet;
        private Label lblEspecie;
        private Label lblDataNascimento;
        private Label lblClienteID;
        private TextBox textBoxNomePet;
        private TextBox textBoxEspecie;
        private Button btnNovoPet;
        private ComboBox cmbCliente;
        private ListBox listBoxPets;
        private Button btnApagarPet;
        private Button btnEditarPet;
        private TextBox textBoxIdPet;
        private Label ID;
        private TextBox textBoxFiltrarPets;
        private Label labelFiltarPets;
        private Panel panel3;
        private Button btnDadosDono;
        private DateTimePicker dateTimePickerDataNascimento;
        private Panel panel2;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Label labelProcuarCliente;
        private ComboBox cmbFiltrarAnimais;
    }
}
