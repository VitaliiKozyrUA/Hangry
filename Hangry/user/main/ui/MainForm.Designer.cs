namespace Hangry.user.main.ui
{
    partial class MainForm
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
            profilePanel = new Panel();
            ordersDataGridView = new DataGridView();
            dateTextBox = new DataGridViewTextBoxColumn();
            productNameTextBox = new DataGridViewTextBoxColumn();
            sumTextBox = new DataGridViewTextBoxColumn();
            countTextBox = new DataGridViewTextBoxColumn();
            label2 = new Label();
            usernameLabel = new Label();
            label1 = new Label();
            profileButton = new Button();
            productsButton = new Button();
            productsPanel = new Panel();
            orderButton = new Button();
            productsDataGridView = new DataGridView();
            productImageView = new DataGridViewImageColumn();
            priceTextBox = new DataGridViewTextBoxColumn();
            productNameTextBoxP = new DataGridViewTextBoxColumn();
            countTextBoxP = new DataGridViewTextBoxColumn();
            addButton = new DataGridViewButtonColumn();
            minusButton = new DataGridViewButtonColumn();
            profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).BeginInit();
            productsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // profilePanel
            // 
            profilePanel.Controls.Add(ordersDataGridView);
            profilePanel.Controls.Add(label2);
            profilePanel.Controls.Add(usernameLabel);
            profilePanel.Controls.Add(label1);
            profilePanel.Location = new Point(12, 54);
            profilePanel.Name = "profilePanel";
            profilePanel.Size = new Size(774, 384);
            profilePanel.TabIndex = 0;
            // 
            // ordersDataGridView
            // 
            ordersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersDataGridView.Columns.AddRange(new DataGridViewColumn[] { dateTextBox, productNameTextBox, sumTextBox, countTextBox });
            ordersDataGridView.Location = new Point(0, 43);
            ordersDataGridView.Name = "ordersDataGridView";
            ordersDataGridView.RowHeadersWidth = 51;
            ordersDataGridView.Size = new Size(774, 341);
            ordersDataGridView.TabIndex = 3;
            // 
            // dateTextBox
            // 
            dateTextBox.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dateTextBox.HeaderText = "Дата";
            dateTextBox.MinimumWidth = 6;
            dateTextBox.Name = "dateTextBox";
            dateTextBox.Width = 70;
            // 
            // productNameTextBox
            // 
            productNameTextBox.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            productNameTextBox.HeaderText = "Назва продукту";
            productNameTextBox.MinimumWidth = 6;
            productNameTextBox.Name = "productNameTextBox";
            // 
            // sumTextBox
            // 
            sumTextBox.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            sumTextBox.HeaderText = "Сума";
            sumTextBox.MinimumWidth = 6;
            sumTextBox.Name = "sumTextBox";
            sumTextBox.Width = 73;
            // 
            // countTextBox
            // 
            countTextBox.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            countTextBox.HeaderText = "Кількість";
            countTextBox.MinimumWidth = 6;
            countTextBox.Name = "countTextBox";
            countTextBox.Width = 99;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 20);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 2;
            label2.Text = "Мої замовлення:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(39, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(38, 20);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "ІМ'Я";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Ім'я:";
            // 
            // profileButton
            // 
            profileButton.Location = new Point(12, 12);
            profileButton.Name = "profileButton";
            profileButton.Size = new Size(94, 29);
            profileButton.TabIndex = 1;
            profileButton.Text = "Профіль";
            profileButton.UseVisualStyleBackColor = true;
            profileButton.Click += profileButton_Click;
            // 
            // productsButton
            // 
            productsButton.Location = new Point(112, 12);
            productsButton.Name = "productsButton";
            productsButton.Size = new Size(94, 29);
            productsButton.TabIndex = 2;
            productsButton.Text = "Продукти";
            productsButton.UseVisualStyleBackColor = true;
            productsButton.Click += productsButton_Click;
            // 
            // productsPanel
            // 
            productsPanel.Controls.Add(orderButton);
            productsPanel.Controls.Add(productsDataGridView);
            productsPanel.Location = new Point(12, 54);
            productsPanel.Name = "productsPanel";
            productsPanel.Size = new Size(774, 384);
            productsPanel.TabIndex = 3;
            // 
            // orderButton
            // 
            orderButton.Location = new Point(680, 355);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(94, 29);
            orderButton.TabIndex = 0;
            orderButton.Text = "Замовити";
            orderButton.UseVisualStyleBackColor = true;
            orderButton.Click += orderButton_Click;
            // 
            // productsDataGridView
            // 
            productsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsDataGridView.Columns.AddRange(new DataGridViewColumn[] { productImageView, priceTextBox, productNameTextBoxP, countTextBoxP, addButton, minusButton });
            productsDataGridView.Location = new Point(0, 0);
            productsDataGridView.Name = "productsDataGridView";
            productsDataGridView.RowHeadersWidth = 51;
            productsDataGridView.RowTemplate.Height = 100;
            productsDataGridView.Size = new Size(774, 349);
            productsDataGridView.TabIndex = 1;
            productsDataGridView.CellContentClick += onProductCellClicked;
            // 
            // productImageView
            // 
            productImageView.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            productImageView.HeaderText = "Зображення";
            productImageView.ImageLayout = DataGridViewImageCellLayout.Zoom;
            productImageView.MinimumWidth = 6;
            productImageView.Name = "productImageView";
            productImageView.Width = 125;
            // 
            // priceTextBox
            // 
            priceTextBox.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            priceTextBox.HeaderText = "Ціна";
            priceTextBox.MinimumWidth = 6;
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Width = 70;
            // 
            // productNameTextBoxP
            // 
            productNameTextBoxP.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            productNameTextBoxP.HeaderText = "Назва продукту";
            productNameTextBoxP.MinimumWidth = 6;
            productNameTextBoxP.Name = "productNameTextBoxP";
            productNameTextBoxP.Resizable = DataGridViewTriState.True;
            productNameTextBoxP.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // countTextBoxP
            // 
            countTextBoxP.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            countTextBoxP.HeaderText = "Кількість";
            countTextBoxP.MinimumWidth = 6;
            countTextBoxP.Name = "countTextBoxP";
            countTextBoxP.Width = 99;
            // 
            // addButton
            // 
            addButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            addButton.HeaderText = "Збільшити";
            addButton.MinimumWidth = 6;
            addButton.Name = "addButton";
            addButton.Text = "+";
            addButton.UseColumnTextForButtonValue = true;
            addButton.Width = 88;
            // 
            // minusButton
            // 
            minusButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            minusButton.HeaderText = "Зменшити";
            minusButton.MinimumWidth = 6;
            minusButton.Name = "minusButton";
            minusButton.Text = "-";
            minusButton.UseColumnTextForButtonValue = true;
            minusButton.Width = 87;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 449);
            Controls.Add(productsButton);
            Controls.Add(profileButton);
            Controls.Add(productsPanel);
            Controls.Add(profilePanel);
            Name = "MainForm";
            Text = "Головна";
            Load += MainForm_Load;
            profilePanel.ResumeLayout(false);
            profilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).EndInit();
            productsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel profilePanel;
        private Button profileButton;
        private Button productsButton;
        private Label label2;
        private Label usernameLabel;
        private Label label1;
        private DataGridView ordersDataGridView;
        private Panel productsPanel;
        private DataGridView productsDataGridView;
        private Button orderButton;
        private DataGridViewImageColumn productImageView;
        private DataGridViewTextBoxColumn priceTextBox;
        private DataGridViewTextBoxColumn productNameTextBoxP;
        private DataGridViewTextBoxColumn countTextBoxP;
        private DataGridViewButtonColumn addButton;
        private DataGridViewButtonColumn minusButton;
        private DataGridViewTextBoxColumn dateTextBox;
        private DataGridViewTextBoxColumn productNameTextBox;
        private DataGridViewTextBoxColumn sumTextBox;
        private DataGridViewTextBoxColumn countTextBox;
    }
}