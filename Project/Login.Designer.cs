namespace Project
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            user = new Label();
            pass = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            login1 = new Button();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // user
            // 
            user.Anchor = AnchorStyles.None;
            user.AutoSize = true;
            user.Location = new Point(231, 245);
            user.Name = "user";
            user.Size = new Size(78, 20);
            user.TabIndex = 0;
            user.Text = "Username:";
            // 
            // pass
            // 
            pass.Anchor = AnchorStyles.None;
            pass.AutoSize = true;
            pass.Location = new Point(231, 297);
            pass.Name = "pass";
            pass.Size = new Size(73, 20);
            pass.TabIndex = 1;
            pass.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(310, 245);
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Horizontal;
            textBox1.Size = new Size(221, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(310, 292);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(221, 27);
            textBox2.TabIndex = 3;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // login1
            // 
            login1.Anchor = AnchorStyles.None;
            login1.Location = new Point(367, 370);
            login1.Name = "login1";
            login1.Size = new Size(94, 29);
            login1.TabIndex = 4;
            login1.Text = "login";
            login1.UseVisualStyleBackColor = true;
            login1.Click += login1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(340, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(340, 340);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "show password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox1);
            Controls.Add(login1);
            Controls.Add(textBox2);
            Controls.Add(user);
            Controls.Add(textBox1);
            Controls.Add(pass);
            Name = "Login";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label user;
        private Label pass;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button login;
        private Button login1;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}