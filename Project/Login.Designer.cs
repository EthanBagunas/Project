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
            checkBox1 = new CheckBox();
            pictureBox1 = new PictureBox();
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
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(221, 27);
            textBox2.TabIndex = 3;
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
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.None;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(377, 215);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(73, 24);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "admin";
            checkBox1.UseVisualStyleBackColor = true;
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
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(checkBox1);
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
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
    }
}