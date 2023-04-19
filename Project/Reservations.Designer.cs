namespace Project
{
    partial class Reservations
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
            load = new Button();
            insert = new Button();
            delete = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            newcus = new Button();
            roomid = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            amount = new Label();
            button1 = new Button();
            daytext = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 132);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 1;
            label2.Text = "Check-In Date:";
            // 
            // load
            // 
            load.Location = new Point(53, 332);
            load.Name = "load";
            load.Size = new Size(94, 29);
            load.TabIndex = 8;
            load.Text = "Load";
            load.UseVisualStyleBackColor = true;
            load.Click += load_Click;
            // 
            // insert
            // 
            insert.Location = new Point(53, 385);
            insert.Name = "insert";
            insert.Size = new Size(94, 29);
            insert.TabIndex = 9;
            insert.Text = "Reserve";
            insert.UseVisualStyleBackColor = true;
            insert.Click += reserve_Click;
            // 
            // delete
            // 
            delete.Location = new Point(182, 332);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 10;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // button4
            // 
            button4.Location = new Point(182, 385);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 11;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(394, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(706, 397);
            dataGridView1.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "YYYY-MM-DD HH:MM:SS";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(154, 125);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(191, 27);
            dateTimePicker1.TabIndex = 13;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // newcus
            // 
            newcus.Location = new Point(53, 279);
            newcus.Name = "newcus";
            newcus.Size = new Size(223, 29);
            newcus.TabIndex = 19;
            newcus.Text = "New Customer";
            newcus.UseVisualStyleBackColor = true;
            newcus.Click += newcus_Click;
            // 
            // roomid
            // 
            roomid.AutoSize = true;
            roomid.Location = new Point(23, 76);
            roomid.Name = "roomid";
            roomid.Size = new Size(71, 20);
            roomid.TabIndex = 23;
            roomid.Text = "Room ID:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "301", "302", "303", "304", "305" });
            comboBox1.Location = new Point(149, 76);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(196, 28);
            comboBox1.TabIndex = 22;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(149, 18);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(196, 27);
            textBox2.TabIndex = 21;
            // 
            // amount
            // 
            amount.AutoSize = true;
            amount.Location = new Point(23, 21);
            amount.Name = "amount";
            amount.Size = new Size(94, 20);
            amount.TabIndex = 20;
            amount.Text = "Customer ID:";
            // 
            // button1
            // 
            button1.Location = new Point(53, 230);
            button1.Name = "button1";
            button1.Size = new Size(223, 29);
            button1.TabIndex = 24;
            button1.Text = "Room Status";
            button1.UseVisualStyleBackColor = true;
            button1.Click += room_Click;
            // 
            // daytext
            // 
            daytext.Location = new Point(154, 171);
            daytext.Name = "daytext";
            daytext.Size = new Size(191, 27);
            daytext.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 174);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 26;
            label1.Text = "No. of Days";
            // 
            // Reservations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 450);
            Controls.Add(label1);
            Controls.Add(daytext);
            Controls.Add(button1);
            Controls.Add(roomid);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(amount);
            Controls.Add(newcus);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(delete);
            Controls.Add(insert);
            Controls.Add(load);
            Controls.Add(label2);
            Name = "Reservations";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button load;
        private Button insert;
        private Button delete;
        private Button button4;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private Button newcus;
        private Label roomid;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label amount;
        private Button button1;
        private TextBox daytext;
        private Label label1;
    }
}