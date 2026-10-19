namespace Faculverso
{
    partial class BVisNov
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BVisNov));
            btnMenu = new Button();
            btnAvanDial = new Button();
            btnVoltDial = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblNomePersonagem = new Label();
            lblDialog = new Label();
            gbNome = new GroupBox();
            btnSeuNome = new Button();
            tbNome = new TextBox();
            lblNome = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            gbNome.SuspendLayout();
            SuspendLayout();
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenu.Location = new Point(1171, 12);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(81, 36);
            btnMenu.TabIndex = 0;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnAvanDial
            // 
            btnAvanDial.BackColor = Color.Transparent;
            btnAvanDial.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAvanDial.Location = new Point(1130, 614);
            btnAvanDial.Name = "btnAvanDial";
            btnAvanDial.Size = new Size(131, 65);
            btnAvanDial.TabIndex = 1;
            btnAvanDial.Text = "Avançar";
            btnAvanDial.UseVisualStyleBackColor = false;
            btnAvanDial.Click += btnAvanDial_Click;
            // 
            // btnVoltDial
            // 
            btnVoltDial.BackColor = Color.Transparent;
            btnVoltDial.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltDial.Location = new Point(3, 614);
            btnVoltDial.Name = "btnVoltDial";
            btnVoltDial.Size = new Size(131, 65);
            btnVoltDial.TabIndex = 2;
            btnVoltDial.Text = "Voltar";
            btnVoltDial.UseVisualStyleBackColor = false;
            btnVoltDial.Click += btnVoltDial_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-8, 489);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1280, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(473, 80);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(360, 413);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // lblNomePersonagem
            // 
            lblNomePersonagem.AutoSize = true;
            lblNomePersonagem.BackColor = SystemColors.ButtonFace;
            lblNomePersonagem.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomePersonagem.Location = new Point(38, 499);
            lblNomePersonagem.Name = "lblNomePersonagem";
            lblNomePersonagem.Size = new Size(0, 23);
            lblNomePersonagem.TabIndex = 5;
            // 
            // lblDialog
            // 
            lblDialog.AutoSize = true;
            lblDialog.BackColor = SystemColors.ButtonFace;
            lblDialog.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDialog.Location = new Point(38, 541);
            lblDialog.Name = "lblDialog";
            lblDialog.Size = new Size(1162, 46);
            lblDialog.TabIndex = 6;
            lblDialog.Text = "Meu primeiro dia em minha nova faculdade, preciso me apressar para não me perder nos assuntos já que cheguei um pouco depois que meus colegas,\r\nentão vamos lá! mas... por onde eu vou?";
            // 
            // gbNome
            // 
            gbNome.BackColor = Color.BlanchedAlmond;
            gbNome.Controls.Add(btnSeuNome);
            gbNome.Controls.Add(tbNome);
            gbNome.Controls.Add(lblNome);
            gbNome.FlatStyle = FlatStyle.Flat;
            gbNome.Location = new Point(988, 262);
            gbNome.Name = "gbNome";
            gbNome.Size = new Size(212, 153);
            gbNome.TabIndex = 7;
            gbNome.TabStop = false;
            gbNome.Visible = false;
            // 
            // btnSeuNome
            // 
            btnSeuNome.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeuNome.Location = new Point(19, 98);
            btnSeuNome.Name = "btnSeuNome";
            btnSeuNome.Size = new Size(173, 36);
            btnSeuNome.TabIndex = 2;
            btnSeuNome.Text = "Esse é o meu nome!";
            btnSeuNome.UseVisualStyleBackColor = true;
            btnSeuNome.Click += btnSeuNome_Click;
            // 
            // tbNome
            // 
            tbNome.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNome.Location = new Point(19, 62);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(173, 30);
            tbNome.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(19, 29);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(173, 30);
            lblNome.TabIndex = 0;
            lblNome.Text = "Qual seu nome?";
            // 
            // BVisNov
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            ControlBox = false;
            Controls.Add(gbNome);
            Controls.Add(lblDialog);
            Controls.Add(lblNomePersonagem);
            Controls.Add(btnVoltDial);
            Controls.Add(btnAvanDial);
            Controls.Add(btnMenu);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            DoubleBuffered = true;
            Name = "BVisNov";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Faculverso";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            gbNome.ResumeLayout(false);
            gbNome.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMenu;
        private Button btnAvanDial;
        private Button btnVoltDial;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblNomePersonagem;
        private Label lblDialog;
        private GroupBox gbNome;
        private Button btnSeuNome;
        private TextBox tbNome;
        private Label lblNome;
    }
}