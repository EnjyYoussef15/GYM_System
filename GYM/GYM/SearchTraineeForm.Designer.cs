namespace GYM
{
    partial class SearchTraineeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchTraineeForm));
            this.btnSearchReset = new System.Windows.Forms.Button();
            this.btnSearchBack = new System.Windows.Forms.Button();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.btnSearch_Search = new System.Windows.Forms.Button();
            this.txtSearch_Search = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchReset
            // 
            this.btnSearchReset.BackColor = System.Drawing.Color.Beige;
            this.btnSearchReset.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.btnSearchReset.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchReset.Image")));
            this.btnSearchReset.Location = new System.Drawing.Point(816, 290);
            this.btnSearchReset.Name = "btnSearchReset";
            this.btnSearchReset.Size = new System.Drawing.Size(109, 36);
            this.btnSearchReset.TabIndex = 9;
            this.btnSearchReset.Text = "Reset";
            this.btnSearchReset.UseVisualStyleBackColor = false;
            this.btnSearchReset.Click += new System.EventHandler(this.btnSearchReset_Click);
            // 
            // btnSearchBack
            // 
            this.btnSearchBack.BackColor = System.Drawing.Color.Beige;
            this.btnSearchBack.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.btnSearchBack.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchBack.Image")));
            this.btnSearchBack.Location = new System.Drawing.Point(451, 290);
            this.btnSearchBack.Name = "btnSearchBack";
            this.btnSearchBack.Size = new System.Drawing.Size(109, 36);
            this.btnSearchBack.TabIndex = 8;
            this.btnSearchBack.Text = "Back";
            this.btnSearchBack.UseVisualStyleBackColor = false;
            this.btnSearchBack.Click += new System.EventHandler(this.btnSearchBack_Click);
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Location = new System.Drawing.Point(12, 374);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.Size = new System.Drawing.Size(995, 305);
            this.dataGridViewSearch.TabIndex = 7;
            // 
            // btnSearch_Search
            // 
            this.btnSearch_Search.BackColor = System.Drawing.Color.Beige;
            this.btnSearch_Search.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.btnSearch_Search.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch_Search.Image")));
            this.btnSearch_Search.Location = new System.Drawing.Point(637, 290);
            this.btnSearch_Search.Name = "btnSearch_Search";
            this.btnSearch_Search.Size = new System.Drawing.Size(109, 36);
            this.btnSearch_Search.TabIndex = 6;
            this.btnSearch_Search.Text = "Search";
            this.btnSearch_Search.UseVisualStyleBackColor = false;
            // 
            // txtSearch_Search
            // 
            this.txtSearch_Search.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.txtSearch_Search.Location = new System.Drawing.Point(514, 207);
            this.txtSearch_Search.Name = "txtSearch_Search";
            this.txtSearch_Search.Size = new System.Drawing.Size(365, 35);
            this.txtSearch_Search.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(547, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 158);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // SearchTraineeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1019, 726);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSearchReset);
            this.Controls.Add(this.btnSearchBack);
            this.Controls.Add(this.dataGridViewSearch);
            this.Controls.Add(this.btnSearch_Search);
            this.Controls.Add(this.txtSearch_Search);
            this.Name = "SearchTraineeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchTraineeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchReset;
        private System.Windows.Forms.Button btnSearchBack;
        private System.Windows.Forms.DataGridView dataGridViewSearch;
        private System.Windows.Forms.Button btnSearch_Search;
        private System.Windows.Forms.TextBox txtSearch_Search;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}