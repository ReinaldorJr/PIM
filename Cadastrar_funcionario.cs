using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using folhaDePagamento.services;
using FolhaPagamento.Classes;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

namespace FolhaPagamento
{
    public partial class Cadastrar_funcionario : Form
    {
        List<Funcionario> funcionarios;
        public Cadastrar_funcionario()
        {
            InitializeComponent();

            funcionarios = new List<Funcionario>();

            cbx_est_civil.Items.Add("Solteiro");
            cbx_est_civil.SelectedIndex = 0;
            cbx_est_civil.Items.Add("Casado");
            cbx_est_civil.Items.Add("Viúvo");

            cbx_cargo.Items.Add("Funcionário");
            cbx_cargo.SelectedIndex = 0;
            cbx_cargo.Items.Add("Departamento Pessoal");
            cbx_cargo.Items.Add("Gerente");
            GerarGrade();
            PopularGrade();
        }



        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Funcionario f = new Funcionario();

            int index = -1;

            foreach (Funcionario funcionario in funcionarios)
            {
                if (funcionario.cpf_funcionario == txt_cpf_funcionario.Text)
                {
                    MessageBox.Show("CPF já cadastrado.", "", MessageBoxButtons.OK);
                    txt_cpf_funcionario.Focus();
                    return;
                }
            }

            if (txt_cpf_funcionario.Text == "")
            {
                msgcampovazio();
                txt_cpf_funcionario.Focus();
                return;
            }
            else
            {
                if (txt_cpf_funcionario.Text.Length == 11)
                {
                    f.cpf_funcionario = txt_cpf_funcionario.Text;
                    f.login = f.cpf_funcionario;

                }
                else
                {
                    msgcampovazio();
                    txt_cpf_funcionario.Focus();
                    return;
                }
            }
            if (boxSenha.Text != "")
            {

                f.senha = boxSenha.Text;

            }
            else
            {
                msgcampovazio();
                boxSenha.Focus();
                return;
            }
            if (txt_nome_funcionario.Text == "")
            {
                msgcampovazio();
                txt_nome_funcionario.Focus();
                return;
            }
            else
            {
                f.nome_funcionario = txt_nome_funcionario.Text;
            }

            if (txt_salario_funcionario.Text == "")
            {
                msgcampovazio();
                txt_salario_funcionario.Focus();
                return;
            }
            else
            {

            }

            if (txt_bairro_funcionario.Text == "")
            {
                msgcampovazio();
                txt_bairro_funcionario.Focus();
                return;
            }
            else
            {
                f.bairro_funcionario = txt_bairro_funcionario.Text;
            }

            if (txt_rua_funcionario.Text == "")
            {
                msgcampovazio();
                txt_rua_funcionario.Focus();
                return;
            }
            else
            {
                f.rua_funcionario = txt_rua_funcionario.Text;
            }

            if (txt_cep_funcionario.Text == "")
            {
                msgcampovazio();
                txt_cep_funcionario.Focus();
                return;
            }
            else
            {
                if (txt_cep_funcionario.Text.Length == 8)
                {
                    f.cep_funcionario = txt_cep_funcionario.Text;
                }
                else
                {
                    msgcampovazio();
                    txt_cep_funcionario.Focus();
                    return;
                }
            }

            if (txt_ddd_funcionario.Text == "")
            {
                msgcampovazio();
                txt_ddd_funcionario.Focus();
                return;
            }
            else
            {
                if (txt_ddd_funcionario.Text.Length == 2)
                {
                    f.ddd_funcionario = txt_ddd_funcionario.Text;
                }
                else
                {
                    msgcampovazio();
                    txt_ddd_funcionario.Focus();
                    return;
                }
            }

            if (txt_telefone_funcionario.Text == "")
            {
                msgcampovazio();
                txt_telefone_funcionario.Focus();
                return;
            }
            else
            {
                if (txt_telefone_funcionario.Text.Length == 9 || txt_telefone_funcionario.Text.Length == 8)
                {
                    f.telefone_funcionario = txt_telefone_funcionario.Text;
                }
                else
                {
                    msgcampovazio();
                    txt_telefone_funcionario.Focus();
                    return;
                }
            }

            if (cbx_est_civil.Text == "")
            {
                msgcampovazio();
                cbx_est_civil.Focus();
                return;
            }
            else
            {
                f.estado_civil_funcionario = cbx_est_civil.SelectedItem.ToString();
            }

            if (dtp_dt_nasc.Text == "")
            {
                msgcampovazio();
                dtp_dt_nasc.Focus();
                return;
            }
            else
            {
                f.dt_nasc_funcionario = dtp_dt_nasc.Value;
            }

            if (cbx_cargo.Text == "")
            {
                msgcampovazio();
                cbx_cargo.Focus();
                return;
            }
            else
            {
                f.cargo = cbx_cargo.SelectedItem.ToString();
            }

            if (index < 0)
            {
                funcionarios.Add(f);
            }
            else
            {
                msgcampovazio();
                funcionarios[index] = f;
            }


            ConnectDatabase db = new ConnectDatabase();
            MySqlCommand comm = db.connect().CreateCommand();


            comm.CommandText = "INSERT INTO tbfuncionario(cpf, nome, dataNasc, estadoCivil, login, senha, cargo, ativo) VALUES(@cpf, @nome, @dataNasc, @estadoCivil, @login, @senha, @cargo, true);";
            comm.Parameters.AddWithValue("@cpf", f.cpf_funcionario);
            comm.Parameters.AddWithValue("@nome", f.nome_funcionario);
            comm.Parameters.AddWithValue("@dataNasc", f.dt_nasc_funcionario);
            comm.Parameters.AddWithValue("@estadoCivil", f.estado_civil_funcionario);
            comm.Parameters.AddWithValue("@login", f.login);
            comm.Parameters.AddWithValue("@senha", f.senha);
            comm.Parameters.AddWithValue("@cargo", f.cargo);
            comm.ExecuteNonQuery();

            insertSalario();
            insertEndereco();
            insertTelefone();

            limparcampos();


            MessageBox.Show("Cadastro efetuado com sucesso.", "", MessageBoxButtons.OK);


        }
        private int queryDatabase()
        {
            ConnectDatabase db = new ConnectDatabase();
            MySqlConnection conn = db.connect();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "SELECT * FROM tbfuncionario where cpf = @cpf";
            comm.Parameters.AddWithValue("@cpf", txt_cpf_funcionario.Text);
            MySqlDataReader reader = comm.ExecuteReader();
            int id = -1;
            while (reader.Read())
            {
                id = int.Parse(reader["idFunc"].ToString());
            }
            return id;

        }

        private void insertSalario()
        {
            ConnectDatabase db = new ConnectDatabase();
            MySqlCommand comm = db.connect().CreateCommand();
            comm.CommandText = "INSERT INTO tbsalario(idFunc, cpf, salarioBase) VALUES(@idFunc, @cpf, @salarioBase);";
            comm.Parameters.AddWithValue("@idFunc", queryDatabase());
            comm.Parameters.AddWithValue("@cpf", txt_cpf_funcionario.Text);
            comm.Parameters.AddWithValue("@salarioBase", txt_salario_funcionario.Text.Replace("R$", ""));

            comm.ExecuteNonQuery();
        }
        private void insertEndereco()
        {
            ConnectDatabase db = new ConnectDatabase();
            MySqlCommand comm = db.connect().CreateCommand();
            comm.CommandText = "INSERT INTO tbendereco(idFunc, bairro, rua, cep) VALUES(@idFunc, @bairro, @rua, @cep);";
            comm.Parameters.AddWithValue("@idFunc", queryDatabase());
            comm.Parameters.AddWithValue("@bairro", txt_bairro_funcionario.Text);
            comm.Parameters.AddWithValue("@rua", txt_rua_funcionario.Text);
            comm.Parameters.AddWithValue("@cep", txt_cep_funcionario.Text);
            comm.ExecuteNonQuery();
        }
        private void insertTelefone()
        {
            ConnectDatabase db = new ConnectDatabase();
            MySqlCommand comm = db.connect().CreateCommand();
            comm.CommandText = "INSERT INTO tbtelefonefuncionario(idFunc, ddd, telefone) VALUES(@idFunc, @ddd, @telefone);";
            comm.Parameters.AddWithValue("@idFunc", queryDatabase());
            comm.Parameters.AddWithValue("@ddd", txt_ddd_funcionario.Text);
            comm.Parameters.AddWithValue("@telefone", txt_telefone_funcionario.Text);
            comm.ExecuteNonQuery();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Se cancelado sera perdida toda informção preenchida, deseja continuar?", "", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                limparcampos();
            }
            else
            {

            }
            txt_cpf_funcionario.Enabled = true;

        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            Funcionario f = new Funcionario();

            int index = -1;

            foreach (Funcionario funcionario in funcionarios)
            {
                if (funcionario.cpf_funcionario == txt_cpf_funcionario.Text)
                {
                    MessageBox.Show("CPF já cadastrado.", "", MessageBoxButtons.OK);
                    txt_cpf_funcionario.Focus();
                    return;
                }
            }

            if (txt_cpf_funcionario.Text == "")
            {
                msgcampovazio();
                txt_cpf_funcionario.Focus();
                return;
            }
            else
            {
                if (txt_cpf_funcionario.Text.Length == 11)
                {
                    f.cpf_funcionario = txt_cpf_funcionario.Text;
                    f.login = f.cpf_funcionario;

                }
                else
                {
                    msgcampovazio();
                    txt_cpf_funcionario.Focus();
                    return;
                }
            }
            if (boxSenha.Text != "")
            {

                f.senha = boxSenha.Text;

            }
            else
            {
                msgcampovazio();
                boxSenha.Focus();
                return;
            }
            if (txt_nome_funcionario.Text == "")
            {
                msgcampovazio();
                txt_nome_funcionario.Focus();
                return;
            }
            else
            {
                f.nome_funcionario = txt_nome_funcionario.Text;
            }

            if (txt_salario_funcionario.Text == "")
            {
                msgcampovazio();
                txt_salario_funcionario.Focus();
                return;
            }
            else
            {

            }

            if (txt_bairro_funcionario.Text == "")
            {
                msgcampovazio();
                txt_bairro_funcionario.Focus();
                return;
            }
            else
            {
                f.bairro_funcionario = txt_bairro_funcionario.Text;
            }

            if (txt_rua_funcionario.Text == "")
            {
                msgcampovazio();
                txt_rua_funcionario.Focus();
                return;
            }
            else
            {
                f.rua_funcionario = txt_rua_funcionario.Text;
            }

            if (txt_cep_funcionario.Text == "")
            {
                msgcampovazio();
                txt_cep_funcionario.Focus();
                return;
            }
            else
            {
                if (txt_cep_funcionario.Text.Length == 8)
                {
                    f.cep_funcionario = txt_cep_funcionario.Text;
                }
                else
                {
                    msgcampovazio();
                    txt_cep_funcionario.Focus();
                    return;
                }
            }

            if (txt_ddd_funcionario.Text == "")
            {
                msgcampovazio();
                txt_ddd_funcionario.Focus();
                return;
            }
            else
            {
                if (txt_ddd_funcionario.Text.Length == 2)
                {
                    f.ddd_funcionario = txt_ddd_funcionario.Text;
                }
                else
                {
                    msgcampovazio();
                    txt_ddd_funcionario.Focus();
                    return;
                }
            }

            if (txt_telefone_funcionario.Text == "")
            {
                msgcampovazio();
                txt_telefone_funcionario.Focus();
                return;
            }
            else
            {
                if (txt_telefone_funcionario.Text.Length == 9 || txt_telefone_funcionario.Text.Length == 8)
                {
                    f.telefone_funcionario = txt_telefone_funcionario.Text;
                }
                else
                {
                    msgcampovazio();
                    txt_telefone_funcionario.Focus();
                    return;
                }
            }

            if (cbx_est_civil.Text == "")
            {
                msgcampovazio();
                cbx_est_civil.Focus();
                return;
            }
            else
            {
                f.estado_civil_funcionario = cbx_est_civil.SelectedItem.ToString();
            }

            if (dtp_dt_nasc.Text == "")
            {
                msgcampovazio();
                dtp_dt_nasc.Focus();
                return;
            }
            else
            {
                f.dt_nasc_funcionario = dtp_dt_nasc.Value;
            }

            if (cbx_cargo.Text == "")
            {
                msgcampovazio();
                cbx_cargo.Focus();
                return;
            }
            else
            {
                f.cargo = cbx_cargo.SelectedItem.ToString();
            }

            if (index < 0)
            {
                funcionarios.Add(f);
            }
            else
            {
                msgcampovazio();
                funcionarios[index] = f;
            }


            ConnectDatabase db = new ConnectDatabase();
            MySqlCommand comm = db.connect().CreateCommand();


            comm.CommandText = "UPDATE tbfuncionario SET cpf = @cpf, nome = @nome, dataNasc = @dataNasc, estadoCivil = @estadoCivil, login = @login, senha = @senha, cargo = @cargo, ativo = true WHERE idFunc = @idFunc;";
            comm.Parameters.AddWithValue("@cpf", f.cpf_funcionario);
            comm.Parameters.AddWithValue("@nome", f.nome_funcionario);
            comm.Parameters.AddWithValue("@dataNasc", f.dt_nasc_funcionario);
            comm.Parameters.AddWithValue("@estadoCivil", f.estado_civil_funcionario);
            comm.Parameters.AddWithValue("@login", f.login);
            comm.Parameters.AddWithValue("@senha", f.senha);
            comm.Parameters.AddWithValue("@cargo", f.cargo);
            comm.ExecuteNonQuery();

            attSalario();
            attEndereco();
            attTelefone();

            limparcampos();


            MessageBox.Show("Atualização efetuado com sucesso.", "", MessageBoxButtons.OK);



        }
        private void attSalario()
        {
            ConnectDatabase db = new ConnectDatabase();
            MySqlCommand comm = db.connect().CreateCommand();
            comm.CommandText = "UPDATE tbsalario SET cpf = @cpf, salarioBase = @salarioBase WHERE idFunc = @idFunc;";
            comm.Parameters.AddWithValue("@idFunc", queryDatabase());
            comm.Parameters.AddWithValue("@cpf", txt_cpf_funcionario.Text);
            comm.Parameters.AddWithValue("@salarioBase", txt_salario_funcionario.Text.Replace("R$", ""));

            comm.ExecuteNonQuery();
        }
        private void attEndereco()
        {
            ConnectDatabase db = new ConnectDatabase();
            MySqlCommand comm = db.connect().CreateCommand();
            comm.CommandText = "UPDATE tbendereco SET bairro = @bairro, rua = @rua, cep = @cep WHERE idFunc = @idFunc;";
            comm.Parameters.AddWithValue("@idFunc", queryDatabase());
            comm.Parameters.AddWithValue("@bairro", txt_bairro_funcionario.Text);
            comm.Parameters.AddWithValue("@rua", txt_rua_funcionario.Text);
            comm.Parameters.AddWithValue("@cep", txt_cep_funcionario.Text);
            comm.ExecuteNonQuery();
        }
        private void attTelefone()
        {
            ConnectDatabase db = new ConnectDatabase();
            MySqlCommand comm = db.connect().CreateCommand();
            comm.CommandText = "UPDATE tbtelefonefuncionario SET ddd = @ddd, telefone = @telefone WHERE idFunc = @idFunc;";
            comm.Parameters.AddWithValue("@idFunc", queryDatabase());
            comm.Parameters.AddWithValue("@ddd", txt_ddd_funcionario.Text);
            comm.Parameters.AddWithValue("@telefone", txt_telefone_funcionario.Text);
            comm.ExecuteNonQuery();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {


            foreach (ListViewItem item in listFuncionarios.Items)
            {
                if (item.Selected || item.Checked)
                {
                    ConnectDatabase connect = new ConnectDatabase();
                    ListViewItem items = listFuncionarios.Items[item.Index];
                    updateFunc(items.SubItems[0].Text);
                    listFuncionarios.Items.RemoveAt(item.Index);
                }


            }
        }
        private void updateFunc(string id)
        {

            ConnectDatabase db = new ConnectDatabase();
            MySqlCommand comm = db.connect().CreateCommand();


            comm.CommandText = "update tbfuncionario set ativo = false where idFunc = @idFunc;";
            comm.Parameters.AddWithValue("@idFunc", id);
            comm.ExecuteNonQuery();
        }

        private void GerarGrade()
        {
            listFuncionarios.Columns.Add("Id", 40).TextAlign = HorizontalAlignment.Center;
            listFuncionarios.Columns.Add("Nome", 280).TextAlign = HorizontalAlignment.Center;
            listFuncionarios.Columns.Add("Cargo", 200).TextAlign = HorizontalAlignment.Center;
            listFuncionarios.Columns.Add("CPF", 165).TextAlign = HorizontalAlignment.Center;
            listFuncionarios.View = View.Details;

            listFuncionarios.FullRowSelect = true;
            listFuncionarios.GridLines = true;
            listFuncionarios.CheckBoxes = true;
        }

        public void PopularGrade()
        {
            String[] item = new string[4];
            ConnectDatabase connect = new ConnectDatabase();
            var listFunc = queryFunc();
            foreach (ListFunc funcionario in listFunc)
            {
                item[0] = funcionario.Id.ToString();
                item[1] = funcionario.Nome;
                item[2] = funcionario.Cargo;
                item[3] = funcionario.Cpf;
                listFuncionarios.Items.Add(new ListViewItem(item));
            }
        }


        public void msgcampovazio()
        {
            MessageBox.Show("É obrigatótio o preenchimento do campo.");
        }
        public void limparcampos()
        {
            txt_cep_funcionario.Text = "";
            txt_cpf_funcionario.Text = "";
            txt_ddd_funcionario.Text = "";
            txt_bairro_funcionario.Text = "";
            txt_nome_funcionario.Text = "";
            txt_rua_funcionario.Text = "";
            txt_salario_funcionario.Text = "";
            txt_telefone_funcionario.Text = "";
            cbx_cargo.SelectedIndex = 0;
            cbx_est_civil.SelectedIndex = 0;

            btn_excluir.Enabled = false;
        }

        private List<ListFunc> queryFunc()
        {
            try
            {
                ConnectDatabase db = new ConnectDatabase();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM tbfuncionario", db.connect());
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                var listFuncionarios = new List<ListFunc>();

                while (reader.Read())
                {

                    if (reader["ativo"].ToString().Equals("True"))
                    {
                        listFuncionarios.Add(new ListFunc(reader["nome"].ToString(), reader["Cpf"].ToString(), reader["cargo"].ToString(), reader["idFunc"].ToString()));
                    }

                }
                return listFuncionarios;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private void Cadastrar_funcionario_Load(object sender, EventArgs e)
        {

        }

        private void listFuncionarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {


            ConnectDatabase db = new ConnectDatabase();
            MySqlConnection conn = db.connect();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "SELECT * FROM tbfuncionario where cpf = @cpf";
            comm.Parameters.AddWithValue("@cpf", listFuncionarios.SelectedItems[0].SubItems[1].Text);
            MySqlDataReader reader = comm.ExecuteReader();

           

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["idFunc"].ToString());
                item.SubItems.Add(reader["cpf"].ToString());
                item.SubItems.Add(reader["nome"].ToString());
                item.SubItems.Add(reader["dataNasc"].ToString());
                item.SubItems.Add(reader["estadoCivil"].ToString());
                item.SubItems.Add(reader["senha"].ToString());
                item.SubItems.Add(reader["cargo"].ToString());
                item.SubItems.Add(reader["salarioBase"].ToString());
                item.SubItems.Add(reader["bairro"].ToString());
                item.SubItems.Add(reader["rua"].ToString());
                item.SubItems.Add(reader["cep"].ToString());
                item.SubItems.Add(reader["ddd"].ToString());
                item.SubItems.Add(reader["telefone"].ToString());

                listFuncionarios.Items.Add(item);

               

                // Seleciona o item adicionado na ListView
                item.Selected = true;
                // Define o foco no item adicionado
                item.Focused = true;

                // Atribui os valores às caixas de texto
                txt_idfuncionario.Text = item.SubItems[0].Text;
                txt_cpf_funcionario.Text = item.SubItems[1].Text;
                txt_nome_funcionario.Text = item.SubItems[2].Text;
                dtp_dt_nasc.Text = item.SubItems[3].Text;
                cbx_est_civil.Text = item.SubItems[4].Text;
                boxSenha.Text = item.SubItems[6].Text;
                cbx_cargo.Text = item.SubItems[7].Text;
                txt_rua_funcionario.Text = item.SubItems[8].Text;
                txt_bairro_funcionario.Text = item.SubItems[9].Text;
                txt_cep_funcionario.Text = item.SubItems[10].Text;
                txt_ddd_funcionario.Text = item.SubItems[11].Text;
                txt_telefone_funcionario.Text = item.SubItems[12].Text;

            }

            reader.Close();
        }

    }
}
