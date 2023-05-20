namespace GYM
{
    partial class EquipmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipmentForm));
            this.view = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.delivery = new System.Windows.Forms.DateTimePicker();
            this.txtmusles = new System.Windows.Forms.RichTextBox();
            this.txtproduct_num = new System.Windows.Forms.TextBox();
            this.txtEquipmentName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTatalPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // view
            // 
            this.view.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.Location = new System.Drawing.Point(740, 519);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(175, 32);
            this.view.TabIndex = 28;
            this.view.Text = "view Equipment";
            this.view.UseVisualStyleBackColor = true;
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(535, 519);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(115, 32);
            this.reset.TabIndex = 27;
            this.reset.Text = "reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(310, 519);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(110, 32);
            this.save.TabIndex = 26;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            // 
            // txtprice
            // 
            this.txtprice.BackColor = System.Drawing.Color.Silver;
            this.txtprice.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtprice.Location = new System.Drawing.Point(505, 207);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(207, 26);
            this.txtprice.TabIndex = 25;
            // 
            // delivery
            // 
            this.delivery.CalendarMonthBackground = System.Drawing.Color.White;
            this.delivery.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delivery.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.delivery.Location = new System.Drawing.Point(559, 348);
            this.delivery.Name = "delivery";
            this.delivery.Size = new System.Drawing.Size(91, 26);
            this.delivery.TabIndex = 24;
            // 
            // txtmusles
            // 
            this.txtmusles.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtmusles.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmusles.Location = new System.Drawing.Point(507, 401);
            this.txtmusles.Name = "txtmusles";
            this.txtmusles.Size = new System.Drawing.Size(207, 87);
            this.txtmusles.TabIndex = 23;
            this.txtmusles.Text = "";
            // 
            // txtproduct_num
            // 
            this.txtproduct_num.BackColor = System.Drawing.Color.LightGray;
            this.txtproduct_num.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproduct_num.Location = new System.Drawing.Point(503, 130);
            this.txtproduct_num.Name = "txtproduct_num";
            this.txtproduct_num.Size = new System.Drawing.Size(211, 26);
            this.txtproduct_num.TabIndex = 22;
            // 
            // txtEquipmentName
            // 
            this.txtEquipmentName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEquipmentName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipmentName.Location = new System.Drawing.Point(504, 56);
            this.txtEquipmentName.Name = "txtEquipmentName";
            this.txtEquipmentName.Size = new System.Drawing.Size(213, 26);
            this.txtEquipmentName.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(384, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(333, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Delivery date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(313, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Musles used";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(317, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Product number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(313, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Equipment name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(357, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "total price";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtTatalPrice
            // 
            this.txtTatalPrice.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTatalPrice.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTatalPrice.Location = new System.Drawing.Point(510, 279);
            this.txtTatalPrice.Name = "txtTatalPrice";
            this.txtTatalPrice.Size = new System.Drawing.Size(203, 26);
            this.txtTatalPrice.TabIndex = 29;
            // 
            // EquipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1202, 640);
            this.Controls.Add(this.view);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.save);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.delivery);
            this.Controls.Add(this.txtmusles);
            this.Controls.Add(this.txtproduct_num);
            this.Controls.Add(this.txtEquipmentName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTatalPrice);
            this.Name = "EquipmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EquipmentForm";
            this.Load += new System.EventHandler(this.EquipmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.DateTimePicker delivery;
        private System.Windows.Forms.RichTextBox txtmusles;
        private System.Windows.Forms.TextBox txtproduct_num;
        private System.Windows.Forms.TextBox txtEquipmentName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTatalPrice;
    }
}