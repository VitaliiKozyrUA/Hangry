namespace Hangry.administrator.main.ui
{
    partial class ProductCreationForm
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
            saveButton = new Button();
            descriptionTextBox = new TextBox();
            description = new Label();
            nameTextBox = new TextBox();
            label2 = new Label();
            imagePickerButton = new Button();
            label1 = new Label();
            image = new PictureBox();
            priceTextBox = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)image).BeginInit();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.Location = new Point(14, 273);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(334, 29);
            saveButton.TabIndex = 15;
            saveButton.Text = "Зберегти";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(114, 177);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(234, 27);
            descriptionTextBox.TabIndex = 14;
            // 
            // description
            // 
            description.AutoSize = true;
            description.Location = new Point(11, 177);
            description.Name = "description";
            description.Size = new Size(45, 20);
            description.TabIndex = 13;
            description.Text = "Опис";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(114, 130);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(234, 27);
            nameTextBox.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 130);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 11;
            label2.Text = "Назва";
            // 
            // imagePickerButton
            // 
            imagePickerButton.Location = new Point(220, 12);
            imagePickerButton.Name = "imagePickerButton";
            imagePickerButton.Size = new Size(128, 53);
            imagePickerButton.TabIndex = 10;
            imagePickerButton.Text = "Обрати зображення";
            imagePickerButton.UseVisualStyleBackColor = true;
            imagePickerButton.Click += imagePickerButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 12);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 9;
            label1.Text = "Зображення";
            // 
            // image
            // 
            image.BorderStyle = BorderStyle.FixedSingle;
            image.Location = new Point(114, 12);
            image.Name = "image";
            image.Size = new Size(100, 100);
            image.SizeMode = PictureBoxSizeMode.Zoom;
            image.TabIndex = 8;
            image.TabStop = false;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(114, 223);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(234, 27);
            priceTextBox.TabIndex = 17;
            priceTextBox.KeyPress += priceTextBox_keyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 223);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 16;
            label3.Text = "Ціна";
            // 
            // ProductCreationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 314);
            Controls.Add(priceTextBox);
            Controls.Add(label3);
            Controls.Add(saveButton);
            Controls.Add(descriptionTextBox);
            Controls.Add(description);
            Controls.Add(nameTextBox);
            Controls.Add(label2);
            Controls.Add(imagePickerButton);
            Controls.Add(label1);
            Controls.Add(image);
            Name = "ProductCreationForm";
            Text = "ProductCreationForm";
            ((System.ComponentModel.ISupportInitialize)image).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveButton;
        private TextBox descriptionTextBox;
        private Label description;
        private TextBox nameTextBox;
        private Label label2;
        private Button imagePickerButton;
        private Label label1;
        private PictureBox image;
        private TextBox priceTextBox;
        private Label label3;
    }
}