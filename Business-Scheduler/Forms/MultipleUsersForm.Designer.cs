namespace Business_Scheduler.Forms
{
    partial class MultipleUsersForm
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
            this.MultipleUsers_Table = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select_Button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MultipleUsers_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.Login_Label);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 77);
            this.panel1.TabIndex = 20;
            // 
            // Login_Label
            // 
            this.Login_Label.AutoSize = true;
            this.Login_Label.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Login_Label.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Login_Label.Location = new System.Drawing.Point(11, 19);
            this.Login_Label.Name = "Login_Label";
            this.Login_Label.Size = new System.Drawing.Size(385, 40);
            this.Login_Label.TabIndex = 1;
            this.Login_Label.Text = "Multiple Users Found";
            // 
            // MultipleUsers_Table
            // 
            this.MultipleUsers_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MultipleUsers_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CustomerName,
            this.Address,
            this.Phone,
            this.Active});
            this.MultipleUsers_Table.Location = new System.Drawing.Point(19, 107);
            this.MultipleUsers_Table.Name = "MultipleUsers_Table";
            this.MultipleUsers_Table.RowHeadersWidth = 51;
            this.MultipleUsers_Table.RowTemplate.Height = 24;
            this.MultipleUsers_Table.Size = new System.Drawing.Size(753, 278);
            this.MultipleUsers_Table.TabIndex = 21;
            this.MultipleUsers_Table.SelectionChanged += new System.EventHandler(this.MultipleUsers_Table_SelectionChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 125;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 200;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 75;
            // 
            // Active
            // 
            this.Active.HeaderText = "Active";
            this.Active.MinimumWidth = 6;
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            this.Active.Width = 55;
            // 
            // Select_Button
            // 
            this.Select_Button.Enabled = false;
            this.Select_Button.Location = new System.Drawing.Point(664, 404);
            this.Select_Button.Name = "Select_Button";
            this.Select_Button.Size = new System.Drawing.Size(108, 34);
            this.Select_Button.TabIndex = 22;
            this.Select_Button.Text = "Select";
            this.Select_Button.UseVisualStyleBackColor = true;
            this.Select_Button.Click += new System.EventHandler(this.Select_Button_Click);
            // 
            // MultipleUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Select_Button);
            this.Controls.Add(this.MultipleUsers_Table);
            this.Controls.Add(this.panel1);
            this.Name = "MultipleUsersForm";
            this.Text = "Multiple Users Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MultipleUsers_Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Login_Label;
        private System.Windows.Forms.DataGridView MultipleUsers_Table;
        private System.Windows.Forms.Button Select_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Active;
    }
}