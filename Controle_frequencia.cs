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
    public partial class Controle_frequencia : Form
    {
        public Controle_frequencia()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Folha_pagamento fp = new Folha_pagamento();

            if (txt_nomefuncionariofrequencia.Text == "")
            {
                msgcampovazio();
                txt_nomefuncionariofrequencia.Focus();
                return;
            }
            else
            {

            }

            if (txt_idfuncionariofrequencia.Text == "")
            {
                msgcampovazio();
                txt_idfuncionariofrequencia.Focus();
                return;
            }
            else
            {

            }

            if (txt_horastrabalhadas.Text == "")
            {
                msgcampovazio();
                txt_horastrabalhadas.Focus();
                return;
            }
            else
            {

            }

            if (txt_faltas.Text == "")
            {
                msgcampovazio();
                txt_faltas.Focus();
                return;
            }
            else
            {

            }

            if (txt_faltasjustificadas.Text == "")
            {
                msgcampovazio();
                txt_faltasjustificadas.Focus();
                return;
            }
            else
            {

            }

            if (dtp_datafrequencia.Text == null)
            {
                msgcampovazio();
                dtp_datafrequencia.Focus();
                return;
            }
            else
            {

            }


            ConnectDatabase db = new ConnectDatabase();
            MySqlCommand comm = db.connect().CreateCommand();
            try
            {

                comm.CommandText = "INSERT INTO tbcontrolefrequencia(idFunc, horastrabalhadas, faltas, faltasjustificadas, dataFrequencia) VALUES(@idFunc, @horastrabalhadas, @faltas, @faltasjustificadas, @dataFrequencia);";
                comm.Parameters.AddWithValue("@idFunc", txt_idfuncionariofrequencia.Text);
                comm.Parameters.AddWithValue("@horastrabalhadas", txt_horastrabalhadas.Text);
                comm.Parameters.AddWithValue("@faltas", txt_faltas.Text);
                comm.Parameters.AddWithValue("@faltasjustificadas", txt_faltasjustificadas.Text);
                comm.Parameters.AddWithValue("@dataFrequencia", dtp_datafrequencia.Value);
                comm.ExecuteNonQuery();

                MessageBox.Show("Cadastro efetuado com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

 
 

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string strConexao = "server=127.0.0.1;uid=root;pwd=0000;database=folhadepagamento";
            MySqlConnection conexao = new MySqlConnection(strConexao);
            conexao.Open();

            MySqlCommand comm = conexao.CreateCommand();
            comm.CommandText = "SELECT idFunc, nome FROM tbfuncionario WHERE cpf = @cpf";
            comm.Parameters.AddWithValue("@cpf", txt_cpf_funcionario.Text);

            using (MySqlDataReader reader = comm.ExecuteReader())
            {
                if (reader.Read())
                {
                    txt_idfuncionariofrequencia.Text = reader["idFunc"].ToString();
                    txt_nomefuncionariofrequencia.Text = reader["nome"].ToString();
                }
            }

            conexao.Close();

        }

        public void msgcampovazio()
        {
            MessageBox.Show("É obrigatótio o preenchimento do campo.");
        }
    }
}
