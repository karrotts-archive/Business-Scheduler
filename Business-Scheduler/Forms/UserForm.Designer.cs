namespace Business_Scheduler.Forms
{
    partial class UserForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Login_Label = new System.Windows.Forms.Label();
            this.Name_Box = new System.Windows.Forms.TextBox();
            this.AddressOne_Box = new System.Windows.Forms.TextBox();
            this.AddressTwo_Box = new System.Windows.Forms.TextBox();
            this.PostalCode_Box = new System.Windows.Forms.TextBox();
            this.City_Box = new System.Windows.Forms.TextBox();
            this.Country_Box = new System.Windows.Forms.TextBox();
            this.PhoneNumber_Box = new System.Windows.Forms.TextBox();
            this.Create_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Active_Radio = new System.Windows.Forms.RadioButton();
            this.Disabled_Radio = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.Login_Label);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 77);
            this.panel1.TabIndex = 0;
            // 
            // Login_Label
            // 
            this.Login_Label.AutoSize = true;
            this.Login_Label.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Login_Label.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Login_Label.Location = new System.Drawing.Point(11, 19);
            this.Login_Label.Name = "Login_Label";
            this.Login_Label.Size = new System.Drawing.Size(273, 40);
            this.Login_Label.TabIndex = 1;
            this.Login_Label.Text = "New Customer";
            // 
            // Name_Box
            // 
            this.Name_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Box.Location = new System.Drawing.Point(34, 132);
            this.Name_Box.Name = "Name_Box";
            this.Name_Box.Size = new System.Drawing.Size(337, 36);
            this.Name_Box.TabIndex = 1;
            // 
            // AddressOne_Box
            // 
            this.AddressOne_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressOne_Box.Location = new System.Drawing.Point(34, 203);
            this.AddressOne_Box.Name = "AddressOne_Box";
            this.AddressOne_Box.Size = new System.Drawing.Size(337, 36);
            this.AddressOne_Box.TabIndex = 2;
            // 
            // AddressTwo_Box
            // 
            this.AddressTwo_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTwo_Box.Location = new System.Drawing.Point(34, 269);
            this.AddressTwo_Box.Name = "AddressTwo_Box";
            this.AddressTwo_Box.Size = new System.Drawing.Size(337, 36);
            this.AddressTwo_Box.TabIndex = 3;
            // 
            // PostalCode_Box
            // 
            this.PostalCode_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostalCode_Box.Location = new System.Drawing.Point(34, 335);
            this.PostalCode_Box.Name = "PostalCode_Box";
            this.PostalCode_Box.Size = new System.Drawing.Size(153, 36);
            this.PostalCode_Box.TabIndex = 4;
            // 
            // City_Box
            // 
            this.City_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City_Box.Location = new System.Drawing.Point(217, 335);
            this.City_Box.Name = "City_Box";
            this.City_Box.Size = new System.Drawing.Size(154, 36);
            this.City_Box.TabIndex = 5;
            // 
            // Country_Box
            // 
            this.Country_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Country_Box.Location = new System.Drawing.Point(33, 404);
            this.Country_Box.Name = "Country_Box";
            this.Country_Box.Size = new System.Drawing.Size(338, 36);
            this.Country_Box.TabIndex = 6;
            // 
            // PhoneNumber_Box
            // 
            this.PhoneNumber_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumber_Box.Location = new System.Drawing.Point(33, 474);
            this.PhoneNumber_Box.Name = "PhoneNumber_Box";
            this.PhoneNumber_Box.Size = new System.Drawing.Size(338, 36);
            this.PhoneNumber_Box.TabIndex = 7;
            // 
            // Create_Button
            // 
            this.Create_Button.Location = new System.Drawing.Point(34, 572);
            this.Create_Button.Name = "Create_Button";
            this.Create_Button.Size = new System.Drawing.Size(337, 50);
            this.Create_Button.TabIndex = 8;
            this.Create_Button.Text = "Create Customer";
            this.Create_Button.UseVisualStyleBackColor = true;
            this.Create_Button.Click += new System.EventHandler(this.Create_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "*Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "*Address Line 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Address Line 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "*Postal Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "*City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "*Country";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 454);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "*Phone Number";
            // 
            // Active_Radio
            // 
            this.Active_Radio.AutoSize = true;
            this.Active_Radio.Location = new System.Drawing.Point(98, 534);
            this.Active_Radio.Name = "Active_Radio";
            this.Active_Radio.Size = new System.Drawing.Size(67, 21);
            this.Active_Radio.TabIndex = 16;
            this.Active_Radio.TabStop = true;
            this.Active_Radio.Text = "Active";
            this.Active_Radio.UseVisualStyleBackColor = true;
            // 
            // Disabled_Radio
            // 
            this.Disabled_Radio.AutoSize = true;
            this.Disabled_Radio.Location = new System.Drawing.Point(217, 534);
            this.Disabled_Radio.Name = "Disabled_Radio";
            this.Disabled_Radio.Size = new System.Drawing.Size(84, 21);
            this.Disabled_Radio.TabIndex = 17;
            this.Disabled_Radio.TabStop = true;
            this.Disabled_Radio.Text = "Disabled";
            this.Disabled_Radio.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "* Required";
            // 
            // UserForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 648);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Disabled_Radio);
            this.Controls.Add(this.Active_Radio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Create_Button);
            this.Controls.Add(this.PhoneNumber_Box);
            this.Controls.Add(this.Country_Box);
            this.Controls.Add(this.City_Box);
            this.Controls.Add(this.PostalCode_Box);
            this.Controls.Add(this.AddressTwo_Box);
            this.Controls.Add(this.AddressOne_Box);
            this.Controls.Add(this.Name_Box);
            this.Controls.Add(this.panel1);
            this.Name = "UserForms";
            this.Text = "CSS - New Customer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Name_Box;
        private System.Windows.Forms.TextBox AddressOne_Box;
        private System.Windows.Forms.TextBox AddressTwo_Box;
        private System.Windows.Forms.TextBox PostalCode_Box;
        private System.Windows.Forms.TextBox City_Box;
        private System.Windows.Forms.TextBox Country_Box;
        private System.Windows.Forms.TextBox PhoneNumber_Box;
        private System.Windows.Forms.Button Create_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton Active_Radio;
        private System.Windows.Forms.RadioButton Disabled_Radio;
        private System.Windows.Forms.Label Login_Label;
        private System.Windows.Forms.Label label8;
    }
}