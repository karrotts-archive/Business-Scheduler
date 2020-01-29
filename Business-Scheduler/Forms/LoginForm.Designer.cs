namespace Business_Scheduler.Forms
{
    partial class LoginForm
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
            this.Username_Box = new System.Windows.Forms.TextBox();
            this.Password_Box = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Company_Label = new System.Windows.Forms.Label();
            this.Login_Label = new System.Windows.Forms.Label();
            this.Login_Button = new System.Windows.Forms.Button();
            this.Error_Message = new System.Windows.Forms.Label();
            this.Username_Label = new System.Windows.Forms.Label();
            this.Password_Label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Username_Box
            // 
            this.Username_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_Box.Location = new System.Drawing.Point(24, 140);
            this.Username_Box.Name = "Username_Box";
            this.Username_Box.Size = new System.Drawing.Size(329, 45);
            this.Username_Box.TabIndex = 0;
            // 
            // Password_Box
            // 
            this.Password_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Box.Location = new System.Drawing.Point(24, 215);
            this.Password_Box.Name = "Password_Box";
            this.Password_Box.PasswordChar = '*';
            this.Password_Box.Size = new System.Drawing.Size(329, 45);
            this.Password_Box.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.Company_Label);
            this.panel1.Controls.Add(this.Login_Label);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 82);
            this.panel1.TabIndex = 2;
            // 
            // Company_Label
            // 
            this.Company_Label.AutoSize = true;
            this.Company_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Company_Label.ForeColor = System.Drawing.SystemColors.Control;
            this.Company_Label.Location = new System.Drawing.Point(21, 10);
            this.Company_Label.Name = "Company_Label";
            this.Company_Label.Size = new System.Drawing.Size(170, 17);
            this.Company_Label.TabIndex = 1;
            this.Company_Label.Text = "Consultant Scheduling";
            // 
            // Login_Label
            // 
            this.Login_Label.AutoSize = true;
            this.Login_Label.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Login_Label.Location = new System.Drawing.Point(10, 29);
            this.Login_Label.Name = "Login_Label";
            this.Login_Label.Size = new System.Drawing.Size(111, 40);
            this.Login_Label.TabIndex = 0;
            this.Login_Label.Text = "Login";
            // 
            // Login_Button
            // 
            this.Login_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Login_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Button.Location = new System.Drawing.Point(24, 284);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(329, 45);
            this.Login_Button.TabIndex = 3;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = false;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Error_Message
            // 
            this.Error_Message.AutoSize = true;
            this.Error_Message.ForeColor = System.Drawing.Color.Red;
            this.Error_Message.Location = new System.Drawing.Point(12, 96);
            this.Error_Message.Name = "Error_Message";
            this.Error_Message.Size = new System.Drawing.Size(0, 17);
            this.Error_Message.TabIndex = 4;
            // 
            // Username_Label
            // 
            this.Username_Label.AutoSize = true;
            this.Username_Label.Location = new System.Drawing.Point(24, 117);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(73, 17);
            this.Username_Label.TabIndex = 5;
            this.Username_Label.Text = "Username";
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Location = new System.Drawing.Point(24, 195);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(69, 17);
            this.Password_Label.TabIndex = 6;
            this.Password_Label.Text = "Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 350);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.Username_Label);
            this.Controls.Add(this.Error_Message);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Password_Box);
            this.Controls.Add(this.Username_Box);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "CSS - Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username_Box;
        private System.Windows.Forms.TextBox Password_Box;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Login_Label;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Label Company_Label;
        private System.Windows.Forms.Label Error_Message;
        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.Label Password_Label;
    }
}

