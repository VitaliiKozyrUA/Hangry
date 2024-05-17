namespace Hangry.administrator.main.ui
{
    partial class EstablishmentsForm
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
            createEstablishmentButton = new Button();
            dataGridView = new DataGridView();
            image = new DataGridViewImageColumn();
            name = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            products = new DataGridViewButtonColumn();
            delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // createEstablishmentButton
            // 
            createEstablishmentButton.Location = new Point(12, 12);
            createEstablishmentButton.Name = "createEstablishmentButton";
            createEstablishmentButton.Size = new Size(94, 29);
            createEstablishmentButton.TabIndex = 0;
            createEstablishmentButton.Text = "Створити";
            createEstablishmentButton.UseVisualStyleBackColor = true;
            createEstablishmentButton.Click += createEstablishmentButton_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { image, name, address, products, delete });
            dataGridView.Location = new Point(12, 47);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 100;
            dataGridView.Size = new Size(849, 418);
            dataGridView.TabIndex = 1;
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
            // address
            // 
            address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            address.HeaderText = "Адреса";
            address.MinimumWidth = 6;
            address.Name = "address";
            // 
            // products
            // 
            products.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            products.FillWeight = 1F;
            products.HeaderText = "Продукти";
            products.MinimumWidth = 6;
            products.Name = "products";
            products.Text = "Продукти";
            products.UseColumnTextForButtonValue = true;
            products.Width = 125;
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 477);
            Controls.Add(dataGridView);
            Controls.Add(createEstablishmentButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "Заклади";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button createEstablishmentButton;
        private DataGridView dataGridView;
        private DataGridViewImageColumn image;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn address;
        private DataGridViewButtonColumn products;
        private DataGridViewButtonColumn delete;
    }
}