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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipment));
            Lbl_equipment_equipment_name = new Label();
            Lbl_equipment_product_number = new Label();
            Lbl_Delivery_date = new Label();
            Lbl_equipment_price = new Label();
            Txt_equipment_equipmentname = new TextBox();
            Txt_equipment_product_num = new TextBox();
            Txt_equipment_delivery = new DateTimePicker();
            Txt_equipment_price = new TextBox();
            Btn_equipment_add = new Button();
            Btn_equipment_reset = new Button();
            Btn_equipment_back_equipment = new Button();
            Txt_equipment_total_price = new TextBox();
            Lbl_equipment_total_price = new Label();
            SuspendLayout();
            // 
            // Lbl_equipment_equipment_name
            // 
            Lbl_equipment_equipment_name.AutoSize = true;
            Lbl_equipment_equipment_name.BackColor = Color.Transparent;
            Lbl_equipment_equipment_name.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_equipment_equipment_name.ForeColor = SystemColors.ControlLightLight;
            Lbl_equipment_equipment_name.Location = new Point(483, 75);
            Lbl_equipment_equipment_name.Margin = new Padding(4, 0, 4, 0);
            Lbl_equipment_equipment_name.Name = "Lbl_equipment_equipment_name";
            Lbl_equipment_equipment_name.Size = new Size(218, 31);
            Lbl_equipment_equipment_name.TabIndex = 1;
            Lbl_equipment_equipment_name.Text = "Equipment Name";
            Lbl_equipment_equipment_name.Click += label1_Click;
            // 
            // Lbl_equipment_product_number
            // 
            Lbl_equipment_product_number.AutoSize = true;
            Lbl_equipment_product_number.BackColor = Color.Transparent;
            Lbl_equipment_product_number.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_equipment_product_number.ForeColor = SystemColors.ControlLightLight;
            Lbl_equipment_product_number.Location = new Point(483, 249);
            Lbl_equipment_product_number.Margin = new Padding(4, 0, 4, 0);
            Lbl_equipment_product_number.Name = "Lbl_equipment_product_number";
            Lbl_equipment_product_number.Size = new Size(206, 31);
            Lbl_equipment_product_number.TabIndex = 2;
            Lbl_equipment_product_number.Text = "Product number";
            Lbl_equipment_product_number.Click += Lbl_equipment_product_number_Click;
            // 
            // Lbl_Delivery_date
            // 
            Lbl_Delivery_date.AutoSize = true;
            Lbl_Delivery_date.BackColor = Color.Transparent;
            Lbl_Delivery_date.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Delivery_date.ForeColor = SystemColors.ControlLightLight;
            Lbl_Delivery_date.Location = new Point(480, 406);
            Lbl_Delivery_date.Margin = new Padding(4, 0, 4, 0);
            Lbl_Delivery_date.Name = "Lbl_Delivery_date";
            Lbl_Delivery_date.Size = new Size(170, 31);
            Lbl_Delivery_date.TabIndex = 4;
            Lbl_Delivery_date.Text = "Delivery date";
            Lbl_Delivery_date.Click += label4_Click;
            // 
            // Lbl_equipment_price
            // 
            Lbl_equipment_price.AutoSize = true;
            Lbl_equipment_price.BackColor = Color.Transparent;
            Lbl_equipment_price.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_equipment_price.ForeColor = SystemColors.ControlLightLight;
            Lbl_equipment_price.Location = new Point(560, 158);
            Lbl_equipment_price.Margin = new Padding(4, 0, 4, 0);
            Lbl_equipment_price.Name = "Lbl_equipment_price";
            Lbl_equipment_price.Size = new Size(75, 31);
            Lbl_equipment_price.TabIndex = 5;
            Lbl_equipment_price.Text = "Price";
            Lbl_equipment_price.Click += Lbl_equipment_price_Click;
            // 
            // Txt_equipment_equipmentname
            // 
            Txt_equipment_equipmentname.BackColor = SystemColors.ScrollBar;
            Txt_equipment_equipmentname.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_equipment_equipmentname.Location = new Point(737, 74);
            Txt_equipment_equipmentname.Margin = new Padding(4, 5, 4, 5);
            Txt_equipment_equipmentname.Name = "Txt_equipment_equipmentname";
            Txt_equipment_equipmentname.Size = new Size(283, 35);
            Txt_equipment_equipmentname.TabIndex = 6;
            Txt_equipment_equipmentname.TextChanged += Txt_equipment_equipmentname_TextChanged;
            // 
            // Txt_equipment_product_num
            // 
            Txt_equipment_product_num.BackColor = Color.LightGray;
            Txt_equipment_product_num.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_equipment_product_num.Location = new Point(740, 245);
            Txt_equipment_product_num.Margin = new Padding(4, 5, 4, 5);
            Txt_equipment_product_num.Name = "Txt_equipment_product_num";
            Txt_equipment_product_num.Size = new Size(280, 35);
            Txt_equipment_product_num.TabIndex = 7;
            Txt_equipment_product_num.TextChanged += Txt_equipment_product_num_TextChanged;
            // 
            // Txt_equipment_delivery
            // 
            Txt_equipment_delivery.CalendarMonthBackground = Color.White;
            Txt_equipment_delivery.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_equipment_delivery.Format = DateTimePickerFormat.Short;
            Txt_equipment_delivery.Location = new Point(737, 406);
            Txt_equipment_delivery.Margin = new Padding(4, 5, 4, 5);
            Txt_equipment_delivery.Name = "Txt_equipment_delivery";
            Txt_equipment_delivery.Size = new Size(286, 35);
            Txt_equipment_delivery.TabIndex = 9;
            Txt_equipment_delivery.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Txt_equipment_price
            // 
            Txt_equipment_price.BackColor = Color.Silver;
            Txt_equipment_price.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_equipment_price.ForeColor = Color.Gainsboro;
            Txt_equipment_price.Location = new Point(737, 157);
            Txt_equipment_price.Margin = new Padding(4, 5, 4, 5);
            Txt_equipment_price.Name = "Txt_equipment_price";
            Txt_equipment_price.Size = new Size(286, 35);
            Txt_equipment_price.TabIndex = 10;
            Txt_equipment_price.TextChanged += textBox3_TextChanged;
            // 
            // Btn_equipment_add
            // 
            Btn_equipment_add.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_equipment_add.Location = new Point(769, 527);
            Btn_equipment_add.Margin = new Padding(4, 5, 4, 5);
            Btn_equipment_add.Name = "Btn_equipment_add";
            Btn_equipment_add.Size = new Size(179, 61);
            Btn_equipment_add.TabIndex = 11;
            Btn_equipment_add.Text = "Add";
            Btn_equipment_add.UseVisualStyleBackColor = true;
            Btn_equipment_add.Click += button1_Click;
            // 
            // Btn_equipment_reset
            // 
            Btn_equipment_reset.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_equipment_reset.Location = new Point(1190, 527);
            Btn_equipment_reset.Margin = new Padding(4, 5, 4, 5);
            Btn_equipment_reset.Name = "Btn_equipment_reset";
            Btn_equipment_reset.Size = new Size(194, 61);
            Btn_equipment_reset.TabIndex = 12;
            Btn_equipment_reset.Text = "Reset";
            Btn_equipment_reset.UseVisualStyleBackColor = true;
            Btn_equipment_reset.Click += button2_Click;
            // 
            // Btn_equipment_back_equipment
            // 
            Btn_equipment_back_equipment.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_equipment_back_equipment.Location = new Point(279, 527);
            Btn_equipment_back_equipment.Margin = new Padding(4, 5, 4, 5);
            Btn_equipment_back_equipment.Name = "Btn_equipment_back_equipment";
            Btn_equipment_back_equipment.Size = new Size(216, 61);
            Btn_equipment_back_equipment.TabIndex = 13;
            Btn_equipment_back_equipment.Text = "Back ";
            Btn_equipment_back_equipment.UseVisualStyleBackColor = true;
            Btn_equipment_back_equipment.Click += button3_Click;
            // 
            // Txt_equipment_total_price
            // 
            Txt_equipment_total_price.BackColor = SystemColors.ScrollBar;
            Txt_equipment_total_price.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_equipment_total_price.Location = new Point(740, 328);
            Txt_equipment_total_price.Margin = new Padding(4, 5, 4, 5);
            Txt_equipment_total_price.Name = "Txt_equipment_total_price";
            Txt_equipment_total_price.Size = new Size(283, 35);
            Txt_equipment_total_price.TabIndex = 14;
            Txt_equipment_total_price.TextChanged += Txt_equipment_total_price_TextChanged;
            // 
            // Lbl_equipment_total_price
            // 
            Lbl_equipment_total_price.AutoSize = true;
            Lbl_equipment_total_price.BackColor = Color.Transparent;
            Lbl_equipment_total_price.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_equipment_total_price.ForeColor = SystemColors.ControlLightLight;
            Lbl_equipment_total_price.Location = new Point(511, 332);
            Lbl_equipment_total_price.Margin = new Padding(4, 0, 4, 0);
            Lbl_equipment_total_price.Name = "Lbl_equipment_total_price";
            Lbl_equipment_total_price.Size = new Size(141, 31);
            Lbl_equipment_total_price.TabIndex = 15;
            Lbl_equipment_total_price.Text = "Total price";
            Lbl_equipment_total_price.Click += Lbl_equipment_total_price_Click;
            // 
            // Equipment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1576, 742);
            Controls.Add(Lbl_equipment_total_price);
            Controls.Add(Txt_equipment_total_price);
            Controls.Add(Btn_equipment_back_equipment);
            Controls.Add(Btn_equipment_reset);
            Controls.Add(Btn_equipment_add);
            Controls.Add(Txt_equipment_price);
            Controls.Add(Txt_equipment_delivery);
            Controls.Add(Txt_equipment_product_num);
            Controls.Add(Txt_equipment_equipmentname);
            Controls.Add(Lbl_equipment_price);
            Controls.Add(Lbl_Delivery_date);
            Controls.Add(Lbl_equipment_product_number);
            Controls.Add(Lbl_equipment_equipment_name);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Equipment";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
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
        //private System.Windows.Forms.Integration.ElementHost elementHost1;
        private System.Windows.Forms.TextBox Txt_equipment_total_price;
        private System.Windows.Forms.Label Lbl_equipment_total_price;

    }
}

