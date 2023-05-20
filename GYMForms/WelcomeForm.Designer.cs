namespace GYMForms
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            btnWel = new Button();
            SuspendLayout();
            // 
            // btnWel
            // 
            btnWel.BackColor = Color.FromArgb(0, 210, 210);
            btnWel.BackgroundImageLayout = ImageLayout.Center;
            btnWel.FlatAppearance.BorderColor = Color.Cyan;
            btnWel.FlatAppearance.MouseDownBackColor = Color.White;
            btnWel.FlatAppearance.MouseOverBackColor = Color.Cyan;
            btnWel.FlatStyle = FlatStyle.Popup;
            btnWel.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnWel.Location = new Point(601, 535);
            btnWel.Name = "btnWel";
            btnWel.Size = new Size(137, 46);
            btnWel.TabIndex = 0;
            btnWel.Text = "Welcome";
            btnWel.UseVisualStyleBackColor = false;
            btnWel.Click += button1_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1391, 692);
            Controls.Add(btnWel);
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome";
            Load += WelcomeForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnWel;
    }
}