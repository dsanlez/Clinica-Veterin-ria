namespace FormPrincipal
{
    partial class ClienteControl
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
            btnGuardar = new Button();
            btnApagarCliente = new Button();
            btnUpdate = new Button();
            textBoxNomeCliente = new TextBox();
            textBoxMorada = new TextBox();
            textBoxTelefone = new TextBox();
            textBoxNif = new TextBox();
            lblNome = new Label();
            lblMorada = new Label();
            lblTelefone = new Label();
            lblNif = new Label();
            lblIDCliente = new Label();
            textBoxIdCliente = new TextBox();
            listBoxClientes = new ListBox();
            textBoxFiltrarLista = new TextBox();
            labelProcuarCliente = new Label();
            panel3 = new Panel();
            btnDadosPets = new Button();
            lblApelido = new Label();
            textBoxApelido = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            cmbFiltrarClientes = new ComboBox();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.White;
            btnGuardar.FlatAppearance.BorderColor = Color.White;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnGuardar.Location = new Point(14, 7);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(129, 60);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Registar Cliente";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnApagarCliente
            // 
            btnApagarCliente.BackColor = Color.White;
            btnApagarCliente.FlatAppearance.BorderColor = Color.White;
            btnApagarCliente.FlatStyle = FlatStyle.Flat;
            btnApagarCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnApagarCliente.Location = new Point(166, 7);
            btnApagarCliente.Name = "btnApagarCliente";
            btnApagarCliente.Size = new Size(129, 60);
            btnApagarCliente.TabIndex = 1;
            btnApagarCliente.Text = "Apagar Cliente";
            btnApagarCliente.UseVisualStyleBackColor = false;
            btnApagarCliente.Click += btnApagarCliente_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.FlatAppearance.BorderColor = Color.White;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnUpdate.Location = new Point(318, 7);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(129, 60);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Editar Cliente";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // textBoxNomeCliente
            // 
            textBoxNomeCliente.Location = new Point(229, 149);
            textBoxNomeCliente.Name = "textBoxNomeCliente";
            textBoxNomeCliente.Size = new Size(175, 25);
            textBoxNomeCliente.TabIndex = 2;
            // 
            // textBoxMorada
            // 
            textBoxMorada.Location = new Point(229, 253);
            textBoxMorada.Name = "textBoxMorada";
            textBoxMorada.Size = new Size(175, 25);
            textBoxMorada.TabIndex = 4;
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.Location = new Point(229, 305);
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(175, 25);
            textBoxTelefone.TabIndex = 5;
            // 
            // textBoxNif
            // 
            textBoxNif.Location = new Point(229, 357);
            textBoxNif.Name = "textBoxNif";
            textBoxNif.Size = new Size(175, 25);
            textBoxNif.TabIndex = 6;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblNome.Location = new Point(147, 154);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(49, 17);
            lblNome.TabIndex = 7;
            lblNome.Text = "Nome:";
            // 
            // lblMorada
            // 
            lblMorada.AutoSize = true;
            lblMorada.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblMorada.Location = new Point(147, 258);
            lblMorada.Name = "lblMorada";
            lblMorada.Size = new Size(59, 17);
            lblMorada.TabIndex = 8;
            lblMorada.Text = "Morada:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblTelefone.Location = new Point(147, 310);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(65, 17);
            lblTelefone.TabIndex = 9;
            lblTelefone.Text = "Telefone:";
            // 
            // lblNif
            // 
            lblNif.AutoSize = true;
            lblNif.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblNif.Location = new Point(147, 362);
            lblNif.Name = "lblNif";
            lblNif.Size = new Size(33, 17);
            lblNif.TabIndex = 10;
            lblNif.Text = "NIF:";
            // 
            // lblIDCliente
            // 
            lblIDCliente.AutoSize = true;
            lblIDCliente.Location = new Point(147, 102);
            lblIDCliente.Name = "lblIDCliente";
            lblIDCliente.Size = new Size(73, 17);
            lblIDCliente.TabIndex = 11;
            lblIDCliente.Text = "ID Cliente:";
            // 
            // textBoxIdCliente
            // 
            textBoxIdCliente.Enabled = false;
            textBoxIdCliente.Location = new Point(229, 97);
            textBoxIdCliente.Name = "textBoxIdCliente";
            textBoxIdCliente.ReadOnly = true;
            textBoxIdCliente.Size = new Size(114, 25);
            textBoxIdCliente.TabIndex = 1;
            // 
            // listBoxClientes
            // 
            listBoxClientes.FormattingEnabled = true;
            listBoxClientes.ItemHeight = 17;
            listBoxClientes.Location = new Point(612, 179);
            listBoxClientes.Name = "listBoxClientes";
            listBoxClientes.ScrollAlwaysVisible = true;
            listBoxClientes.Size = new Size(385, 208);
            listBoxClientes.TabIndex = 13;
            listBoxClientes.SelectedIndexChanged += listBoxClientes_SelectedIndexChanged;
            // 
            // textBoxFiltrarLista
            // 
            textBoxFiltrarLista.Location = new Point(685, 137);
            textBoxFiltrarLista.Name = "textBoxFiltrarLista";
            textBoxFiltrarLista.Size = new Size(230, 25);
            textBoxFiltrarLista.TabIndex = 7;
            textBoxFiltrarLista.TextChanged += textBoxFiltrarLista_TextChanged;
            // 
            // labelProcuarCliente
            // 
            labelProcuarCliente.AutoSize = true;
            labelProcuarCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProcuarCliente.Location = new Point(685, 97);
            labelProcuarCliente.Name = "labelProcuarCliente";
            labelProcuarCliente.Size = new Size(97, 17);
            labelProcuarCliente.TabIndex = 15;
            labelProcuarCliente.Text = "Pesquisar por:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGreen;
            panel3.Controls.Add(btnDadosPets);
            panel3.Controls.Add(btnGuardar);
            panel3.Controls.Add(btnApagarCliente);
            panel3.Controls.Add(btnUpdate);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 425);
            panel3.Name = "panel3";
            panel3.Size = new Size(1096, 74);
            panel3.TabIndex = 16;
            // 
            // btnDadosPets
            // 
            btnDadosPets.BackColor = Color.White;
            btnDadosPets.Enabled = false;
            btnDadosPets.FlatAppearance.BorderColor = Color.White;
            btnDadosPets.FlatStyle = FlatStyle.Flat;
            btnDadosPets.Location = new Point(470, 7);
            btnDadosPets.Name = "btnDadosPets";
            btnDadosPets.Size = new Size(129, 60);
            btnDadosPets.TabIndex = 19;
            btnDadosPets.Text = "Ver Pets";
            btnDadosPets.UseVisualStyleBackColor = false;
            btnDadosPets.Click += btnDadosPets_Click;
            // 
            // lblApelido
            // 
            lblApelido.AutoSize = true;
            lblApelido.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblApelido.Location = new Point(147, 206);
            lblApelido.Name = "lblApelido";
            lblApelido.Size = new Size(60, 17);
            lblApelido.TabIndex = 18;
            lblApelido.Text = "Apelido:";
            // 
            // textBoxApelido
            // 
            textBoxApelido.Location = new Point(229, 201);
            textBoxApelido.Name = "textBoxApelido";
            textBoxApelido.Size = new Size(175, 25);
            textBoxApelido.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(70, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(418, 42);
            panel1.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 5);
            label1.Name = "label1";
            label1.Size = new Size(226, 30);
            label1.TabIndex = 0;
            label1.Text = "Registar Novo Cliente";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Green;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(583, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(438, 42);
            panel2.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(11, 5);
            label2.Name = "label2";
            label2.Size = new Size(179, 30);
            label2.TabIndex = 0;
            label2.Text = "Pesquisar Cliente";
            // 
            // cmbFiltrarClientes
            // 
            cmbFiltrarClientes.FormattingEnabled = true;
            cmbFiltrarClientes.Location = new Point(794, 94);
            cmbFiltrarClientes.Name = "cmbFiltrarClientes";
            cmbFiltrarClientes.Size = new Size(121, 25);
            cmbFiltrarClientes.TabIndex = 21;
            // 
            // ClienteControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(cmbFiltrarClientes);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblApelido);
            Controls.Add(textBoxApelido);
            Controls.Add(labelProcuarCliente);
            Controls.Add(textBoxFiltrarLista);
            Controls.Add(listBoxClientes);
            Controls.Add(textBoxIdCliente);
            Controls.Add(lblIDCliente);
            Controls.Add(lblNif);
            Controls.Add(lblTelefone);
            Controls.Add(lblMorada);
            Controls.Add(lblNome);
            Controls.Add(textBoxNif);
            Controls.Add(textBoxTelefone);
            Controls.Add(textBoxMorada);
            Controls.Add(textBoxNomeCliente);
            Controls.Add(panel3);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Name = "ClienteControl";
            Size = new Size(1096, 499);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnApagarCliente;
        private Button btnUpdate;
        private TextBox textBoxNomeCliente;
        private TextBox textBoxMorada;
        private TextBox textBoxTelefone;
        private TextBox textBoxNif;
        private Label lblNome;
        private Label lblMorada;
        private Label lblTelefone;
        private Label lblNif;
        private Label lblIDCliente;
        private TextBox textBoxIdCliente;
        private ListBox listBoxClientes;
        private TextBox textBoxFiltrarLista;
        private Label labelProcuarCliente;
        private Panel panel3;
        private Label lblApelido;
        private TextBox textBoxApelido;
        private Button btnDadosPets;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private ComboBox cmbFiltrarClientes;
    }
}
