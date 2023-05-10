namespace Project
{
    partial class Receipt
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
            customer = new Label();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // customer
            // 
            customer.AutoSize = true;
            customer.Location = new Point(57, 108);
            customer.Name = "customer";
            customer.Size = new Size(94, 20);
            customer.TabIndex = 0;
            customer.Text = "Customer ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 206);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 1;
            label1.Text = "Amount";
            // 
            // button1
            // 
            button1.Location = new Point(139, 280);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Pay";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 156);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 3;
            label2.Text = "Transaction Type:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(181, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(181, 206);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(135, 27);
            textBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Check-In", "Check-Out", "Reservation", "" });
            comboBox1.Location = new Point(181, 158);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(135, 28);
            comboBox1.TabIndex = 6;
            // 
            // Transaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 358);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(customer);
            Name = "Transaction";
            Text = "Transaction";
            Load += Transaction_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label customer;
        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
    }
}