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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            load = new Button();
            insert = new Button();
            delete = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            amount = new Label();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            roomid = new Label();
            newcus = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 50);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "Reservation ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 104);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 1;
            label2.Text = "Reservation Date:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(151, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 27);
            textBox1.TabIndex = 4;
            // 
            // load
            // 
            load.Location = new Point(53, 332);
            load.Name = "load";
            load.Size = new Size(94, 29);
            load.TabIndex = 8;
            load.Text = "Load";
            load.UseVisualStyleBackColor = true;
            // 
            // insert
            // 
            insert.Location = new Point(53, 385);
            insert.Name = "insert";
            insert.Size = new Size(94, 29);
            insert.TabIndex = 9;
            insert.Text = "Insert";
            insert.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            delete.Location = new Point(182, 332);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 10;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
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
            dataGridView1.Location = new Point(371, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(706, 397);
            dataGridView1.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd MMM yyyy hh:mm tt ";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(153, 99);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(194, 27);
            dateTimePicker1.TabIndex = 13;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // amount
            // 
            amount.AutoSize = true;
            amount.Location = new Point(22, 161);
            amount.Name = "amount";
            amount.Size = new Size(62, 20);
            amount.TabIndex = 14;
            amount.Text = "Amount";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(148, 158);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(199, 27);
            textBox2.TabIndex = 15;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "301-America", "302-Africa", "303-Europe", "304-Asia", "305-australia" });
            comboBox1.Location = new Point(148, 216);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 17;
            // 
            // roomid
            // 
            roomid.AutoSize = true;
            roomid.Location = new Point(22, 216);
            roomid.Name = "roomid";
            roomid.Size = new Size(71, 20);
            roomid.TabIndex = 18;
            roomid.Text = "Room ID:";
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
            // Reservations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 450);
            Controls.Add(newcus);
            Controls.Add(roomid);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(amount);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(delete);
            Controls.Add(insert);
            Controls.Add(load);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Reservations";
            Text = "Form2";
            Load += Reservations_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button load;
        private Button insert;
        private Button delete;
        private Button button4;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private Label amount;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label roomid;
        private Button newcus;
    }
}