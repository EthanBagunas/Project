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
            updatebox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(48, 163);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(768, 339);
            dataGridView1.TabIndex = 1;
            // 
            // status
            // 
            status.Location = new Point(200, 89);
            status.Name = "status";
            status.Size = new Size(197, 29);
            status.TabIndex = 2;
            status.Text = "Room Status";
            status.UseVisualStyleBackColor = true;
            status.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(83, 89);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 5;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Update
            // 
            Update.AutoSize = true;
            Update.Location = new Point(83, 38);
            Update.Name = "Update";
            Update.Size = new Size(58, 20);
            Update.TabIndex = 6;
            Update.Text = "Update";
            // 
            // updatebox
            // 
            updatebox.FormattingEnabled = true;
            updatebox.Items.AddRange(new object[] { "OPEN", "RESERVED", "OCCUPIED" });
            updatebox.Location = new Point(200, 35);
            updatebox.Name = "updatebox";
            updatebox.Size = new Size(197, 28);
            updatebox.TabIndex = 7;
            // 
            // checkin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(updatebox);
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
        private ComboBox updatebox;
    }
}