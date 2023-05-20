namespace Fitness
{
    partial class TraineeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraineeForm));
            txtTraineeSubscriptionFee = new TextBox();
            TraineeJoinDate = new DateTimePicker();
            radioTraineeFemale = new RadioButton();
            radioTraineeMale = new RadioButton();
            txtTraineeName = new TextBox();
            txtTraineeID = new TextBox();
            lblSubscriptionFee = new Label();
            lblAge = new Label();
            lblEndDate = new Label();
            lblJoinDate = new Label();
            lblGender = new Label();
            lblid = new Label();
            lblName = new Label();
            lblTraineeClass = new Label();
            txtTraineeClass = new TextBox();
            btnTraineeReset = new Button();
            txtTraineePhone = new TextBox();
            lblPhone = new Label();
            txtTraineeAge = new TextBox();
            btnTraineeSave = new Button();
            btnTraineeBack = new Button();
            txtDurationUpDown = new NumericUpDown();
            lblErrTrinee = new Label();
            ((System.ComponentModel.ISupportInitialize)txtDurationUpDown).BeginInit();
            SuspendLayout();
            // 
            // txtTraineeSubscriptionFee
            // 
            txtTraineeSubscriptionFee.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTraineeSubscriptionFee.Location = new Point(1121, 273);
            txtTraineeSubscriptionFee.Margin = new Padding(5, 6, 5, 6);
            txtTraineeSubscriptionFee.Name = "txtTraineeSubscriptionFee";
            txtTraineeSubscriptionFee.Size = new Size(366, 34);
            txtTraineeSubscriptionFee.TabIndex = 68;
            // 
            // TraineeJoinDate
            // 
            TraineeJoinDate.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TraineeJoinDate.Format = DateTimePickerFormat.Short;
            TraineeJoinDate.Location = new Point(392, 430);
            TraineeJoinDate.Margin = new Padding(5, 6, 5, 6);
            TraineeJoinDate.Name = "TraineeJoinDate";
            TraineeJoinDate.Size = new Size(361, 34);
            TraineeJoinDate.TabIndex = 64;
            TraineeJoinDate.Value = new DateTime(2023, 5, 19, 5, 6, 0, 0);
            // 
            // radioTraineeFemale
            // 
            radioTraineeFemale.AutoSize = true;
            radioTraineeFemale.BackColor = Color.Transparent;
            radioTraineeFemale.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            radioTraineeFemale.ForeColor = Color.White;
            radioTraineeFemale.Location = new Point(601, 354);
            radioTraineeFemale.Margin = new Padding(5, 6, 5, 6);
            radioTraineeFemale.Name = "radioTraineeFemale";
            radioTraineeFemale.Size = new Size(100, 30);
            radioTraineeFemale.TabIndex = 63;
            radioTraineeFemale.TabStop = true;
            radioTraineeFemale.Text = "Female";
            radioTraineeFemale.UseVisualStyleBackColor = false;
            // 
            // radioTraineeMale
            // 
            radioTraineeMale.AutoSize = true;
            radioTraineeMale.BackColor = Color.Transparent;
            radioTraineeMale.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            radioTraineeMale.ForeColor = Color.White;
            radioTraineeMale.Location = new Point(403, 354);
            radioTraineeMale.Margin = new Padding(5, 6, 5, 6);
            radioTraineeMale.Name = "radioTraineeMale";
            radioTraineeMale.Size = new Size(78, 30);
            radioTraineeMale.TabIndex = 62;
            radioTraineeMale.TabStop = true;
            radioTraineeMale.Text = "Male";
            radioTraineeMale.UseVisualStyleBackColor = false;
            // 
            // txtTraineeName
            // 
            txtTraineeName.BackColor = Color.White;
            txtTraineeName.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTraineeName.Location = new Point(397, 193);
            txtTraineeName.Margin = new Padding(5, 6, 5, 6);
            txtTraineeName.Name = "txtTraineeName";
            txtTraineeName.Size = new Size(361, 34);
            txtTraineeName.TabIndex = 59;
            // 
            // txtTraineeID
            // 
            txtTraineeID.BackColor = Color.White;
            txtTraineeID.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTraineeID.Location = new Point(397, 113);
            txtTraineeID.Margin = new Padding(5, 6, 5, 6);
            txtTraineeID.Name = "txtTraineeID";
            txtTraineeID.Size = new Size(361, 34);
            txtTraineeID.TabIndex = 58;
            // 
            // lblSubscriptionFee
            // 
            lblSubscriptionFee.BackColor = Color.Transparent;
            lblSubscriptionFee.CausesValidation = false;
            lblSubscriptionFee.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubscriptionFee.ForeColor = Color.White;
            lblSubscriptionFee.Image = (Image)resources.GetObject("lblSubscriptionFee.Image");
            lblSubscriptionFee.ImageAlign = ContentAlignment.MiddleLeft;
            lblSubscriptionFee.Location = new Point(840, 273);
            lblSubscriptionFee.Margin = new Padding(5, 0, 5, 0);
            lblSubscriptionFee.Name = "lblSubscriptionFee";
            lblSubscriptionFee.Size = new Size(170, 42);
            lblSubscriptionFee.TabIndex = 57;
            lblSubscriptionFee.Text = "Sub fee";
            lblSubscriptionFee.TextAlign = ContentAlignment.MiddleRight;
            lblSubscriptionFee.Click += lblSubscriptionFee_Click;
            // 
            // lblAge
            // 
            lblAge.BackColor = Color.Transparent;
            lblAge.CausesValidation = false;
            lblAge.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblAge.ForeColor = Color.White;
            lblAge.Image = (Image)resources.GetObject("lblAge.Image");
            lblAge.ImageAlign = ContentAlignment.MiddleLeft;
            lblAge.Location = new Point(107, 261);
            lblAge.Margin = new Padding(5, 0, 5, 0);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(174, 48);
            lblAge.TabIndex = 55;
            lblAge.Text = "Age";
            lblAge.TextAlign = ContentAlignment.MiddleRight;
            lblAge.Click += lblAge_Click;
            // 
            // lblEndDate
            // 
            lblEndDate.BackColor = Color.Transparent;
            lblEndDate.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblEndDate.ForeColor = Color.White;
            lblEndDate.Image = (Image)resources.GetObject("lblEndDate.Image");
            lblEndDate.ImageAlign = ContentAlignment.MiddleLeft;
            lblEndDate.Location = new Point(840, 101);
            lblEndDate.Margin = new Padding(5, 0, 5, 0);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(184, 67);
            lblEndDate.TabIndex = 54;
            lblEndDate.Text = "duration";
            lblEndDate.TextAlign = ContentAlignment.MiddleRight;
            lblEndDate.Click += lblEndDate_Click;
            // 
            // lblJoinDate
            // 
            lblJoinDate.BackColor = Color.Transparent;
            lblJoinDate.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblJoinDate.ForeColor = Color.White;
            lblJoinDate.Image = (Image)resources.GetObject("lblJoinDate.Image");
            lblJoinDate.ImageAlign = ContentAlignment.MiddleLeft;
            lblJoinDate.Location = new Point(106, 427);
            lblJoinDate.Margin = new Padding(5, 0, 5, 0);
            lblJoinDate.Name = "lblJoinDate";
            lblJoinDate.Size = new Size(184, 42);
            lblJoinDate.TabIndex = 53;
            lblJoinDate.Text = "Join Date";
            lblJoinDate.TextAlign = ContentAlignment.MiddleRight;
            lblJoinDate.Click += lblJoinDate_Click;
            // 
            // lblGender
            // 
            lblGender.BackColor = Color.Transparent;
            lblGender.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblGender.ForeColor = Color.White;
            lblGender.Image = (Image)resources.GetObject("lblGender.Image");
            lblGender.ImageAlign = ContentAlignment.MiddleLeft;
            lblGender.Location = new Point(111, 347);
            lblGender.Margin = new Padding(5, 0, 5, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(179, 42);
            lblGender.TabIndex = 52;
            lblGender.Text = "Gender";
            lblGender.TextAlign = ContentAlignment.MiddleRight;
            lblGender.Click += lblGender_Click;
            // 
            // lblid
            // 
            lblid.BackColor = Color.Transparent;
            lblid.CausesValidation = false;
            lblid.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblid.ForeColor = Color.White;
            lblid.Image = (Image)resources.GetObject("lblid.Image");
            lblid.ImageAlign = ContentAlignment.MiddleLeft;
            lblid.Location = new Point(111, 113);
            lblid.Margin = new Padding(5, 0, 5, 0);
            lblid.Name = "lblid";
            lblid.Size = new Size(154, 42);
            lblid.TabIndex = 51;
            lblid.Text = "ID";
            lblid.TextAlign = ContentAlignment.MiddleRight;
            lblid.Click += lblid_Click;
            // 
            // lblName
            // 
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.White;
            lblName.Image = (Image)resources.GetObject("lblName.Image");
            lblName.ImageAlign = ContentAlignment.MiddleLeft;
            lblName.Location = new Point(111, 190);
            lblName.Margin = new Padding(5, 0, 5, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(179, 50);
            lblName.TabIndex = 49;
            lblName.Text = "Full Name";
            lblName.TextAlign = ContentAlignment.MiddleRight;
            lblName.Click += lblName_Click;
            // 
            // lblTraineeClass
            // 
            lblTraineeClass.BackColor = Color.Transparent;
            lblTraineeClass.CausesValidation = false;
            lblTraineeClass.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTraineeClass.ForeColor = Color.White;
            lblTraineeClass.Image = (Image)resources.GetObject("lblTraineeClass.Image");
            lblTraineeClass.ImageAlign = ContentAlignment.MiddleLeft;
            lblTraineeClass.Location = new Point(845, 197);
            lblTraineeClass.Margin = new Padding(5, 0, 5, 0);
            lblTraineeClass.Name = "lblTraineeClass";
            lblTraineeClass.Size = new Size(179, 42);
            lblTraineeClass.TabIndex = 68;
            lblTraineeClass.Text = "Trainee Class";
            lblTraineeClass.TextAlign = ContentAlignment.MiddleRight;
            lblTraineeClass.Click += lblTraineeClass_Click;
            // 
            // txtTraineeClass
            // 
            txtTraineeClass.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTraineeClass.Location = new Point(1121, 203);
            txtTraineeClass.Margin = new Padding(5, 6, 5, 6);
            txtTraineeClass.Name = "txtTraineeClass";
            txtTraineeClass.Size = new Size(368, 34);
            txtTraineeClass.TabIndex = 69;
            // 
            // btnTraineeReset
            // 
            btnTraineeReset.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnTraineeReset.ForeColor = Color.White;
            btnTraineeReset.Image = (Image)resources.GetObject("btnTraineeReset.Image");
            btnTraineeReset.Location = new Point(1204, 565);
            btnTraineeReset.Margin = new Padding(5, 6, 5, 6);
            btnTraineeReset.Name = "btnTraineeReset";
            btnTraineeReset.Size = new Size(171, 47);
            btnTraineeReset.TabIndex = 74;
            btnTraineeReset.Text = "Reset";
            btnTraineeReset.UseVisualStyleBackColor = true;
            btnTraineeReset.Click += btnTraineeReset_Click;
            // 
            // txtTraineePhone
            // 
            txtTraineePhone.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTraineePhone.Location = new Point(1116, 353);
            txtTraineePhone.Margin = new Padding(5, 6, 5, 6);
            txtTraineePhone.Name = "txtTraineePhone";
            txtTraineePhone.Size = new Size(366, 34);
            txtTraineePhone.TabIndex = 73;
            // 
            // lblPhone
            // 
            lblPhone.BackColor = Color.Transparent;
            lblPhone.CausesValidation = false;
            lblPhone.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPhone.ForeColor = Color.White;
            lblPhone.Image = (Image)resources.GetObject("lblPhone.Image");
            lblPhone.ImageAlign = ContentAlignment.MiddleLeft;
            lblPhone.Location = new Point(840, 347);
            lblPhone.Margin = new Padding(5, 0, 5, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(170, 42);
            lblPhone.TabIndex = 72;
            lblPhone.Text = "Phone";
            lblPhone.TextAlign = ContentAlignment.MiddleRight;
            lblPhone.Click += lblPhone_Click;
            // 
            // txtTraineeAge
            // 
            txtTraineeAge.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTraineeAge.Location = new Point(397, 275);
            txtTraineeAge.Margin = new Padding(5, 6, 5, 6);
            txtTraineeAge.Name = "txtTraineeAge";
            txtTraineeAge.Size = new Size(361, 34);
            txtTraineeAge.TabIndex = 66;
            // 
            // btnTraineeSave
            // 
            btnTraineeSave.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnTraineeSave.ForeColor = Color.White;
            btnTraineeSave.Image = (Image)resources.GetObject("btnTraineeSave.Image");
            btnTraineeSave.Location = new Point(744, 565);
            btnTraineeSave.Margin = new Padding(5, 6, 5, 6);
            btnTraineeSave.Name = "btnTraineeSave";
            btnTraineeSave.Size = new Size(188, 53);
            btnTraineeSave.TabIndex = 70;
            btnTraineeSave.Text = "ADD";
            btnTraineeSave.UseVisualStyleBackColor = true;
            btnTraineeSave.Click += btnTraineeSave_Click;
            // 
            // btnTraineeBack
            // 
            btnTraineeBack.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnTraineeBack.ForeColor = Color.White;
            btnTraineeBack.Image = (Image)resources.GetObject("btnTraineeBack.Image");
            btnTraineeBack.Location = new Point(258, 565);
            btnTraineeBack.Margin = new Padding(5, 6, 5, 6);
            btnTraineeBack.Name = "btnTraineeBack";
            btnTraineeBack.Size = new Size(171, 47);
            btnTraineeBack.TabIndex = 74;
            btnTraineeBack.Text = "BACK";
            btnTraineeBack.UseVisualStyleBackColor = true;
            btnTraineeBack.Click += button1_Click;
            // 
            // txtDurationUpDown
            // 
            txtDurationUpDown.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtDurationUpDown.Location = new Point(1121, 120);
            txtDurationUpDown.Margin = new Padding(7, 6, 7, 6);
            txtDurationUpDown.Name = "txtDurationUpDown";
            txtDurationUpDown.Size = new Size(366, 34);
            txtDurationUpDown.TabIndex = 75;
            // 
            // lblErrTrinee
            // 
            lblErrTrinee.AutoSize = true;
            lblErrTrinee.BackColor = Color.White;
            lblErrTrinee.ForeColor = Color.Red;
            lblErrTrinee.Location = new Point(576, 648);
            lblErrTrinee.Name = "lblErrTrinee";
            lblErrTrinee.Size = new Size(70, 25);
            lblErrTrinee.TabIndex = 76;
            lblErrTrinee.Text = "label1";
            lblErrTrinee.Visible = false;
            // 
            // TraineeForm
            // 
            AutoScaleDimensions = new SizeF(14F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1572, 738);
            Controls.Add(lblErrTrinee);
            Controls.Add(txtDurationUpDown);
            Controls.Add(btnTraineeBack);
            Controls.Add(txtTraineePhone);
            Controls.Add(lblPhone);
            Controls.Add(btnTraineeReset);
            Controls.Add(btnTraineeSave);
            Controls.Add(txtTraineeClass);
            Controls.Add(lblTraineeClass);
            Controls.Add(txtTraineeSubscriptionFee);
            Controls.Add(txtTraineeAge);
            Controls.Add(TraineeJoinDate);
            Controls.Add(radioTraineeFemale);
            Controls.Add(radioTraineeMale);
            Controls.Add(txtTraineeName);
            Controls.Add(txtTraineeID);
            Controls.Add(lblSubscriptionFee);
            Controls.Add(lblAge);
            Controls.Add(lblEndDate);
            Controls.Add(lblJoinDate);
            Controls.Add(lblGender);
            Controls.Add(lblid);
            Controls.Add(lblName);
            DoubleBuffered = true;
            Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TraineeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TraineeForm";
            Load += TraineeForm_Load;
            ((System.ComponentModel.ISupportInitialize)txtDurationUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtTraineeSubscriptionFee;
        private System.Windows.Forms.DateTimePicker TraineeJoinDate;
        private System.Windows.Forms.RadioButton radioTraineeFemale;
        private System.Windows.Forms.RadioButton radioTraineeMale;
        private System.Windows.Forms.TextBox txtTraineeName;
        private System.Windows.Forms.TextBox txtTraineeID;
        private System.Windows.Forms.Label lblSubscriptionFee;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblJoinDate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTraineeClass;
        private System.Windows.Forms.TextBox txtTraineeClass;
        private System.Windows.Forms.Button btnTraineeReset;
        private System.Windows.Forms.TextBox txtTraineePhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtTraineeAge;
        private System.Windows.Forms.Button btnTraineeSave;
        private System.Windows.Forms.Button btnTraineeBack;
        private System.Windows.Forms.NumericUpDown txtDurationUpDown;
        private System.Windows.Forms.Label lblErrTrinee;
    }
}

