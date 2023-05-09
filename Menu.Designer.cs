namespace FolhaPagamento
{
    partial class Menu
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
            btn_cadastro_funcionario = new Button();
            btn_frequencia = new Button();
            btn_folhapagamento = new Button();
            btn_sair = new Button();
            painel_menu = new Panel();
            SuspendLayout();
            // 
            // btn_cadastro_funcionario
            // 
            btn_cadastro_funcionario.BackColor = Color.Transparent;
            btn_cadastro_funcionario.Location = new Point(8, 89);
            btn_cadastro_funcionario.Name = "btn_cadastro_funcionario";
            btn_cadastro_funcionario.Size = new Size(164, 23);
            btn_cadastro_funcionario.TabIndex = 0;
            btn_cadastro_funcionario.Text = "Cadastro funcionário";
            btn_cadastro_funcionario.UseVisualStyleBackColor = false;
            btn_cadastro_funcionario.Click += btn_cadastro_funcionario_Click;
            // 
            // btn_frequencia
            // 
            btn_frequencia.BackColor = Color.Transparent;
            btn_frequencia.Location = new Point(8, 227);
            btn_frequencia.Name = "btn_frequencia";
            btn_frequencia.Size = new Size(164, 23);
            btn_frequencia.TabIndex = 1;
            btn_frequencia.Text = "Controle de frequência";
            btn_frequencia.UseVisualStyleBackColor = false;
            btn_frequencia.Click += btn_frequencia_Click;
            // 
            // btn_folhapagamento
            // 
            btn_folhapagamento.BackColor = Color.Transparent;
            btn_folhapagamento.Location = new Point(8, 151);
            btn_folhapagamento.Name = "btn_folhapagamento";
            btn_folhapagamento.Size = new Size(164, 23);
            btn_folhapagamento.TabIndex = 2;
            btn_folhapagamento.Text = "Folha de pagamento";
            btn_folhapagamento.UseVisualStyleBackColor = false;
            btn_folhapagamento.Click += btn_folhapagamento_Click;
            // 
            // btn_sair
            // 
            btn_sair.Location = new Point(56, 484);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(76, 23);
            btn_sair.TabIndex = 3;
            btn_sair.Text = "sair";
            btn_sair.UseVisualStyleBackColor = true;
            btn_sair.Click += bt_sair_Click;
            // 
            // painel_menu
            // 
            painel_menu.Anchor = AnchorStyles.None;
            painel_menu.AutoSize = true;
            painel_menu.BackColor = SystemColors.AppWorkspace;
            painel_menu.BorderStyle = BorderStyle.Fixed3D;
            painel_menu.Location = new Point(195, 10);
            painel_menu.Margin = new Padding(1);
            painel_menu.Name = "painel_menu";
            painel_menu.Size = new Size(733, 497);
            painel_menu.TabIndex = 4;
            painel_menu.Paint += painel_menu_Paint;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(938, 517);
            Controls.Add(painel_menu);
            Controls.Add(btn_sair);
            Controls.Add(btn_folhapagamento);
            Controls.Add(btn_frequencia);
            Controls.Add(btn_cadastro_funcionario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cadastro_funcionario;
        private Button btn_frequencia;
        private Button btn_folhapagamento;
        private Button btn_sair;
        private Panel painel_menu;
    }
}