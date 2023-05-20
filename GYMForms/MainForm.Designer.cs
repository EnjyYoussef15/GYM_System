namespace GYM
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            toolStripMenuItem1 = new ToolStripMenuItem();
            newMemberToolStripMenuItem = new ToolStripMenuItem();
            newStaffToolStripMenuItem = new ToolStripMenuItem();
            coutchToolStripMenuItem = new ToolStripMenuItem();
            employeeToolStripMenuItem = new ToolStripMenuItem();
            searchMemberToolStripMenuItem = new ToolStripMenuItem();
            coachToolStripMenuItem = new ToolStripMenuItem();
            employeeToolStripMenuItem1 = new ToolStripMenuItem();
            traineeToolStripMenuItem = new ToolStripMenuItem();
            deleteMemberToolStripMenuItem = new ToolStripMenuItem();
            coachToolStripMenuItem1 = new ToolStripMenuItem();
            emplyeeToolStripMenuItem = new ToolStripMenuItem();
            traineeToolStripMenuItem1 = new ToolStripMenuItem();
            equipmentToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(14, 68);
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // newMemberToolStripMenuItem
            // 
            newMemberToolStripMenuItem.BackColor = Color.Silver;
            newMemberToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            newMemberToolStripMenuItem.Image = (Image)resources.GetObject("newMemberToolStripMenuItem.Image");
            newMemberToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            newMemberToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            newMemberToolStripMenuItem.Name = "newMemberToolStripMenuItem";
            newMemberToolStripMenuItem.Size = new Size(242, 68);
            newMemberToolStripMenuItem.Text = "New Trainee";
            newMemberToolStripMenuItem.Click += newMemberToolStripMenuItem_Click;
            // 
            // newStaffToolStripMenuItem
            // 
            newStaffToolStripMenuItem.BackColor = Color.FromArgb(224, 224, 224);
            newStaffToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { coutchToolStripMenuItem, employeeToolStripMenuItem });
            newStaffToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            newStaffToolStripMenuItem.Image = (Image)resources.GetObject("newStaffToolStripMenuItem.Image");
            newStaffToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            newStaffToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            newStaffToolStripMenuItem.Name = "newStaffToolStripMenuItem";
            newStaffToolStripMenuItem.Size = new Size(203, 68);
            newStaffToolStripMenuItem.Text = "New Staff";
            // 
            // coutchToolStripMenuItem
            // 
            coutchToolStripMenuItem.Name = "coutchToolStripMenuItem";
            coutchToolStripMenuItem.Size = new Size(217, 34);
            coutchToolStripMenuItem.Text = "Coach";
            coutchToolStripMenuItem.Click += coutchToolStripMenuItem_Click;
            // 
            // employeeToolStripMenuItem
            // 
            employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            employeeToolStripMenuItem.Size = new Size(217, 34);
            employeeToolStripMenuItem.Text = "Employee";
            employeeToolStripMenuItem.Click += employeeToolStripMenuItem_Click;
            // 
            // searchMemberToolStripMenuItem
            // 
            searchMemberToolStripMenuItem.BackColor = Color.Silver;
            searchMemberToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { coachToolStripMenuItem, employeeToolStripMenuItem1, traineeToolStripMenuItem });
            searchMemberToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            searchMemberToolStripMenuItem.Image = (Image)resources.GetObject("searchMemberToolStripMenuItem.Image");
            searchMemberToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            searchMemberToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            searchMemberToolStripMenuItem.Name = "searchMemberToolStripMenuItem";
            searchMemberToolStripMenuItem.Size = new Size(173, 68);
            searchMemberToolStripMenuItem.Text = "Search";
            searchMemberToolStripMenuItem.Click += searchMemberToolStripMenuItem_Click;
            // 
            // coachToolStripMenuItem
            // 
            coachToolStripMenuItem.Name = "coachToolStripMenuItem";
            coachToolStripMenuItem.Size = new Size(217, 34);
            coachToolStripMenuItem.Text = "Coach";
            coachToolStripMenuItem.Click += coachToolStripMenuItem_Click;
            // 
            // employeeToolStripMenuItem1
            // 
            employeeToolStripMenuItem1.Name = "employeeToolStripMenuItem1";
            employeeToolStripMenuItem1.Size = new Size(217, 34);
            employeeToolStripMenuItem1.Text = "Employee";
            employeeToolStripMenuItem1.Click += employeeToolStripMenuItem1_Click;
            // 
            // traineeToolStripMenuItem
            // 
            traineeToolStripMenuItem.Name = "traineeToolStripMenuItem";
            traineeToolStripMenuItem.Size = new Size(217, 34);
            traineeToolStripMenuItem.Text = "Trainee";
            traineeToolStripMenuItem.Click += traineeToolStripMenuItem_Click;
            // 
            // deleteMemberToolStripMenuItem
            // 
            deleteMemberToolStripMenuItem.BackColor = Color.FromArgb(224, 224, 224);
            deleteMemberToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { coachToolStripMenuItem1, emplyeeToolStripMenuItem, traineeToolStripMenuItem1 });
            deleteMemberToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            deleteMemberToolStripMenuItem.Image = (Image)resources.GetObject("deleteMemberToolStripMenuItem.Image");
            deleteMemberToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            deleteMemberToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            deleteMemberToolStripMenuItem.Name = "deleteMemberToolStripMenuItem";
            deleteMemberToolStripMenuItem.Size = new Size(311, 68);
            deleteMemberToolStripMenuItem.Text = "Delete And Update";
            // 
            // coachToolStripMenuItem1
            // 
            coachToolStripMenuItem1.Name = "coachToolStripMenuItem1";
            coachToolStripMenuItem1.Size = new Size(202, 34);
            coachToolStripMenuItem1.Text = "Coach";
            coachToolStripMenuItem1.Click += coachToolStripMenuItem1_Click;
            // 
            // emplyeeToolStripMenuItem
            // 
            emplyeeToolStripMenuItem.Name = "emplyeeToolStripMenuItem";
            emplyeeToolStripMenuItem.Size = new Size(202, 34);
            emplyeeToolStripMenuItem.Text = "Emplyee";
            emplyeeToolStripMenuItem.Click += emplyeeToolStripMenuItem_Click;
            // 
            // traineeToolStripMenuItem1
            // 
            traineeToolStripMenuItem1.Name = "traineeToolStripMenuItem1";
            traineeToolStripMenuItem1.Size = new Size(202, 34);
            traineeToolStripMenuItem1.Text = "Trainee";
            traineeToolStripMenuItem1.Click += traineeToolStripMenuItem1_Click;
            // 
            // equipmentToolStripMenuItem
            // 
            equipmentToolStripMenuItem.BackColor = Color.Silver;
            equipmentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, deleteToolStripMenuItem, searchToolStripMenuItem });
            equipmentToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            equipmentToolStripMenuItem.Image = (Image)resources.GetObject("equipmentToolStripMenuItem.Image");
            equipmentToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            equipmentToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            equipmentToolStripMenuItem.Name = "equipmentToolStripMenuItem";
            equipmentToolStripMenuItem.Size = new Size(216, 68);
            equipmentToolStripMenuItem.Text = "Equipment";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(182, 34);
            newToolStripMenuItem.Text = "New ";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(182, 34);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(182, 34);
            searchToolStripMenuItem.Text = "Search";
            searchToolStripMenuItem.Click += searchToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.BackColor = Color.FromArgb(224, 224, 224);
            logOutToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            logOutToolStripMenuItem.Image = (Image)resources.GetObject("logOutToolStripMenuItem.Image");
            logOutToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            logOutToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(134, 68);
            logOutToolStripMenuItem.Text = "Exit";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.BackColor = Color.Silver;
            toolStripMenuItem2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripMenuItem2.Image = (Image)resources.GetObject("toolStripMenuItem2.Image");
            toolStripMenuItem2.ImageAlign = ContentAlignment.MiddleLeft;
            toolStripMenuItem2.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(178, 68);
            toolStripMenuItem2.Text = "Log out";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.BackgroundImageLayout = ImageLayout.Center;
            menuStrip1.GripMargin = new Padding(2);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, newMemberToolStripMenuItem, newStaffToolStripMenuItem, searchMemberToolStripMenuItem, deleteMemberToolStripMenuItem, equipmentToolStripMenuItem, logOutToolStripMenuItem, toolStripMenuItem2 });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 1);
            menuStrip1.Size = new Size(1829, 72);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1829, 968);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            Load += MainPage_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem newMemberToolStripMenuItem;
        private ToolStripMenuItem newStaffToolStripMenuItem;
        private ToolStripMenuItem coutchToolStripMenuItem;
        private ToolStripMenuItem employeeToolStripMenuItem;
        private ToolStripMenuItem searchMemberToolStripMenuItem;
        private ToolStripMenuItem coachToolStripMenuItem;
        private ToolStripMenuItem employeeToolStripMenuItem1;
        private ToolStripMenuItem traineeToolStripMenuItem;
        private ToolStripMenuItem deleteMemberToolStripMenuItem;
        private ToolStripMenuItem coachToolStripMenuItem1;
        private ToolStripMenuItem emplyeeToolStripMenuItem;
        private ToolStripMenuItem traineeToolStripMenuItem1;
        private ToolStripMenuItem equipmentToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private MenuStrip menuStrip1;
    }
}

