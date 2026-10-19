namespace Faculverso
{
    partial class CTutorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CTutorial));
            btnMenu = new Button();
            btnTV = new Button();
            btnTQ = new Button();
            btnTM = new Button();
            btnTQC = new Button();
            lblTV = new Label();
            lblTQ = new Label();
            lblTM = new Label();
            lblQC = new Label();
            lbltutoriais = new Label();
            SuspendLayout();
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenu.Location = new Point(1131, 12);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(121, 62);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnTV
            // 
            btnTV.Font = new Font("Comic Sans MS", 12F);
            btnTV.Location = new Point(170, 188);
            btnTV.Name = "btnTV";
            btnTV.Size = new Size(119, 64);
            btnTV.TabIndex = 2;
            btnTV.Text = "Tutorial Visual Novel";
            btnTV.UseVisualStyleBackColor = true;
            btnTV.Click += btnTV_Click;
            // 
            // btnTQ
            // 
            btnTQ.Font = new Font("Comic Sans MS", 12F);
            btnTQ.Location = new Point(170, 258);
            btnTQ.Name = "btnTQ";
            btnTQ.Size = new Size(119, 64);
            btnTQ.TabIndex = 3;
            btnTQ.Text = "Tutorial Quiz";
            btnTQ.UseVisualStyleBackColor = true;
            btnTQ.Click += btnTQ_Click;
            // 
            // btnTM
            // 
            btnTM.Font = new Font("Comic Sans MS", 12F);
            btnTM.Location = new Point(170, 328);
            btnTM.Name = "btnTM";
            btnTM.Size = new Size(119, 64);
            btnTM.TabIndex = 4;
            btnTM.Text = "Tutorial Jogo da memória";
            btnTM.UseVisualStyleBackColor = true;
            btnTM.Click += btnTM_Click;
            // 
            // btnTQC
            // 
            btnTQC.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTQC.Location = new Point(170, 398);
            btnTQC.Name = "btnTQC";
            btnTQC.Size = new Size(119, 64);
            btnTQC.TabIndex = 5;
            btnTQC.Text = "Tutorial Quebra Cabeça";
            btnTQC.UseVisualStyleBackColor = true;
            btnTQC.Click += btnTQC_Click;
            // 
            // lblTV
            // 
            lblTV.AutoSize = true;
            lblTV.Font = new Font("Comic Sans MS", 12F);
            lblTV.Location = new Point(362, 209);
            lblTV.Name = "lblTV";
            lblTV.Size = new Size(187, 23);
            lblTV.TabIndex = 6;
            lblTV.Text = "Tutorial da Visual Novel";
            lblTV.Visible = false;
            // 
            // lblTQ
            // 
            lblTQ.AutoSize = true;
            lblTQ.Font = new Font("Comic Sans MS", 12F);
            lblTQ.Location = new Point(362, 279);
            lblTQ.Name = "lblTQ";
            lblTQ.Size = new Size(133, 23);
            lblTQ.TabIndex = 7;
            lblTQ.Text = "Tutorial do Quiz";
            lblTQ.Visible = false;
            // 
            // lblTM
            // 
            lblTM.AutoSize = true;
            lblTM.Font = new Font("Comic Sans MS", 12F);
            lblTM.Location = new Point(362, 349);
            lblTM.Name = "lblTM";
            lblTM.Size = new Size(205, 23);
            lblTM.TabIndex = 8;
            lblTM.Text = "Tutorial  Jogo da Memória";
            lblTM.Visible = false;
            // 
            // lblQC
            // 
            lblQC.AutoSize = true;
            lblQC.Font = new Font("Comic Sans MS", 12F);
            lblQC.Location = new Point(362, 427);
            lblQC.Name = "lblQC";
            lblQC.Size = new Size(195, 23);
            lblQC.TabIndex = 9;
            lblQC.Text = "Tutorial Quebra Cabeças";
            lblQC.Visible = false;
            // 
            // lbltutoriais
            // 
            lbltutoriais.AutoSize = true;
            lbltutoriais.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltutoriais.Location = new Point(522, 25);
            lbltutoriais.Name = "lbltutoriais";
            lbltutoriais.Size = new Size(171, 49);
            lbltutoriais.TabIndex = 10;
            lbltutoriais.Text = "Tutoriais";
            // 
            // CTutorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            ControlBox = false;
            Controls.Add(lbltutoriais);
            Controls.Add(lblQC);
            Controls.Add(lblTM);
            Controls.Add(lblTQ);
            Controls.Add(lblTV);
            Controls.Add(btnTQC);
            Controls.Add(btnTM);
            Controls.Add(btnTQ);
            Controls.Add(btnTV);
            Controls.Add(btnMenu);
            DoubleBuffered = true;
            Name = "CTutorial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Faculverso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMenu;
        private Button btnTV;
        private Button btnTQ;
        private Button btnTM;
        private Button btnTQC;
        private Label lblTV;
        private Label lblTQ;
        private Label lblTM;
        private Label lblQC;
        private Label lbltutoriais;
    }
}