namespace LigaNosEarredores
{
    partial class ClubesForms
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
            btnAdicionarClube = new Button();
            textBoxNomeClube = new TextBox();
            textBoxCidade = new TextBox();
            textBoxEstadio = new TextBox();
            btnAtualizarClube = new Button();
            btnApagarClube = new Button();
            listBoxResultados = new ListBox();
            textBoxAnoFundacao = new TextBox();
            textBoxTrofeus = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnPDF = new Button();
            label6 = new Label();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // btnAdicionarClube
            // 
            btnAdicionarClube.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAdicionarClube.Location = new Point(611, 65);
            btnAdicionarClube.Name = "btnAdicionarClube";
            btnAdicionarClube.Size = new Size(160, 52);
            btnAdicionarClube.TabIndex = 0;
            btnAdicionarClube.Text = "Adicionar Clube";
            btnAdicionarClube.UseVisualStyleBackColor = true;
            btnAdicionarClube.Click += btnAdicionarClube_Click;
            // 
            // textBoxNomeClube
            // 
            textBoxNomeClube.Location = new Point(133, 67);
            textBoxNomeClube.Name = "textBoxNomeClube";
            textBoxNomeClube.Size = new Size(141, 23);
            textBoxNomeClube.TabIndex = 1;
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(100, 110);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(174, 23);
            textBoxCidade.TabIndex = 2;
            // 
            // textBoxEstadio
            // 
            textBoxEstadio.Location = new Point(100, 150);
            textBoxEstadio.Name = "textBoxEstadio";
            textBoxEstadio.Size = new Size(176, 23);
            textBoxEstadio.TabIndex = 3;
            textBoxEstadio.TextChanged += textBoxEstadio_TextChanged;
            // 
            // btnAtualizarClube
            // 
            btnAtualizarClube.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualizarClube.Location = new Point(611, 123);
            btnAtualizarClube.Name = "btnAtualizarClube";
            btnAtualizarClube.Size = new Size(160, 52);
            btnAtualizarClube.TabIndex = 4;
            btnAtualizarClube.Text = "Editar Clube";
            btnAtualizarClube.UseVisualStyleBackColor = true;
            btnAtualizarClube.Click += btnAtualizarClube_Click;
            // 
            // btnApagarClube
            // 
            btnApagarClube.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApagarClube.Location = new Point(611, 181);
            btnApagarClube.Name = "btnApagarClube";
            btnApagarClube.Size = new Size(160, 52);
            btnApagarClube.TabIndex = 5;
            btnApagarClube.Text = "Apagar Clube";
            btnApagarClube.UseVisualStyleBackColor = true;
            btnApagarClube.Click += btnApagarClube_Click;
            // 
            // listBoxResultados
            // 
            listBoxResultados.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxResultados.FormattingEnabled = true;
            listBoxResultados.ItemHeight = 17;
            listBoxResultados.Location = new Point(6, 358);
            listBoxResultados.Name = "listBoxResultados";
            listBoxResultados.Size = new Size(782, 89);
            listBoxResultados.TabIndex = 6;
            // 
            // textBoxAnoFundacao
            // 
            textBoxAnoFundacao.Location = new Point(131, 197);
            textBoxAnoFundacao.Name = "textBoxAnoFundacao";
            textBoxAnoFundacao.Size = new Size(143, 23);
            textBoxAnoFundacao.TabIndex = 7;
            // 
            // textBoxTrofeus
            // 
            textBoxTrofeus.Location = new Point(100, 245);
            textBoxTrofeus.Name = "textBoxTrofeus";
            textBoxTrofeus.Size = new Size(174, 23);
            textBoxTrofeus.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 67);
            label1.Name = "label1";
            label1.Size = new Size(88, 17);
            label1.TabIndex = 9;
            label1.Text = "Nome Clube:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 151);
            label2.Name = "label2";
            label2.Size = new Size(57, 17);
            label2.TabIndex = 10;
            label2.Text = "Estádio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 110);
            label3.Name = "label3";
            label3.Size = new Size(54, 17);
            label3.TabIndex = 11;
            label3.Text = "Cidade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 198);
            label4.Name = "label4";
            label4.Size = new Size(100, 17);
            label4.TabIndex = 12;
            label4.Text = "Ano Fundação:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 245);
            label5.Name = "label5";
            label5.Size = new Size(58, 17);
            label5.TabIndex = 13;
            label5.Text = "Troféus:";
            // 
            // btnPDF
            // 
            btnPDF.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnPDF.Location = new Point(660, 301);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(128, 51);
            btnPDF.TabIndex = 14;
            btnPDF.Text = "Criar PDF";
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += btnPDF_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(318, 24);
            label6.Name = "label6";
            label6.Size = new Size(168, 25);
            label6.TabIndex = 15;
            label6.Text = "Adicione um clube!";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(526, 302);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(128, 51);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Fechar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // ClubesForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(label6);
            Controls.Add(btnPDF);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxTrofeus);
            Controls.Add(textBoxAnoFundacao);
            Controls.Add(listBoxResultados);
            Controls.Add(btnApagarClube);
            Controls.Add(btnAtualizarClube);
            Controls.Add(textBoxEstadio);
            Controls.Add(textBoxCidade);
            Controls.Add(textBoxNomeClube);
            Controls.Add(btnAdicionarClube);
            Name = "ClubesForms";
            Text = "ClubesForms";
            Load += ClubesForms_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdicionarClube;
        private TextBox textBoxNomeClube;
        private TextBox textBoxCidade;
        private TextBox textBoxEstadio;
        private Button btnAtualizarClube;
        private Button btnApagarClube;
        private ListBox listBoxResultados;
        private TextBox textBoxAnoFundacao;
        private TextBox textBoxTrofeus;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnPDF;
        private Label label6;
        private Button btnCancelar;
    }
}