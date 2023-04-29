namespace Project
{
    partial class admin
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
            Customers = new Button();
            dataGridView1 = new DataGridView();
            room = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Customers
            // 
            Customers.Location = new Point(35, 49);
            Customers.Name = "Customers";
            Customers.Size = new Size(187, 44);
            Customers.TabIndex = 0;
            Customers.Text = "Customers";
            Customers.UseVisualStyleBackColor = true;
            Customers.Click += customer_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(254, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(514, 426);
            dataGridView1.TabIndex = 1;
            // 
            // room
            // 
            room.Location = new Point(35, 129);
            room.Name = "room";
            room.Size = new Size(187, 50);
            room.TabIndex = 2;
            room.Text = "Rooms";
            room.UseVisualStyleBackColor = true;
            room.Click += room_Click;
            // 
            // button1
            // 
            button1.Location = new Point(35, 213);
            button1.Name = "button1";
            button1.Size = new Size(187, 50);
            button1.TabIndex = 3;
            button1.Text = "Rooms";
            button1.UseVisualStyleBackColor = true;
            // 
            // admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(room);
            Controls.Add(dataGridView1);
            Controls.Add(Customers);
            Name = "admin";
            Text = "admin";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Customers;
        private DataGridView dataGridView1;
        private Button room;
        private Button button1;
    }
}