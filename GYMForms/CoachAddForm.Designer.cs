namespace GYMForms
{
    partial class CoachAddForm
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
            label7 = new Label();
            txtCoachTrainee = new TextBox();
            HireDateCoach = new DateTimePicker();
            label6 = new Label();
            radFemale = new RadioButton();
            radMale = new RadioButton();
            btnCoachAdd = new Button();
            btnCoachBack = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtCoachName = new TextBox();
            txtCoachSalary = new TextBox();
            txtCoachClass = new TextBox();
            txtCoachID = new TextBox();
            btnCoachReset = new Button();
            lblErrCoach = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.BackColor = Color.BlanchedAlmond;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(495, 420);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(203, 27);
            label7.TabIndex = 42;
            label7.Text = "Nmber OF Trainee";
            // 
            // txtCoachTrainee
            // 
            txtCoachTrainee.Anchor = AnchorStyles.None;
            txtCoachTrainee.BackColor = Color.BlanchedAlmond;
            txtCoachTrainee.BorderStyle = BorderStyle.FixedSingle;
            txtCoachTrainee.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtCoachTrainee.Location = new Point(713, 420);
            txtCoachTrainee.Margin = new Padding(4, 3, 4, 3);
            txtCoachTrainee.Multiline = true;
            txtCoachTrainee.Name = "txtCoachTrainee";
            txtCoachTrainee.Size = new Size(306, 37);
            txtCoachTrainee.TabIndex = 41;
            // 
            // HireDateCoach
            // 
            HireDateCoach.CalendarMonthBackground = Color.BlanchedAlmond;
            HireDateCoach.CustomFormat = "";
            HireDateCoach.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            HireDateCoach.Format = DateTimePickerFormat.Custom;
            HireDateCoach.ImeMode = ImeMode.NoControl;
            HireDateCoach.Location = new Point(712, 468);
            HireDateCoach.MaxDate = new DateTime(9998, 12, 16, 0, 0, 0, 0);
            HireDateCoach.Name = "HireDateCoach";
            HireDateCoach.Size = new Size(292, 34);
            HireDateCoach.TabIndex = 40;
            HireDateCoach.Value = new DateTime(2023, 5, 19, 0, 0, 0, 0);
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.BlanchedAlmond;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(557, 214);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(90, 27);
            label6.TabIndex = 39;
            label6.Text = "Gender";
            // 
            // radFemale
            // 
            radFemale.AutoSize = true;
            radFemale.BackColor = Color.BlanchedAlmond;
            radFemale.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            radFemale.Location = new Point(849, 198);
            radFemale.Name = "radFemale";
            radFemale.Size = new Size(106, 29);
            radFemale.TabIndex = 38;
            radFemale.TabStop = true;
            radFemale.Text = "Female";
            radFemale.UseVisualStyleBackColor = false;
            // 
            // radMale
            // 
            radMale.AutoSize = true;
            radMale.BackColor = Color.BlanchedAlmond;
            radMale.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            radMale.Location = new Point(712, 198);
            radMale.Name = "radMale";
            radMale.Size = new Size(84, 29);
            radMale.TabIndex = 37;
            radMale.TabStop = true;
            radMale.Text = "Male";
            radMale.UseVisualStyleBackColor = false;
            // 
            // btnCoachAdd
            // 
            btnCoachAdd.Anchor = AnchorStyles.None;
            btnCoachAdd.BackColor = SystemColors.GradientActiveCaption;
            btnCoachAdd.FlatAppearance.CheckedBackColor = Color.LightSkyBlue;
            btnCoachAdd.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            btnCoachAdd.FlatAppearance.MouseOverBackColor = Color.White;
            btnCoachAdd.FlatStyle = FlatStyle.Popup;
            btnCoachAdd.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCoachAdd.Location = new Point(778, 559);
            btnCoachAdd.Margin = new Padding(4, 3, 4, 3);
            btnCoachAdd.Name = "btnCoachAdd";
            btnCoachAdd.Size = new Size(152, 44);
            btnCoachAdd.TabIndex = 35;
            btnCoachAdd.Text = "Add";
            btnCoachAdd.UseVisualStyleBackColor = false;
            btnCoachAdd.Click += btnCoachAdd_Click;
            // 
            // btnCoachBack
            // 
            btnCoachBack.Anchor = AnchorStyles.None;
            btnCoachBack.BackColor = SystemColors.GradientActiveCaption;
            btnCoachBack.FlatAppearance.CheckedBackColor = Color.LightSkyBlue;
            btnCoachBack.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            btnCoachBack.FlatAppearance.MouseOverBackColor = Color.White;
            btnCoachBack.FlatStyle = FlatStyle.Popup;
            btnCoachBack.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCoachBack.Location = new Point(263, 559);
            btnCoachBack.Margin = new Padding(4, 3, 4, 3);
            btnCoachBack.Name = "btnCoachBack";
            btnCoachBack.Size = new Size(152, 43);
            btnCoachBack.TabIndex = 34;
            btnCoachBack.Text = "Back";
            btnCoachBack.UseVisualStyleBackColor = false;
            btnCoachBack.Click += btnCoachBack_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.BlanchedAlmond;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(557, 281);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(77, 27);
            label5.TabIndex = 32;
            label5.Text = "Salary";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.BlanchedAlmond;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(539, 344);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(131, 27);
            label4.TabIndex = 31;
            label4.Text = "Class Name";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.BlanchedAlmond;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(542, 487);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 27);
            label3.TabIndex = 30;
            label3.Text = "Hire Date";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.BlanchedAlmond;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(561, 74);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(40, 27);
            label2.TabIndex = 29;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.BlanchedAlmond;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(561, 149);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 27);
            label1.TabIndex = 28;
            label1.Text = "Name";
            // 
            // txtCoachName
            // 
            txtCoachName.Anchor = AnchorStyles.None;
            txtCoachName.BackColor = Color.BlanchedAlmond;
            txtCoachName.BorderStyle = BorderStyle.FixedSingle;
            txtCoachName.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtCoachName.Location = new Point(713, 149);
            txtCoachName.Margin = new Padding(4, 3, 4, 3);
            txtCoachName.Multiline = true;
            txtCoachName.Name = "txtCoachName";
            txtCoachName.Size = new Size(306, 37);
            txtCoachName.TabIndex = 27;
            // 
            // txtCoachSalary
            // 
            txtCoachSalary.Anchor = AnchorStyles.None;
            txtCoachSalary.BackColor = Color.BlanchedAlmond;
            txtCoachSalary.BorderStyle = BorderStyle.FixedSingle;
            txtCoachSalary.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtCoachSalary.Location = new Point(713, 281);
            txtCoachSalary.Margin = new Padding(4, 3, 4, 3);
            txtCoachSalary.Multiline = true;
            txtCoachSalary.Name = "txtCoachSalary";
            txtCoachSalary.Size = new Size(306, 37);
            txtCoachSalary.TabIndex = 26;
            // 
            // txtCoachClass
            // 
            txtCoachClass.Anchor = AnchorStyles.None;
            txtCoachClass.BackColor = Color.BlanchedAlmond;
            txtCoachClass.BorderStyle = BorderStyle.FixedSingle;
            txtCoachClass.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtCoachClass.Location = new Point(713, 344);
            txtCoachClass.Margin = new Padding(4, 3, 4, 3);
            txtCoachClass.Multiline = true;
            txtCoachClass.Name = "txtCoachClass";
            txtCoachClass.Size = new Size(306, 37);
            txtCoachClass.TabIndex = 25;
            // 
            // txtCoachID
            // 
            txtCoachID.Anchor = AnchorStyles.None;
            txtCoachID.BackColor = Color.BlanchedAlmond;
            txtCoachID.BorderStyle = BorderStyle.FixedSingle;
            txtCoachID.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtCoachID.Location = new Point(713, 74);
            txtCoachID.Margin = new Padding(4, 3, 4, 3);
            txtCoachID.Multiline = true;
            txtCoachID.Name = "txtCoachID";
            txtCoachID.Size = new Size(306, 37);
            txtCoachID.TabIndex = 24;
            // 
            // btnCoachReset
            // 
            btnCoachReset.Anchor = AnchorStyles.None;
            btnCoachReset.BackColor = SystemColors.GradientActiveCaption;
            btnCoachReset.FlatAppearance.CheckedBackColor = Color.LightSkyBlue;
            btnCoachReset.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            btnCoachReset.FlatAppearance.MouseOverBackColor = Color.White;
            btnCoachReset.FlatStyle = FlatStyle.Popup;
            btnCoachReset.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCoachReset.Location = new Point(1252, 565);
            btnCoachReset.Margin = new Padding(4, 3, 4, 3);
            btnCoachReset.Name = "btnCoachReset";
            btnCoachReset.RightToLeft = RightToLeft.Yes;
            btnCoachReset.Size = new Size(152, 41);
            btnCoachReset.TabIndex = 36;
            btnCoachReset.Text = "Reset";
            btnCoachReset.UseVisualStyleBackColor = false;
            btnCoachReset.Click += btnCoachReset_Click;
            // 
            // lblErrCoach
            // 
            lblErrCoach.AutoSize = true;
            lblErrCoach.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrCoach.ForeColor = Color.Red;
            lblErrCoach.Location = new Point(671, 618);
            lblErrCoach.Name = "lblErrCoach";
            lblErrCoach.Size = new Size(86, 32);
            lblErrCoach.TabIndex = 43;
            lblErrCoach.Text = "label8";
            lblErrCoach.Visible = false;
            // 
            // CoachAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1617790968609;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1576, 742);
            Controls.Add(lblErrCoach);
            Controls.Add(label7);
            Controls.Add(txtCoachTrainee);
            Controls.Add(HireDateCoach);
            Controls.Add(label6);
            Controls.Add(radFemale);
            Controls.Add(radMale);
            Controls.Add(btnCoachReset);
            Controls.Add(btnCoachAdd);
            Controls.Add(btnCoachBack);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCoachName);
            Controls.Add(txtCoachSalary);
            Controls.Add(txtCoachClass);
            Controls.Add(txtCoachID);
            Name = "CoachAddForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CoachAddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox txtCoachTrainee;
        private DateTimePicker HireDateCoach;
        private Label label6;
        private RadioButton radFemale;
        private RadioButton radMale;
        private Button btnCoachUpdate;
        private Button btnCoachAdd;
        private Button btnCoachBack;

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtCoachName;
        private TextBox txtCoachSalary;
        private TextBox txtCoachClass;
        private TextBox txtCoachID;
        private Button btnCoachReset;
        private Label lblErrCoach;
    }
}