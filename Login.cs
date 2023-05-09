using folhaDePagamento.services;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace FolhaPagamento
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtSenha.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (loginAuth(txtUsuario.Text, txtSenha.Text))
                {

                    MessageBox.Show("Usuário validado", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Preencha os campos. ", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUsuario.Focus();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }





        }

        private bool loginAuth(string usuario, string senha)
        {
            try
            {
                //Criando conex�o com o BD
                string strConexao = "server=127.0.0.1;uid=root;pwd=0000;database=folhadepagamento";
                MySqlConnection conexao = new MySqlConnection(strConexao);
                conexao.Open();
                var comand = conexao.CreateCommand();
                comand.CommandText = "select * from tbFuncionario;";
                MySqlDataReader reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["login"].ToString().ToLower() == usuario.ToLower() && reader["senha"].ToString() == senha)
                    {
                        return true;
                    }

                }
                return false;
                conexao.Close();
            }
            catch
            { 
                MessageBox.Show("Ocorreu algum erro, tente novamente", "Erro");
                return false;
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}