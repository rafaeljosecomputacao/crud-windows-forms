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
            txtConnection = new Label();
            SuspendLayout();
            // 
            // txtConnection
            // 
            txtConnection.AutoSize = true;
            txtConnection.Location = new Point(12, 287);
            txtConnection.Name = "txtConnection";
            txtConnection.Size = new Size(75, 15);
            txtConnection.TabIndex = 1;
            txtConnection.Text = "Connection: ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(txtConnection);
            Name = "MainForm";
            Text = "Elite System";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label txtConnection;
    }
}