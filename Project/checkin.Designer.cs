namespace Project
{
    partial class checkin
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
            dataGridView1 = new DataGridView();
            status = new Button();
            button4 = new Button();
            Update = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.SandyBrown;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 29);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(854, 263);
            dataGridView1.TabIndex = 1;
            // 
            // status
            // 
            status.BackColor = Color.SandyBrown;
            status.Location = new Point(512, 393);
            status.Name = "status";
            status.Size = new Size(233, 29);
            status.TabIndex = 2;
            status.Text = "Room Status";
            status.UseVisualStyleBackColor = false;
            status.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.SandyBrown;
            button4.Location = new Point(512, 446);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 5;
            button4.Text = "Check In";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Update
            // 
            Update.AutoSize = true;
            Update.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Update.Location = new Point(42, 376);
            Update.Name = "Update";
            Update.Size = new Size(134, 28);
            Update.TabIndex = 6;
            Update.Text = "Customer ID:";
            // 
            // button1
            // 
            button1.BackColor = Color.SandyBrown;
            button1.Location = new Point(651, 446);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Check-out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += out_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(182, 377);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 27);
            textBox1.TabIndex = 9;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(460, 333);
            label1.Name = "label1";
            label1.Size = new Size(72, 28);
            label1.TabIndex = 11;
            label1.Text = "Room:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "301", "302", "303", "304", "305" });
            comboBox1.Location = new Point(553, 333);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(207, 28);
            comboBox1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(42, 430);
            label2.Name = "label2";
            label2.Size = new Size(80, 28);
            label2.TabIndex = 13;
            label2.Text = "Search:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(182, 430);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(207, 27);
            textBox2.TabIndex = 14;
            textBox2.KeyDown += textBox2_KeyDown;
            // 
            // checkin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(905, 541);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(Update);
            Controls.Add(button4);
            Controls.Add(status);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "checkin";
            Text = "Transactions";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button status;
        private Button button4;
        private Label Update;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox textBox2;
    }
}