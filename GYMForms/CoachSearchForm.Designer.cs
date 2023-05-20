namespace GYMForms
{
    partial class CoachSearchForm
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
            btnCoachSearch = new Button();
            btnCoachBack = new Button();
            txtCoachSearch = new TextBox();
            btnCoachRefresh = new Button();
            grdCoachSearch = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grdCoachSearch).BeginInit();
            SuspendLayout();
            // 
            // btnCoachSearch
            // 
            btnCoachSearch.Anchor = AnchorStyles.None;
            btnCoachSearch.BackColor = SystemColors.GradientActiveCaption;
            btnCoachSearch.FlatAppearance.CheckedBackColor = Color.LightSkyBlue;
            btnCoachSearch.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            btnCoachSearch.FlatAppearance.MouseOverBackColor = Color.White;
            btnCoachSearch.FlatStyle = FlatStyle.Popup;
            btnCoachSearch.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCoachSearch.Location = new Point(414, 68);
            btnCoachSearch.Margin = new Padding(4, 3, 4, 3);
            btnCoachSearch.Name = "btnCoachSearch";
            btnCoachSearch.Size = new Size(152, 44);
            btnCoachSearch.TabIndex = 35;
            btnCoachSearch.Text = "Search";
            btnCoachSearch.UseVisualStyleBackColor = false;
            btnCoachSearch.Click += btnCoachSearch_Click;
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
            btnCoachBack.Location = new Point(98, 655);
            btnCoachBack.Margin = new Padding(4, 3, 4, 3);
            btnCoachBack.Name = "btnCoachBack";
            btnCoachBack.Size = new Size(152, 43);
            btnCoachBack.TabIndex = 34;
            btnCoachBack.Text = "Back";
            btnCoachBack.UseVisualStyleBackColor = false;
            btnCoachBack.Click += btnCoachBack_Click;
            // 
            // txtCoachSearch
            // 
            txtCoachSearch.Anchor = AnchorStyles.None;
            txtCoachSearch.BackColor = Color.BlanchedAlmond;
            txtCoachSearch.BorderStyle = BorderStyle.FixedSingle;
            txtCoachSearch.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtCoachSearch.Location = new Point(653, 74);
            txtCoachSearch.Margin = new Padding(4, 3, 4, 3);
            txtCoachSearch.Multiline = true;
            txtCoachSearch.Name = "txtCoachSearch";
            txtCoachSearch.Size = new Size(306, 37);
            txtCoachSearch.TabIndex = 24;
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
            btnCoachRefresh.Location = new Point(1054, 70);
            btnCoachRefresh.Margin = new Padding(4, 3, 4, 3);
            btnCoachRefresh.Name = "btnCoachRefresh";
            btnCoachRefresh.RightToLeft = RightToLeft.Yes;
            btnCoachRefresh.Size = new Size(152, 41);
            btnCoachRefresh.TabIndex = 36;
            btnCoachRefresh.Text = "Refresh";
            btnCoachRefresh.UseVisualStyleBackColor = false;
            btnCoachRefresh.Click += btnCoachRefresh_Click;
            // 
            // grdCoachSearch
            // 
            grdCoachSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdCoachSearch.Location = new Point(333, 128);
            grdCoachSearch.Name = "grdCoachSearch";
            grdCoachSearch.RowHeadersWidth = 51;
            grdCoachSearch.RowTemplate.Height = 29;
            grdCoachSearch.Size = new Size(926, 286);
            grdCoachSearch.TabIndex = 37;
            // 
            // CoachSearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1617790968609;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1576, 742);
            Controls.Add(grdCoachSearch);
            Controls.Add(btnCoachRefresh);
            Controls.Add(btnCoachSearch);
            Controls.Add(btnCoachBack);
            Controls.Add(txtCoachSearch);
            Name = "CoachSearchForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CoachSearchForm";
            Load += CoachSearchForm_Load;
            ((System.ComponentModel.ISupportInitialize)grdCoachSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCoachRefresh;
        private Button btnCoachSearch;
        private Button btnCoachBack;
        private TextBox txtCoachSearch;
        private DataGridView grdCoachSearch;
    }
}