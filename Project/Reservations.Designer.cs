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
            delete = new Button();
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            newcus = new Button();
            roomid = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            amount = new Label();
            daytext = new TextBox();
            label1 = new Label();
            insert = new Button();
            price = new Label();
            amountbox = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 293);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 1;
            label2.Text = "Check-In Date:";
            // 
            // load
            // 
            load.Location = new Point(386, 405);
            load.Name = "load";
            load.Size = new Size(94, 29);
            load.TabIndex = 8;
            load.Text = "Load";
            load.UseVisualStyleBackColor = true;
            load.Click += load_Click;
            // 
            // delete
            // 
            delete.Location = new Point(921, 405);
            delete.Name = "delete";
            delete.Size = new Size(158, 29);
            delete.TabIndex = 10;
            delete.Text = "Cancel Reservation";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(386, 18);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(693, 363);
            dataGridView1.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "YYYY-MM-DD HH:MM:SS";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(149, 286);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(196, 27);
            dateTimePicker1.TabIndex = 13;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // newcus
            // 
            newcus.Location = new Point(104, 178);
            newcus.Name = "newcus";
            newcus.Size = new Size(144, 29);
            newcus.TabIndex = 19;
            newcus.Text = "New Customer";
            newcus.UseVisualStyleBackColor = true;
            newcus.Click += newcus_Click;
            // 
            // roomid
            // 
            roomid.AutoSize = true;
            roomid.Location = new Point(23, 237);
            roomid.Name = "roomid";
            roomid.Size = new Size(71, 20);
            roomid.TabIndex = 23;
            roomid.Text = "Room ID:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "301", "302", "303", "304", "305" });
            comboBox1.Location = new Point(149, 237);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(196, 28);
            comboBox1.TabIndex = 22;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(149, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(196, 27);
            textBox2.TabIndex = 21;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // amount
            // 
            amount.AutoSize = true;
            amount.Location = new Point(23, 73);
            amount.Name = "amount";
            amount.Size = new Size(94, 20);
            amount.TabIndex = 20;
            amount.Text = "Customer ID:";
            // 
            // daytext
            // 
            daytext.Location = new Point(149, 328);
            daytext.Name = "daytext";
            daytext.Size = new Size(196, 27);
            daytext.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 335);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 26;
            label1.Text = "No. of Days";
            // 
            // insert
            // 
            insert.Location = new Point(770, 405);
            insert.Name = "insert";
            insert.Size = new Size(131, 29);
            insert.TabIndex = 9;
            insert.Text = "Reserve";
            insert.UseVisualStyleBackColor = true;
            insert.Click += reserve_Click;
            // 
            // price
            // 
            price.AutoSize = true;
            price.Location = new Point(23, 379);
            price.Name = "price";
            price.Size = new Size(62, 20);
            price.TabIndex = 27;
            price.Text = "Amount";
            // 
            // amountbox
            // 
            amountbox.Location = new Point(149, 372);
            amountbox.Name = "amountbox";
            amountbox.Size = new Size(196, 27);
            amountbox.TabIndex = 28;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 27);
            textBox1.TabIndex = 30;
            // 
            // button1
            // 
            button1.Location = new Point(236, 121);
            button1.Name = "button1";
            button1.Size = new Size(109, 29);
            button1.TabIndex = 31;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Reservations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 450);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(amountbox);
            Controls.Add(price);
            Controls.Add(label1);
            Controls.Add(daytext);
            Controls.Add(roomid);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(amount);
            Controls.Add(newcus);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
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
        private Button delete;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private Button newcus;
        private Label roomid;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label amount;
        private TextBox daytext;
        private Label label1;
        private Button insert;
        private Label price;
        private TextBox amountbox;
        private TextBox textBox1;
        private Button button1;
    }
}