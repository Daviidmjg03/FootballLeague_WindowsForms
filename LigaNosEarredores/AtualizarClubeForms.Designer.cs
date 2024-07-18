namespace LigaNosEarredores
{
    partial class AtualizarClubeForms
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
            textBoxNomeClube = new TextBox();
            textBoxCidadeClube = new TextBox();
            textBoxEstadioClube = new TextBox();
            btnSalvar = new Button();
            textBoxAnoFundacao = new TextBox();
            textBoxTrofeus = new TextBox();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBoxNomeClube
            // 
            textBoxNomeClube.Location = new Point(134, 86);
            textBoxNomeClube.Name = "textBoxNomeClube";
            textBoxNomeClube.Size = new Size(127, 23);
            textBoxNomeClube.TabIndex = 0;
            // 
            // textBoxCidadeClube
            // 
            textBoxCidadeClube.Location = new Point(104, 129);
            textBoxCidadeClube.Name = "textBoxCidadeClube";
            textBoxCidadeClube.Size = new Size(157, 23);
            textBoxCidadeClube.TabIndex = 1;
            // 
            // textBoxEstadioClube
            // 
            textBoxEstadioClube.Location = new Point(104, 166);
            textBoxEstadioClube.Name = "textBoxEstadioClube";
            textBoxEstadioClube.Size = new Size(157, 23);
            textBoxEstadioClube.TabIndex = 2;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(614, 357);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(159, 56);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Guardar Informação";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnAtualizar_Click;
            // 
            // textBoxAnoFundacao
            // 
            textBoxAnoFundacao.Location = new Point(146, 203);
            textBoxAnoFundacao.Name = "textBoxAnoFundacao";
            textBoxAnoFundacao.Size = new Size(115, 23);
            textBoxAnoFundacao.TabIndex = 4;
            // 
            // textBoxTrofeus
            // 
            textBoxTrofeus.Location = new Point(104, 239);
            textBoxTrofeus.Name = "textBoxTrofeus";
            textBoxTrofeus.Size = new Size(157, 23);
            textBoxTrofeus.TabIndex = 5;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(449, 357);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(159, 56);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 87);
            label1.Name = "label1";
            label1.Size = new Size(88, 17);
            label1.TabIndex = 7;
            label1.Text = "Nome Clube:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 240);
            label2.Name = "label2";
            label2.Size = new Size(58, 17);
            label2.TabIndex = 8;
            label2.Text = "Troféus:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 204);
            label3.Name = "label3";
            label3.Size = new Size(100, 17);
            label3.TabIndex = 9;
            label3.Text = "Ano Fundação:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(40, 167);
            label4.Name = "label4";
            label4.Size = new Size(57, 17);
            label4.TabIndex = 10;
            label4.Text = "Estádio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(40, 129);
            label5.Name = "label5";
            label5.Size = new Size(54, 17);
            label5.TabIndex = 11;
            label5.Text = "Cidade:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(240, 20);
            label6.Name = "label6";
            label6.Size = new Size(385, 25);
            label6.TabIndex = 16;
            label6.Text = "Altere a informação referente ao seu clube!";
            // 
            // AtualizarClubeForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(textBoxTrofeus);
            Controls.Add(textBoxAnoFundacao);
            Controls.Add(btnSalvar);
            Controls.Add(textBoxEstadioClube);
            Controls.Add(textBoxCidadeClube);
            Controls.Add(textBoxNomeClube);
            Name = "AtualizarClubeForms";
            Text = "AtualizarClubeForms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNomeClube;
        private TextBox textBoxCidadeClube;
        private TextBox textBoxEstadioClube;
        private Button btnSalvar;
        private TextBox textBoxAnoFundacao;
        private TextBox textBoxTrofeus;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}