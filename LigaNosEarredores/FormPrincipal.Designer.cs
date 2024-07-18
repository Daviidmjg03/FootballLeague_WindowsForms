namespace LigaNosEarredores
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            btnClubes = new Button();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnClubes
            // 
            btnClubes.BackColor = SystemColors.Control;
            btnClubes.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClubes.ForeColor = SystemColors.ActiveCaptionText;
            btnClubes.Location = new Point(124, 149);
            btnClubes.Name = "btnClubes";
            btnClubes.Size = new Size(149, 74);
            btnClubes.TabIndex = 0;
            btnClubes.Text = "Clubes";
            btnClubes.UseVisualStyleBackColor = false;
            btnClubes.Click += btnClubes_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(323, 149);
            button1.Name = "button1";
            button1.Size = new Size(149, 74);
            button1.TabIndex = 1;
            button1.Text = "Jogos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(523, 149);
            button2.Name = "button2";
            button2.Size = new Size(149, 74);
            button2.TabIndex = 2;
            button2.Text = "Estatisticas";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(197, -3);
            label1.Name = "label1";
            label1.Size = new Size(440, 40);
            label1.TabIndex = 3;
            label1.Text = "Seja bem vindo à liga de futebol! ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(2, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(798, 417);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClubes);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "FormPrincipal";
            Text = "FormLigadeFutebol";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClubes;
        private Button button1;
        private Button button2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
