using System;
using System.Windows.Forms;
using Ecotur;
using MySql.Data.MySqlClient;

namespace EcoTurCRM
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DatabaseSetup.CriarBanco();  // Cria as tabelas no MySQL
            Application.Run(new Form1());  // Abre a tela de Login
        }

        public static class DatabaseSetup
        {
            private static string connectionString = "Server=127.0.0.1;Port=3306;Database=Ecotur;Uid=root;Pwd=;"; // Ajuste com suas credenciais

            public static void CriarBanco()
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string sql = @"
                        CREATE TABLE IF NOT EXISTS Usuarios (
                            ID INT AUTO_INCREMENT PRIMARY KEY,
                            Email VARCHAR(100),
                            Senha VARCHAR(50)
                        );
                        CREATE TABLE IF NOT EXISTS Clientes (
                            ID INT AUTO_INCREMENT PRIMARY KEY,
                            Nome VARCHAR(100),
                            Email VARCHAR(100),
                            Telefone VARCHAR(20),
                            Preferencias VARCHAR(50)
                        );
                        CREATE TABLE IF NOT EXISTS Pacotes (
                            ID INT AUTO_INCREMENT PRIMARY KEY,
                            Nome VARCHAR(100),
                            Destino VARCHAR(100),
                            Duracao INT,
                            Preco DECIMAL(10,2),
                            Dificuldade VARCHAR(20),
                            Descricao TEXT
                        );
                        CREATE TABLE IF NOT EXISTS Reservas (
                            ID INT AUTO_INCREMENT PRIMARY KEY,
                            ClienteID INT,
                            PacoteID INT,
                            Data VARCHAR(10),
                            Status VARCHAR(20)
                        );
                        CREATE TABLE IF NOT EXISTS Guias (
                            ID INT AUTO_INCREMENT PRIMARY KEY,
                            Nome VARCHAR(100),
                            Especialidade VARCHAR(100)
                        );
                        CREATE TABLE IF NOT EXISTS PontosTuristicos (
                            ID INT AUTO_INCREMENT PRIMARY KEY,
                            Nome VARCHAR(100),
                            Localizacao VARCHAR(100)
                        );
                        CREATE TABLE IF NOT EXISTS Avaliacoes (
                            ID INT AUTO_INCREMENT PRIMARY KEY,
                            ClienteID INT,
                            GuiaID INT,
                            PontoID INT,
                            Nota INT,
                            Comentario TEXT
                        );
                        CREATE TABLE IF NOT EXISTS Pagamentos (
                            ID INT AUTO_INCREMENT PRIMARY KEY,
                            ReservaID INT,
                            Metodo VARCHAR(20),
                            Valor DECIMAL(10,2),
                            Status VARCHAR(20)
                        );";
                        using (var cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                        // Adiciona usuário padrão para teste
                        sql = "INSERT IGNORE INTO Usuarios (Email, Senha) VALUES ('admin@ecotur.com', '123');";
                        using (var cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao criar banco: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}