namespace LigaNosEarredores
{
    partial class EstatisticasForms
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
            listBoxClassificacao = new ListBox();
            btnClassificacaoGeral = new Button();
            btnGolos = new Button();
            btnClasssificacao = new Button();
            btnVitorias = new Button();
            btnDerrotas = new Button();
            btnCancelar = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // listBoxClassificacao
            // 
            listBoxClassificacao.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxClassificacao.FormattingEnabled = true;
            listBoxClassificacao.ItemHeight = 17;
            listBoxClassificacao.Location = new Point(6, 324);
            listBoxClassificacao.Name = "listBoxClassificacao";
            listBoxClassificacao.Size = new Size(790, 123);
            listBoxClassificacao.TabIndex = 12;
            // 
            // btnClassificacaoGeral
            // 
            btnClassificacaoGeral.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClassificacaoGeral.Location = new Point(12, 76);
            btnClassificacaoGeral.Name = "btnClassificacaoGeral";
            btnClassificacaoGeral.Size = new Size(240, 53);
            btnClassificacaoGeral.TabIndex = 13;
            btnClassificacaoGeral.Text = "Mostrar toda a informação";
            btnClassificacaoGeral.UseVisualStyleBackColor = true;
            btnClassificacaoGeral.Click += btnClassificacaoGeral_Click;
            // 
            // btnGolos
            // 
            btnGolos.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGolos.Location = new Point(537, 76);
            btnGolos.Name = "btnGolos";
            btnGolos.Size = new Size(240, 51);
            btnGolos.TabIndex = 14;
            btnGolos.Text = "Mostrar os clubes com mais golos";
            btnGolos.UseVisualStyleBackColor = true;
            btnGolos.Click += btnGolos_Click;
            // 
            // btnClasssificacao
            // 
            btnClasssificacao.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClasssificacao.Location = new Point(273, 77);
            btnClasssificacao.Name = "btnClasssificacao";
            btnClasssificacao.Size = new Size(240, 51);
            btnClasssificacao.TabIndex = 15;
            btnClasssificacao.Text = "Mostrar Classificação";
            btnClasssificacao.UseVisualStyleBackColor = true;
            btnClasssificacao.Click += btnClasssificacao_Click;
            // 
            // btnVitorias
            // 
            btnVitorias.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVitorias.Location = new Point(136, 156);
            btnVitorias.Name = "btnVitorias";
            btnVitorias.Size = new Size(240, 51);
            btnVitorias.TabIndex = 16;
            btnVitorias.Text = "Mostrar os clubes com mais vitórias";
            btnVitorias.UseVisualStyleBackColor = true;
            btnVitorias.Click += btnVitorias_Click;
            // 
            // btnDerrotas
            // 
            btnDerrotas.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDerrotas.Location = new Point(408, 156);
            btnDerrotas.Name = "btnDerrotas";
            btnDerrotas.Size = new Size(240, 51);
            btnDerrotas.TabIndex = 17;
            btnDerrotas.Text = "Mostrar os clubes com mais derrotas";
            btnDerrotas.UseVisualStyleBackColor = true;
            btnDerrotas.Click += btnDerrotas_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(668, 267);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(128, 51);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Fechar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(273, 21);
            label6.Name = "label6";
            label6.Size = new Size(259, 25);
            label6.TabIndex = 20;
            label6.Text = "Estatisticas de todos os clubes!";
            // 
            // EstatisticasForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(btnCancelar);
            Controls.Add(btnDerrotas);
            Controls.Add(btnVitorias);
            Controls.Add(btnClasssificacao);
            Controls.Add(btnGolos);
            Controls.Add(btnClassificacaoGeral);
            Controls.Add(listBoxClassificacao);
            Name = "EstatisticasForms";
            Text = "Estatisticas";
            Load += EstatisticasForms_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBoxClassificacao;
        private Button btnClassificacaoGeral;
        private Button btnGolos;
        private Button btnClasssificacao;
        private Button btnVitorias;
        private Button btnDerrotas;
        private Button btnCancelar;
        private Label label6;
        private ListView listView1;
    }
}