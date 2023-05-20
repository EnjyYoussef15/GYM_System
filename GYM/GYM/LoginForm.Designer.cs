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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtLoginUseName = new System.Windows.Forms.TextBox();
            this.txtLoginPass = new System.Windows.Forms.TextBox();
            this.btnLogin_Login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelWrongUserNameOrPassowrd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(549, 244);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(735, 464);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtLoginUseName
            // 
            this.txtLoginUseName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtLoginUseName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginUseName.Location = new System.Drawing.Point(697, 71);
            this.txtLoginUseName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLoginUseName.Name = "txtLoginUseName";
            this.txtLoginUseName.Size = new System.Drawing.Size(288, 40);
            this.txtLoginUseName.TabIndex = 1;
            // 
            // txtLoginPass
            // 
            this.txtLoginPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtLoginPass.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginPass.Location = new System.Drawing.Point(700, 156);
            this.txtLoginPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLoginPass.Name = "txtLoginPass";
            this.txtLoginPass.Size = new System.Drawing.Size(288, 40);
            this.txtLoginPass.TabIndex = 2;
            // 
            // btnLogin_Login
            // 
            this.btnLogin_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLogin_Login.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin_Login.Location = new System.Drawing.Point(1051, 111);
            this.btnLogin_Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin_Login.Name = "btnLogin_Login";
            this.btnLogin_Login.Size = new System.Drawing.Size(127, 47);
            this.btnLogin_Login.TabIndex = 3;
            this.btnLogin_Login.Text = "Login";
            this.btnLogin_Login.UseVisualStyleBackColor = false;
            this.btnLogin_Login.Click += new System.EventHandler(this.btnLogin_Login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(695, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(695, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Passowrd";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelWrongUserNameOrPassowrd
            // 
            this.labelWrongUserNameOrPassowrd.AutoSize = true;
            this.labelWrongUserNameOrPassowrd.BackColor = System.Drawing.Color.Transparent;
            this.labelWrongUserNameOrPassowrd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWrongUserNameOrPassowrd.ForeColor = System.Drawing.Color.Red;
            this.labelWrongUserNameOrPassowrd.Location = new System.Drawing.Point(847, 214);
            this.labelWrongUserNameOrPassowrd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWrongUserNameOrPassowrd.Name = "labelWrongUserNameOrPassowrd";
            this.labelWrongUserNameOrPassowrd.Size = new System.Drawing.Size(0, 19);
            this.labelWrongUserNameOrPassowrd.TabIndex = 6;
            this.labelWrongUserNameOrPassowrd.Click += new System.EventHandler(this.labelWrongUserNameOrPassowrd_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1331, 722);
            this.Controls.Add(this.labelWrongUserNameOrPassowrd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin_Login);
            this.Controls.Add(this.txtLoginPass);
            this.Controls.Add(this.txtLoginUseName);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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