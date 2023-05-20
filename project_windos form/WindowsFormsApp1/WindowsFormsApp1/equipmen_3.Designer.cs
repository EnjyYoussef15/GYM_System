namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btnEquSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEquRefresh = new System.Windows.Forms.Button();
            this.Btn_equipment_back_equipment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEquSearch
            // 
            this.btnEquSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEquSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquSearch.ForeColor = System.Drawing.Color.White;
            this.btnEquSearch.Location = new System.Drawing.Point(349, 29);
            this.btnEquSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEquSearch.Name = "btnEquSearch";
            this.btnEquSearch.Size = new System.Drawing.Size(140, 44);
            this.btnEquSearch.TabIndex = 0;
            this.btnEquSearch.Text = "Search";
            this.btnEquSearch.UseVisualStyleBackColor = false;
            this.btnEquSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(544, 29);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 44);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(216, 102);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(971, 446);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnEquRefresh
            // 
            this.btnEquRefresh.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEquRefresh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquRefresh.ForeColor = System.Drawing.Color.White;
            this.btnEquRefresh.Location = new System.Drawing.Point(906, 29);
            this.btnEquRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnEquRefresh.Name = "btnEquRefresh";
            this.btnEquRefresh.Size = new System.Drawing.Size(140, 44);
            this.btnEquRefresh.TabIndex = 3;
            this.btnEquRefresh.Text = "Refresh";
            this.btnEquRefresh.UseVisualStyleBackColor = false;
            // 
            // Btn_equipment_back_equipment
            // 
            this.Btn_equipment_back_equipment.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_equipment_back_equipment.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_equipment_back_equipment.ForeColor = System.Drawing.Color.White;
            this.Btn_equipment_back_equipment.Location = new System.Drawing.Point(121, 665);
            this.Btn_equipment_back_equipment.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_equipment_back_equipment.Name = "Btn_equipment_back_equipment";
            this.Btn_equipment_back_equipment.Size = new System.Drawing.Size(197, 52);
            this.Btn_equipment_back_equipment.TabIndex = 14;
            this.Btn_equipment_back_equipment.Text = "Back ";
            this.Btn_equipment_back_equipment.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._72;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1420, 763);
            this.Controls.Add(this.Btn_equipment_back_equipment);
            this.Controls.Add(this.btnEquRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnEquSearch);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEquSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEquRefresh;
        private System.Windows.Forms.Button Btn_equipment_back_equipment;
    }
}