namespace BankingApp
{
    partial class AccountCreated
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
            log = new Label();
            SuspendLayout();
            // 
            // log
            // 
            log.AutoSize = true;
            log.Location = new Point(12, 34);
            log.Name = "log";
            log.RightToLeft = RightToLeft.No;
            log.Size = new Size(38, 15);
            log.TabIndex = 0;
            log.Text = "label1";
            log.Click += log_Click;
            // 
            // AccountCreated
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 81);
            Controls.Add(log);
            Name = "AccountCreated";
            Text = "AccountCreated";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label log;
    }
}