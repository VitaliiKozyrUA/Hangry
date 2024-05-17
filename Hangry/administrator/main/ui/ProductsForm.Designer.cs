namespace Hangry.administrator.main.ui
{
    partial class ProductsForm
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
            dataGridView = new DataGridView();
            image = new DataGridViewImageColumn();
            name = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            delete = new DataGridViewButtonColumn();
            createProductButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { image, name, description, price, delete });
            dataGridView.Location = new Point(12, 47);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 100;
            dataGridView.Size = new Size(849, 418);
            dataGridView.TabIndex = 3;
            dataGridView.CellContentClick += onCellContentClicked;
            // 
            // image
            // 
            image.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            image.HeaderText = "Зображення";
            image.ImageLayout = DataGridViewImageCellLayout.Zoom;
            image.MinimumWidth = 25;
            image.Name = "image";
            image.Width = 125;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.HeaderText = "Назва";
            name.MinimumWidth = 6;
            name.Name = "name";
            // 
            // description
            // 
            description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            description.HeaderText = "Опис";
            description.MinimumWidth = 6;
            description.Name = "description";
            // 
            // price
            // 
            price.HeaderText = "Ціна";
            price.MinimumWidth = 6;
            price.Name = "price";
            price.Width = 125;
            // 
            // delete
            // 
            delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            delete.FillWeight = 1F;
            delete.HeaderText = "Видалити";
            delete.MinimumWidth = 6;
            delete.Name = "delete";
            delete.Text = "Видалити";
            delete.UseColumnTextForButtonValue = true;
            delete.Width = 125;
            // 
            // createProductButton
            // 
            createProductButton.Location = new Point(12, 12);
            createProductButton.Name = "createProductButton";
            createProductButton.Size = new Size(94, 29);
            createProductButton.TabIndex = 2;
            createProductButton.Text = "Створити";
            createProductButton.UseVisualStyleBackColor = true;
            createProductButton.Click += createProductButton_Click;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 481);
            Controls.Add(dataGridView);
            Controls.Add(createProductButton);
            Name = "ProductsForm";
            Text = "Продукти";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private Button createProductButton;
        private DataGridViewImageColumn image;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn price;
        private DataGridViewButtonColumn delete;
    }
}