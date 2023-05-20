namespace WindowsFormsApp1
{
    partial class equipment_2
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(equipment_2));
            Lbl_equipment_total_price = new Label();
            Btn_equipment_update = new Button();
            Lbl_equipment_price = new Label();
            Lbl_Delivery_date = new Label();
            Lbl_equipment_product_number = new Label();
            Lbl_equipment_equipment_name = new Label();
            Txt_equipment_total_price = new TextBox();
            Btn_equipment_delete = new Button();
            Txt_equipment_price = new TextBox();
            Txt_equipment_delivery = new DateTimePicker();
            Txt_equipment_product_num = new TextBox();
            Txt_equipment_equipmentname = new TextBox();
            Btn_equipment_Back = new Button();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            grdEqupUpdate = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grdEqupUpdate).BeginInit();
            SuspendLayout();
            // 
            // Lbl_equipment_total_price
            // 
            Lbl_equipment_total_price.AutoSize = true;
            Lbl_equipment_total_price.BackColor = Color.Transparent;
            Lbl_equipment_total_price.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_equipment_total_price.ForeColor = SystemColors.ControlLightLight;
            Lbl_equipment_total_price.Location = new Point(70, 337);
            Lbl_equipment_total_price.Margin = new Padding(4, 0, 4, 0);
            Lbl_equipment_total_price.Name = "Lbl_equipment_total_price";
            Lbl_equipment_total_price.Size = new Size(141, 31);
            Lbl_equipment_total_price.TabIndex = 30;
            Lbl_equipment_total_price.Text = "Total price";
            // 
            // Btn_equipment_update
            // 
            Btn_equipment_update.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_equipment_update.Location = new Point(685, 600);
            Btn_equipment_update.Margin = new Padding(4, 5, 4, 5);
            Btn_equipment_update.Name = "Btn_equipment_update";
            Btn_equipment_update.Size = new Size(147, 49);
            Btn_equipment_update.TabIndex = 26;
            Btn_equipment_update.Text = "Update";
            Btn_equipment_update.UseVisualStyleBackColor = true;
            // 
            // Lbl_equipment_price
            // 
            Lbl_equipment_price.AutoSize = true;
            Lbl_equipment_price.BackColor = Color.Transparent;
            Lbl_equipment_price.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_equipment_price.ForeColor = SystemColors.ControlLightLight;
            Lbl_equipment_price.Location = new Point(78, 220);
            Lbl_equipment_price.Margin = new Padding(4, 0, 4, 0);
            Lbl_equipment_price.Name = "Lbl_equipment_price";
            Lbl_equipment_price.Size = new Size(75, 31);
            Lbl_equipment_price.TabIndex = 20;
            Lbl_equipment_price.Text = "Price";
            // 
            // Lbl_Delivery_date
            // 
            Lbl_Delivery_date.AutoSize = true;
            Lbl_Delivery_date.BackColor = Color.Transparent;
            Lbl_Delivery_date.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Delivery_date.ForeColor = SystemColors.ControlLightLight;
            Lbl_Delivery_date.Location = new Point(62, 449);
            Lbl_Delivery_date.Margin = new Padding(4, 0, 4, 0);
            Lbl_Delivery_date.Name = "Lbl_Delivery_date";
            Lbl_Delivery_date.Size = new Size(170, 31);
            Lbl_Delivery_date.TabIndex = 19;
            Lbl_Delivery_date.Text = "Delivery date";
            // 
            // Lbl_equipment_product_number
            // 
            Lbl_equipment_product_number.AutoSize = true;
            Lbl_equipment_product_number.BackColor = Color.Transparent;
            Lbl_equipment_product_number.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_equipment_product_number.ForeColor = SystemColors.ControlLightLight;
            Lbl_equipment_product_number.Location = new Point(47, 130);
            Lbl_equipment_product_number.Margin = new Padding(4, 0, 4, 0);
            Lbl_equipment_product_number.Name = "Lbl_equipment_product_number";
            Lbl_equipment_product_number.Size = new Size(181, 26);
            Lbl_equipment_product_number.TabIndex = 17;
            Lbl_equipment_product_number.Text = "Product number";
            Lbl_equipment_product_number.Click += Lbl_equipment_product_number_Click;
            // 
            // Lbl_equipment_equipment_name
            // 
            Lbl_equipment_equipment_name.AutoSize = true;
            Lbl_equipment_equipment_name.BackColor = Color.Transparent;
            Lbl_equipment_equipment_name.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_equipment_equipment_name.ForeColor = SystemColors.ControlLightLight;
            Lbl_equipment_equipment_name.Location = new Point(47, 48);
            Lbl_equipment_equipment_name.Margin = new Padding(4, 0, 4, 0);
            Lbl_equipment_equipment_name.Name = "Lbl_equipment_equipment_name";
            Lbl_equipment_equipment_name.Size = new Size(186, 26);
            Lbl_equipment_equipment_name.TabIndex = 16;
            Lbl_equipment_equipment_name.Text = "Equipment name";
            Lbl_equipment_equipment_name.Click += Lbl_equipment_equipment_name_Click;
            // 
            // Txt_equipment_total_price
            // 
            Txt_equipment_total_price.BackColor = SystemColors.ScrollBar;
            Txt_equipment_total_price.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_equipment_total_price.Location = new Point(237, 333);
            Txt_equipment_total_price.Margin = new Padding(4, 5, 4, 5);
            Txt_equipment_total_price.Name = "Txt_equipment_total_price";
            Txt_equipment_total_price.Size = new Size(251, 35);
            Txt_equipment_total_price.TabIndex = 37;
            // 
            // Btn_equipment_delete
            // 
            Btn_equipment_delete.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_equipment_delete.Location = new Point(1029, 600);
            Btn_equipment_delete.Margin = new Padding(4, 5, 4, 5);
            Btn_equipment_delete.Name = "Btn_equipment_delete";
            Btn_equipment_delete.Size = new Size(153, 49);
            Btn_equipment_delete.TabIndex = 36;
            Btn_equipment_delete.Text = "Delete";
            Btn_equipment_delete.UseVisualStyleBackColor = true;
            // 
            // Txt_equipment_price
            // 
            Txt_equipment_price.BackColor = Color.Silver;
            Txt_equipment_price.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_equipment_price.ForeColor = Color.Gainsboro;
            Txt_equipment_price.Location = new Point(236, 220);
            Txt_equipment_price.Margin = new Padding(4, 5, 4, 5);
            Txt_equipment_price.Name = "Txt_equipment_price";
            Txt_equipment_price.Size = new Size(251, 35);
            Txt_equipment_price.TabIndex = 35;
            // 
            // Txt_equipment_delivery
            // 
            Txt_equipment_delivery.CalendarMonthBackground = Color.White;
            Txt_equipment_delivery.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_equipment_delivery.Format = DateTimePickerFormat.Short;
            Txt_equipment_delivery.Location = new Point(240, 449);
            Txt_equipment_delivery.Margin = new Padding(4, 5, 4, 5);
            Txt_equipment_delivery.Name = "Txt_equipment_delivery";
            Txt_equipment_delivery.Size = new Size(251, 35);
            Txt_equipment_delivery.TabIndex = 34;
            // 
            // Txt_equipment_product_num
            // 
            Txt_equipment_product_num.BackColor = Color.LightGray;
            Txt_equipment_product_num.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_equipment_product_num.Location = new Point(240, 127);
            Txt_equipment_product_num.Margin = new Padding(4, 5, 4, 5);
            Txt_equipment_product_num.Name = "Txt_equipment_product_num";
            Txt_equipment_product_num.Size = new Size(247, 35);
            Txt_equipment_product_num.TabIndex = 32;
            // 
            // Txt_equipment_equipmentname
            // 
            Txt_equipment_equipmentname.BackColor = SystemColors.ScrollBar;
            Txt_equipment_equipmentname.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_equipment_equipmentname.Location = new Point(240, 48);
            Txt_equipment_equipmentname.Margin = new Padding(4, 5, 4, 5);
            Txt_equipment_equipmentname.Name = "Txt_equipment_equipmentname";
            Txt_equipment_equipmentname.Size = new Size(248, 35);
            Txt_equipment_equipmentname.TabIndex = 31;
            // 
            // Btn_equipment_Back
            // 
            Btn_equipment_Back.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_equipment_Back.Location = new Point(326, 600);
            Btn_equipment_Back.Margin = new Padding(4, 5, 4, 5);
            Btn_equipment_Back.Name = "Btn_equipment_Back";
            Btn_equipment_Back.Size = new Size(147, 49);
            Btn_equipment_Back.TabIndex = 39;
            Btn_equipment_Back.Text = "Back";
            Btn_equipment_Back.UseVisualStyleBackColor = true;
            Btn_equipment_Back.Click += Btn_equipment_Back_Click;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.FillWeight = 120F;
            Column5.HeaderText = "Delivery date";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.FillWeight = 90F;
            Column4.HeaderText = "total price";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 50F;
            Column3.HeaderText = "price";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.FillWeight = 120F;
            Column2.HeaderText = "product number";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 130F;
            Column1.HeaderText = "Equipment name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // grdEqupUpdate
            // 
            grdEqupUpdate.AllowUserToAddRows = false;
            grdEqupUpdate.AllowUserToDeleteRows = false;
            grdEqupUpdate.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grdEqupUpdate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grdEqupUpdate.ColumnHeadersHeight = 40;
            grdEqupUpdate.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            grdEqupUpdate.DefaultCellStyle = dataGridViewCellStyle2;
            grdEqupUpdate.Location = new Point(539, 92);
            grdEqupUpdate.Margin = new Padding(4, 5, 4, 5);
            grdEqupUpdate.Name = "grdEqupUpdate";
            grdEqupUpdate.ReadOnly = true;
            grdEqupUpdate.RowHeadersWidth = 51;
            grdEqupUpdate.Size = new Size(827, 345);
            grdEqupUpdate.TabIndex = 38;
            grdEqupUpdate.CellContentClick += dataGridView1_CellContentClick;
            // 
            // equipment_2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1576, 742);
            Controls.Add(Btn_equipment_Back);
            Controls.Add(grdEqupUpdate);
            Controls.Add(Txt_equipment_total_price);
            Controls.Add(Btn_equipment_delete);
            Controls.Add(Txt_equipment_price);
            Controls.Add(Txt_equipment_delivery);
            Controls.Add(Txt_equipment_product_num);
            Controls.Add(Txt_equipment_equipmentname);
            Controls.Add(Lbl_equipment_total_price);
            Controls.Add(Btn_equipment_update);
            Controls.Add(Lbl_equipment_price);
            Controls.Add(Lbl_Delivery_date);
            Controls.Add(Lbl_equipment_product_number);
            Controls.Add(Lbl_equipment_equipment_name);
            Margin = new Padding(4, 5, 4, 5);
            Name = "equipment_2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "equipment_2";
            ((System.ComponentModel.ISupportInitialize)grdEqupUpdate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label Lbl_equipment_total_price;
        private System.Windows.Forms.Button Btn_equipment_update;
        private System.Windows.Forms.Label Lbl_equipment_price;
        private System.Windows.Forms.Label Lbl_Delivery_date;
        private System.Windows.Forms.Label Lbl_equipment_product_number;
        private System.Windows.Forms.Label Lbl_equipment_equipment_name;
        private System.Windows.Forms.TextBox Txt_equipment_total_price;
        private System.Windows.Forms.Button Btn_equipment_delete;
        private System.Windows.Forms.TextBox Txt_equipment_price;
        private System.Windows.Forms.DateTimePicker Txt_equipment_delivery;
        private System.Windows.Forms.TextBox Txt_equipment_product_num;
        private System.Windows.Forms.TextBox Txt_equipment_equipmentname;
        private System.Windows.Forms.Button Btn_equipment_Back;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridView grdEqupUpdate;
    }
}