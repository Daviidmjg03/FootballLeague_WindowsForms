namespace LigaNosEarredores
{
    partial class AtualizarJogosForms
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
            dateTimePickerJogos = new DateTimePicker();
            btnGuardar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // dateTimePickerJogos
            // 
            dateTimePickerJogos.Location = new Point(304, 101);
            dateTimePickerJogos.Name = "dateTimePickerJogos";
            dateTimePickerJogos.Size = new Size(231, 23);
            dateTimePickerJogos.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(461, 163);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(174, 54);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar informação";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += button1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(179, 163);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(174, 54);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(97, 37);
            label1.Name = "label1";
            label1.Size = new Size(636, 25);
            label1.TabIndex = 3;
            label1.Text = "Não tem as condições necessárias para acontecer o jogo ? Altere a data!";
            // 
            // AtualizarJogosForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 281);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(dateTimePickerJogos);
            Name = "AtualizarJogosForms";
            Text = "AtualizarJogosForms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePickerJogos;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label label1;
    }
}