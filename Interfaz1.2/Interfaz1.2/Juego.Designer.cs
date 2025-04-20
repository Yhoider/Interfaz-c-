namespace Interfaz1._2
{
    partial class Juego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Juego));
            panel1 = new Panel();
            btnMinimizar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnRestaurar = new PictureBox();
            btnCerrar = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            txtcoordeY = new TextBox();
            intcoordeX = new TextBox();
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
            btnMinimizar.Location = new Point(806, 19);
            btnMinimizar.Margin = new Padding(4, 3, 4, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(19, 18);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 19;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(842, 19);
            btnMaximizar.Margin = new Padding(4, 3, 4, 3);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(19, 18);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 18;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(842, 19);
            btnRestaurar.Margin = new Padding(4, 3, 4, 3);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(19, 18);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 17;
            btnRestaurar.TabStop = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(880, 19);
            btnCerrar.Margin = new Padding(4, 3, 4, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(19, 18);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 16;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(380, 333);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(468, 42);
            button1.TabIndex = 15;
            button1.Text = "Disparar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(584, 52);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(90, 33);
            label1.TabIndex = 14;
            label1.Text = "Juego";
            // 
            // txtcoordeY
            // 
            txtcoordeY.Anchor = AnchorStyles.None;
            txtcoordeY.BackColor = Color.FromArgb(15, 15, 15);
            txtcoordeY.BorderStyle = BorderStyle.None;
            txtcoordeY.Font = new Font("Centaur", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcoordeY.ForeColor = Color.DimGray;
            txtcoordeY.Location = new Point(380, 253);
            txtcoordeY.Margin = new Padding(4, 3, 4, 3);
            txtcoordeY.Name = "txtcoordeY";
            txtcoordeY.Size = new Size(468, 19);
            txtcoordeY.TabIndex = 13;
            txtcoordeY.Text = "Coordenadas Y";
            txtcoordeY.Enter += txtpassword_Enter;
            txtcoordeY.Leave += txtpassword_Leave;
            // 
            // intcoordeX
            // 
            intcoordeX.Anchor = AnchorStyles.None;
            intcoordeX.BackColor = Color.FromArgb(15, 15, 15);
            intcoordeX.BorderStyle = BorderStyle.None;
            intcoordeX.Font = new Font("Centaur", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            intcoordeX.ForeColor = Color.DimGray;
            intcoordeX.Location = new Point(380, 150);
            intcoordeX.Margin = new Padding(4, 3, 4, 3);
            intcoordeX.Name = "intcoordeX";
            intcoordeX.Size = new Size(468, 19);
            intcoordeX.TabIndex = 12;
            intcoordeX.Text = "Coordenadas X";
            intcoordeX.Enter += txtuser_Enter;
            intcoordeX.Leave += txtuser_Leave;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(377, 105);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 11;
            // 
            // Juego
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
            Controls.Add(txtcoordeY);
            Controls.Add(intcoordeX);
            Controls.Add(linkLabel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Juego";
            Text = "Juego";
            MouseDown += Juego_MouseDown;
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
        private Button button1;
        private Label label1;
        private TextBox txtcoordeY;
        private TextBox intcoordeX;
        private LinkLabel linkLabel1;
    }
}