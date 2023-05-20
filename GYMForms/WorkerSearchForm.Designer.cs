namespace GYMForms
{
    partial class WorkerSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerSearchForm));
            btnWorkerSearch = new Button();
            btnWorkerBack = new Button();
            grdWorkerSearch = new DataGridView();
            txtWorkerSearch = new TextBox();
            btnCoachRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)grdWorkerSearch).BeginInit();
            SuspendLayout();
            // 
            // btnWorkerSearch
            // 
            btnWorkerSearch.Anchor = AnchorStyles.None;
            btnWorkerSearch.BackColor = SystemColors.GradientActiveCaption;
            btnWorkerSearch.FlatAppearance.CheckedBackColor = Color.LightSkyBlue;
            btnWorkerSearch.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            btnWorkerSearch.FlatAppearance.MouseOverBackColor = Color.White;
            btnWorkerSearch.FlatStyle = FlatStyle.Popup;
            btnWorkerSearch.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnWorkerSearch.Location = new Point(335, 126);
            btnWorkerSearch.Margin = new Padding(6, 4, 6, 4);
            btnWorkerSearch.Name = "btnWorkerSearch";
            btnWorkerSearch.RightToLeft = RightToLeft.Yes;
            btnWorkerSearch.Size = new Size(209, 45);
            btnWorkerSearch.TabIndex = 53;
            btnWorkerSearch.Text = "Search";
            btnWorkerSearch.UseVisualStyleBackColor = false;
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
            btnWorkerBack.Location = new Point(97, 533);
            btnWorkerBack.Margin = new Padding(6, 4, 6, 4);
            btnWorkerBack.Name = "btnWorkerBack";
            btnWorkerBack.Size = new Size(209, 48);
            btnWorkerBack.TabIndex = 51;
            btnWorkerBack.Text = "Back";
            btnWorkerBack.UseVisualStyleBackColor = false;
            btnWorkerBack.Click += btnWorkerBack_Click;
            // 
            // grdWorkerSearch
            // 
            grdWorkerSearch.Anchor = AnchorStyles.None;
            grdWorkerSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdWorkerSearch.Location = new Point(277, 199);
            grdWorkerSearch.Margin = new Padding(6, 4, 6, 4);
            grdWorkerSearch.Name = "grdWorkerSearch";
            grdWorkerSearch.RowHeadersWidth = 51;
            grdWorkerSearch.RowTemplate.Height = 29;
            grdWorkerSearch.Size = new Size(1189, 278);
            grdWorkerSearch.TabIndex = 50;
            // 
            // txtWorkerSearch
            // 
            txtWorkerSearch.Anchor = AnchorStyles.None;
            txtWorkerSearch.BackColor = Color.White;
            txtWorkerSearch.BorderStyle = BorderStyle.FixedSingle;
            txtWorkerSearch.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtWorkerSearch.Location = new Point(636, 126);
            txtWorkerSearch.Margin = new Padding(6, 4, 6, 4);
            txtWorkerSearch.Multiline = true;
            txtWorkerSearch.Name = "txtWorkerSearch";
            txtWorkerSearch.Size = new Size(420, 36);
            txtWorkerSearch.TabIndex = 41;
            // 
            // btnCoachRefresh
            // 
            btnCoachRefresh.Anchor = AnchorStyles.None;
            btnCoachRefresh.BackColor = SystemColors.GradientActiveCaption;
            btnCoachRefresh.FlatAppearance.CheckedBackColor = Color.LightSkyBlue;
            btnCoachRefresh.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            btnCoachRefresh.FlatAppearance.MouseOverBackColor = Color.White;
            btnCoachRefresh.FlatStyle = FlatStyle.Popup;
            btnCoachRefresh.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCoachRefresh.Location = new Point(1153, 126);
            btnCoachRefresh.Margin = new Padding(6, 4, 6, 4);
            btnCoachRefresh.Name = "btnCoachRefresh";
            btnCoachRefresh.RightToLeft = RightToLeft.Yes;
            btnCoachRefresh.Size = new Size(209, 45);
            btnCoachRefresh.TabIndex = 54;
            btnCoachRefresh.Text = "Refresh";
            btnCoachRefresh.UseVisualStyleBackColor = false;
            btnCoachRefresh.Click += btnCoachRefresh_Click;
            // 
            // WorkerSearchForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1576, 742);
            Controls.Add(btnCoachRefresh);
            Controls.Add(btnWorkerSearch);
            Controls.Add(btnWorkerBack);
            Controls.Add(grdWorkerSearch);
            Controls.Add(txtWorkerSearch);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "WorkerSearchForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "WorkerSearchForm";
            Load += WorkerSearchForm_Load;
            ((System.ComponentModel.ISupportInitialize)grdWorkerSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnWorkerSearch;
        private Button btnWorkerBack;
        private DataGridView grdWorkerSearch;
        private TextBox txtWorkerSearch;
        private Button btnCoachRefresh;
    }
}