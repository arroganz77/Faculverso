namespace Faculverso
{
    partial class AMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AMenu));
            btnJogar = new Button();
            btnTuto = new Button();
            btnCred = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // btnJogar
            // 
            btnJogar.AutoSize = true;
            btnJogar.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            btnJogar.Location = new Point(204, 498);
            btnJogar.Name = "btnJogar";
            btnJogar.Size = new Size(207, 110);
            btnJogar.TabIndex = 0;
            btnJogar.Text = "Jogar";
            btnJogar.UseVisualStyleBackColor = true;
            btnJogar.Click += btnJogar_Click;
            // 
            // btnTuto
            // 
            btnTuto.AutoSize = true;
            btnTuto.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            btnTuto.Location = new Point(524, 498);
            btnTuto.Name = "btnTuto";
            btnTuto.Size = new Size(230, 110);
            btnTuto.TabIndex = 1;
            btnTuto.Text = "Tutoriais";
            btnTuto.UseVisualStyleBackColor = true;
            btnTuto.Click += btnTuto_Click;
            // 
            // btnCred
            // 
            btnCred.AutoSize = true;
            btnCred.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            btnCred.Location = new Point(844, 498);
            btnCred.Name = "btnCred";
            btnCred.Size = new Size(233, 110);
            btnCred.TabIndex = 2;
            btnCred.Text = "Creditos";
            btnCred.UseVisualStyleBackColor = true;
            btnCred.Click += btnCred_Click;
            // 
            // btnSair
            // 
            btnSair.AutoSize = true;
            btnSair.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            btnSair.Location = new Point(12, 12);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(99, 50);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // AMenu
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            ControlBox = false;
            Controls.Add(btnSair);
            Controls.Add(btnCred);
            Controls.Add(btnTuto);
            Controls.Add(btnJogar);
            DoubleBuffered = true;
            Name = "AMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Faculverso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnJogar;
        private Button btnTuto;
        private Button btnCred;
        private Button btnSair;
    }
}
