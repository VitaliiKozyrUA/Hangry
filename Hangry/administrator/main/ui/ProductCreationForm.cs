using Hangry.common.data.datasources;
using Hangry.common.data.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangry.administrator.main.ui
{
    public partial class ProductCreationForm : Form
    {
        private string imagePath = string.Empty;
        private int EstablishmentId { get; set; }

        public ProductCreationForm(int establishmentId)
        {
            EstablishmentId = establishmentId;
            InitializeComponent();
        }

        private void priceTextBox_keyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void imagePickerButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Виберіть зображення";
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            imagePath = openFileDialog.FileName;
            image.Image = Image.FromFile(imagePath);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var isInvalid = imagePath == string.Empty || descriptionTextBox.Text == string.Empty || nameTextBox.Text == string.Empty || priceTextBox.Text == string.Empty;
            if (isInvalid)
            {
                MessageBox.Show(
                    "Не всі поля заповнено!", "Помилка збереження",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
                return;
            }
            var product = new Product(
                new Random().Next(),
                nameTextBox.Text,
                descriptionTextBox.Text,
                Convert.ToDouble(priceTextBox.Text),
                imagePath
            );
            EstablishmentLocalDataSource.AddProduct(EstablishmentId, product);
            Close();
        }
    }
}
