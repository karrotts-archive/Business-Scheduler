namespace Business_Scheduler.Forms
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Month_Table = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Week_Table = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewAppointment_Button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.NewCustomer_Button = new System.Windows.Forms.Button();
            this.UpdateCustomer_Button = new System.Windows.Forms.Button();
            this.DeleteCustomer_Button = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Close_Button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Month_Table)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Week_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 66);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(332, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(421, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Consulting Scheduling Software";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Main";
            // 
            // Month_Table
            // 
            this.Month_Table.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.Month_Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Month_Table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Month_Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Month_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Month_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Type,
            this.StartTime,
            this.EndTime,
            this.Customer});
            this.Month_Table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Month_Table.Location = new System.Drawing.Point(22, 35);
            this.Month_Table.Name = "Month_Table";
            this.Month_Table.RowHeadersWidth = 51;
            this.Month_Table.RowTemplate.Height = 24;
            this.Month_Table.Size = new System.Drawing.Size(603, 226);
            this.Month_Table.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // Type
            // 
            this.Type.HeaderText = "Appointment Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 125;
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "Start Time";
            this.StartTime.MinimumWidth = 6;
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            this.StartTime.Width = 125;
            // 
            // EndTime
            // 
            this.EndTime.HeaderText = "End Time";
            this.EndTime.MinimumWidth = 6;
            this.EndTime.Name = "EndTime";
            this.EndTime.ReadOnly = true;
            this.EndTime.Width = 125;
            // 
            // Customer
            // 
            this.Customer.HeaderText = "Customer";
            this.Customer.MinimumWidth = 6;
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            this.Customer.Width = 125;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Week_Table);
            this.panel2.Controls.Add(this.Month_Table);
            this.panel2.Location = new System.Drawing.Point(404, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 543);
            this.panel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Weekly Calendar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Monthly Calendar";
            // 
            // Week_Table
            // 
            this.Week_Table.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.Week_Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Week_Table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Week_Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Week_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Week_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.Week_Table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Week_Table.Location = new System.Drawing.Point(22, 302);
            this.Week_Table.Name = "Week_Table";
            this.Week_Table.RowHeadersWidth = 51;
            this.Week_Table.RowTemplate.Height = 24;
            this.Week_Table.Size = new System.Drawing.Size(603, 226);
            this.Week_Table.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Appointment Type";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Start Time";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "End Time";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Customer";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // NewAppointment_Button
            // 
            this.NewAppointment_Button.Location = new System.Drawing.Point(20, 84);
            this.NewAppointment_Button.Name = "NewAppointment_Button";
            this.NewAppointment_Button.Size = new System.Drawing.Size(356, 48);
            this.NewAppointment_Button.TabIndex = 3;
            this.NewAppointment_Button.Text = "New Appointment";
            this.NewAppointment_Button.UseVisualStyleBackColor = true;
            this.NewAppointment_Button.Click += new System.EventHandler(this.NewAppointment_Button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(356, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "View All Appointments";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // NewCustomer_Button
            // 
            this.NewCustomer_Button.Location = new System.Drawing.Point(20, 235);
            this.NewCustomer_Button.Name = "NewCustomer_Button";
            this.NewCustomer_Button.Size = new System.Drawing.Size(356, 48);
            this.NewCustomer_Button.TabIndex = 5;
            this.NewCustomer_Button.Text = "Create New Customer";
            this.NewCustomer_Button.UseVisualStyleBackColor = true;
            this.NewCustomer_Button.Click += new System.EventHandler(this.NewCustomer_Button_Click);
            // 
            // UpdateCustomer_Button
            // 
            this.UpdateCustomer_Button.Location = new System.Drawing.Point(20, 310);
            this.UpdateCustomer_Button.Name = "UpdateCustomer_Button";
            this.UpdateCustomer_Button.Size = new System.Drawing.Size(356, 48);
            this.UpdateCustomer_Button.TabIndex = 6;
            this.UpdateCustomer_Button.Text = "Update Customer Information";
            this.UpdateCustomer_Button.UseVisualStyleBackColor = true;
            this.UpdateCustomer_Button.Click += new System.EventHandler(this.UpdateCustomer_Button_Click);
            // 
            // DeleteCustomer_Button
            // 
            this.DeleteCustomer_Button.Location = new System.Drawing.Point(20, 386);
            this.DeleteCustomer_Button.Name = "DeleteCustomer_Button";
            this.DeleteCustomer_Button.Size = new System.Drawing.Size(356, 48);
            this.DeleteCustomer_Button.TabIndex = 7;
            this.DeleteCustomer_Button.Text = "Delete Customer";
            this.DeleteCustomer_Button.UseVisualStyleBackColor = true;
            this.DeleteCustomer_Button.Click += new System.EventHandler(this.DeleteCustomer_Button_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(20, 458);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(356, 48);
            this.button6.TabIndex = 8;
            this.button6.Text = "Reports";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Close_Button
            // 
            this.Close_Button.Location = new System.Drawing.Point(20, 579);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(356, 48);
            this.Close_Button.TabIndex = 9;
            this.Close_Button.Text = "Close";
            this.Close_Button.UseVisualStyleBackColor = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 658);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.DeleteCustomer_Button);
            this.Controls.Add(this.UpdateCustomer_Button);
            this.Controls.Add(this.NewCustomer_Button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NewAppointment_Button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "CSS - Main Screen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Month_Table)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Week_Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Month_Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Week_Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button NewAppointment_Button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button NewCustomer_Button;
        private System.Windows.Forms.Button UpdateCustomer_Button;
        private System.Windows.Forms.Button DeleteCustomer_Button;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button Close_Button;
    }
}