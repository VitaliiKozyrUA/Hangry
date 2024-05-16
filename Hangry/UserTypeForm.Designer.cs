namespace Hangry
{
    partial class UserTypeForm
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
            administratorButton = new Button();
            userButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 90F);
            label1.Location = new Point(-3, -21);
            label1.Name = "label1";
            label1.Size = new Size(173, 199);
            label1.TabIndex = 0;
            label1.Text = "Я";
            // 
            // administratorButton
            // 
            administratorButton.Location = new Point(137, 38);
            administratorButton.Name = "administratorButton";
            administratorButton.Size = new Size(193, 47);
            administratorButton.TabIndex = 1;
            administratorButton.Text = "Адміністратор";
            administratorButton.UseVisualStyleBackColor = true;
            administratorButton.Click += administratorButton_Click;
            // 
            // userButton
            // 
            userButton.Location = new Point(137, 92);
            userButton.Name = "userButton";
            userButton.Size = new Size(193, 47);
            userButton.TabIndex = 2;
            userButton.Text = "Користувач";
            userButton.UseVisualStyleBackColor = true;
            // 
            // UserTypeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 174);
            Controls.Add(userButton);
            Controls.Add(administratorButton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "UserTypeForm";
            Text = "Вибір типу користувача";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button administratorButton;
        private Button userButton;
    }
}
