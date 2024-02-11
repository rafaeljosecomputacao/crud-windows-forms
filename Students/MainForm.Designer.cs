namespace Students
{
    partial class MainForm
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
            lblConnection = new Label();
            lblTitle = new Label();
            lblName = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            btnSave = new Button();
            dgvStudents = new DataGridView();
            btnNew = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // lblConnection
            // 
            lblConnection.AutoSize = true;
            lblConnection.BackColor = Color.Transparent;
            lblConnection.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblConnection.ForeColor = Color.FromArgb(64, 64, 64);
            lblConnection.Location = new Point(12, 288);
            lblConnection.Name = "lblConnection";
            lblConnection.Size = new Size(67, 14);
            lblConnection.TabIndex = 1;
            lblConnection.Text = "Connection: ";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(302, 22);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Management of the Elite School";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.ForeColor = Color.FromArgb(64, 64, 64);
            lblName.Location = new Point(12, 53);
            lblName.Name = "lblName";
            lblName.Size = new Size(41, 16);
            lblName.TabIndex = 3;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = Color.FromArgb(64, 64, 64);
            txtName.Location = new Point(12, 72);
            txtName.Name = "txtName";
            txtName.Size = new Size(270, 19);
            txtName.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.FromArgb(64, 64, 64);
            txtEmail.Location = new Point(305, 72);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(267, 19);
            txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.ForeColor = Color.FromArgb(64, 64, 64);
            lblEmail.Location = new Point(305, 53);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(40, 16);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DodgerBlue;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.InfoText;
            btnSave.Location = new Point(472, 153);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 40);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // dgvStudents
            // 
            dgvStudents.BackgroundColor = Color.White;
            dgvStudents.BorderStyle = BorderStyle.None;
            dgvStudents.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.GridColor = Color.Silver;
            dgvStudents.Location = new Point(12, 107);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowTemplate.Height = 25;
            dgvStudents.Size = new Size(454, 178);
            dgvStudents.TabIndex = 12;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.ForestGreen;
            btnNew.FlatAppearance.BorderSize = 0;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.ForeColor = SystemColors.InfoText;
            btnNew.Location = new Point(472, 107);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(100, 40);
            btnNew.TabIndex = 13;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.InfoText;
            btnDelete.Location = new Point(472, 245);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 40);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Yellow;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.InfoText;
            btnUpdate.Location = new Point(472, 199);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 40);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(584, 311);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(dgvStudents);
            Controls.Add(btnSave);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Controls.Add(lblConnection);
            Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainForm";
            RightToLeftLayout = true;
            Text = "Elite System";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblConnection;
        private Label lblTitle;
        private Label lblName;
        private TextBox txtName;
        private TextBox txtEmail;
        private Label lblEmail;
        private Button btnSave;
        private DataGridView dgvStudents;
        private Button btnNew;
        private Button btnDelete;
        private Button btnUpdate;
    }
}