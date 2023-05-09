namespace FolhaPagamento
{
    partial class Folha_pagamento
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
            button1 = new Button();
            txt_nomefuncionariofolha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_idfuincionariofolha = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            button3 = new Button();
            button5 = new Button();
            txt_cpf_funcionario = new MaskedTextBox();
            label10 = new Label();
            button2 = new Button();
            label11 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dpt_datapagamento = new DateTimePicker();
            txt_salariobruto = new MaskedTextBox();
            txt_descontos = new MaskedTextBox();
            txt_adicionais = new MaskedTextBox();
            listFolhaPagamento = new ListView();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(632, 557);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(90, 27);
            button1.TabIndex = 0;
            button1.Text = "confirmar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_nomefuncionariofolha
            // 
            txt_nomefuncionariofolha.Enabled = false;
            txt_nomefuncionariofolha.Location = new Point(27, 42);
            txt_nomefuncionariofolha.Margin = new Padding(3, 4, 3, 4);
            txt_nomefuncionariofolha.Name = "txt_nomefuncionariofolha";
            txt_nomefuncionariofolha.Size = new Size(51, 27);
            txt_nomefuncionariofolha.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 18);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 11;
            label1.Text = "NOME:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 18);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 13;
            label2.Text = "ID:";
            // 
            // txt_idfuincionariofolha
            // 
            txt_idfuincionariofolha.Enabled = false;
            txt_idfuincionariofolha.Location = new Point(84, 42);
            txt_idfuincionariofolha.Margin = new Padding(3, 4, 3, 4);
            txt_idfuincionariofolha.Name = "txt_idfuincionariofolha";
            txt_idfuincionariofolha.Size = new Size(468, 27);
            txt_idfuincionariofolha.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 145);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 15;
            label3.Text = "ADICIONAIS:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 198);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 17;
            label4.Text = "DESCONTOS:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(415, 88);
            label5.Name = "label5";
            label5.Size = new Size(140, 20);
            label5.TabIndex = 19;
            label5.Text = "DATA PAGAMENTO:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 96);
            label7.Name = "label7";
            label7.Size = new Size(121, 20);
            label7.TabIndex = 23;
            label7.Text = "SALARIO BRUTO:";
            // 
            // button3
            // 
            button3.Location = new Point(538, 557);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(90, 27);
            button3.TabIndex = 28;
            button3.Text = "cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(674, 42);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(48, 25);
            button5.TabIndex = 31;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // txt_cpf_funcionario
            // 
            txt_cpf_funcionario.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cpf_funcionario.Location = new Point(558, 42);
            txt_cpf_funcionario.Margin = new Padding(3, 4, 3, 4);
            txt_cpf_funcionario.Mask = "00000000000";
            txt_cpf_funcionario.Name = "txt_cpf_funcionario";
            txt_cpf_funcionario.Size = new Size(110, 29);
            txt_cpf_funcionario.TabIndex = 40;
            txt_cpf_funcionario.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(558, 18);
            label10.Name = "label10";
            label10.Size = new Size(36, 20);
            label10.TabIndex = 39;
            label10.Text = "CPF:";
            // 
            // button2
            // 
            button2.Location = new Point(674, 326);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(48, 25);
            button2.TabIndex = 52;
            button2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(382, 328);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(120, 20);
            label11.TabIndex = 51;
            label11.Text = "DATA PESQUISA:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(503, 324);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(167, 30);
            dateTimePicker1.TabIndex = 50;
            dateTimePicker1.Value = new DateTime(2023, 4, 25, 0, 0, 0, 0);
            // 
            // dpt_datapagamento
            // 
            dpt_datapagamento.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dpt_datapagamento.Location = new Point(555, 82);
            dpt_datapagamento.Margin = new Padding(2);
            dpt_datapagamento.Name = "dpt_datapagamento";
            dpt_datapagamento.Size = new Size(167, 30);
            dpt_datapagamento.TabIndex = 54;
            dpt_datapagamento.Value = new DateTime(2023, 4, 25, 0, 0, 0, 0);
            // 
            // txt_salariobruto
            // 
            txt_salariobruto.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txt_salariobruto.Location = new Point(173, 94);
            txt_salariobruto.Margin = new Padding(2);
            txt_salariobruto.Mask = "$000000000";
            txt_salariobruto.Name = "txt_salariobruto";
            txt_salariobruto.Size = new Size(121, 29);
            txt_salariobruto.TabIndex = 55;
            // 
            // txt_descontos
            // 
            txt_descontos.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txt_descontos.Location = new Point(173, 198);
            txt_descontos.Margin = new Padding(2);
            txt_descontos.Mask = "$000000000";
            txt_descontos.Name = "txt_descontos";
            txt_descontos.Size = new Size(121, 29);
            txt_descontos.TabIndex = 56;
            // 
            // txt_adicionais
            // 
            txt_adicionais.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txt_adicionais.Location = new Point(173, 145);
            txt_adicionais.Margin = new Padding(2);
            txt_adicionais.Mask = "$000000000";
            txt_adicionais.Name = "txt_adicionais";
            txt_adicionais.Size = new Size(121, 29);
            txt_adicionais.TabIndex = 57;
            // 
            // listFolhaPagamento
            // 
            listFolhaPagamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listFolhaPagamento.Location = new Point(27, 358);
            listFolhaPagamento.Margin = new Padding(2);
            listFolhaPagamento.Name = "listFolhaPagamento";
            listFolhaPagamento.Size = new Size(695, 194);
            listFolhaPagamento.TabIndex = 53;
            listFolhaPagamento.UseCompatibleStateImageBehavior = false;
            // 
            // Folha_pagamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 611);
            Controls.Add(txt_adicionais);
            Controls.Add(txt_descontos);
            Controls.Add(txt_salariobruto);
            Controls.Add(dpt_datapagamento);
            Controls.Add(listFolhaPagamento);
            Controls.Add(button2);
            Controls.Add(label11);
            Controls.Add(dateTimePicker1);
            Controls.Add(txt_cpf_funcionario);
            Controls.Add(label10);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_idfuincionariofolha);
            Controls.Add(label1);
            Controls.Add(txt_nomefuncionariofolha);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Folha_pagamento";
            Text = "Folha Pagamento";
            Load += Folha_pagamento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txt_nomefuncionariofolha;
        private Label label1;
        private Label label2;
        private TextBox txt_idfuincionariofolha;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Button button3;
        private Button button5;
        private MaskedTextBox txt_cpf_funcionario;
        private Label label10;
        private Button button2;
        private Label label11;
        private DateTimePicker dateTimePicker1;
        private ListView listView1;
        private DateTimePicker dpt_datapagamento;
        private MaskedTextBox txt_salariobruto;
        private MaskedTextBox txt_descontos;
        private MaskedTextBox txt_adicionais;
        private ListView listFolhaPagamento;
    }
}