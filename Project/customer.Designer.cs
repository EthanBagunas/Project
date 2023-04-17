namespace Project
{
    partial class Customer
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
            label2 = new Label();
            label3 = new Label();
            contact = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            insert = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Lastname:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 117);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 2;
            label3.Text = "Firstname:";
            // 
            // contact
            // 
            contact.AutoSize = true;
            contact.Location = new Point(12, 159);
            contact.Name = "contact";
            contact.Size = new Size(121, 20);
            contact.TabIndex = 3;
            contact.Text = "Contact Number:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(146, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(152, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(146, 117);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(152, 27);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(146, 159);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(152, 27);
            textBox4.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(40, 252);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += load_click;
            // 
            // insert
            // 
            insert.Location = new Point(40, 308);
            insert.Name = "insert";
            insert.Size = new Size(94, 29);
            insert.TabIndex = 9;
            insert.Text = "Insert";
            insert.UseVisualStyleBackColor = true;
            insert.Click += insert_Click;
            // 
            // button3
            // 
            button3.Location = new Point(161, 252);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 10;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += delete_Click;
            // 
            // button4
            // 
            button4.Location = new Point(161, 308);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 11;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = true;
            button4.Click += update_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(319, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(443, 370);
            dataGridView1.TabIndex = 12;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(insert);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(contact);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Customer";
            Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label cus_id;
        private Label label2;
        private Label label3;
        private Label contact;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button insert;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
    }
}