namespace Hangry.administrator.main.ui
{
    partial class EstablishmentCreationForm
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
            image = new PictureBox();
            label1 = new Label();
            imagePickerButton = new Button();
            label2 = new Label();
            nameTextBox = new TextBox();
            addressTextBox = new TextBox();
            label3 = new Label();
            saveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)image).BeginInit();
            SuspendLayout();
            // 
            // image
            // 
            image.BorderStyle = BorderStyle.FixedSingle;
            image.Location = new Point(115, 9);
            image.Name = "image";
            image.Size = new Size(100, 100);
            image.SizeMode = PictureBoxSizeMode.Zoom;
            image.TabIndex = 0;
            image.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 1;
            label1.Text = "Зображення";
            // 
            // imagePickerButton
            // 
            imagePickerButton.Location = new Point(221, 9);
            imagePickerButton.Name = "imagePickerButton";
            imagePickerButton.Size = new Size(128, 53);
            imagePickerButton.TabIndex = 2;
            imagePickerButton.Text = "Обрати зображення";
            imagePickerButton.UseVisualStyleBackColor = true;
            imagePickerButton.Click += imagePickerButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 127);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 3;
            label2.Text = "Назва";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(115, 127);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(234, 27);
            nameTextBox.TabIndex = 4;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(115, 174);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(234, 27);
            addressTextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 174);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 5;
            label3.Text = "Адреса";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(15, 219);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(334, 29);
            saveButton.TabIndex = 7;
            saveButton.Text = "Зберегти";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // EstablishmentCreationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 260);
            Controls.Add(saveButton);
            Controls.Add(addressTextBox);
            Controls.Add(label3);
            Controls.Add(nameTextBox);
            Controls.Add(label2);
            Controls.Add(imagePickerButton);
            Controls.Add(label1);
            Controls.Add(image);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "EstablishmentCreationForm";
            Text = "Створення закладу";
            ((System.ComponentModel.ISupportInitialize)image).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox image;
        private Label label1;
        private Button imagePickerButton;
        private Label label2;
        private TextBox nameTextBox;
        private TextBox addressTextBox;
        private Label label3;
        private Button saveButton;
    }
}