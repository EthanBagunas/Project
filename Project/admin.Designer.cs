﻿namespace Project
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
            Reservation = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Customers
            // 
            Customers.Location = new Point(199, 360);
            Customers.Name = "Customers";
            Customers.Size = new Size(150, 55);
            Customers.TabIndex = 0;
            Customers.Text = "Customers";
            Customers.UseVisualStyleBackColor = true;
            Customers.Click += customer_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(756, 329);
            dataGridView1.TabIndex = 1;
            // 
            // room
            // 
            room.Location = new Point(29, 360);
            room.Name = "room";
            room.Size = new Size(150, 55);
            room.TabIndex = 2;
            room.Text = "Rooms";
            room.UseVisualStyleBackColor = true;
            room.Click += room_Click;
            // 
            // Reservation
            // 
            Reservation.Location = new Point(390, 360);
            Reservation.Name = "Reservation";
            Reservation.Size = new Size(150, 55);
            Reservation.TabIndex = 3;
            Reservation.Text = "Reservations";
            Reservation.UseVisualStyleBackColor = true;
            Reservation.Click += Reservation_Click;
            // 
            // admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Reservation);
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
        private Button Reservation;
    }
}