namespace Interfaz1._2
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            btnMinimizar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnRestaurar = new PictureBox();
            btnCerrar = new PictureBox();
            linkLabel2 = new LinkLabel();
            button1 = new Button();
            label1 = new Label();
            txtpassword = new TextBox();
            txtuser = new TextBox();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 443);
            panel1.TabIndex = 0;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(834, 9);
            btnMinimizar.Margin = new Padding(4, 3, 4, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(19, 18);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 20;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(870, 9);
            btnMaximizar.Margin = new Padding(4, 3, 4, 3);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(19, 18);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 19;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(870, 9);
            btnRestaurar.Margin = new Padding(4, 3, 4, 3);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(19, 18);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 18;
            btnRestaurar.TabStop = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(908, 9);
            btnCerrar.Margin = new Padding(4, 3, 4, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(19, 18);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 17;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.FromArgb(0, 122, 204);
            linkLabel2.Anchor = AnchorStyles.None;
            linkLabel2.AutoSize = true;
            linkLabel2.ForeColor = Color.Gray;
            linkLabel2.LinkColor = Color.DimGray;
            linkLabel2.Location = new Point(478, 383);
            linkLabel2.Margin = new Padding(4, 0, 4, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(161, 15);
            linkLabel2.TabIndex = 16;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "¿Haz olvidado tu contraseña?";
            
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(341, 319);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(468, 42);
            button1.TabIndex = 15;
            button1.Text = "Acceder";
            button1.UseVisualStyleBackColor = true;
            
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(551, 41);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 33);
            label1.TabIndex = 14;
            label1.Text = "Login";
            // 
            // txtpassword
            // 
            txtpassword.Anchor = AnchorStyles.None;
            txtpassword.BackColor = Color.FromArgb(15, 15, 15);
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Font = new Font("Centaur", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.ForeColor = Color.DimGray;
            txtpassword.Location = new Point(341, 239);
            txtpassword.Margin = new Padding(4, 3, 4, 3);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(468, 19);
            txtpassword.TabIndex = 13;
            txtpassword.Text = "Contraseña";
            txtpassword.Enter += txtpassword_Enter;
            txtpassword.Leave += txtpassword_Leave;
            // 
            // txtuser
            // 
            txtuser.Anchor = AnchorStyles.None;
            txtuser.BackColor = Color.FromArgb(15, 15, 15);
            txtuser.BorderStyle = BorderStyle.None;
            txtuser.Font = new Font("Centaur", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtuser.ForeColor = Color.DimGray;
            txtuser.Location = new Point(341, 136);
            txtuser.Margin = new Padding(4, 3, 4, 3);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(468, 19);
            txtuser.TabIndex = 12;
            txtuser.Text = "Usuario";
            txtuser.Enter += txtuser_Enter;
            txtuser.Leave += txtuser_Leave;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(338, 91);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 11;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(933, 443);
            Controls.Add(btnMinimizar);
            Controls.Add(btnMaximizar);
            Controls.Add(btnRestaurar);
            Controls.Add(btnCerrar);
            Controls.Add(linkLabel2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtpassword);
            Controls.Add(txtuser);
            Controls.Add(linkLabel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            MouseDown += Login_MouseDown;
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox btnMinimizar;
        private PictureBox btnMaximizar;
        private PictureBox btnRestaurar;
        private PictureBox btnCerrar;
        private LinkLabel linkLabel2;
        private Button button1;
        private Label label1;
        private TextBox txtpassword;
        private TextBox txtuser;
        private LinkLabel linkLabel1;
    }
}