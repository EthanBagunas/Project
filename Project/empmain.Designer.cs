namespace Project
{
    partial class empmain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(empmain));
            transact = new Button();
            reserve = new Button();
            customer = new Button();
            monthCalendar1 = new MonthCalendar();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox4 = new PictureBox();
            trans = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // transact
            // 
            transact.BackColor = Color.Cyan;
            transact.BackgroundImageLayout = ImageLayout.Center;
            transact.FlatAppearance.BorderColor = Color.Cyan;
            transact.FlatStyle = FlatStyle.Popup;
            transact.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            transact.Location = new Point(772, 446);
            transact.Name = "transact";
            transact.Size = new Size(197, 70);
            transact.TabIndex = 0;
            transact.Text = "Check-In/Check-Out";
            transact.UseVisualStyleBackColor = false;
            transact.Click += transact_Click;
            // 
            // reserve
            // 
            reserve.BackColor = Color.Cyan;
            reserve.BackgroundImageLayout = ImageLayout.Center;
            reserve.FlatAppearance.BorderColor = Color.Cyan;
            reserve.FlatStyle = FlatStyle.Popup;
            reserve.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            reserve.Location = new Point(350, 321);
            reserve.Margin = new Padding(3, 4, 3, 4);
            reserve.Name = "reserve";
            reserve.Size = new Size(197, 70);
            reserve.TabIndex = 1;
            reserve.Text = "Reservations";
            reserve.UseVisualStyleBackColor = false;
            reserve.Click += reserve_Click;
            // 
            // customer
            // 
            customer.BackColor = Color.Cyan;
            customer.BackgroundImageLayout = ImageLayout.Center;
            customer.FlatAppearance.BorderColor = Color.Cyan;
            customer.FlatStyle = FlatStyle.Popup;
            customer.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customer.Location = new Point(350, 446);
            customer.Margin = new Padding(3, 4, 3, 4);
            customer.Name = "customer";
            customer.Size = new Size(197, 70);
            customer.TabIndex = 3;
            customer.Text = "Customer Info";
            customer.UseVisualStyleBackColor = false;
            customer.Click += customer_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(446, 45);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(225, 416);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(225, 291);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 100);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(647, 415);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(540, 16);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 10;
            label1.Text = "Time label";
            label1.Click += label1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(647, 291);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 100);
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // trans
            // 
            trans.BackColor = Color.Cyan;
            trans.BackgroundImageLayout = ImageLayout.Center;
            trans.FlatAppearance.BorderColor = Color.Cyan;
            trans.FlatStyle = FlatStyle.Popup;
            trans.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            trans.Location = new Point(772, 319);
            trans.Margin = new Padding(3, 4, 3, 4);
            trans.Name = "trans";
            trans.Size = new Size(197, 72);
            trans.TabIndex = 12;
            trans.Text = "Transactions";
            trans.UseVisualStyleBackColor = false;
            trans.Click += trans_Click;
            // 
            // empmain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1182, 628);
            Controls.Add(trans);
            Controls.Add(pictureBox4);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(monthCalendar1);
            Controls.Add(customer);
            Controls.Add(reserve);
            Controls.Add(transact);
            Name = "empmain";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button transact;
        private Button reserve;
        private Button customer;
        private MonthCalendar monthCalendar1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox4;
        private Button trans;
    }
}