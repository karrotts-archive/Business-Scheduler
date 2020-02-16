namespace Business_Scheduler.Forms
{
    partial class ReportsForm
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
            this.Reports_Table = new System.Windows.Forms.DataGridView();
            this.ReportOne_Button = new System.Windows.Forms.Button();
            this.ReportTwo_Button = new System.Windows.Forms.Button();
            this.ReportThree_Button = new System.Windows.Forms.Button();
            this.Close_Button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reports_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.Login_Label);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 77);
            this.panel1.TabIndex = 2;
            // 
            // Login_Label
            // 
            this.Login_Label.AutoSize = true;
            this.Login_Label.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Login_Label.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Login_Label.Location = new System.Drawing.Point(11, 19);
            this.Login_Label.Name = "Login_Label";
            this.Login_Label.Size = new System.Drawing.Size(152, 40);
            this.Login_Label.TabIndex = 1;
            this.Login_Label.Text = "Reports";
            // 
            // Reports_Table
            // 
            this.Reports_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Reports_Table.Location = new System.Drawing.Point(307, 108);
            this.Reports_Table.Name = "Reports_Table";
            this.Reports_Table.RowHeadersWidth = 51;
            this.Reports_Table.RowTemplate.Height = 24;
            this.Reports_Table.Size = new System.Drawing.Size(469, 321);
            this.Reports_Table.TabIndex = 3;
            // 
            // ReportOne_Button
            // 
            this.ReportOne_Button.Location = new System.Drawing.Point(57, 108);
            this.ReportOne_Button.Name = "ReportOne_Button";
            this.ReportOne_Button.Size = new System.Drawing.Size(202, 44);
            this.ReportOne_Button.TabIndex = 4;
            this.ReportOne_Button.Text = "Number of Appointments";
            this.ReportOne_Button.UseVisualStyleBackColor = true;
            this.ReportOne_Button.Click += new System.EventHandler(this.ReportOne_Button_Click);
            // 
            // ReportTwo_Button
            // 
            this.ReportTwo_Button.Location = new System.Drawing.Point(57, 175);
            this.ReportTwo_Button.Name = "ReportTwo_Button";
            this.ReportTwo_Button.Size = new System.Drawing.Size(202, 44);
            this.ReportTwo_Button.TabIndex = 5;
            this.ReportTwo_Button.Text = "Consultant Schedules";
            this.ReportTwo_Button.UseVisualStyleBackColor = true;
            this.ReportTwo_Button.Click += new System.EventHandler(this.ReportTwo_Button_Click);
            // 
            // ReportThree_Button
            // 
            this.ReportThree_Button.Location = new System.Drawing.Point(57, 246);
            this.ReportThree_Button.Name = "ReportThree_Button";
            this.ReportThree_Button.Size = new System.Drawing.Size(202, 44);
            this.ReportThree_Button.TabIndex = 6;
            this.ReportThree_Button.Text = "Number of Appointments for each Customer";
            this.ReportThree_Button.UseVisualStyleBackColor = true;
            this.ReportThree_Button.Click += new System.EventHandler(this.ReportThree_Button_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.Location = new System.Drawing.Point(57, 385);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(202, 44);
            this.Close_Button.TabIndex = 7;
            this.Close_Button.Text = "Close";
            this.Close_Button.UseVisualStyleBackColor = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.ReportThree_Button);
            this.Controls.Add(this.ReportTwo_Button);
            this.Controls.Add(this.ReportOne_Button);
            this.Controls.Add(this.Reports_Table);
            this.Controls.Add(this.panel1);
            this.Name = "ReportsForm";
            this.Text = "CSS - Reports";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reports_Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Login_Label;
        private System.Windows.Forms.DataGridView Reports_Table;
        private System.Windows.Forms.Button ReportOne_Button;
        private System.Windows.Forms.Button ReportTwo_Button;
        private System.Windows.Forms.Button ReportThree_Button;
        private System.Windows.Forms.Button Close_Button;
    }
}