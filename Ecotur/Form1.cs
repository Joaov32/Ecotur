namespace Ecotur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            if (email == "admin@ecotur.com" && senha == "123")
            { // Simulação simples
                MessageBox.Show("Bem-vindo!");
                new Form2().Show();
                this.Hide();
                return;
            }
            else
            {
                MessageBox.Show("E-mail ou senha errados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
    }
}
