namespace Interfaz
{
    partial class Crear_cuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crear_cuenta));
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            txtuser = new TextBox();
            txtpassword = new TextBox();
            label1 = new Label();
            button1 = new Button();
            btnMinimizar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnRestaurar = new PictureBox();
            btnCerrar = new PictureBox();
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
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 443);
            panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(398, 100);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 1;
            // 
            // txtuser
            // 
            txtuser.Anchor = AnchorStyles.None;
            txtuser.BackColor = Color.FromArgb(15, 15, 15);
            txtuser.BorderStyle = BorderStyle.None;
            txtuser.Font = new Font("Centaur", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtuser.ForeColor = Color.DimGray;
            txtuser.Location = new Point(401, 145);
            txtuser.Margin = new Padding(4, 3, 4, 3);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(468, 19);
            txtuser.TabIndex = 2;
            txtuser.Text = "Usuario";
            txtuser.Enter += textuser_Enter;
            txtuser.Leave += txtuser_Leave;
            // 
            // txtpassword
            // 
            txtpassword.Anchor = AnchorStyles.None;
            txtpassword.BackColor = Color.FromArgb(15, 15, 15);
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Font = new Font("Centaur", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.ForeColor = Color.DimGray;
            txtpassword.Location = new Point(401, 248);
            txtpassword.Margin = new Padding(4, 3, 4, 3);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(468, 19);
            txtpassword.TabIndex = 3;
            txtpassword.Text = "Contraseña";
            txtpassword.Enter += txtpassword_Enter;
            txtpassword.Leave += txtpassword_Leave;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(526, 59);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(199, 33);
            label1.TabIndex = 4;
            label1.Text = "create account";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(401, 328);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(468, 42);
            button1.TabIndex = 5;
            button1.Text = "Crear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(827, 14);
            btnMinimizar.Margin = new Padding(4, 3, 4, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(19, 18);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 10;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(863, 14);
            btnMaximizar.Margin = new Padding(4, 3, 4, 3);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(19, 18);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 9;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(863, 14);
            btnRestaurar.Margin = new Padding(4, 3, 4, 3);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(19, 18);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 8;
            btnRestaurar.TabStop = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(901, 14);
            btnCerrar.Margin = new Padding(4, 3, 4, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(19, 18);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 7;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Crear_cuenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(933, 443);
            Controls.Add(btnMinimizar);
            Controls.Add(btnMaximizar);
            Controls.Add(btnRestaurar);
            Controls.Add(btnCerrar);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtpassword);
            Controls.Add(txtuser);
            Controls.Add(linkLabel1);
            Controls.Add(panel1);
            ForeColor = Color.DimGray;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Crear_cuenta";
            Opacity = 0.9D;
            Text = "Crear_cuenta";
            MouseDown += Crear_cuenta_MouseDown;
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnCerrar;
    }
}