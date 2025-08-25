using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ecotur
{
    public partial class Form2 : Form1
    {
        public Form2()
        {
            InitializeComponent();

            // Carregar reservas na tabela
            CarregarReservas();

        }

        private void CarregarReservas()
        {
            string connectionString = "Server=127.0.0.1;Port=3306;Database=Ecotur;Uid=root;Pwd=;" // *Ajuste com suas credenciais*
            using (var conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = @"
                SELECT r.ID, c.Nome AS Cliente, p.Nome AS Pacote, r.Data, r.Status
                FROM Reservas r
                JOIN Clientes c ON r.ClienteID = c.ID
                JOIN Pacotes p ON r.PacoteID = p.ID";
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            gridReservas.DataSource = dt;
                            // Ajusta as colunas para melhor visualização
                            gridReservas.Columns["ID"].HeaderText = "ID";
                            gridReservas.Columns["Cliente"].HeaderText = "Cliente";
                            gridReservas.Columns["Pacote"].HeaderText = "Pacote";
                            gridReservas.Columns["Data"].HeaderText = "Data";
                            gridReservas.Columns["Status"].HeaderText = "Status";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar reservas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
          

        (Exception ex)
            {
                MessageBox.Show("Erro ao carregar reservas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void btnClientes_Click(object sender, EventArgs e)
        {
            new TelaGerenciarClientes().Show();
            this.Hide();
        }

        private void btnPacotes_Click(object sender, EventArgs e)
        {
            new TelaGerenciarPacotes().Show();
            this.Hide();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            new TelaReservas().Show();
            this.Hide();
        }

        private void btnAvaliacoes_Click(object sender, EventArgs e)
        {
            new TelaAvaliacoes().Show();
            this.Hide();
        }

        private void btnPagamentos_Click(object sender, EventArgs e)
        {
            new TelaPagamentos().Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
