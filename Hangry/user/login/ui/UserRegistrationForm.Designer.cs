namespace Hangry.user.login.ui
{
    partial class UserRegistrationForm
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
            haveAccountButton = new Button();
            label1 = new Label();
            passwordTextBox = new TextBox();
            registerButton = new Button();
            label2 = new Label();
            usernameTextBox = new TextBox();
            label3 = new Label();
            addressTextBox = new TextBox();
            SuspendLayout();
            // 
            // haveAccountButton
            // 
            haveAccountButton.Location = new Point(12, 232);
            haveAccountButton.Name = "haveAccountButton";
            haveAccountButton.Size = new Size(233, 29);
            haveAccountButton.TabIndex = 16;
            haveAccountButton.Text = "Вже є аккаунт?";
            haveAccountButton.UseVisualStyleBackColor = true;
            haveAccountButton.Click += haveAccountButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 71);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 15;
            label1.Text = "Пароль";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(12, 94);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(233, 27);
            passwordTextBox.TabIndex = 14;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(12, 197);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(233, 29);
            registerButton.TabIndex = 13;
            registerButton.Text = "Створити аккаунт";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += logInButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 10);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 12;
            label2.Text = "Логін";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(12, 33);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(233, 27);
            usernameTextBox.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 134);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 18;
            label3.Text = "Адреса";
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(12, 157);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(233, 27);
            addressTextBox.TabIndex = 17;
            // 
            // UserRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 272);
            Controls.Add(label3);
            Controls.Add(addressTextBox);
            Controls.Add(haveAccountButton);
            Controls.Add(label1);
            Controls.Add(passwordTextBox);
            Controls.Add(registerButton);
            Controls.Add(label2);
            Controls.Add(usernameTextBox);
            Name = "UserRegistrationForm";
            Text = "Реєстрація";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button haveAccountButton;
        private Label label1;
        private TextBox passwordTextBox;
        private Button registerButton;
        private Label label2;
        private TextBox usernameTextBox;
        private Label label3;
        private TextBox addressTextBox;
    }
}