namespace Hangry.user.login.ui
{
    partial class UserLoginForm
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
            noAccountButton = new Button();
            label1 = new Label();
            passwordTextBox = new TextBox();
            logInButton = new Button();
            label2 = new Label();
            usernameTextBox = new TextBox();
            SuspendLayout();
            // 
            // noAccountButton
            // 
            noAccountButton.Location = new Point(12, 173);
            noAccountButton.Name = "noAccountButton";
            noAccountButton.Size = new Size(233, 29);
            noAccountButton.TabIndex = 24;
            noAccountButton.Text = "Немає аккаунту?";
            noAccountButton.UseVisualStyleBackColor = true;
            noAccountButton.Click += noAccountButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 72);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 23;
            label1.Text = "Пароль";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(12, 95);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(233, 27);
            passwordTextBox.TabIndex = 22;
            // 
            // logInButton
            // 
            logInButton.Location = new Point(12, 138);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(233, 29);
            logInButton.TabIndex = 21;
            logInButton.Text = "Увійти";
            logInButton.UseVisualStyleBackColor = true;
            logInButton.Click += logInButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 11);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 20;
            label2.Text = "Логін";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(12, 34);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(233, 27);
            usernameTextBox.TabIndex = 19;
            // 
            // UserLoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(258, 215);
            Controls.Add(noAccountButton);
            Controls.Add(label1);
            Controls.Add(passwordTextBox);
            Controls.Add(logInButton);
            Controls.Add(label2);
            Controls.Add(usernameTextBox);
            Name = "UserLoginForm";
            Text = "Вхід";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button noAccountButton;
        private Label label1;
        private TextBox passwordTextBox;
        private Button logInButton;
        private Label label2;
        private TextBox usernameTextBox;
    }
}