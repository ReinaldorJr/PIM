namespace FolhaPagamento
{
    partial class Controle_frequencia
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
            dtp_datafrequencia = new DateTimePicker();
            label1 = new Label();
            txt_nomefuncionariofrequencia = new TextBox();
            txt_idfuncionariofrequencia = new TextBox();
            label2 = new Label();
            txt_horastrabalhadas = new TextBox();
            label3 = new Label();
            txt_faltas = new TextBox();
            label5 = new Label();
            txt_faltasjustificadas = new TextBox();
            label6 = new Label();
            label4 = new Label();
            button3 = new Button();
            txt_cpf_funcionario = new MaskedTextBox();
            label8 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            button5 = new Button();
            listControle = new ListView();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(633, 418);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(79, 28);
            button1.TabIndex = 0;
            button1.Text = "confirmar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtp_datafrequencia
            // 
            dtp_datafrequencia.Location = new Point(565, 64);
            dtp_datafrequencia.Margin = new Padding(2);
            dtp_datafrequencia.Name = "dtp_datafrequencia";
            dtp_datafrequencia.Size = new Size(147, 23);
            dtp_datafrequencia.TabIndex = 1;
            dtp_datafrequencia.Value = new DateTime(2023, 4, 25, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 2;
            label1.Text = "NOME:";
            label1.Click += label1_Click;
            // 
            // txt_nomefuncionariofrequencia
            // 
            txt_nomefuncionariofrequencia.Enabled = false;
            txt_nomefuncionariofrequencia.Location = new Point(74, 32);
            txt_nomefuncionariofrequencia.Margin = new Padding(2);
            txt_nomefuncionariofrequencia.Name = "txt_nomefuncionariofrequencia";
            txt_nomefuncionariofrequencia.Size = new Size(487, 23);
            txt_nomefuncionariofrequencia.TabIndex = 3;
            // 
            // txt_idfuncionariofrequencia
            // 
            txt_idfuncionariofrequencia.Enabled = false;
            txt_idfuncionariofrequencia.Location = new Point(24, 32);
            txt_idfuncionariofrequencia.Margin = new Padding(2);
            txt_idfuncionariofrequencia.Name = "txt_idfuncionariofrequencia";
            txt_idfuncionariofrequencia.Size = new Size(45, 23);
            txt_idfuncionariofrequencia.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 14);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 4;
            label2.Text = "ID:";
            // 
            // txt_horastrabalhadas
            // 
            txt_horastrabalhadas.Location = new Point(170, 64);
            txt_horastrabalhadas.Margin = new Padding(2);
            txt_horastrabalhadas.Name = "txt_horastrabalhadas";
            txt_horastrabalhadas.Size = new Size(83, 23);
            txt_horastrabalhadas.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 66);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(133, 15);
            label3.TabIndex = 6;
            label3.Text = "HORAS TRABALHADAS:";
            // 
            // txt_faltas
            // 
            txt_faltas.Location = new Point(170, 134);
            txt_faltas.Margin = new Padding(2);
            txt_faltas.Name = "txt_faltas";
            txt_faltas.Size = new Size(83, 23);
            txt_faltas.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 135);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 10;
            label5.Text = "FALTAS:";
            // 
            // txt_faltasjustificadas
            // 
            txt_faltasjustificadas.Location = new Point(170, 98);
            txt_faltasjustificadas.Margin = new Padding(2);
            txt_faltasjustificadas.Name = "txt_faltasjustificadas";
            txt_faltasjustificadas.Size = new Size(83, 23);
            txt_faltasjustificadas.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 100);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(124, 15);
            label6.TabIndex = 12;
            label6.Text = "FALTAS JUSTIFICADAS:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(453, 66);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 15;
            label4.Text = "DATA REFERENTE:";
            // 
            // button3
            // 
            button3.Location = new Point(550, 418);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(79, 28);
            button3.TabIndex = 17;
            button3.Text = "cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // txt_cpf_funcionario
            // 
            txt_cpf_funcionario.Location = new Point(569, 32);
            txt_cpf_funcionario.Mask = "00000000000";
            txt_cpf_funcionario.Name = "txt_cpf_funcionario";
            txt_cpf_funcionario.Size = new Size(97, 23);
            txt_cpf_funcionario.TabIndex = 44;
            txt_cpf_funcionario.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(495, -16);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 43;
            label8.Text = "CPF:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, -16);
            label7.Name = "label7";
            label7.Size = new Size(21, 15);
            label7.TabIndex = 41;
            label7.Text = "ID:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(45, -16);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 40;
            label9.Text = "Nome:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(569, 14);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(31, 15);
            label10.TabIndex = 45;
            label10.Text = "CPF:";
            // 
            // button5
            // 
            button5.Location = new Point(672, 30);
            button5.Name = "button5";
            button5.Size = new Size(42, 25);
            button5.TabIndex = 46;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // listControle
            // 
            listControle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            listControle.Location = new Point(24, 268);
            listControle.Margin = new Padding(2);
            listControle.Name = "listControle";
            listControle.Size = new Size(688, 146);
            listControle.TabIndex = 50;
            listControle.UseCompatibleStateImageBehavior = false;
            listControle.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Controle_frequencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 458);
            Controls.Add(listControle);
            Controls.Add(button5);
            Controls.Add(label10);
            Controls.Add(txt_cpf_funcionario);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(txt_faltasjustificadas);
            Controls.Add(label6);
            Controls.Add(txt_faltas);
            Controls.Add(label5);
            Controls.Add(txt_horastrabalhadas);
            Controls.Add(label3);
            Controls.Add(txt_idfuncionariofrequencia);
            Controls.Add(label2);
            Controls.Add(txt_nomefuncionariofrequencia);
            Controls.Add(label1);
            Controls.Add(dtp_datafrequencia);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "Controle_frequencia";
            Text = "Controle_frequencia";
            Load += Controle_frequencia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DateTimePicker dtp_datafrequencia;
        private Label label1;
        private TextBox txt_nomefuncionariofrequencia;
        private TextBox txt_idfuncionariofrequencia;
        private Label label2;
        private TextBox txt_horastrabalhadas;
        private Label label3;
        private TextBox txt_faltas;
        private Label label5;
        private TextBox txt_faltasjustificadas;
        private Label label6;
        private Label label4;
        private Button button3;
        private MaskedTextBox txt_cpf_funcionario;
        private Label label8;
        private Label label7;
        private Label label9;
        private Label label10;
        private Button button5;
        private ListView listView1;
        private ListView listControle;
    }
}