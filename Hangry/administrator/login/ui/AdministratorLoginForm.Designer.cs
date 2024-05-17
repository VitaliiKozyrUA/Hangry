namespace Hangry
{
    partial class AdministratorLoginForm
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
            passwordTextBox = new TextBox();
            label2 = new Label();
            logInButton = new Button();
            SuspendLayout();
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(12, 36);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(233, 27);
            passwordTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 13);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 3;
            label2.Text = "Пароль";
            // 
            // logInButton
            // 
            logInButton.Location = new Point(12, 69);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(233, 29);
            logInButton.TabIndex = 4;
            logInButton.Text = "Увійти";
            logInButton.UseVisualStyleBackColor = true;
            logInButton.Click += logInButton_Click;
            // 
            // AdministratorLoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 111);
            Controls.Add(logInButton);
            Controls.Add(label2);
            Controls.Add(passwordTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdministratorLoginForm";
            Text = "Вхід";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox passwordTextBox;
        private Label label2;
        private Button logInButton;
    }
}