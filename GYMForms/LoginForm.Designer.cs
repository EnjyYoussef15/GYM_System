namespace GYM
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            txtLoginUseName = new TextBox();
            txtLoginPass = new TextBox();
            btnLogin_Login = new Button();
            label1 = new Label();
            label2 = new Label();
            labelWrongUserNameOrPassowrd = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(549, 305);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(735, 580);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtLoginUseName
            // 
            txtLoginUseName.BackColor = Color.FromArgb(224, 224, 224);
            txtLoginUseName.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtLoginUseName.Location = new Point(697, 89);
            txtLoginUseName.Margin = new Padding(4, 5, 4, 5);
            txtLoginUseName.Name = "txtLoginUseName";
            txtLoginUseName.Size = new Size(288, 40);
            txtLoginUseName.TabIndex = 1;
            // 
            // txtLoginPass
            // 
            txtLoginPass.BackColor = Color.FromArgb(224, 224, 224);
            txtLoginPass.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtLoginPass.Location = new Point(700, 195);
            txtLoginPass.Margin = new Padding(4, 5, 4, 5);
            txtLoginPass.Name = "txtLoginPass";
            txtLoginPass.Size = new Size(288, 40);
            txtLoginPass.TabIndex = 2;
            // 
            // btnLogin_Login
            // 
            btnLogin_Login.BackColor = Color.FromArgb(224, 224, 224);
            btnLogin_Login.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin_Login.Location = new Point(1051, 139);
            btnLogin_Login.Margin = new Padding(4, 5, 4, 5);
            btnLogin_Login.Name = "btnLogin_Login";
            btnLogin_Login.Size = new Size(127, 59);
            btnLogin_Login.TabIndex = 3;
            btnLogin_Login.Text = "Login";
            btnLogin_Login.UseVisualStyleBackColor = false;
            btnLogin_Login.Click += btnLogin_Login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(695, 51);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(140, 28);
            label1.TabIndex = 4;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(700, 158);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(121, 28);
            label2.TabIndex = 5;
            label2.Text = "Passowrd";
            label2.Click += label2_Click;
            // 
            // labelWrongUserNameOrPassowrd
            // 
            labelWrongUserNameOrPassowrd.AutoSize = true;
            labelWrongUserNameOrPassowrd.BackColor = Color.Transparent;
            labelWrongUserNameOrPassowrd.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelWrongUserNameOrPassowrd.ForeColor = Color.Red;
            labelWrongUserNameOrPassowrd.Location = new Point(847, 268);
            labelWrongUserNameOrPassowrd.Margin = new Padding(4, 0, 4, 0);
            labelWrongUserNameOrPassowrd.Name = "labelWrongUserNameOrPassowrd";
            labelWrongUserNameOrPassowrd.Size = new Size(0, 19);
            labelWrongUserNameOrPassowrd.TabIndex = 6;
            labelWrongUserNameOrPassowrd.Click += labelWrongUserNameOrPassowrd_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1331, 902);
            Controls.Add(labelWrongUserNameOrPassowrd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin_Login);
            Controls.Add(txtLoginPass);
            Controls.Add(txtLoginUseName);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtLoginUseName;
        private System.Windows.Forms.TextBox txtLoginPass;
        private System.Windows.Forms.Button btnLogin_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelWrongUserNameOrPassowrd;
    }
}