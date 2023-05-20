namespace Fitness
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            txtSearch_Search = new TextBox();
            btnSearch_Search = new Button();
            grdTraineeSearch = new DataGridView();
            btnSearchBack = new Button();
            btnSearchRe = new Button();
            ((System.ComponentModel.ISupportInitialize)grdTraineeSearch).BeginInit();
            SuspendLayout();
            // 
            // txtSearch_Search
            // 
            txtSearch_Search.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch_Search.Location = new Point(531, 108);
            txtSearch_Search.Margin = new Padding(4, 5, 4, 5);
            txtSearch_Search.Name = "txtSearch_Search";
            txtSearch_Search.Size = new Size(533, 34);
            txtSearch_Search.TabIndex = 0;
            // 
            // btnSearch_Search
            // 
            btnSearch_Search.BackColor = Color.Beige;
            btnSearch_Search.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch_Search.ForeColor = Color.White;
            btnSearch_Search.Image = (Image)resources.GetObject("btnSearch_Search.Image");
            btnSearch_Search.Location = new Point(242, 108);
            btnSearch_Search.Margin = new Padding(4, 5, 4, 5);
            btnSearch_Search.Name = "btnSearch_Search";
            btnSearch_Search.Size = new Size(193, 55);
            btnSearch_Search.TabIndex = 1;
            btnSearch_Search.Text = "Search";
            btnSearch_Search.UseVisualStyleBackColor = false;
            btnSearch_Search.Click += btnSearch_Search_Click;
            // 
            // grdTraineeSearch
            // 
            grdTraineeSearch.BackgroundColor = Color.FromArgb(224, 224, 224);
            grdTraineeSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdTraineeSearch.Location = new Point(150, 226);
            grdTraineeSearch.Margin = new Padding(4, 5, 4, 5);
            grdTraineeSearch.Name = "grdTraineeSearch";
            grdTraineeSearch.RowHeadersWidth = 51;
            grdTraineeSearch.Size = new Size(1284, 378);
            grdTraineeSearch.TabIndex = 2;
            // 
            // btnSearchBack
            // 
            btnSearchBack.BackColor = Color.Beige;
            btnSearchBack.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearchBack.ForeColor = Color.White;
            btnSearchBack.Image = (Image)resources.GetObject("btnSearchBack.Image");
            btnSearchBack.Location = new Point(111, 671);
            btnSearchBack.Margin = new Padding(4, 5, 4, 5);
            btnSearchBack.Name = "btnSearchBack";
            btnSearchBack.Size = new Size(193, 55);
            btnSearchBack.TabIndex = 3;
            btnSearchBack.Text = "Back";
            btnSearchBack.UseVisualStyleBackColor = false;
            btnSearchBack.Click += btnSearchFromBack_Click;
            // 
            // btnSearchRe
            // 
            btnSearchRe.BackColor = Color.Beige;
            btnSearchRe.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearchRe.ForeColor = Color.White;
            btnSearchRe.Image = (Image)resources.GetObject("btnSearchRe.Image");
            btnSearchRe.Location = new Point(1174, 108);
            btnSearchRe.Margin = new Padding(4, 5, 4, 5);
            btnSearchRe.Name = "btnSearchRe";
            btnSearchRe.Size = new Size(193, 55);
            btnSearchRe.TabIndex = 4;
            btnSearchRe.Text = "Refresh";
            btnSearchRe.UseVisualStyleBackColor = false;
            btnSearchRe.Click += btnSearchFormReset_Click;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1576, 742);
            Controls.Add(btnSearchRe);
            Controls.Add(btnSearchBack);
            Controls.Add(grdTraineeSearch);
            Controls.Add(btnSearch_Search);
            Controls.Add(txtSearch_Search);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SearchForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)grdTraineeSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch_Search;
        private System.Windows.Forms.Button btnSearch_Search;
        private System.Windows.Forms.DataGridView grdTraineeSearch;
        private System.Windows.Forms.Button btnSearchBack;
        private System.Windows.Forms.Button btnSearchRe;
    }
}