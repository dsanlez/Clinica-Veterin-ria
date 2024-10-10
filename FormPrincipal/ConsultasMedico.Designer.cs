namespace FormPrincipal
{
    partial class ConsultasMedico
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
            this.listBoxConsultas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            // listBoxConsultas
            this.listBoxConsultas.FormattingEnabled = true;
            this.listBoxConsultas.ItemHeight = 20;
            this.listBoxConsultas.Location = new System.Drawing.Point(12, 12);
            this.listBoxConsultas.Name = "listBoxConsultas";
            this.listBoxConsultas.Size = new System.Drawing.Size(776, 404);
            this.listBoxConsultas.TabIndex = 0;

            // FormConsultasMedico
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxConsultas);
            this.Name = "FormConsultasMedico";
            this.Text = "Consultas do Médico";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox listBoxConsultas;
    }
        #endregion
    
}