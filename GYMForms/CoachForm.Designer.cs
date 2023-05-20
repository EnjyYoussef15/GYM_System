namespace GYMForms
{
    partial class CoachForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoachForm));
            txtCoachID = new TextBox();
            txtCoachClass = new TextBox();
            txtCoachSalary = new TextBox();
            txtCoachName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            btnCoachBack = new Button();
            btnCoachDelete = new Button();
            btnCoachUpdate = new Button();
            radMale = new RadioButton();
            radFemale = new RadioButton();
            label6 = new Label();
            HireDateCoach = new DateTimePicker();
            label7 = new Label();
            txtCoachTrainee = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtCoachID
            // 
            txtCoachID.Anchor = AnchorStyles.None;
            txtCoachID.BackColor = Color.BlanchedAlmond;
            txtCoachID.BorderStyle = BorderStyle.FixedSingle;
            txtCoachID.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtCoachID.Location = new Point(237, 62);
            txtCoachID.Margin = new Padding(4, 3, 4, 3);
            txtCoachID.Multiline = true;
            txtCoachID.Name = "txtCoachID";
            txtCoachID.Size = new Size(306, 37);
            txtCoachID.TabIndex = 0;
            txtCoachID.TextChanged += textBox1_TextChanged;
            // 
            // txtCoachClass
            // 
            txtCoachClass.Anchor = AnchorStyles.None;
            txtCoachClass.BackColor = Color.BlanchedAlmond;
            txtCoachClass.BorderStyle = BorderStyle.FixedSingle;
            txtCoachClass.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtCoachClass.Location = new Point(237, 332);
            txtCoachClass.Margin = new Padding(4, 3, 4, 3);
            txtCoachClass.Multiline = true;
            txtCoachClass.Name = "txtCoachClass";
            txtCoachClass.Size = new Size(306, 37);
            txtCoachClass.TabIndex = 4;
            // 
            // txtCoachSalary
            // 
            txtCoachSalary.Anchor = AnchorStyles.None;
            txtCoachSalary.BackColor = Color.BlanchedAlmond;
            txtCoachSalary.BorderStyle = BorderStyle.FixedSingle;
            txtCoachSalary.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtCoachSalary.Location = new Point(237, 269);
            txtCoachSalary.Margin = new Padding(4, 3, 4, 3);
            txtCoachSalary.Multiline = true;
            txtCoachSalary.Name = "txtCoachSalary";
            txtCoachSalary.Size = new Size(306, 37);
            txtCoachSalary.TabIndex = 6;
            // 
            // txtCoachName
            // 
            txtCoachName.Anchor = AnchorStyles.None;
            txtCoachName.BackColor = Color.BlanchedAlmond;
            txtCoachName.BorderStyle = BorderStyle.FixedSingle;
            txtCoachName.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtCoachName.Location = new Point(237, 137);
            txtCoachName.Margin = new Padding(4, 3, 4, 3);
            txtCoachName.Multiline = true;
            txtCoachName.Name = "txtCoachName";
            txtCoachName.Size = new Size(306, 37);
            txtCoachName.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.BlanchedAlmond;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(85, 137);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 27);
            label1.TabIndex = 8;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.BlanchedAlmond;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(85, 62);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(40, 27);
            label2.TabIndex = 9;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.BlanchedAlmond;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(66, 475);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 27);
            label3.TabIndex = 10;
            label3.Text = "Hire Date";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.BlanchedAlmond;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(63, 332);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(131, 27);
            label4.TabIndex = 11;
            label4.Text = "Class Name";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.BlanchedAlmond;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(81, 269);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(77, 27);
            label5.TabIndex = 12;
            label5.Text = "Salary";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(645, 53);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(865, 298);
            dataGridView1.TabIndex = 13;
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
            btnCoachBack.Location = new Point(352, 647);
            btnCoachBack.Margin = new Padding(4, 3, 4, 3);
            btnCoachBack.Name = "btnCoachBack";
            btnCoachBack.Size = new Size(152, 43);
            btnCoachBack.TabIndex = 14;
            btnCoachBack.Text = "Back";
            btnCoachBack.UseVisualStyleBackColor = false;
            btnCoachBack.Click += btnCoachAdd_Click;
            // 
            // btnCoachDelete
            // 
            btnCoachDelete.Anchor = AnchorStyles.None;
            btnCoachDelete.BackColor = SystemColors.GradientActiveCaption;
            btnCoachDelete.FlatAppearance.CheckedBackColor = Color.LightSkyBlue;
            btnCoachDelete.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            btnCoachDelete.FlatAppearance.MouseOverBackColor = Color.White;
            btnCoachDelete.FlatStyle = FlatStyle.Popup;
            btnCoachDelete.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCoachDelete.Location = new Point(747, 642);
            btnCoachDelete.Margin = new Padding(4, 3, 4, 3);
            btnCoachDelete.Name = "btnCoachDelete";
            btnCoachDelete.Size = new Size(152, 44);
            btnCoachDelete.TabIndex = 15;
            btnCoachDelete.Text = "Delete";
            btnCoachDelete.UseVisualStyleBackColor = false;
            btnCoachDelete.Click += btnCoachDelete_Click;
            // 
            // btnCoachUpdate
            // 
            btnCoachUpdate.Anchor = AnchorStyles.None;
            btnCoachUpdate.BackColor = SystemColors.GradientActiveCaption;
            btnCoachUpdate.FlatAppearance.CheckedBackColor = Color.LightSkyBlue;
            btnCoachUpdate.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            btnCoachUpdate.FlatAppearance.MouseOverBackColor = Color.White;
            btnCoachUpdate.FlatStyle = FlatStyle.Popup;
            btnCoachUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCoachUpdate.Location = new Point(1132, 645);
            btnCoachUpdate.Margin = new Padding(4, 3, 4, 3);
            btnCoachUpdate.Name = "btnCoachUpdate";
            btnCoachUpdate.RightToLeft = RightToLeft.Yes;
            btnCoachUpdate.Size = new Size(152, 41);
            btnCoachUpdate.TabIndex = 16;
            btnCoachUpdate.Text = "Update";
            btnCoachUpdate.UseVisualStyleBackColor = false;
            btnCoachUpdate.Click += btnCoachUpdate_Click;
            // 
            // radMale
            // 
            radMale.AutoSize = true;
            radMale.BackColor = Color.BlanchedAlmond;
            radMale.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            radMale.Location = new Point(237, 206);
            radMale.Name = "radMale";
            radMale.Size = new Size(84, 29);
            radMale.TabIndex = 18;
            radMale.TabStop = true;
            radMale.Text = "Male";
            radMale.UseVisualStyleBackColor = false;
            // 
            // radFemale
            // 
            radFemale.AutoSize = true;
            radFemale.BackColor = Color.BlanchedAlmond;
            radFemale.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            radFemale.Location = new Point(399, 206);
            radFemale.Name = "radFemale";
            radFemale.Size = new Size(106, 29);
            radFemale.TabIndex = 19;
            radFemale.TabStop = true;
            radFemale.Text = "Female";
            radFemale.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.BlanchedAlmond;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(81, 202);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(90, 27);
            label6.TabIndex = 20;
            label6.Text = "Gender";
            // 
            // HireDateCoach
            // 
            HireDateCoach.CalendarMonthBackground = Color.BlanchedAlmond;
            HireDateCoach.CustomFormat = "";
            HireDateCoach.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            HireDateCoach.Format = DateTimePickerFormat.Custom;
            HireDateCoach.ImeMode = ImeMode.NoControl;
            HireDateCoach.Location = new Point(237, 475);
            HireDateCoach.MaxDate = new DateTime(9998, 12, 16, 0, 0, 0, 0);
            HireDateCoach.Name = "HireDateCoach";
            HireDateCoach.Size = new Size(292, 34);
            HireDateCoach.TabIndex = 21;
            HireDateCoach.Value = new DateTime(2023, 5, 19, 0, 0, 0, 0);
            HireDateCoach.ValueChanged += HireDateCoach_ValueChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.BackColor = Color.BlanchedAlmond;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(19, 408);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(203, 27);
            label7.TabIndex = 23;
            label7.Text = "Nmber OF Trainee";
            // 
            // txtCoachTrainee
            // 
            txtCoachTrainee.Anchor = AnchorStyles.None;
            txtCoachTrainee.BackColor = Color.BlanchedAlmond;
            txtCoachTrainee.BorderStyle = BorderStyle.FixedSingle;
            txtCoachTrainee.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtCoachTrainee.Location = new Point(237, 408);
            txtCoachTrainee.Margin = new Padding(4, 3, 4, 3);
            txtCoachTrainee.Multiline = true;
            txtCoachTrainee.Name = "txtCoachTrainee";
            txtCoachTrainee.Size = new Size(306, 37);
            txtCoachTrainee.TabIndex = 22;
            // 
            // CoachForm
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1576, 742);
            Controls.Add(label7);
            Controls.Add(txtCoachTrainee);
            Controls.Add(HireDateCoach);
            Controls.Add(label6);
            Controls.Add(radFemale);
            Controls.Add(radMale);
            Controls.Add(btnCoachUpdate);
            Controls.Add(btnCoachDelete);
            Controls.Add(btnCoachBack);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCoachName);
            Controls.Add(txtCoachSalary);
            Controls.Add(txtCoachClass);
            Controls.Add(txtCoachID);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CoachForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CoachForm";
            Load += CoachForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCoachID;
        private TextBox txtCoachClass;
        private TextBox txtCoachHireDate;
        private TextBox txtCoachSalary;
        private TextBox txtCoachName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
        private Button btnCoachBack;
        private Button btnCoachDelete;
        private Button btnCoachUpdate;
        private RadioButton radMale;
        private RadioButton radFemale;
        private Label label6;
        private DateTimePicker HireDateCoach;
        private Label label7;
        private TextBox txtCoachTrainee;
    }
}