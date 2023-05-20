namespace Login_Form
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            pictureBox1 = new PictureBox();
            txtUsername = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnReset = new Button();
            lblErrorMassege = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 38);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(446, 360);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(583, 116);
            txtUsername.Margin = new Padding(4, 3, 4, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(308, 45);
            txtUsername.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(890, 116);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(890, 234);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(47, 45);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(583, 234);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(313, 45);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(44, 82, 207);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Location = new Point(797, 323);
            btnLogin.Margin = new Padding(4, 3, 4, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(154, 48);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(44, 82, 207);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.ForeColor = SystemColors.Control;
            btnReset.Location = new Point(568, 323);
            btnReset.Margin = new Padding(4, 3, 4, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(155, 48);
            btnReset.TabIndex = 7;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // lblErrorMassege
            // 
            lblErrorMassege.AutoSize = true;
            lblErrorMassege.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrorMassege.ForeColor = Color.Red;
            lblErrorMassege.Location = new Point(583, 424);
            lblErrorMassege.Margin = new Padding(4, 0, 4, 0);
            lblErrorMassege.Name = "lblErrorMassege";
            lblErrorMassege.Size = new Size(60, 23);
            lblErrorMassege.TabIndex = 8;
            lblErrorMassege.Text = "label1";
            lblErrorMassege.Visible = false;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1081, 500);
            Controls.Add(lblErrorMassege);
            Controls.Add(btnReset);
            Controls.Add(btnLogin);
            Controls.Add(pictureBox3);
            Controls.Add(txtPassword);
            Controls.Add(pictureBox2);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtUsername;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnReset;
        private Label lblErrorMassege;
    }
}