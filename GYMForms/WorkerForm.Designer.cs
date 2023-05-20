namespace GYMForms
{
    partial class WorkerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerForm));
            HireDateCoach = new DateTimePicker();
            label6 = new Label();
            radFemale = new RadioButton();
            radMale = new RadioButton();
            btnWorkerUpdate = new Button();
            btnWorkerDelete = new Button();
            btnWorkerBack = new Button();
            grdWorkerUpdate = new DataGridView();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtWorkerName = new TextBox();
            txtWorkerSalary = new TextBox();
            txtWorkerJob = new TextBox();
            txtWorkerID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)grdWorkerUpdate).BeginInit();
            SuspendLayout();
            // 
            // HireDateCoach
            // 
            HireDateCoach.CalendarMonthBackground = Color.BlanchedAlmond;
            HireDateCoach.CustomFormat = "";
            HireDateCoach.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            HireDateCoach.Format = DateTimePickerFormat.Custom;
            HireDateCoach.ImeMode = ImeMode.NoControl;
            HireDateCoach.Location = new Point(346, 411);
            HireDateCoach.MaxDate = new DateTime(9998, 12, 16, 0, 0, 0, 0);
            HireDateCoach.Name = "HireDateCoach";
            HireDateCoach.Size = new Size(306, 34);
            HireDateCoach.TabIndex = 40;
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
            label6.Location = new Point(190, 228);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(90, 27);
            label6.TabIndex = 39;
            label6.Text = "Gender";
            // 
            // radFemale
            // 
            radFemale.AutoSize = true;
            radFemale.BackColor = Color.FromArgb(64, 64, 64);
            radFemale.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            radFemale.ForeColor = Color.White;
            radFemale.Location = new Point(497, 228);
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
            radMale.BackColor = Color.FromArgb(64, 64, 64);
            radMale.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            radMale.ForeColor = Color.White;
            radMale.Location = new Point(346, 226);
            radMale.Name = "radMale";
            radMale.Size = new Size(84, 29);
            radMale.TabIndex = 37;
            radMale.TabStop = true;
            radMale.Text = "Male";
            radMale.UseVisualStyleBackColor = false;
            // 
            // btnWorkerUpdate
            // 
            btnWorkerUpdate.Anchor = AnchorStyles.None;
            btnWorkerUpdate.BackColor = SystemColors.GradientActiveCaption;
            btnWorkerUpdate.FlatAppearance.CheckedBackColor = Color.LightSkyBlue;
            btnWorkerUpdate.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            btnWorkerUpdate.FlatAppearance.MouseOverBackColor = Color.White;
            btnWorkerUpdate.FlatStyle = FlatStyle.Popup;
            btnWorkerUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnWorkerUpdate.Location = new Point(1231, 518);
            btnWorkerUpdate.Margin = new Padding(4, 3, 4, 3);
            btnWorkerUpdate.Name = "btnWorkerUpdate";
            btnWorkerUpdate.RightToLeft = RightToLeft.Yes;
            btnWorkerUpdate.Size = new Size(152, 35);
            btnWorkerUpdate.TabIndex = 36;
            btnWorkerUpdate.Text = "Update";
            btnWorkerUpdate.UseVisualStyleBackColor = false;
            btnWorkerUpdate.Click += btnWorkerUpdate_Click;
            // 
            // btnWorkerDelete
            // 
            btnWorkerDelete.Anchor = AnchorStyles.None;
            btnWorkerDelete.BackColor = SystemColors.GradientActiveCaption;
            btnWorkerDelete.FlatAppearance.CheckedBackColor = Color.LightSkyBlue;
            btnWorkerDelete.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            btnWorkerDelete.FlatAppearance.MouseOverBackColor = Color.White;
            btnWorkerDelete.FlatStyle = FlatStyle.Popup;
            btnWorkerDelete.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnWorkerDelete.Location = new Point(846, 516);
            btnWorkerDelete.Margin = new Padding(4, 3, 4, 3);
            btnWorkerDelete.Name = "btnWorkerDelete";
            btnWorkerDelete.Size = new Size(152, 37);
            btnWorkerDelete.TabIndex = 35;
            btnWorkerDelete.Text = "Delete";
            btnWorkerDelete.UseVisualStyleBackColor = false;
            btnWorkerDelete.Click += btnWorkerDelete_Click;
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
            btnWorkerBack.Location = new Point(451, 520);
            btnWorkerBack.Margin = new Padding(4, 3, 4, 3);
            btnWorkerBack.Name = "btnWorkerBack";
            btnWorkerBack.Size = new Size(152, 37);
            btnWorkerBack.TabIndex = 34;
            btnWorkerBack.Text = "Back";
            btnWorkerBack.UseVisualStyleBackColor = false;
            btnWorkerBack.Click += btnWorkerBack_Click;
            // 
            // grdWorkerUpdate
            // 
            grdWorkerUpdate.Anchor = AnchorStyles.None;
            grdWorkerUpdate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdWorkerUpdate.Location = new Point(754, 101);
            grdWorkerUpdate.Margin = new Padding(4, 3, 4, 3);
            grdWorkerUpdate.Name = "grdWorkerUpdate";
            grdWorkerUpdate.RowHeadersWidth = 51;
            grdWorkerUpdate.RowTemplate.Height = 29;
            grdWorkerUpdate.Size = new Size(865, 253);
            grdWorkerUpdate.TabIndex = 33;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(64, 64, 64);
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(190, 285);
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
            label4.BackColor = Color.FromArgb(64, 64, 64);
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(190, 338);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(101, 27);
            label4.TabIndex = 31;
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
            label3.Location = new Point(190, 411);
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
            label2.BackColor = Color.FromArgb(64, 64, 64);
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(190, 109);
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
            label1.BackColor = Color.FromArgb(64, 64, 64);
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(190, 172);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 27);
            label1.TabIndex = 28;
            label1.Text = "Name";
            // 
            // txtWorkerName
            // 
            txtWorkerName.Anchor = AnchorStyles.None;
            txtWorkerName.BackColor = Color.WhiteSmoke;
            txtWorkerName.BorderStyle = BorderStyle.FixedSingle;
            txtWorkerName.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtWorkerName.Location = new Point(346, 172);
            txtWorkerName.Margin = new Padding(4, 3, 4, 3);
            txtWorkerName.Multiline = true;
            txtWorkerName.Name = "txtWorkerName";
            txtWorkerName.Size = new Size(306, 32);
            txtWorkerName.TabIndex = 27;
            // 
            // txtWorkerSalary
            // 
            txtWorkerSalary.Anchor = AnchorStyles.None;
            txtWorkerSalary.BackColor = Color.WhiteSmoke;
            txtWorkerSalary.BorderStyle = BorderStyle.FixedSingle;
            txtWorkerSalary.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtWorkerSalary.Location = new Point(346, 285);
            txtWorkerSalary.Margin = new Padding(4, 3, 4, 3);
            txtWorkerSalary.Multiline = true;
            txtWorkerSalary.Name = "txtWorkerSalary";
            txtWorkerSalary.Size = new Size(306, 32);
            txtWorkerSalary.TabIndex = 26;
            // 
            // txtWorkerJob
            // 
            txtWorkerJob.Anchor = AnchorStyles.None;
            txtWorkerJob.BackColor = Color.WhiteSmoke;
            txtWorkerJob.BorderStyle = BorderStyle.FixedSingle;
            txtWorkerJob.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtWorkerJob.Location = new Point(346, 338);
            txtWorkerJob.Margin = new Padding(4, 3, 4, 3);
            txtWorkerJob.Multiline = true;
            txtWorkerJob.Name = "txtWorkerJob";
            txtWorkerJob.Size = new Size(306, 32);
            txtWorkerJob.TabIndex = 25;
            // 
            // txtWorkerID
            // 
            txtWorkerID.Anchor = AnchorStyles.None;
            txtWorkerID.BackColor = Color.WhiteSmoke;
            txtWorkerID.BorderStyle = BorderStyle.FixedSingle;
            txtWorkerID.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtWorkerID.Location = new Point(346, 109);
            txtWorkerID.Margin = new Padding(4, 3, 4, 3);
            txtWorkerID.Multiline = true;
            txtWorkerID.Name = "txtWorkerID";
            txtWorkerID.Size = new Size(306, 32);
            txtWorkerID.TabIndex = 24;
            // 
            // WorkerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1576, 742);
            Controls.Add(HireDateCoach);
            Controls.Add(label6);
            Controls.Add(radFemale);
            Controls.Add(radMale);
            Controls.Add(btnWorkerUpdate);
            Controls.Add(btnWorkerDelete);
            Controls.Add(btnWorkerBack);
            Controls.Add(grdWorkerUpdate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtWorkerName);
            Controls.Add(txtWorkerSalary);
            Controls.Add(txtWorkerJob);
            Controls.Add(txtWorkerID);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "WorkerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "WorkerForm";
            Load += WorkerForm_Load;
            ((System.ComponentModel.ISupportInitialize)grdWorkerUpdate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker HireDateCoach;
        private Label label6;
        private RadioButton radFemale;
        private RadioButton radMale;
        private Button btnWorkerUpdate;
        private Button btnWorkerDelete;
        private Button btnWorkerBack;
        private DataGridView grdWorkerUpdate;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtWorkerName;
        private TextBox txtWorkerSalary;
        private TextBox txtWorkerJob;
        private TextBox txtWorkerID;
    }
}