namespace Faculverso
{
    partial class DCreditos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DCreditos));
            btnMenu = new Button();
            lblCred2 = new Label();
            lblCred1 = new Label();
            SuspendLayout();
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenu.Location = new Point(1140, 12);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(112, 59);
            btnMenu.TabIndex = 0;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // lblCred2
            // 
            lblCred2.AutoSize = true;
            lblCred2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCred2.Location = new Point(475, 129);
            lblCred2.Name = "lblCred2";
            lblCred2.Size = new Size(304, 270);
            lblCred2.TabIndex = 1;
            lblCred2.Text = resources.GetString("lblCred2.Text");
            // 
            // lblCred1
            // 
            lblCred1.AutoSize = true;
            lblCred1.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCred1.Location = new Point(540, 22);
            lblCred1.Name = "lblCred1";
            lblCred1.Size = new Size(163, 49);
            lblCred1.TabIndex = 2;
            lblCred1.Text = "Creditos";
            // 
            // DCreditos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            ControlBox = false;
            Controls.Add(lblCred1);
            Controls.Add(lblCred2);
            Controls.Add(btnMenu);
            Name = "DCreditos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DCreditos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMenu;
        private Label lblCred2;
        private Label lblCred1;
    }
}