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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnEquSearch = new Button();
            textBox1 = new TextBox();
            grdEqupSearch = new DataGridView();
            btnEquRefresh = new Button();
            Btn_equipment_back_equipment = new Button();
            ((System.ComponentModel.ISupportInitialize)grdEqupSearch).BeginInit();
            SuspendLayout();
            // 
            // btnEquSearch
            // 
            btnEquSearch.BackColor = SystemColors.Highlight;
            btnEquSearch.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEquSearch.ForeColor = Color.White;
            btnEquSearch.Location = new Point(349, 36);
            btnEquSearch.Margin = new Padding(4, 5, 4, 5);
            btnEquSearch.Name = "btnEquSearch";
            btnEquSearch.Size = new Size(140, 55);
            btnEquSearch.TabIndex = 0;
            btnEquSearch.Text = "Search";
            btnEquSearch.UseVisualStyleBackColor = false;
            btnEquSearch.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(544, 36);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(293, 54);
            textBox1.TabIndex = 1;
            // 
            // grdEqupSearch
            // 
            grdEqupSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdEqupSearch.Location = new Point(216, 128);
            grdEqupSearch.Margin = new Padding(4, 5, 4, 5);
            grdEqupSearch.Name = "grdEqupSearch";
            grdEqupSearch.RowHeadersWidth = 51;
            grdEqupSearch.Size = new Size(971, 435);
            grdEqupSearch.TabIndex = 2;
            // 
            // btnEquRefresh
            // 
            btnEquRefresh.BackColor = SystemColors.Highlight;
            btnEquRefresh.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEquRefresh.ForeColor = Color.White;
            btnEquRefresh.Location = new Point(906, 36);
            btnEquRefresh.Margin = new Padding(4, 5, 4, 5);
            btnEquRefresh.Name = "btnEquRefresh";
            btnEquRefresh.Size = new Size(140, 55);
            btnEquRefresh.TabIndex = 3;
            btnEquRefresh.Text = "Refresh";
            btnEquRefresh.UseVisualStyleBackColor = false;
            // 
            // Btn_equipment_back_equipment
            // 
            Btn_equipment_back_equipment.BackColor = SystemColors.Highlight;
            Btn_equipment_back_equipment.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_equipment_back_equipment.ForeColor = Color.White;
            Btn_equipment_back_equipment.Location = new Point(105, 613);
            Btn_equipment_back_equipment.Margin = new Padding(4, 5, 4, 5);
            Btn_equipment_back_equipment.Name = "Btn_equipment_back_equipment";
            Btn_equipment_back_equipment.Size = new Size(197, 65);
            Btn_equipment_back_equipment.TabIndex = 14;
            Btn_equipment_back_equipment.Text = "Back ";
            Btn_equipment_back_equipment.UseVisualStyleBackColor = false;
            Btn_equipment_back_equipment.Click += Btn_equipment_back_equipment_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1576, 742);
            Controls.Add(Btn_equipment_back_equipment);
            Controls.Add(btnEquRefresh);
            Controls.Add(grdEqupSearch);
            Controls.Add(textBox1);
            Controls.Add(btnEquSearch);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)grdEqupSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnEquSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView grdEqupSearch;
        private System.Windows.Forms.Button btnEquRefresh;
        private System.Windows.Forms.Button Btn_equipment_back_equipment;
    }
}