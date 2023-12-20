namespace EmployeeManagementSystem
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
            this.navbarPanel = new System.Windows.Forms.Panel();
            this.closeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.salaryButton = new System.Windows.Forms.Button();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.salaryUserControl1 = new EmployeeManagementSystem.SalaryUserControl();
            this.dashboardUserControl1 = new EmployeeManagementSystem.DashboardUserControl();
            this.addEmployeeUserControl1 = new EmployeeManagementSystem.AddEmployeeUserControl();
            this.navbarPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // navbarPanel
            // 
            this.navbarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(15)))), ((int)(((byte)(245)))));
            this.navbarPanel.Controls.Add(this.closeLabel);
            this.navbarPanel.Controls.Add(this.label1);
            this.navbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navbarPanel.ForeColor = System.Drawing.Color.White;
            this.navbarPanel.Location = new System.Drawing.Point(0, 0);
            this.navbarPanel.Margin = new System.Windows.Forms.Padding(0);
            this.navbarPanel.Name = "navbarPanel";
            this.navbarPanel.Padding = new System.Windows.Forms.Padding(16);
            this.navbarPanel.Size = new System.Drawing.Size(1084, 52);
            this.navbarPanel.TabIndex = 0;
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeLabel.Location = new System.Drawing.Point(1047, 16);
            this.closeLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 24);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(21, 22);
            this.closeLabel.TabIndex = 8;
            this.closeLabel.Text = "X";
            this.closeLabel.Click += new System.EventHandler(this.closeLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Management System ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.salaryButton);
            this.panel1.Controls.Add(this.addEmployeeButton);
            this.panel1.Controls.Add(this.dashboardButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(278, 709);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 662);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sign Out";
            // 
            // logoutButton
            // 
            this.logoutButton.AutoSize = true;
            this.logoutButton.BackColor = System.Drawing.Color.Red;
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Image = global::EmployeeManagementSystem.Properties.Resources.icons8_logout_rounded_up_filled_25px;
            this.logoutButton.Location = new System.Drawing.Point(16, 656);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(33, 33);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // salaryButton
            // 
            this.salaryButton.AutoSize = true;
            this.salaryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.salaryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salaryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(13)))), ((int)(((byte)(207)))));
            this.salaryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(13)))), ((int)(((byte)(207)))));
            this.salaryButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryButton.ForeColor = System.Drawing.Color.White;
            this.salaryButton.Image = global::EmployeeManagementSystem.Properties.Resources.icons8_Salary_male_30px;
            this.salaryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salaryButton.Location = new System.Drawing.Point(16, 358);
            this.salaryButton.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.salaryButton.Name = "salaryButton";
            this.salaryButton.Padding = new System.Windows.Forms.Padding(8);
            this.salaryButton.Size = new System.Drawing.Size(239, 52);
            this.salaryButton.TabIndex = 4;
            this.salaryButton.Text = "SALARY";
            this.salaryButton.UseVisualStyleBackColor = false;
            this.salaryButton.Click += new System.EventHandler(this.salaryButton_Click);
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.AutoSize = true;
            this.addEmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.addEmployeeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployeeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(13)))), ((int)(((byte)(207)))));
            this.addEmployeeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(13)))), ((int)(((byte)(207)))));
            this.addEmployeeButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeButton.ForeColor = System.Drawing.Color.White;
            this.addEmployeeButton.Image = global::EmployeeManagementSystem.Properties.Resources.icons8_employee_card_30px;
            this.addEmployeeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addEmployeeButton.Location = new System.Drawing.Point(16, 298);
            this.addEmployeeButton.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Padding = new System.Windows.Forms.Padding(8);
            this.addEmployeeButton.Size = new System.Drawing.Size(239, 52);
            this.addEmployeeButton.TabIndex = 3;
            this.addEmployeeButton.Text = "ADD EMPLOYEE";
            this.addEmployeeButton.UseVisualStyleBackColor = false;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.AutoSize = true;
            this.dashboardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.dashboardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(13)))), ((int)(((byte)(207)))));
            this.dashboardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(13)))), ((int)(((byte)(207)))));
            this.dashboardButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton.ForeColor = System.Drawing.Color.White;
            this.dashboardButton.Image = global::EmployeeManagementSystem.Properties.Resources.icons8_dashboard_30px;
            this.dashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.Location = new System.Drawing.Point(16, 238);
            this.dashboardButton.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Padding = new System.Windows.Forms.Padding(8);
            this.dashboardButton.Size = new System.Drawing.Size(239, 52);
            this.dashboardButton.TabIndex = 2;
            this.dashboardButton.Text = "DASHBOARD";
            this.dashboardButton.UseVisualStyleBackColor = false;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome, User!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmployeeManagementSystem.Properties.Resources.icons8_employee_card_100px;
            this.pictureBox1.Location = new System.Drawing.Point(80, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dashboardUserControl1);
            this.panel2.Controls.Add(this.addEmployeeUserControl1);
            this.panel2.Controls.Add(this.salaryUserControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(278, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(806, 709);
            this.panel2.TabIndex = 2;
            // 
            // salaryUserControl1
            // 
            this.salaryUserControl1.Location = new System.Drawing.Point(0, 0);
            this.salaryUserControl1.Name = "salaryUserControl1";
            this.salaryUserControl1.Size = new System.Drawing.Size(806, 709);
            this.salaryUserControl1.TabIndex = 2;
            // 
            // dashboardUserControl1
            // 
            this.dashboardUserControl1.Location = new System.Drawing.Point(0, 0);
            this.dashboardUserControl1.Name = "dashboardUserControl1";
            this.dashboardUserControl1.Size = new System.Drawing.Size(806, 709);
            this.dashboardUserControl1.TabIndex = 1;
            // 
            // addEmployeeUserControl1
            // 
            this.addEmployeeUserControl1.Location = new System.Drawing.Point(0, 0);
            this.addEmployeeUserControl1.Name = "addEmployeeUserControl1";
            this.addEmployeeUserControl1.Padding = new System.Windows.Forms.Padding(20);
            this.addEmployeeUserControl1.Size = new System.Drawing.Size(806, 709);
            this.addEmployeeUserControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 761);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.navbarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.navbarPanel.ResumeLayout(false);
            this.navbarPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navbarPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Button salaryButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private AddEmployeeUserControl addEmployeeUserControl1;
        private SalaryUserControl salaryUserControl1;
        private DashboardUserControl dashboardUserControl1;
    }
}