namespace McDaniel_PA5
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
            this.name = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.large_pizza = new System.Windows.Forms.RadioButton();
            this.medium_pizza = new System.Windows.Forms.RadioButton();
            this.small_pizza = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.delivery = new System.Windows.Forms.RadioButton();
            this.pickup = new System.Windows.Forms.RadioButton();
            this.promo = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.checkout = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pepp_top = new System.Windows.Forms.CheckBox();
            this.saus_top = new System.Windows.Forms.CheckBox();
            this.pine_top = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(82, 72);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(151, 26);
            this.name.TabIndex = 0;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.large_pizza);
            this.panel1.Controls.Add(this.medium_pizza);
            this.panel1.Controls.Add(this.small_pizza);
            this.panel1.Location = new System.Drawing.Point(82, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 192);
            this.panel1.TabIndex = 1;
            // 
            // large_pizza
            // 
            this.large_pizza.AutoSize = true;
            this.large_pizza.Location = new System.Drawing.Point(15, 129);
            this.large_pizza.Name = "large_pizza";
            this.large_pizza.Size = new System.Drawing.Size(75, 24);
            this.large_pizza.TabIndex = 2;
            this.large_pizza.TabStop = true;
            this.large_pizza.Text = "Large";
            this.large_pizza.UseVisualStyleBackColor = true;
            this.large_pizza.CheckedChanged += new System.EventHandler(this.large_pizza_CheckedChanged);
            // 
            // medium_pizza
            // 
            this.medium_pizza.AutoSize = true;
            this.medium_pizza.Location = new System.Drawing.Point(15, 76);
            this.medium_pizza.Name = "medium_pizza";
            this.medium_pizza.Size = new System.Drawing.Size(90, 24);
            this.medium_pizza.TabIndex = 1;
            this.medium_pizza.TabStop = true;
            this.medium_pizza.Text = "Medium";
            this.medium_pizza.UseVisualStyleBackColor = true;
            this.medium_pizza.CheckedChanged += new System.EventHandler(this.medium_pizza_CheckedChanged);
            // 
            // small_pizza
            // 
            this.small_pizza.AutoSize = true;
            this.small_pizza.Location = new System.Drawing.Point(15, 30);
            this.small_pizza.Name = "small_pizza";
            this.small_pizza.Size = new System.Drawing.Size(73, 24);
            this.small_pizza.TabIndex = 0;
            this.small_pizza.TabStop = true;
            this.small_pizza.Text = "Small";
            this.small_pizza.UseVisualStyleBackColor = true;
            this.small_pizza.CheckedChanged += new System.EventHandler(this.small_pizza_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel2.Controls.Add(this.delivery);
            this.panel2.Controls.Add(this.pickup);
            this.panel2.Location = new System.Drawing.Point(86, 379);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 102);
            this.panel2.TabIndex = 2;
            // 
            // delivery
            // 
            this.delivery.AutoSize = true;
            this.delivery.Location = new System.Drawing.Point(35, 71);
            this.delivery.Name = "delivery";
            this.delivery.Size = new System.Drawing.Size(89, 24);
            this.delivery.TabIndex = 1;
            this.delivery.TabStop = true;
            this.delivery.Text = "Delivery";
            this.delivery.UseVisualStyleBackColor = true;
            this.delivery.CheckedChanged += new System.EventHandler(this.delivery_CheckedChanged);
            // 
            // pickup
            // 
            this.pickup.AutoSize = true;
            this.pickup.Location = new System.Drawing.Point(35, 31);
            this.pickup.Name = "pickup";
            this.pickup.Size = new System.Drawing.Size(81, 24);
            this.pickup.TabIndex = 0;
            this.pickup.TabStop = true;
            this.pickup.Text = "Pickup";
            this.pickup.UseVisualStyleBackColor = true;
            this.pickup.CheckedChanged += new System.EventHandler(this.pickup_CheckedChanged);
            // 
            // promo
            // 
            this.promo.Location = new System.Drawing.Point(403, 488);
            this.promo.Name = "promo";
            this.promo.Size = new System.Drawing.Size(146, 26);
            this.promo.TabIndex = 3;
            this.promo.TextChanged += new System.EventHandler(this.promo_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(785, 307);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(254, 262);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // checkout
            // 
            this.checkout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkout.Location = new System.Drawing.Point(612, 474);
            this.checkout.Name = "checkout";
            this.checkout.Size = new System.Drawing.Size(152, 54);
            this.checkout.TabIndex = 7;
            this.checkout.Text = "checkout";
            this.checkout.UseVisualStyleBackColor = false;
            this.checkout.Click += new System.EventHandler(this.checkout_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(840, 105);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(152, 61);
            this.reset.TabIndex = 8;
            this.reset.Text = "clear order";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.pine_top);
            this.panel3.Controls.Add(this.saus_top);
            this.panel3.Controls.Add(this.pepp_top);
            this.panel3.Location = new System.Drawing.Point(288, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(281, 173);
            this.panel3.TabIndex = 9;
            // 
            // pepp_top
            // 
            this.pepp_top.AutoSize = true;
            this.pepp_top.Location = new System.Drawing.Point(14, 30);
            this.pepp_top.Name = "pepp_top";
            this.pepp_top.Size = new System.Drawing.Size(107, 24);
            this.pepp_top.TabIndex = 0;
            this.pepp_top.Text = "Pepperoni";
            this.pepp_top.UseVisualStyleBackColor = true;
            this.pepp_top.CheckedChanged += new System.EventHandler(this.pepp_top_CheckedChanged);
            // 
            // saus_top
            // 
            this.saus_top.AutoSize = true;
            this.saus_top.Location = new System.Drawing.Point(14, 71);
            this.saus_top.Name = "saus_top";
            this.saus_top.Size = new System.Drawing.Size(146, 24);
            this.saus_top.TabIndex = 1;
            this.saus_top.Text = "Italian Sausage";
            this.saus_top.UseVisualStyleBackColor = true;
            this.saus_top.CheckedChanged += new System.EventHandler(this.saus_top_CheckedChanged);
            // 
            // pine_top
            // 
            this.pine_top.AutoSize = true;
            this.pine_top.Location = new System.Drawing.Point(14, 110);
            this.pine_top.Name = "pine_top";
            this.pine_top.Size = new System.Drawing.Size(113, 24);
            this.pine_top.TabIndex = 2;
            this.pine_top.Text = "Pineapples";
            this.pine_top.UseVisualStyleBackColor = true;
            this.pine_top.CheckedChanged += new System.EventHandler(this.pine_top_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(72, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter Name for Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select Pizza Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Select Pizza Toppings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Khaki;
            this.label4.Location = new System.Drawing.Point(423, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Promo Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "$.50";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "$.50";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "$.50";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "$7.99";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(121, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "$9.99";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(121, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "$13.99";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(97, 353);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Delivery Options";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Yellow;
            this.label12.Location = new System.Drawing.Point(403, 548);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(206, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Enter Save2 for 2$ off order";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(849, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "reset order form ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1051, 581);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.checkout);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.promo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PIZZA TOWN";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton large_pizza;
        private System.Windows.Forms.RadioButton medium_pizza;
        private System.Windows.Forms.RadioButton small_pizza;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton delivery;
        private System.Windows.Forms.RadioButton pickup;
        private System.Windows.Forms.TextBox promo;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button checkout;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox pine_top;
        private System.Windows.Forms.CheckBox saus_top;
        private System.Windows.Forms.CheckBox pepp_top;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

