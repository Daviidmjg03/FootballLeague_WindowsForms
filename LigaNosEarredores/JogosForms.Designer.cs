namespace LigaNosEarredores
{
    partial class JogosForms
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
            btnAdicionarJogo = new Button();
            btnAtualizarJogo = new Button();
            btnCancelarJogo = new Button();
            comboBoxCasa = new ComboBox();
            textBoxGolosCasa = new TextBox();
            textBoxGolosFora = new TextBox();
            comboBoxFora = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            listBoxJogos = new ListBox();
            label3 = new Label();
            dateTimePickerData = new DateTimePicker();
            label4 = new Label();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnAdicionarJogo
            // 
            btnAdicionarJogo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAdicionarJogo.Location = new Point(45, 62);
            btnAdicionarJogo.Name = "btnAdicionarJogo";
            btnAdicionarJogo.Size = new Size(151, 57);
            btnAdicionarJogo.TabIndex = 0;
            btnAdicionarJogo.Text = "Adicionar Jogo";
            btnAdicionarJogo.UseVisualStyleBackColor = true;
            btnAdicionarJogo.Click += btnAdicionarJogo_Click;
            // 
            // btnAtualizarJogo
            // 
            btnAtualizarJogo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAtualizarJogo.Location = new Point(45, 125);
            btnAtualizarJogo.Name = "btnAtualizarJogo";
            btnAtualizarJogo.Size = new Size(151, 57);
            btnAtualizarJogo.TabIndex = 1;
            btnAtualizarJogo.Text = "Atualizar Jogo";
            btnAtualizarJogo.UseVisualStyleBackColor = true;
            btnAtualizarJogo.Click += btnAtualizarJogo_Click;
            // 
            // btnCancelarJogo
            // 
            btnCancelarJogo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCancelarJogo.Location = new Point(45, 188);
            btnCancelarJogo.Name = "btnCancelarJogo";
            btnCancelarJogo.Size = new Size(151, 57);
            btnCancelarJogo.TabIndex = 2;
            btnCancelarJogo.Text = "Anular jogo";
            btnCancelarJogo.UseVisualStyleBackColor = true;
            btnCancelarJogo.Click += btnCancelarJogo_Click;
            // 
            // comboBoxCasa
            // 
            comboBoxCasa.FormattingEnabled = true;
            comboBoxCasa.Location = new Point(658, 102);
            comboBoxCasa.Name = "comboBoxCasa";
            comboBoxCasa.Size = new Size(121, 23);
            comboBoxCasa.TabIndex = 3;
            // 
            // textBoxGolosCasa
            // 
            textBoxGolosCasa.Location = new Point(658, 219);
            textBoxGolosCasa.Name = "textBoxGolosCasa";
            textBoxGolosCasa.Size = new Size(121, 23);
            textBoxGolosCasa.TabIndex = 5;
            // 
            // textBoxGolosFora
            // 
            textBoxGolosFora.Location = new Point(658, 248);
            textBoxGolosFora.Name = "textBoxGolosFora";
            textBoxGolosFora.Size = new Size(121, 23);
            textBoxGolosFora.TabIndex = 6;
            // 
            // comboBoxFora
            // 
            comboBoxFora.FormattingEnabled = true;
            comboBoxFora.Location = new Point(658, 131);
            comboBoxFora.Name = "comboBoxFora";
            comboBoxFora.Size = new Size(121, 23);
            comboBoxFora.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(579, 220);
            label1.Name = "label1";
            label1.Size = new Size(75, 17);
            label1.TabIndex = 9;
            label1.Text = "GolosCasa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(580, 249);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 10;
            label2.Text = "GolosFora:";
            // 
            // listBoxJogos
            // 
            listBoxJogos.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxJogos.FormattingEnabled = true;
            listBoxJogos.ItemHeight = 13;
            listBoxJogos.Location = new Point(3, 341);
            listBoxJogos.MultiColumn = true;
            listBoxJogos.Name = "listBoxJogos";
            listBoxJogos.Size = new Size(794, 108);
            listBoxJogos.TabIndex = 14;
            listBoxJogos.Click += listBoxJogos_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(579, 165);
            label3.Name = "label3";
            label3.Size = new Size(93, 17);
            label3.TabIndex = 16;
            label3.Text = "Data do jogo:";
            // 
            // dateTimePickerData
            // 
            dateTimePickerData.Format = DateTimePickerFormat.Short;
            dateTimePickerData.Location = new Point(579, 188);
            dateTimePickerData.Name = "dateTimePickerData";
            dateTimePickerData.Size = new Size(200, 23);
            dateTimePickerData.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(647, 82);
            label4.Name = "label4";
            label4.Size = new Size(132, 17);
            label4.TabIndex = 19;
            label4.Text = "Adicionar os clubes:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(667, 287);
            button1.Name = "button1";
            button1.Size = new Size(130, 48);
            button1.TabIndex = 20;
            button1.Text = "Fechar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(276, 22);
            label6.Name = "label6";
            label6.Size = new Size(238, 25);
            label6.TabIndex = 21;
            label6.Text = "Adicione um ou mais jogos!";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(596, 47);
            label5.Name = "label5";
            label5.Size = new Size(192, 25);
            label5.TabIndex = 22;
            label5.Text = "Informação dos jogos!";
            // 
            // JogosForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(dateTimePickerData);
            Controls.Add(label3);
            Controls.Add(listBoxJogos);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxFora);
            Controls.Add(textBoxGolosFora);
            Controls.Add(textBoxGolosCasa);
            Controls.Add(comboBoxCasa);
            Controls.Add(btnCancelarJogo);
            Controls.Add(btnAtualizarJogo);
            Controls.Add(btnAdicionarJogo);
            Name = "JogosForms";
            Text = "JogosForms";
            FormClosing += JogosForms_FormClosing;
            Load += JogosForms_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdicionarJogo;
        private Button btnAtualizarJogo;
        private Button btnCancelarJogo;
        private ComboBox comboBoxCasa;
        private TextBox textBoxGolosCasa;
        private TextBox textBoxGolosFora;
        private ComboBox comboBoxFora;
        private Label label1;
        private Label label2;
        private ListBox listBoxJogos;
        private Label label3;
        private DateTimePicker dateTimePickerData;
        private Label label4;
        private Button button1;
        private Label label6;
        private Label label5;
    }
}