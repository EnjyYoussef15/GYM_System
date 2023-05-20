namespace GYMForms
{
    partial class WorkerAddForm
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
            btnWorkerAdd = new Button();
            btnWorkerBack = new Button();
            HireDateCoach = new DateTimePicker();
            label6 = new Label();
            radFemale = new RadioButton();
            radMale = new RadioButton();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtWorkerName = new TextBox();
            txtWorkerSalary = new TextBox();
            txtWorkerJob = new TextBox();
            txtWorkerID = new TextBox();
            btnWorkerReset = new Button();
            lblErrWorker = new Label();
            SuspendLayout();
            // 
            // btnWorkerAdd
            // 
            btnWorkerAdd.Anchor = AnchorStyles.None;
            btnWorkerAdd.BackColor = SystemColors.GradientActiveCaption;
            btnWorkerAdd.FlatAppearance.CheckedBackColor = Color.LightSkyBlue;
            btnWorkerAdd.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            btnWorkerAdd.FlatAppearance.MouseOverBackColor = Color.White;
            btnWorkerAdd.FlatStyle = FlatStyle.Popup;
            btnWorkerAdd.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnWorkerAdd.Location = new Point(687, 542);
            btnWorkerAdd.Margin = new Padding(4, 3, 4, 3);
            btnWorkerAdd.Name = "btnWorkerAdd";
            btnWorkerAdd.Size = new Size(152, 37);
            btnWorkerAdd.TabIndex = 52;
            btnWorkerAdd.Text = "Add";
            btnWorkerAdd.UseVisualStyleBackColor = false;
            btnWorkerAdd.Click += btnWorkerAdd_Click;
            // 
            // btnWorkerBack
            // 
            btnWorkerBack.Anchor = AnchorStyles.None;
            btnWorkerBack.BackColor = SystemColors.GradientActiveCaption;
            btnWorkerBack.FlatAppearance.CheckedBackColor = Color.LightSkyBlue;
            btnWorkerBack.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            btnWorkerBack.FlatAppearance.MouseOverBackColor = Color.White;
            btnWorkerBack.FlatStyle = FlatStyle.Popup;
            btnWorkerBack.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnWorkerBack.Location = new Point(262, 542);
            btnWorkerBack.Margin = new Padding(4, 3, 4, 3);
            btnWorkerBack.Name = "btnWorkerBack";
            btnWorkerBack.Size = new Size(152, 37);
            btnWorkerBack.TabIndex = 51;
            btnWorkerBack.Text = "Back";
            btnWorkerBack.UseVisualStyleBackColor = false;
            btnWorkerBack.Click += btnWorkerBack_Click;
            // 
            // HireDateCoach
            // 
            HireDateCoach.CalendarMonthBackground = Color.BlanchedAlmond;
            HireDateCoach.CustomFormat = "";
            HireDateCoach.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            HireDateCoach.Format = DateTimePickerFormat.Custom;
            HireDateCoach.ImeMode = ImeMode.NoControl;
            HireDateCoach.Location = new Point(612, 440);
            HireDateCoach.MaxDate = new DateTime(9998, 12, 16, 0, 0, 0, 0);
            HireDateCoach.Name = "HireDateCoach";
            HireDateCoach.Size = new Size(306, 34);
            HireDateCoach.TabIndex = 65;
            HireDateCoach.Value = new DateTime(2023, 5, 19, 0, 0, 0, 0);
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(64, 64, 64);
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(456, 263);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(90, 27);
            label6.TabIndex = 64;
            label6.Text = "Gender";
            // 
            // radFemale
            // 
            radFemale.AutoSize = true;
            radFemale.BackColor = Color.FromArgb(64, 64, 64);
            radFemale.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            radFemale.ForeColor = Color.White;
            radFemale.Location = new Point(777, 263);
            radFemale.Name = "radFemale";
            radFemale.Size = new Size(106, 29);
            radFemale.TabIndex = 63;
            radFemale.TabStop = true;
            radFemale.Text = "Female";
            radFemale.UseVisualStyleBackColor = false;
            // 
            // radMale
            // 
            radMale.AutoSize = true;
            radMale.BackColor = Color.FromArgb(64, 64, 64);
            radMale.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            radMale.ForeColor = Color.White;
            radMale.Location = new Point(626, 263);
            radMale.Name = "radMale";
            radMale.Size = new Size(84, 29);
            radMale.TabIndex = 62;
            radMale.TabStop = true;
            radMale.Text = "Male";
            radMale.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(64, 64, 64);
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(456, 320);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(77, 27);
            label5.TabIndex = 61;
            label5.Text = "Salary";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(64, 64, 64);
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(456, 373);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(101, 27);
            label4.TabIndex = 60;
            label4.Text = "Job Title";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(64, 64, 64);
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(456, 446);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 27);
            label3.TabIndex = 59;
            label3.Text = "Hire Date";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(64, 64, 64);
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(469, 146);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(40, 27);
            label2.TabIndex = 58;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 64, 64);
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(456, 207);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 27);
            label1.TabIndex = 57;
            label1.Text = "Name";
            // 
            // txtWorkerName
            // 
            txtWorkerName.Anchor = AnchorStyles.None;
            txtWorkerName.BackColor = Color.WhiteSmoke;
            txtWorkerName.BorderStyle = BorderStyle.FixedSingle;
            txtWorkerName.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtWorkerName.Location = new Point(612, 207);
            txtWorkerName.Margin = new Padding(4, 3, 4, 3);
            txtWorkerName.Multiline = true;
            txtWorkerName.Name = "txtWorkerName";
            txtWorkerName.Size = new Size(306, 32);
            txtWorkerName.TabIndex = 56;
            // 
            // txtWorkerSalary
            // 
            txtWorkerSalary.Anchor = AnchorStyles.None;
            txtWorkerSalary.BackColor = Color.WhiteSmoke;
            txtWorkerSalary.BorderStyle = BorderStyle.FixedSingle;
            txtWorkerSalary.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtWorkerSalary.Location = new Point(612, 320);
            txtWorkerSalary.Margin = new Padding(4, 3, 4, 3);
            txtWorkerSalary.Multiline = true;
            txtWorkerSalary.Name = "txtWorkerSalary";
            txtWorkerSalary.Size = new Size(306, 32);
            txtWorkerSalary.TabIndex = 55;
            // 
            // txtWorkerJob
            // 
            txtWorkerJob.Anchor = AnchorStyles.None;
            txtWorkerJob.BackColor = Color.WhiteSmoke;
            txtWorkerJob.BorderStyle = BorderStyle.FixedSingle;
            txtWorkerJob.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtWorkerJob.Location = new Point(612, 373);
            txtWorkerJob.Margin = new Padding(4, 3, 4, 3);
            txtWorkerJob.Multiline = true;
            txtWorkerJob.Name = "txtWorkerJob";
            txtWorkerJob.Size = new Size(306, 32);
            txtWorkerJob.TabIndex = 54;
            // 
            // txtWorkerID
            // 
            txtWorkerID.Anchor = AnchorStyles.None;
            txtWorkerID.BackColor = Color.WhiteSmoke;
            txtWorkerID.BorderStyle = BorderStyle.FixedSingle;
            txtWorkerID.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtWorkerID.Location = new Point(612, 144);
            txtWorkerID.Margin = new Padding(4, 3, 4, 3);
            txtWorkerID.Multiline = true;
            txtWorkerID.Name = "txtWorkerID";
            txtWorkerID.Size = new Size(306, 32);
            txtWorkerID.TabIndex = 53;
            // 
            // btnWorkerReset
            // 
            btnWorkerReset.Anchor = AnchorStyles.None;
            btnWorkerReset.BackColor = SystemColors.GradientActiveCaption;
            btnWorkerReset.FlatAppearance.CheckedBackColor = Color.LightSkyBlue;
            btnWorkerReset.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            btnWorkerReset.FlatAppearance.MouseOverBackColor = Color.White;
            btnWorkerReset.FlatStyle = FlatStyle.Popup;
            btnWorkerReset.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnWorkerReset.Location = new Point(1138, 542);
            btnWorkerReset.Margin = new Padding(4, 3, 4, 3);
            btnWorkerReset.Name = "btnWorkerReset";
            btnWorkerReset.RightToLeft = RightToLeft.Yes;
            btnWorkerReset.Size = new Size(152, 41);
            btnWorkerReset.TabIndex = 66;
            btnWorkerReset.Text = "Reset";
            btnWorkerReset.UseVisualStyleBackColor = false;
            btnWorkerReset.Click += btnWorkerReset_Click;
            // 
            // lblErrWorker
            // 
            lblErrWorker.AutoSize = true;
            lblErrWorker.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrWorker.ForeColor = Color.Red;
            lblErrWorker.Location = new Point(552, 639);
            lblErrWorker.Name = "lblErrWorker";
            lblErrWorker.Size = new Size(86, 32);
            lblErrWorker.TabIndex = 67;
            lblErrWorker.Text = "label7";
            lblErrWorker.Visible = false;
            // 
            // WorkerAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._6_Reasons_You_Should_Never_Open_a_Gym;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1576, 742);
            Controls.Add(lblErrWorker);
            Controls.Add(btnWorkerReset);
            Controls.Add(HireDateCoach);
            Controls.Add(label6);
            Controls.Add(radFemale);
            Controls.Add(radMale);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtWorkerName);
            Controls.Add(txtWorkerSalary);
            Controls.Add(txtWorkerJob);
            Controls.Add(txtWorkerID);
            Controls.Add(btnWorkerAdd);
            Controls.Add(btnWorkerBack);
            Name = "WorkerAddForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "WorkerAddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnWorkerAdd;
        private Button btnWorkerBack;
        private DateTimePicker HireDateCoach;
        private Label label6;
        private RadioButton radFemale;
        private RadioButton radMale;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtWorkerName;
        private TextBox txtWorkerSalary;
        private TextBox txtWorkerJob;
        private TextBox txtWorkerID;
        private Button btnWorkerReset;
        private Label lblErrWorker;
    }
}