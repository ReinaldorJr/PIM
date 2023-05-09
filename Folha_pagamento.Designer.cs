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
            dpt_datapagamento = new DateTimePicker();
            txt_salariobruto = new MaskedTextBox();
            txt_descontos = new MaskedTextBox();
            txt_adicionais = new MaskedTextBox();
            listFolhaPagamento = new ListView();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(635, 419);
            button1.Name = "button1";
            button1.Size = new Size(79, 28);
            button1.TabIndex = 0;
            button1.Text = "confirmar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_nomefuncionariofolha
            // 
            txt_nomefuncionariofolha.Enabled = false;
            txt_nomefuncionariofolha.Location = new Point(24, 32);
            txt_nomefuncionariofolha.Name = "txt_nomefuncionariofolha";
            txt_nomefuncionariofolha.Size = new Size(45, 23);
            txt_nomefuncionariofolha.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 14);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 11;
            label1.Text = "NOME:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 14);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 13;
            label2.Text = "ID:";
            // 
            // txt_idfuincionariofolha
            // 
            txt_idfuincionariofolha.Enabled = false;
            txt_idfuincionariofolha.Location = new Point(74, 32);
            txt_idfuincionariofolha.Name = "txt_idfuincionariofolha";
            txt_idfuincionariofolha.Size = new Size(487, 23);
            txt_idfuincionariofolha.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 109);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 15;
            label3.Text = "ADICIONAIS:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 148);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 17;
            label4.Text = "DESCONTOS:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(363, 66);
            label5.Name = "label5";
            label5.Size = new Size(111, 15);
            label5.TabIndex = 19;
            label5.Text = "DATA PAGAMENTO:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 72);
            label7.Name = "label7";
            label7.Size = new Size(96, 15);
            label7.TabIndex = 23;
            label7.Text = "SALARIO BRUTO:";
            // 
            // button3
            // 
            button3.Location = new Point(550, 419);
            button3.Name = "button3";
            button3.Size = new Size(79, 28);
            button3.TabIndex = 28;
            button3.Text = "cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(672, 32);
            button5.Name = "button5";
            button5.Size = new Size(42, 25);
            button5.TabIndex = 31;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // txt_cpf_funcionario
            // 
            txt_cpf_funcionario.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cpf_funcionario.Location = new Point(569, 32);
            txt_cpf_funcionario.Mask = "00000000000";
            txt_cpf_funcionario.Name = "txt_cpf_funcionario";
            txt_cpf_funcionario.Size = new Size(97, 24);
            txt_cpf_funcionario.TabIndex = 40;
            txt_cpf_funcionario.TextAlign = HorizontalAlignment.Center;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(569, 14);
            label10.Name = "label10";
            label10.Size = new Size(31, 15);
            label10.TabIndex = 39;
            label10.Text = "CPF:";
            // 
            // dpt_datapagamento
            // 
            dpt_datapagamento.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dpt_datapagamento.Location = new Point(567, 62);
            dpt_datapagamento.Margin = new Padding(2);
            dpt_datapagamento.Name = "dpt_datapagamento";
            dpt_datapagamento.Size = new Size(147, 25);
            dpt_datapagamento.TabIndex = 54;
            dpt_datapagamento.Value = new DateTime(2023, 4, 25, 0, 0, 0, 0);
            // 
            // txt_salariobruto
            // 
            txt_salariobruto.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txt_salariobruto.Location = new Point(151, 70);
            txt_salariobruto.Margin = new Padding(2);
            txt_salariobruto.Mask = "$000000000";
            txt_salariobruto.Name = "txt_salariobruto";
            txt_salariobruto.Size = new Size(106, 24);
            txt_salariobruto.TabIndex = 55;
            // 
            // txt_descontos
            // 
            txt_descontos.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txt_descontos.Location = new Point(151, 148);
            txt_descontos.Margin = new Padding(2);
            txt_descontos.Mask = "$000000000";
            txt_descontos.Name = "txt_descontos";
            txt_descontos.Size = new Size(106, 24);
            txt_descontos.TabIndex = 56;
            // 
            // txt_adicionais
            // 
            txt_adicionais.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txt_adicionais.Location = new Point(151, 109);
            txt_adicionais.Margin = new Padding(2);
            txt_adicionais.Mask = "$000000000";
            txt_adicionais.Name = "txt_adicionais";
            txt_adicionais.Size = new Size(106, 24);
            txt_adicionais.TabIndex = 57;
            // 
            // listFolhaPagamento
            // 
            listFolhaPagamento.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            listFolhaPagamento.Location = new Point(24, 268);
            listFolhaPagamento.Margin = new Padding(2);
            listFolhaPagamento.Name = "listFolhaPagamento";
            listFolhaPagamento.Size = new Size(688, 146);
            listFolhaPagamento.TabIndex = 53;
            listFolhaPagamento.UseCompatibleStateImageBehavior = false;
            // 
            // Folha_pagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 458);
            Controls.Add(txt_adicionais);
            Controls.Add(txt_descontos);
            Controls.Add(txt_salariobruto);
            Controls.Add(dpt_datapagamento);
            Controls.Add(listFolhaPagamento);
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
        private ListView listView1;
        private DateTimePicker dpt_datapagamento;
        private MaskedTextBox txt_salariobruto;
        private MaskedTextBox txt_descontos;
        private MaskedTextBox txt_adicionais;
        private ListView listFolhaPagamento;
    }
}