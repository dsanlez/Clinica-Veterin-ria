namespace FormPrincipal
{
    partial class ConsultasControl
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
            listBoxConsultas = new ListBox();
            comboBoxAnimal = new ComboBox();
            comboBoxMedico = new ComboBox();
            monthCalendarConsultas = new MonthCalendar();
            textBoxIdConsulta = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxEspecialidade = new TextBox();
            lblIdConsulta = new Label();
            lblTipoConsulta = new Label();
            btnRegistarConsulta = new Button();
            btnEditarConsulta = new Button();
            btnApagarConsulta = new Button();
            panel3 = new Panel();
            numericUpDownHoras = new NumericUpDown();
            numericUpDownMinutos = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            lblConsultório = new Label();
            panel1 = new Panel();
            label5 = new Label();
            label6 = new Label();
            comboBoxDono = new ComboBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHoras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinutos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxConsultas
            // 
            listBoxConsultas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxConsultas.FormattingEnabled = true;
            listBoxConsultas.ItemHeight = 17;
            listBoxConsultas.Location = new Point(367, 201);
            listBoxConsultas.Name = "listBoxConsultas";
            listBoxConsultas.ScrollAlwaysVisible = true;
            listBoxConsultas.Size = new Size(670, 191);
            listBoxConsultas.TabIndex = 0;
            listBoxConsultas.SelectedIndexChanged += listBoxConsultas_SelectedIndexChanged;
            // 
            // comboBoxAnimal
            // 
            comboBoxAnimal.FormattingEnabled = true;
            comboBoxAnimal.Location = new Point(480, 122);
            comboBoxAnimal.Name = "comboBoxAnimal";
            comboBoxAnimal.Size = new Size(121, 23);
            comboBoxAnimal.TabIndex = 1;
            // 
            // comboBoxMedico
            // 
            comboBoxMedico.FormattingEnabled = true;
            comboBoxMedico.Location = new Point(687, 122);
            comboBoxMedico.Name = "comboBoxMedico";
            comboBoxMedico.Size = new Size(121, 23);
            comboBoxMedico.TabIndex = 3;
            comboBoxMedico.SelectedIndexChanged += comboBoxMedico_SelectedIndexChanged;
            // 
            // monthCalendarConsultas
            // 
            monthCalendarConsultas.Location = new Point(63, 230);
            monthCalendarConsultas.Name = "monthCalendarConsultas";
            monthCalendarConsultas.TabIndex = 3;
            monthCalendarConsultas.DateChanged += ConsultasDoMes_DateChanged;
            // 
            // textBoxIdConsulta
            // 
            textBoxIdConsulta.Enabled = false;
            textBoxIdConsulta.Location = new Point(66, 122);
            textBoxIdConsulta.Name = "textBoxIdConsulta";
            textBoxIdConsulta.Size = new Size(121, 23);
            textBoxIdConsulta.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(478, 97);
            label1.Name = "label1";
            label1.Size = new Size(138, 17);
            label1.TabIndex = 5;
            label1.Text = "Selecione o Paciente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(685, 97);
            label2.Name = "label2";
            label2.Size = new Size(131, 17);
            label2.TabIndex = 6;
            label2.Text = "Selecione o Médico:";
            // 
            // textBoxEspecialidade
            // 
            textBoxEspecialidade.Location = new Point(894, 122);
            textBoxEspecialidade.Name = "textBoxEspecialidade";
            textBoxEspecialidade.Size = new Size(121, 23);
            textBoxEspecialidade.TabIndex = 4;
            // 
            // lblIdConsulta
            // 
            lblIdConsulta.AutoSize = true;
            lblIdConsulta.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblIdConsulta.Location = new Point(63, 95);
            lblIdConsulta.Name = "lblIdConsulta";
            lblIdConsulta.Size = new Size(84, 17);
            lblIdConsulta.TabIndex = 8;
            lblIdConsulta.Text = "ID Consulta:";
            // 
            // lblTipoConsulta
            // 
            lblTipoConsulta.AutoSize = true;
            lblTipoConsulta.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblTipoConsulta.Location = new Point(891, 96);
            lblTipoConsulta.Name = "lblTipoConsulta";
            lblTipoConsulta.Size = new Size(117, 17);
            lblTipoConsulta.TabIndex = 9;
            lblTipoConsulta.Text = "Tipo de Consulta:";
            // 
            // btnRegistarConsulta
            // 
            btnRegistarConsulta.BackColor = Color.White;
            btnRegistarConsulta.FlatAppearance.BorderColor = Color.White;
            btnRegistarConsulta.FlatStyle = FlatStyle.Flat;
            btnRegistarConsulta.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnRegistarConsulta.Location = new Point(10, 5);
            btnRegistarConsulta.Name = "btnRegistarConsulta";
            btnRegistarConsulta.Size = new Size(151, 63);
            btnRegistarConsulta.TabIndex = 10;
            btnRegistarConsulta.Text = "Agendar Consulta";
            btnRegistarConsulta.UseVisualStyleBackColor = false;
            btnRegistarConsulta.Click += btnRegistarConsulta_Click;
            // 
            // btnEditarConsulta
            // 
            btnEditarConsulta.BackColor = Color.White;
            btnEditarConsulta.FlatAppearance.BorderColor = Color.White;
            btnEditarConsulta.FlatStyle = FlatStyle.Flat;
            btnEditarConsulta.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnEditarConsulta.Location = new Point(179, 5);
            btnEditarConsulta.Name = "btnEditarConsulta";
            btnEditarConsulta.Size = new Size(151, 63);
            btnEditarConsulta.TabIndex = 11;
            btnEditarConsulta.Text = "Editar Consulta";
            btnEditarConsulta.UseVisualStyleBackColor = false;
            btnEditarConsulta.Click += btnEditarConsulta_Click;
            // 
            // btnApagarConsulta
            // 
            btnApagarConsulta.BackColor = Color.White;
            btnApagarConsulta.FlatAppearance.BorderColor = Color.White;
            btnApagarConsulta.FlatStyle = FlatStyle.Flat;
            btnApagarConsulta.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnApagarConsulta.Location = new Point(348, 5);
            btnApagarConsulta.Name = "btnApagarConsulta";
            btnApagarConsulta.Size = new Size(151, 63);
            btnApagarConsulta.TabIndex = 12;
            btnApagarConsulta.Text = "Apagar Consulta";
            btnApagarConsulta.UseVisualStyleBackColor = false;
            btnApagarConsulta.Click += btnApagarConsulta_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGreen;
            panel3.Controls.Add(btnRegistarConsulta);
            panel3.Controls.Add(btnEditarConsulta);
            panel3.Controls.Add(btnApagarConsulta);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 425);
            panel3.Name = "panel3";
            panel3.Size = new Size(1096, 74);
            panel3.TabIndex = 14;
            // 
            // numericUpDownHoras
            // 
            numericUpDownHoras.Location = new Point(117, 193);
            numericUpDownHoras.Maximum = new decimal(new int[] { 16, 0, 0, 0 });
            numericUpDownHoras.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            numericUpDownHoras.Name = "numericUpDownHoras";
            numericUpDownHoras.Size = new Size(39, 23);
            numericUpDownHoras.TabIndex = 16;
            numericUpDownHoras.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // numericUpDownMinutos
            // 
            numericUpDownMinutos.Increment = new decimal(new int[] { 30, 0, 0, 0 });
            numericUpDownMinutos.Location = new Point(252, 193);
            numericUpDownMinutos.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            numericUpDownMinutos.Name = "numericUpDownMinutos";
            numericUpDownMinutos.Size = new Size(36, 23);
            numericUpDownMinutos.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(63, 194);
            label3.Name = "label3";
            label3.Size = new Size(48, 17);
            label3.TabIndex = 17;
            label3.Text = "Horas:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(183, 194);
            label4.Name = "label4";
            label4.Size = new Size(63, 17);
            label4.TabIndex = 18;
            label4.Text = "Minutos:";
            // 
            // lblConsultório
            // 
            lblConsultório.AutoSize = true;
            lblConsultório.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsultório.Location = new Point(687, 158);
            lblConsultório.Name = "lblConsultório";
            lblConsultório.Size = new Size(84, 17);
            lblConsultório.TabIndex = 19;
            lblConsultório.Text = "Consultório:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(label5);
            panel1.Location = new Point(52, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(985, 42);
            panel1.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(11, 5);
            label5.Name = "label5";
            label5.Size = new Size(377, 30);
            label5.TabIndex = 0;
            label5.Text = "Pesquisar ou Agendar Nova Consulta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.Location = new Point(271, 97);
            label6.Name = "label6";
            label6.Size = new Size(116, 17);
            label6.TabIndex = 24;
            label6.Text = "Selecione o Dono";
            // 
            // comboBoxDono
            // 
            comboBoxDono.FormattingEnabled = true;
            comboBoxDono.Location = new Point(273, 122);
            comboBoxDono.Name = "comboBoxDono";
            comboBoxDono.Size = new Size(121, 23);
            comboBoxDono.TabIndex = 2;
            comboBoxDono.SelectedIndexChanged += comboBoxDono_SelectedIndexChanged;
            // 
            // ConsultasControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label6);
            Controls.Add(comboBoxDono);
            Controls.Add(panel1);
            Controls.Add(lblConsultório);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(numericUpDownHoras);
            Controls.Add(numericUpDownMinutos);
            Controls.Add(panel3);
            Controls.Add(lblTipoConsulta);
            Controls.Add(lblIdConsulta);
            Controls.Add(textBoxEspecialidade);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxIdConsulta);
            Controls.Add(monthCalendarConsultas);
            Controls.Add(comboBoxMedico);
            Controls.Add(comboBoxAnimal);
            Controls.Add(listBoxConsultas);
            Name = "ConsultasControl";
            Size = new Size(1096, 499);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownHoras).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinutos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxConsultas;
        private ComboBox comboBoxAnimal;
        private ComboBox comboBoxMedico;
        private MonthCalendar monthCalendarConsultas;
        private TextBox textBoxIdConsulta;
        private Label label1;
        private Label label2;
        private TextBox textBoxEspecialidade;
        private Label lblIdConsulta;
        private Label lblTipoConsulta;
        private Button btnRegistarConsulta;
        private Button btnEditarConsulta;
        private Button btnApagarConsulta;        
        private Panel panel3;
        private NumericUpDown numericUpDownHoras;
        private NumericUpDown numericUpDownMinutos;
        private Label label3;
        private Label label4;
        private Label lblConsultório;
        private Panel panel1;
        private Label label5;
        private Label label6;
        private ComboBox comboBoxDono;
    }
}
