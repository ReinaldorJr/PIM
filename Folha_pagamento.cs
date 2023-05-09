using folhaDePagamento.services;
using FolhaPagamento.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaPagamento
{
    public partial class Folha_pagamento : Form
    {
        public Folha_pagamento()
        {
            InitializeComponent();
            PopularGrade();
            GerarGrade();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salarioBruto, inss, irrf, salarioLiquido, descontos, adicionais;

            try
            {
                salarioBruto = double.Parse(txt_salariobruto.Text.Replace("R$", ""));

                descontos = double.Parse(txt_descontos.Text.Replace("R$", ""));

                adicionais = double.Parse(txt_adicionais.Text.Replace("R$", ""));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Obrigatório o preenchimento dos campos.");
                txt_adicionais.Focus();
                return;
            }




            Folha_pagamento fp = new Folha_pagamento();

            if (txt_nomefuncionariofolha.Text == "")
            {
                msgcampovazio();
                txt_nomefuncionariofolha.Focus();
                return;
            }
            else
            {

            }

            if (txt_idfuincionariofolha.Text == "")
            {
                msgcampovazio();
                txt_idfuincionariofolha.Focus();
                return;
            }
            else
            {

            }

            if (dpt_datapagamento.Text == null)
            {
                msgcampovazio();
                dpt_datapagamento.Focus();
                return;
            }
            else
            {

            }

            if (txt_descontos.Text == "")
            {
                msgcampovazio();
                txt_descontos.Text = "0";
                return;
            }
            else
            {

            }

            if (txt_adicionais.Text == "")
            {
                msgcampovazio();
                txt_adicionais.Text = "0";
                return;
            }
            else
            {

            }



            // Calcula o valor do INSS
            if (salarioBruto <= 1100)
            {
                inss = salarioBruto * 0.075;
            }
            else if (salarioBruto <= 2203.48)
            {
                inss = salarioBruto * 0.09;
            }
            else if (salarioBruto <= 3305.22)
            {
                inss = salarioBruto * 0.12;
            }
            else if (salarioBruto <= 6433.57)
            {
                inss = salarioBruto * 0.14;
            }
            else
            {
                inss = 751.99;
            }

            // Calcula o valor do IRRF
            double salarioBase = salarioBruto - inss;
            if (salarioBase <= 1903.98)
            {
                irrf = 0;
            }
            else if (salarioBase <= 2826.65)
            {
                irrf = (salarioBase * 0.075) - 142.80;
            }
            else if (salarioBase <= 3751.05)
            {
                irrf = (salarioBase * 0.15) - 354.80;
            }
            else if (salarioBase <= 4664.68)
            {
                irrf = (salarioBase * 0.225) - 636.13;
            }
            else
            {
                irrf = (salarioBase * 0.275) - 869.36;
            }



            salarioBruto = salarioBruto + adicionais - descontos;
            salarioLiquido = salarioBruto - inss - irrf;




            ConnectDatabase db = new ConnectDatabase();
            MySqlCommand comm = db.connect().CreateCommand();
            try
            {

                comm.CommandText = "INSERT INTO tbdemonstrativopagamento(idFunc, inssfunc, irrfFunci, descontosFunc, adicionaisFunc, salarioLiqFunc, salarioBrutoFunc, dataPagFunc) VALUES(@idFunc, @inssfunc, @irrfFunci, @descontosFunc, @adicionaisFunc, @salarioLiqFunc, @salarioBrutoFunc, @dataPagFunc);";
                comm.Parameters.AddWithValue("@idFunc", txt_nomefuncionariofolha.Text);
                comm.Parameters.AddWithValue("@inssfunc", inss);
                comm.Parameters.AddWithValue("@irrfFunci", irrf);
                comm.Parameters.AddWithValue("@descontosFunc", txt_descontos.Text.Replace("R$", ""));
                comm.Parameters.AddWithValue("@adicionaisFunc", txt_adicionais.Text.Replace("R$", ""));
                comm.Parameters.AddWithValue("@salarioLiqFunc", salarioLiquido);
                comm.Parameters.AddWithValue("@salarioBrutoFunc", txt_salariobruto.Text.Replace("R$", ""));
                comm.Parameters.AddWithValue("@dataPagFunc", dpt_datapagamento.Value);
                comm.ExecuteNonQuery();

                MessageBox.Show("Cadastro efetuado com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("é aqui");
                MessageBox.Show(ex.ToString());
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        //puxa ID e NOME
        private void button5_Click(object sender, EventArgs e)
        {
            string strConexao = "server=127.0.0.1;uid=root;pwd=0000;database=folhadepagamento";
            MySqlConnection conexao = new MySqlConnection(strConexao);
            conexao.Open();

            MySqlCommand comm = conexao.CreateCommand();

            try
            {
                comm.CommandText = "SELECT idFunc, nome FROM tbFuncionario WHERE cpf = @cpf";
                comm.Parameters.AddWithValue("@cpf", txt_cpf_funcionario.Text);
                using (MySqlDataReader reader = comm.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txt_nomefuncionariofolha.Text = reader["idFunc"].ToString();
                        txt_idfuincionariofolha.Text = reader["nome"].ToString();
                    }
                }


                comm.CommandText = "SELECT salarioBase FROM tbSalario WHERE cpf = @cpf2";
                comm.Parameters.AddWithValue("@cpf2", txt_cpf_funcionario.Text);
                using (MySqlDataReader reader = comm.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txt_salariobruto.Text = reader["salarioBase"].ToString();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            conexao.Close();

        }
        private void GerarGrade()
        {
            listFolhaPagamento.Columns.Add("Id", 40).TextAlign = HorizontalAlignment.Center;
            listFolhaPagamento.Columns.Add("Nome", 280).TextAlign = HorizontalAlignment.Center;
            listFolhaPagamento.Columns.Add("Cargo", 200).TextAlign = HorizontalAlignment.Center;
            listFolhaPagamento.Columns.Add("CPF", 165).TextAlign = HorizontalAlignment.Center;
            listFolhaPagamento.View = View.Details;

            listFolhaPagamento.FullRowSelect = true;
            listFolhaPagamento.GridLines = true;
            listFolhaPagamento.CheckBoxes = true;
        }

        public void PopularGrade()
        {
            String[] item = new string[4];

            var listFunc = queryFunc();
            foreach (ListFunc funcionario in listFunc)
            {
                item[0] = funcionario.Id.ToString();
                item[1] = funcionario.Nome;
                item[2] = funcionario.Cargo;
                item[3] = funcionario.Cpf;
                listFolhaPagamento.Items.Add(new ListViewItem(item));
            }
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
                Console.WriteLine("error ===> ", ex);
                return null;
            }
        }
        public void msgcampovazio()
        {
            MessageBox.Show("É obrigatótio o preenchimento do campo.");
        }

        private void Folha_pagamento_Load(object sender, EventArgs e)
        {

        }
    }
}
