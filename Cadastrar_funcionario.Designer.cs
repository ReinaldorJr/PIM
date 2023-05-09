namespace FolhaPagamento
{
    partial class Cadastrar_funcionario
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
            txt_nome_funcionario = new TextBox();
            txt_rua_funcionario = new TextBox();
            txt_bairro_funcionario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_idfuncionario = new TextBox();
            label8 = new Label();
            dtp_dt_nasc = new DateTimePicker();
            cbx_est_civil = new ComboBox();
            txt_telefone_funcionario = new MaskedTextBox();
            txt_ddd_funcionario = new MaskedTextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            btn_cadastrar = new Button();
            btn_cancelar = new Button();
            cbx_cargo = new ComboBox();
            txt_cpf_funcionario = new MaskedTextBox();
            txt_cep_funcionario = new MaskedTextBox();
            btn_excluir = new Button();
            btn_atualizar = new Button();
            txt_salario_funcionario = new MaskedTextBox();
            listFuncionarios = new ListView();
            boxSenha = new TextBox();
            label12 = new Label();
            SuspendLayout();
            // 
            // txt_nome_funcionario
            // 
            txt_nome_funcionario.Location = new Point(65, 32);
            txt_nome_funcionario.Margin = new Padding(4, 5, 4, 5);
            txt_nome_funcionario.Name = "txt_nome_funcionario";
            txt_nome_funcionario.Size = new Size(437, 24);
            txt_nome_funcionario.TabIndex = 2;
            // 
            // txt_rua_funcionario
            // 
            txt_rua_funcionario.ForeColor = SystemColors.ActiveCaptionText;
            txt_rua_funcionario.Location = new Point(24, 253);
            txt_rua_funcionario.Margin = new Padding(4, 5, 4, 5);
            txt_rua_funcionario.Name = "txt_rua_funcionario";
            txt_rua_funcionario.Size = new Size(557, 24);
            txt_rua_funcionario.TabIndex = 7;
            // 
            // txt_bairro_funcionario
            // 
            txt_bairro_funcionario.ForeColor = SystemColors.ActiveCaptionText;
            txt_bairro_funcionario.Location = new Point(24, 198);
            txt_bairro_funcionario.Margin = new Padding(4, 5, 4, 5);
            txt_bairro_funcionario.Name = "txt_bairro_funcionario";
            txt_bairro_funcionario.Size = new Size(688, 24);
            txt_bairro_funcionario.TabIndex = 8;
            txt_bairro_funcionario.Tag = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 17);
            label1.TabIndex = 9;
            label1.Text = "NOME:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 9);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(23, 17);
            label2.TabIndex = 10;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(602, 73);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 17);
            label3.TabIndex = 11;
            label3.Text = "DATA NASC:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(311, 70);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 17);
            label4.TabIndex = 12;
            label4.Text = "ESTADO CIVIL:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 72);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 17);
            label5.TabIndex = 13;
            label5.Text = "CARGO:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 176);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(55, 17);
            label6.TabIndex = 14;
            label6.Text = "BAIRRO:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(423, 72);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(71, 17);
            label7.TabIndex = 15;
            label7.Text = "TELEFONE:";
            // 
            // txt_idfuncionario
            // 
            txt_idfuncionario.Enabled = false;
            txt_idfuncionario.Location = new Point(24, 32);
            txt_idfuncionario.Margin = new Padding(4, 5, 4, 5);
            txt_idfuncionario.Name = "txt_idfuncionario";
            txt_idfuncionario.Size = new Size(33, 24);
            txt_idfuncionario.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(621, 11);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(32, 17);
            label8.TabIndex = 17;
            label8.Text = "CPF:";
            // 
            // dtp_dt_nasc
            // 
            dtp_dt_nasc.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_dt_nasc.Location = new Point(602, 95);
            dtp_dt_nasc.Margin = new Padding(4, 5, 4, 5);
            dtp_dt_nasc.MaxDate = new DateTime(2023, 4, 13, 13, 21, 33, 0);
            dtp_dt_nasc.Name = "dtp_dt_nasc";
            dtp_dt_nasc.Size = new Size(110, 23);
            dtp_dt_nasc.TabIndex = 21;
            dtp_dt_nasc.Value = new DateTime(2023, 4, 13, 0, 0, 0, 0);
            // 
            // cbx_est_civil
            // 
            cbx_est_civil.FormattingEnabled = true;
            cbx_est_civil.Location = new Point(311, 91);
            cbx_est_civil.Margin = new Padding(4, 5, 4, 5);
            cbx_est_civil.Name = "cbx_est_civil";
            cbx_est_civil.Size = new Size(90, 25);
            cbx_est_civil.TabIndex = 22;
            // 
            // txt_telefone_funcionario
            // 
            txt_telefone_funcionario.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txt_telefone_funcionario.Location = new Point(466, 92);
            txt_telefone_funcionario.Margin = new Padding(4, 5, 4, 5);
            txt_telefone_funcionario.Mask = "000000000";
            txt_telefone_funcionario.Name = "txt_telefone_funcionario";
            txt_telefone_funcionario.Size = new Size(115, 24);
            txt_telefone_funcionario.TabIndex = 23;
            txt_telefone_funcionario.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_ddd_funcionario
            // 
            txt_ddd_funcionario.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ddd_funcionario.Location = new Point(423, 92);
            txt_ddd_funcionario.Margin = new Padding(4, 5, 4, 5);
            txt_ddd_funcionario.Mask = "00";
            txt_ddd_funcionario.Name = "txt_ddd_funcionario";
            txt_ddd_funcionario.Size = new Size(42, 24);
            txt_ddd_funcionario.TabIndex = 24;
            txt_ddd_funcionario.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 231);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(36, 17);
            label9.TabIndex = 27;
            label9.Text = "RUA:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(589, 231);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(33, 17);
            label10.TabIndex = 28;
            label10.Text = "CEP:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(182, 70);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(61, 17);
            label11.TabIndex = 31;
            label11.Text = "SALÁRIO:";
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Location = new Point(633, 435);
            btn_cadastrar.Margin = new Padding(4, 5, 4, 5);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(79, 28);
            btn_cadastrar.TabIndex = 34;
            btn_cadastrar.Text = "confirmar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(550, 435);
            btn_cancelar.Margin = new Padding(4, 5, 4, 5);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(79, 28);
            btn_cancelar.TabIndex = 35;
            btn_cancelar.Text = "cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // cbx_cargo
            // 
            cbx_cargo.FormattingEnabled = true;
            cbx_cargo.Location = new Point(24, 92);
            cbx_cargo.Margin = new Padding(4, 5, 4, 5);
            cbx_cargo.Name = "cbx_cargo";
            cbx_cargo.Size = new Size(142, 25);
            cbx_cargo.TabIndex = 36;
            // 
            // txt_cpf_funcionario
            // 
            txt_cpf_funcionario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cpf_funcionario.Location = new Point(621, 32);
            txt_cpf_funcionario.Margin = new Padding(4, 5, 4, 5);
            txt_cpf_funcionario.Mask = "00000000000";
            txt_cpf_funcionario.Name = "txt_cpf_funcionario";
            txt_cpf_funcionario.Size = new Size(91, 25);
            txt_cpf_funcionario.TabIndex = 38;
            txt_cpf_funcionario.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_cep_funcionario
            // 
            txt_cep_funcionario.Location = new Point(589, 253);
            txt_cep_funcionario.Margin = new Padding(4, 5, 4, 5);
            txt_cep_funcionario.Mask = "00000000";
            txt_cep_funcionario.Name = "txt_cep_funcionario";
            txt_cep_funcionario.Size = new Size(123, 24);
            txt_cep_funcionario.TabIndex = 39;
            txt_cep_funcionario.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_excluir
            // 
            btn_excluir.Location = new Point(24, 435);
            btn_excluir.Margin = new Padding(4, 5, 4, 5);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(79, 28);
            btn_excluir.TabIndex = 40;
            btn_excluir.Text = "excluir";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // btn_atualizar
            // 
            btn_atualizar.Enabled = false;
            btn_atualizar.Location = new Point(111, 435);
            btn_atualizar.Margin = new Padding(4, 5, 4, 5);
            btn_atualizar.Name = "btn_atualizar";
            btn_atualizar.Size = new Size(79, 28);
            btn_atualizar.TabIndex = 42;
            btn_atualizar.Text = "atualizar";
            btn_atualizar.UseVisualStyleBackColor = true;
            btn_atualizar.Click += btn_atualizar_Click;
            // 
            // txt_salario_funcionario
            // 
            txt_salario_funcionario.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txt_salario_funcionario.Location = new Point(186, 92);
            txt_salario_funcionario.Margin = new Padding(4, 5, 4, 5);
            txt_salario_funcionario.Mask = "$000000000";
            txt_salario_funcionario.Name = "txt_salario_funcionario";
            txt_salario_funcionario.Size = new Size(98, 24);
            txt_salario_funcionario.TabIndex = 43;
            txt_salario_funcionario.TextAlign = HorizontalAlignment.Center;
            // 
            // listFuncionarios
            // 
            listFuncionarios.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            listFuncionarios.Location = new Point(24, 285);
            listFuncionarios.Name = "listFuncionarios";
            listFuncionarios.Size = new Size(688, 146);
            listFuncionarios.TabIndex = 44;
            listFuncionarios.UseCompatibleStateImageBehavior = false;
            listFuncionarios.MouseDoubleClick += listFuncionarios_MouseDoubleClick;
            // 
            // boxSenha
            // 
            boxSenha.Location = new Point(510, 32);
            boxSenha.Margin = new Padding(4, 5, 4, 5);
            boxSenha.Name = "boxSenha";
            boxSenha.Size = new Size(103, 24);
            boxSenha.TabIndex = 46;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(510, 10);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(52, 17);
            label12.TabIndex = 45;
            label12.Text = "SENHA:";
            // 
            // Cadastrar_funcionario
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 477);
            Controls.Add(boxSenha);
            Controls.Add(label12);
            Controls.Add(listFuncionarios);
            Controls.Add(txt_salario_funcionario);
            Controls.Add(btn_atualizar);
            Controls.Add(btn_excluir);
            Controls.Add(txt_cep_funcionario);
            Controls.Add(txt_cpf_funcionario);
            Controls.Add(cbx_cargo);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_cadastrar);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txt_ddd_funcionario);
            Controls.Add(txt_telefone_funcionario);
            Controls.Add(cbx_est_civil);
            Controls.Add(dtp_dt_nasc);
            Controls.Add(label8);
            Controls.Add(txt_idfuncionario);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_bairro_funcionario);
            Controls.Add(txt_rua_funcionario);
            Controls.Add(txt_nome_funcionario);
            Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Cadastrar_funcionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Funcionario";
            Load += Cadastrar_funcionario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_nome_funcionario;
        private TextBox txt_rua_funcionario;
        private TextBox txt_bairro_funcionario;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_idfuncionario;
        private Label label8;
        private DateTimePicker dtp_dt_nasc;
        private ComboBox cbx_est_civil;
        private MaskedTextBox txt_telefone_funcionario;
        private MaskedTextBox txt_ddd_funcionario;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button button2;
        private System.CodeDom.CodeTypeReference button3;
        private System.CodeDom.CodeTypeReference button4;
        private Button btn_cadastrar;
        private Button btn_cancelar;
        private ComboBox cbx_cargo;
        private MaskedTextBox txt_cpf_funcionario;
        private MaskedTextBox txt_cep_funcionario;
        private Button btn_excluir;
        private Button btn_atualizar;
        private MaskedTextBox txt_salario_funcionario;
        private ListView listFuncionarios;
        private TextBox boxSenha;
        private Label label12;
    }
}