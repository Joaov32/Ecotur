namespace Ecotur
{
    partial class Form2
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
            btnClientes = new Button();
            btnPacotes = new Button();
            btnReservas = new Button();
            btnAvaliações = new Button();
            btnPagamentos = new Button();
            btnSair = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.Transparent;
            btnClientes.BackgroundImageLayout = ImageLayout.Center;
            btnClientes.FlatAppearance.BorderColor = Color.Green;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Location = new Point(177, 267);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(149, 23);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "Clientes ";
            btnClientes.UseVisualStyleBackColor = false;
            // 
            // btnPacotes
            // 
            btnPacotes.BackColor = Color.Transparent;
            btnPacotes.BackgroundImageLayout = ImageLayout.Center;
            btnPacotes.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            btnPacotes.FlatAppearance.BorderSize = 0;
            btnPacotes.FlatStyle = FlatStyle.Flat;
            btnPacotes.Location = new Point(177, 312);
            btnPacotes.Name = "btnPacotes";
            btnPacotes.Size = new Size(101, 23);
            btnPacotes.TabIndex = 1;
            btnPacotes.Text = "Pacotes ";
            btnPacotes.UseVisualStyleBackColor = false;
            // 
            // btnReservas
            // 
            btnReservas.BackColor = Color.Transparent;
            btnReservas.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            btnReservas.FlatAppearance.BorderSize = 0;
            btnReservas.FlatStyle = FlatStyle.Flat;
            btnReservas.Location = new Point(301, 312);
            btnReservas.Name = "btnReservas";
            btnReservas.Size = new Size(92, 23);
            btnReservas.TabIndex = 2;
            btnReservas.Text = "Reservas";
            btnReservas.UseVisualStyleBackColor = false;
            // 
            // btnAvaliações
            // 
            btnAvaliações.BackColor = Color.Transparent;
            btnAvaliações.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            btnAvaliações.FlatAppearance.BorderSize = 0;
            btnAvaliações.FlatStyle = FlatStyle.Flat;
            btnAvaliações.Location = new Point(415, 312);
            btnAvaliações.Name = "btnAvaliações";
            btnAvaliações.Size = new Size(111, 23);
            btnAvaliações.TabIndex = 3;
            btnAvaliações.Text = "Avaliações";
            btnAvaliações.UseVisualStyleBackColor = false;
            // 
            // btnPagamentos
            // 
            btnPagamentos.BackColor = Color.Transparent;
            btnPagamentos.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            btnPagamentos.FlatAppearance.BorderSize = 0;
            btnPagamentos.FlatStyle = FlatStyle.Flat;
            btnPagamentos.Location = new Point(177, 356);
            btnPagamentos.Name = "btnPagamentos";
            btnPagamentos.Size = new Size(120, 23);
            btnPagamentos.TabIndex = 4;
            btnPagamentos.Text = "Pagamentos";
            btnPagamentos.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Transparent;
            btnSair.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Location = new Point(323, 356);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(119, 23);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair ";
            btnSair.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(177, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(453, 109);
            dataGridView1.TabIndex = 6;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._8280f560_af8b_49de_89b4_a18b7f55dafd;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnSair);
            Controls.Add(btnPagamentos);
            Controls.Add(btnAvaliações);
            Controls.Add(btnReservas);
            Controls.Add(btnPacotes);
            Controls.Add(btnClientes);
            Name = "Form2";
            Text = "Form2";
            Controls.SetChildIndex(btnClientes, 0);
            Controls.SetChildIndex(btnPacotes, 0);
            Controls.SetChildIndex(btnReservas, 0);
            Controls.SetChildIndex(btnAvaliações, 0);
            Controls.SetChildIndex(btnPagamentos, 0);
            Controls.SetChildIndex(btnSair, 0);
            Controls.SetChildIndex(dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClientes;
        private Button btnPacotes;
        private Button btnReservas;
        private Button btnAvaliações;
        private Button btnPagamentos;
        private Button btnSair;
        private DataGridView dataGridView1;
    }
}