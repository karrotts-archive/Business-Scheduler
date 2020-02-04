namespace Business_Scheduler.Forms
{
    partial class ViewAppointmentForm
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
            this.Appointments_Table = new System.Windows.Forms.DataGridView();
            this.Update_Button = new System.Windows.Forms.Button();
            this.Close_Button = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Appointments_Table)).BeginInit();
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
            this.Login_Label.Size = new System.Drawing.Size(317, 40);
            this.Login_Label.TabIndex = 1;
            this.Login_Label.Text = "All Appointments";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.Login_Label);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 77);
            this.panel1.TabIndex = 2;
            // 
            // Appointments_Table
            // 
            this.Appointments_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Appointments_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.AppointmentTitle,
            this.AppointmentType,
            this.StartTime,
            this.EndTime,
            this.Customer});
            this.Appointments_Table.Location = new System.Drawing.Point(19, 99);
            this.Appointments_Table.Name = "Appointments_Table";
            this.Appointments_Table.RowHeadersWidth = 51;
            this.Appointments_Table.RowTemplate.Height = 24;
            this.Appointments_Table.Size = new System.Drawing.Size(756, 329);
            this.Appointments_Table.TabIndex = 3;
            this.Appointments_Table.SelectionChanged += new System.EventHandler(this.Appointments_Table_SelectionChanged);
            // 
            // Update_Button
            // 
            this.Update_Button.Enabled = false;
            this.Update_Button.Location = new System.Drawing.Point(658, 442);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(117, 35);
            this.Update_Button.TabIndex = 4;
            this.Update_Button.Text = "Update";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.Location = new System.Drawing.Point(400, 442);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(117, 35);
            this.Close_Button.TabIndex = 5;
            this.Close_Button.Text = "Close";
            this.Close_Button.UseVisualStyleBackColor = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // AppointmentTitle
            // 
            this.AppointmentTitle.HeaderText = "Title";
            this.AppointmentTitle.MinimumWidth = 6;
            this.AppointmentTitle.Name = "AppointmentTitle";
            this.AppointmentTitle.ReadOnly = true;
            this.AppointmentTitle.Width = 125;
            // 
            // AppointmentType
            // 
            this.AppointmentType.HeaderText = "Type";
            this.AppointmentType.MinimumWidth = 6;
            this.AppointmentType.Name = "AppointmentType";
            this.AppointmentType.ReadOnly = true;
            // 
            // StartTime
            // 
            this.StartTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StartTime.HeaderText = "Start Time";
            this.StartTime.MinimumWidth = 6;
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            this.StartTime.Width = 102;
            // 
            // EndTime
            // 
            this.EndTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.EndTime.HeaderText = "End Time";
            this.EndTime.MinimumWidth = 6;
            this.EndTime.Name = "EndTime";
            this.EndTime.ReadOnly = true;
            this.EndTime.Width = 97;
            // 
            // Customer
            // 
            this.Customer.HeaderText = "Customer";
            this.Customer.MinimumWidth = 6;
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            this.Customer.Width = 125;
            // 
            // Delete_Button
            // 
            this.Delete_Button.Enabled = false;
            this.Delete_Button.Location = new System.Drawing.Point(529, 442);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(117, 35);
            this.Delete_Button.TabIndex = 6;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // ViewAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 490);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.Appointments_Table);
            this.Controls.Add(this.panel1);
            this.Name = "ViewAppointmentForm";
            this.Text = "CSS - All Appointments";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Appointments_Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Login_Label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Appointments_Table;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.Button Delete_Button;
    }
}