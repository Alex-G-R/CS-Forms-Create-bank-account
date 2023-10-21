namespace BankingApp
{
    partial class Form1
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
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            name = new TextBox();
            surname = new TextBox();
            label3 = new Label();
            password = new TextBox();
            label4 = new Label();
            initialBalance = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(294, 0);
            label1.Name = "label1";
            label1.Size = new Size(162, 68);
            label1.TabIndex = 0;
            label1.Text = "Bank";
            // 
            // button1
            // 
            button1.Location = new Point(309, 334);
            button1.Name = "button1";
            button1.Size = new Size(147, 52);
            button1.TabIndex = 1;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(309, 96);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // name
            // 
            name.Location = new Point(309, 114);
            name.Name = "name";
            name.Size = new Size(147, 23);
            name.TabIndex = 3;
            // 
            // surname
            // 
            surname.Location = new Point(309, 162);
            surname.Name = "surname";
            surname.Size = new Size(147, 23);
            surname.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(309, 144);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "Surname";
            // 
            // password
            // 
            password.Location = new Point(309, 214);
            password.Name = "password";
            password.Size = new Size(147, 23);
            password.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(309, 196);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // initialBalance
            // 
            initialBalance.Location = new Point(309, 270);
            initialBalance.Name = "initialBalance";
            initialBalance.Size = new Size(147, 23);
            initialBalance.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(309, 252);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 8;
            label5.Text = "Initial balance";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 445);
            Controls.Add(initialBalance);
            Controls.Add(label5);
            Controls.Add(password);
            Controls.Add(label4);
            Controls.Add(surname);
            Controls.Add(label3);
            Controls.Add(name);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox name;
        private TextBox surname;
        private Label label3;
        private TextBox password;
        private Label label4;
        private TextBox initialBalance;
        private Label label5;
    }
}