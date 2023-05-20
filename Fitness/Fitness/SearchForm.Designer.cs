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
            this.txtSearch_Search = new System.Windows.Forms.TextBox();
            this.btnSearch_Search = new System.Windows.Forms.Button();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.btnSearchBack = new System.Windows.Forms.Button();
            this.btnSearchRe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch_Search
            // 
            this.txtSearch_Search.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch_Search.Location = new System.Drawing.Point(531, 86);
            this.txtSearch_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch_Search.Name = "txtSearch_Search";
            this.txtSearch_Search.Size = new System.Drawing.Size(533, 34);
            this.txtSearch_Search.TabIndex = 0;
            // 
            // btnSearch_Search
            // 
            this.btnSearch_Search.BackColor = System.Drawing.Color.Beige;
            this.btnSearch_Search.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch_Search.ForeColor = System.Drawing.Color.White;
            this.btnSearch_Search.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch_Search.Image")));
            this.btnSearch_Search.Location = new System.Drawing.Point(242, 86);
            this.btnSearch_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch_Search.Name = "btnSearch_Search";
            this.btnSearch_Search.Size = new System.Drawing.Size(193, 44);
            this.btnSearch_Search.TabIndex = 1;
            this.btnSearch_Search.Text = "Search";
            this.btnSearch_Search.UseVisualStyleBackColor = false;
            this.btnSearch_Search.Click += new System.EventHandler(this.btnSearch_Search_Click);
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Location = new System.Drawing.Point(21, 219);
            this.dataGridViewSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.RowHeadersWidth = 51;
            this.dataGridViewSearch.Size = new System.Drawing.Size(1569, 302);
            this.dataGridViewSearch.TabIndex = 2;
            // 
            // btnSearchBack
            // 
            this.btnSearchBack.BackColor = System.Drawing.Color.Beige;
            this.btnSearchBack.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBack.ForeColor = System.Drawing.Color.White;
            this.btnSearchBack.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchBack.Image")));
            this.btnSearchBack.Location = new System.Drawing.Point(100, 678);
            this.btnSearchBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchBack.Name = "btnSearchBack";
            this.btnSearchBack.Size = new System.Drawing.Size(193, 44);
            this.btnSearchBack.TabIndex = 3;
            this.btnSearchBack.Text = "Back";
            this.btnSearchBack.UseVisualStyleBackColor = false;
            this.btnSearchBack.Click += new System.EventHandler(this.btnSearchFromBack_Click);
            // 
            // btnSearchRe
            // 
            this.btnSearchRe.BackColor = System.Drawing.Color.Beige;
            this.btnSearchRe.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchRe.ForeColor = System.Drawing.Color.White;
            this.btnSearchRe.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchRe.Image")));
            this.btnSearchRe.Location = new System.Drawing.Point(1174, 86);
            this.btnSearchRe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchRe.Name = "btnSearchRe";
            this.btnSearchRe.Size = new System.Drawing.Size(193, 44);
            this.btnSearchRe.TabIndex = 4;
            this.btnSearchRe.Text = "Refresh";
            this.btnSearchRe.UseVisualStyleBackColor = false;
            this.btnSearchRe.Click += new System.EventHandler(this.btnSearchFormReset_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1603, 788);
            this.Controls.Add(this.btnSearchRe);
            this.Controls.Add(this.btnSearchBack);
            this.Controls.Add(this.dataGridViewSearch);
            this.Controls.Add(this.btnSearch_Search);
            this.Controls.Add(this.txtSearch_Search);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch_Search;
        private System.Windows.Forms.Button btnSearch_Search;
        private System.Windows.Forms.DataGridView dataGridViewSearch;
        private System.Windows.Forms.Button btnSearchBack;
        private System.Windows.Forms.Button btnSearchRe;
    }
}