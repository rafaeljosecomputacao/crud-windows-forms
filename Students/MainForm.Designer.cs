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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblConnection = new Label();
            lblTitle = new Label();
            lblName = new Label();
            lblEmail = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            btnNew = new Button();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvStudents = new DataGridView();
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
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.ForeColor = Color.FromArgb(64, 64, 64);
            lblEmail.Location = new Point(305, 53);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(40, 16);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = Color.FromArgb(64, 64, 64);
            txtName.Location = new Point(12, 72);
            txtName.Name = "txtName";
            txtName.RightToLeft = RightToLeft.No;
            txtName.Size = new Size(267, 15);
            txtName.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.FromArgb(64, 64, 64);
            txtEmail.Location = new Point(305, 72);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(267, 15);
            txtEmail.TabIndex = 6;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.ForestGreen;
            btnNew.FlatAppearance.BorderSize = 0;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.ForeColor = SystemColors.ControlText;
            btnNew.Location = new Point(472, 107);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(100, 40);
            btnNew.TabIndex = 7;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DodgerBlue;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ControlText;
            btnSave.Location = new Point(472, 153);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 40);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Yellow;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.ControlText;
            btnUpdate.Location = new Point(472, 199);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 40);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ControlText;
            btnDelete.Location = new Point(472, 245);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 40);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.AllowUserToResizeColumns = false;
            dgvStudents.AllowUserToResizeRows = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.BackgroundColor = Color.FromArgb(64, 64, 64);
            dgvStudents.BorderStyle = BorderStyle.None;
            dgvStudents.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvStudents.DefaultCellStyle = dataGridViewCellStyle2;
            dgvStudents.EnableHeadersVisualStyles = false;
            dgvStudents.GridColor = Color.LightGray;
            dgvStudents.Location = new Point(12, 107);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvStudents.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvStudents.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgvStudents.RowTemplate.DefaultCellStyle.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dgvStudents.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            dgvStudents.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            dgvStudents.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dgvStudents.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvStudents.RowTemplate.Height = 20;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(454, 178);
            dgvStudents.TabIndex = 11;
            dgvStudents.CellContentClick += dgvStudents_CellContentClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(584, 311);
            Controls.Add(dgvStudents);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(lblEmail);
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
        private Label lblEmail;
        private TextBox txtName;
        private TextBox txtEmail;
        private Button btnNew;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvStudents;
    }
}