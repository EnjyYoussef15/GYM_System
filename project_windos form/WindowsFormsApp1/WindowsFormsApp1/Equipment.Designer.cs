namespace WindowsFormsApp1
{
    partial class Equipment
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
            this.Lbl_equipment_equipment_name = new System.Windows.Forms.Label();
            this.Lbl_equipment_product_number = new System.Windows.Forms.Label();
            this.Lbl_Delivery_date = new System.Windows.Forms.Label();
            this.Lbl_equipment_price = new System.Windows.Forms.Label();
            this.Txt_equipment_equipmentname = new System.Windows.Forms.TextBox();
            this.Txt_equipment_product_num = new System.Windows.Forms.TextBox();
            this.Txt_equipment_delivery = new System.Windows.Forms.DateTimePicker();
            this.Txt_equipment_price = new System.Windows.Forms.TextBox();
            this.Btn_equipment_add = new System.Windows.Forms.Button();
            this.Btn_equipment_reset = new System.Windows.Forms.Button();
            this.Btn_equipment_back_equipment = new System.Windows.Forms.Button();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.Txt_equipment_total_price = new System.Windows.Forms.TextBox();
            this.Lbl_equipment_total_price = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_equipment_equipment_name
            // 
            this.Lbl_equipment_equipment_name.AutoSize = true;
            this.Lbl_equipment_equipment_name.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_equipment_equipment_name.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_equipment_equipment_name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_equipment_equipment_name.Location = new System.Drawing.Point(495, 106);
            this.Lbl_equipment_equipment_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_equipment_equipment_name.Name = "Lbl_equipment_equipment_name";
            this.Lbl_equipment_equipment_name.Size = new System.Drawing.Size(218, 31);
            this.Lbl_equipment_equipment_name.TabIndex = 1;
            this.Lbl_equipment_equipment_name.Text = "Equipment Name";
            this.Lbl_equipment_equipment_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lbl_equipment_product_number
            // 
            this.Lbl_equipment_product_number.AutoSize = true;
            this.Lbl_equipment_product_number.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_equipment_product_number.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_equipment_product_number.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_equipment_product_number.Location = new System.Drawing.Point(500, 282);
            this.Lbl_equipment_product_number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_equipment_product_number.Name = "Lbl_equipment_product_number";
            this.Lbl_equipment_product_number.Size = new System.Drawing.Size(206, 31);
            this.Lbl_equipment_product_number.TabIndex = 2;
            this.Lbl_equipment_product_number.Text = "Product number";
            this.Lbl_equipment_product_number.Click += new System.EventHandler(this.Lbl_equipment_product_number_Click);
            // 
            // Lbl_Delivery_date
            // 
            this.Lbl_Delivery_date.AutoSize = true;
            this.Lbl_Delivery_date.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Delivery_date.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Delivery_date.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_Delivery_date.Location = new System.Drawing.Point(500, 506);
            this.Lbl_Delivery_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Delivery_date.Name = "Lbl_Delivery_date";
            this.Lbl_Delivery_date.Size = new System.Drawing.Size(170, 31);
            this.Lbl_Delivery_date.TabIndex = 4;
            this.Lbl_Delivery_date.Text = "Delivery date";
            this.Lbl_Delivery_date.Click += new System.EventHandler(this.label4_Click);
            // 
            // Lbl_equipment_price
            // 
            this.Lbl_equipment_price.AutoSize = true;
            this.Lbl_equipment_price.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_equipment_price.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_equipment_price.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_equipment_price.Location = new System.Drawing.Point(569, 191);
            this.Lbl_equipment_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_equipment_price.Name = "Lbl_equipment_price";
            this.Lbl_equipment_price.Size = new System.Drawing.Size(75, 31);
            this.Lbl_equipment_price.TabIndex = 5;
            this.Lbl_equipment_price.Text = "Price";
            this.Lbl_equipment_price.Click += new System.EventHandler(this.Lbl_equipment_price_Click);
            // 
            // Txt_equipment_equipmentname
            // 
            this.Txt_equipment_equipmentname.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Txt_equipment_equipmentname.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_equipment_equipmentname.Location = new System.Drawing.Point(749, 105);
            this.Txt_equipment_equipmentname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_equipment_equipmentname.Name = "Txt_equipment_equipmentname";
            this.Txt_equipment_equipmentname.Size = new System.Drawing.Size(283, 35);
            this.Txt_equipment_equipmentname.TabIndex = 6;
            this.Txt_equipment_equipmentname.TextChanged += new System.EventHandler(this.Txt_equipment_equipmentname_TextChanged);
            // 
            // Txt_equipment_product_num
            // 
            this.Txt_equipment_product_num.BackColor = System.Drawing.Color.LightGray;
            this.Txt_equipment_product_num.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_equipment_product_num.Location = new System.Drawing.Point(749, 281);
            this.Txt_equipment_product_num.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_equipment_product_num.Name = "Txt_equipment_product_num";
            this.Txt_equipment_product_num.Size = new System.Drawing.Size(280, 35);
            this.Txt_equipment_product_num.TabIndex = 7;
            this.Txt_equipment_product_num.TextChanged += new System.EventHandler(this.Txt_equipment_product_num_TextChanged);
            // 
            // Txt_equipment_delivery
            // 
            this.Txt_equipment_delivery.CalendarMonthBackground = System.Drawing.Color.White;
            this.Txt_equipment_delivery.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_equipment_delivery.Location = new System.Drawing.Point(757, 506);
            this.Txt_equipment_delivery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_equipment_delivery.Name = "Txt_equipment_delivery";
            this.Txt_equipment_delivery.Size = new System.Drawing.Size(389, 35);
            this.Txt_equipment_delivery.TabIndex = 9;
            this.Txt_equipment_delivery.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Txt_equipment_price
            // 
            this.Txt_equipment_price.BackColor = System.Drawing.Color.Silver;
            this.Txt_equipment_price.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_equipment_price.ForeColor = System.Drawing.Color.Gainsboro;
            this.Txt_equipment_price.Location = new System.Drawing.Point(746, 190);
            this.Txt_equipment_price.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_equipment_price.Name = "Txt_equipment_price";
            this.Txt_equipment_price.Size = new System.Drawing.Size(286, 35);
            this.Txt_equipment_price.TabIndex = 10;
            this.Txt_equipment_price.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Btn_equipment_add
            // 
            this.Btn_equipment_add.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_equipment_add.Location = new System.Drawing.Point(801, 589);
            this.Btn_equipment_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_equipment_add.Name = "Btn_equipment_add";
            this.Btn_equipment_add.Size = new System.Drawing.Size(179, 49);
            this.Btn_equipment_add.TabIndex = 11;
            this.Btn_equipment_add.Text = "Add";
            this.Btn_equipment_add.UseVisualStyleBackColor = true;
            this.Btn_equipment_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_equipment_reset
            // 
            this.Btn_equipment_reset.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_equipment_reset.Location = new System.Drawing.Point(1222, 589);
            this.Btn_equipment_reset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_equipment_reset.Name = "Btn_equipment_reset";
            this.Btn_equipment_reset.Size = new System.Drawing.Size(194, 49);
            this.Btn_equipment_reset.TabIndex = 12;
            this.Btn_equipment_reset.Text = "Reset";
            this.Btn_equipment_reset.UseVisualStyleBackColor = true;
            this.Btn_equipment_reset.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_equipment_back_equipment
            // 
            this.Btn_equipment_back_equipment.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_equipment_back_equipment.Location = new System.Drawing.Point(311, 589);
            this.Btn_equipment_back_equipment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_equipment_back_equipment.Name = "Btn_equipment_back_equipment";
            this.Btn_equipment_back_equipment.Size = new System.Drawing.Size(216, 49);
            this.Btn_equipment_back_equipment.TabIndex = 13;
            this.Btn_equipment_back_equipment.Text = "Back ";
            this.Btn_equipment_back_equipment.UseVisualStyleBackColor = true;
            this.Btn_equipment_back_equipment.Click += new System.EventHandler(this.button3_Click);
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(0, 0);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(200, 100);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = null;
            // 
            // Txt_equipment_total_price
            // 
            this.Txt_equipment_total_price.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Txt_equipment_total_price.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_equipment_total_price.Location = new System.Drawing.Point(746, 373);
            this.Txt_equipment_total_price.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_equipment_total_price.Name = "Txt_equipment_total_price";
            this.Txt_equipment_total_price.Size = new System.Drawing.Size(283, 35);
            this.Txt_equipment_total_price.TabIndex = 14;
            this.Txt_equipment_total_price.TextChanged += new System.EventHandler(this.Txt_equipment_total_price_TextChanged);
            // 
            // Lbl_equipment_total_price
            // 
            this.Lbl_equipment_total_price.AutoSize = true;
            this.Lbl_equipment_total_price.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_equipment_total_price.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_equipment_total_price.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_equipment_total_price.Location = new System.Drawing.Point(520, 373);
            this.Lbl_equipment_total_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_equipment_total_price.Name = "Lbl_equipment_total_price";
            this.Lbl_equipment_total_price.Size = new System.Drawing.Size(141, 31);
            this.Lbl_equipment_total_price.TabIndex = 15;
            this.Lbl_equipment_total_price.Text = "Total price";
            this.Lbl_equipment_total_price.Click += new System.EventHandler(this.Lbl_equipment_total_price_Click);
            // 
            // Equipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1527, 775);
            this.Controls.Add(this.Lbl_equipment_total_price);
            this.Controls.Add(this.Txt_equipment_total_price);
            this.Controls.Add(this.Btn_equipment_back_equipment);
            this.Controls.Add(this.Btn_equipment_reset);
            this.Controls.Add(this.Btn_equipment_add);
            this.Controls.Add(this.Txt_equipment_price);
            this.Controls.Add(this.Txt_equipment_delivery);
            this.Controls.Add(this.Txt_equipment_product_num);
            this.Controls.Add(this.Txt_equipment_equipmentname);
            this.Controls.Add(this.Lbl_equipment_price);
            this.Controls.Add(this.Lbl_Delivery_date);
            this.Controls.Add(this.Lbl_equipment_product_number);
            this.Controls.Add(this.Lbl_equipment_equipment_name);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Equipment";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_equipment_equipment_name;
        private System.Windows.Forms.Label Lbl_equipment_product_number;
        private System.Windows.Forms.Label Lbl_Delivery_date;
        private System.Windows.Forms.Label Lbl_equipment_price;
        private System.Windows.Forms.TextBox Txt_equipment_equipmentname;
        private System.Windows.Forms.TextBox Txt_equipment_product_num;
        private System.Windows.Forms.DateTimePicker Txt_equipment_delivery;
        private System.Windows.Forms.TextBox Txt_equipment_price;
        private System.Windows.Forms.Button Btn_equipment_add;
        private System.Windows.Forms.Button Btn_equipment_reset;
        private System.Windows.Forms.Button Btn_equipment_back_equipment;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private System.Windows.Forms.TextBox Txt_equipment_total_price;
        private System.Windows.Forms.Label Lbl_equipment_total_price;
    }
}

