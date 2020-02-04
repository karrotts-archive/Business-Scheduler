namespace Business_Scheduler.Forms
{
    partial class AppointmentForm
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
            this.Login_Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CustomerSearch_Box = new System.Windows.Forms.TextBox();
            this.Search_Button = new System.Windows.Forms.Button();
            this.CustomerSearch_Label = new System.Windows.Forms.Label();
            this.Title_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Description_Box = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Location_Box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Contact_Box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Type_Box = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.URL_Box = new System.Windows.Forms.TextBox();
            this.StartDate_Date = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Create_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.StartDate_Time = new System.Windows.Forms.DateTimePicker();
            this.EndDate_Time = new System.Windows.Forms.DateTimePicker();
            this.EndDate_Date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerName_Box = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_Label
            // 
            this.Login_Label.AutoSize = true;
            this.Login_Label.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Login_Label.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Login_Label.Location = new System.Drawing.Point(11, 19);
            this.Login_Label.Name = "Login_Label";
            this.Login_Label.Size = new System.Drawing.Size(330, 40);
            this.Login_Label.TabIndex = 1;
            this.Login_Label.Text = "New Appointment";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.Login_Label);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 77);
            this.panel1.TabIndex = 1;
            // 
            // CustomerSearch_Box
            // 
            this.CustomerSearch_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerSearch_Box.Location = new System.Drawing.Point(23, 119);
            this.CustomerSearch_Box.Name = "CustomerSearch_Box";
            this.CustomerSearch_Box.Size = new System.Drawing.Size(185, 36);
            this.CustomerSearch_Box.TabIndex = 2;
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(224, 119);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(95, 36);
            this.Search_Button.TabIndex = 3;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // CustomerSearch_Label
            // 
            this.CustomerSearch_Label.AutoSize = true;
            this.CustomerSearch_Label.Location = new System.Drawing.Point(23, 97);
            this.CustomerSearch_Label.Name = "CustomerSearch_Label";
            this.CustomerSearch_Label.Size = new System.Drawing.Size(117, 17);
            this.CustomerSearch_Label.TabIndex = 4;
            this.CustomerSearch_Label.Text = "Customer Search";
            // 
            // Title_Box
            // 
            this.Title_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Box.Location = new System.Drawing.Point(23, 267);
            this.Title_Box.Name = "Title_Box";
            this.Title_Box.Size = new System.Drawing.Size(296, 36);
            this.Title_Box.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Description";
            // 
            // Description_Box
            // 
            this.Description_Box.Location = new System.Drawing.Point(23, 332);
            this.Description_Box.Name = "Description_Box";
            this.Description_Box.Size = new System.Drawing.Size(296, 112);
            this.Description_Box.TabIndex = 11;
            this.Description_Box.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Location";
            // 
            // Location_Box
            // 
            this.Location_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location_Box.Location = new System.Drawing.Point(23, 470);
            this.Location_Box.Name = "Location_Box";
            this.Location_Box.Size = new System.Drawing.Size(296, 36);
            this.Location_Box.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Contact";
            // 
            // Contact_Box
            // 
            this.Contact_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact_Box.Location = new System.Drawing.Point(372, 119);
            this.Contact_Box.Name = "Contact_Box";
            this.Contact_Box.Size = new System.Drawing.Size(296, 36);
            this.Contact_Box.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "*Type";
            // 
            // Type_Box
            // 
            this.Type_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type_Box.Location = new System.Drawing.Point(372, 193);
            this.Type_Box.Name = "Type_Box";
            this.Type_Box.Size = new System.Drawing.Size(296, 36);
            this.Type_Box.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(372, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "URL";
            // 
            // URL_Box
            // 
            this.URL_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URL_Box.Location = new System.Drawing.Point(372, 267);
            this.URL_Box.Name = "URL_Box";
            this.URL_Box.Size = new System.Drawing.Size(296, 36);
            this.URL_Box.TabIndex = 18;
            // 
            // StartDate_Date
            // 
            this.StartDate_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDate_Date.Location = new System.Drawing.Point(372, 354);
            this.StartDate_Date.Name = "StartDate_Date";
            this.StartDate_Date.Size = new System.Drawing.Size(167, 22);
            this.StartDate_Date.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(372, 334);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "*Start Date and Time";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(372, 402);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "*End Date and Time";
            // 
            // Create_Button
            // 
            this.Create_Button.Location = new System.Drawing.Point(581, 477);
            this.Create_Button.Name = "Create_Button";
            this.Create_Button.Size = new System.Drawing.Size(87, 31);
            this.Create_Button.TabIndex = 26;
            this.Create_Button.Text = "Create";
            this.Create_Button.UseVisualStyleBackColor = true;
            this.Create_Button.Click += new System.EventHandler(this.Create_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(478, 477);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(87, 31);
            this.Cancel_Button.TabIndex = 27;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // StartDate_Time
            // 
            this.StartDate_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartDate_Time.Location = new System.Drawing.Point(545, 354);
            this.StartDate_Time.Name = "StartDate_Time";
            this.StartDate_Time.ShowUpDown = true;
            this.StartDate_Time.Size = new System.Drawing.Size(123, 22);
            this.StartDate_Time.TabIndex = 28;
            // 
            // EndDate_Time
            // 
            this.EndDate_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndDate_Time.Location = new System.Drawing.Point(545, 422);
            this.EndDate_Time.Name = "EndDate_Time";
            this.EndDate_Time.ShowUpDown = true;
            this.EndDate_Time.Size = new System.Drawing.Size(123, 22);
            this.EndDate_Time.TabIndex = 30;
            // 
            // EndDate_Date
            // 
            this.EndDate_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDate_Date.Location = new System.Drawing.Point(372, 422);
            this.EndDate_Date.Name = "EndDate_Date";
            this.EndDate_Date.Size = new System.Drawing.Size(167, 22);
            this.EndDate_Date.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "*Customer Name";
            // 
            // CustomerName_Box
            // 
            this.CustomerName_Box.Enabled = false;
            this.CustomerName_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName_Box.Location = new System.Drawing.Point(23, 193);
            this.CustomerName_Box.Name = "CustomerName_Box";
            this.CustomerName_Box.Size = new System.Drawing.Size(296, 36);
            this.CustomerName_Box.TabIndex = 31;
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 529);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerName_Box);
            this.Controls.Add(this.EndDate_Time);
            this.Controls.Add(this.EndDate_Date);
            this.Controls.Add(this.StartDate_Time);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Create_Button);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.StartDate_Date);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.URL_Box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Type_Box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Contact_Box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Location_Box);
            this.Controls.Add(this.Description_Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Title_Box);
            this.Controls.Add(this.CustomerSearch_Label);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.CustomerSearch_Box);
            this.Controls.Add(this.panel1);
            this.Name = "AppointmentForm";
            this.Text = "CSS - New Appointment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login_Label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox CustomerSearch_Box;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Label CustomerSearch_Label;
        private System.Windows.Forms.TextBox Title_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox Description_Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Location_Box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Contact_Box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Type_Box;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox URL_Box;
        private System.Windows.Forms.DateTimePicker StartDate_Date;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Create_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.DateTimePicker StartDate_Time;
        private System.Windows.Forms.DateTimePicker EndDate_Time;
        private System.Windows.Forms.DateTimePicker EndDate_Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomerName_Box;
    }
}