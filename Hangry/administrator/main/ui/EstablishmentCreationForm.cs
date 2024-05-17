using Hangry.common.data.datasources;
using Hangry.common.data.models;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangry.administrator.main.ui
{
    public partial class EstablishmentCreationForm : Form
    {
        private string imagePath = string.Empty;

        public EstablishmentCreationForm()
        {
            InitializeComponent();
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
            var isInvalid = imagePath == string.Empty || addressTextBox.Text == string.Empty || nameTextBox.Text == string.Empty;
            if(isInvalid)
            {
                MessageBox.Show(
                    "Не всі поля заповнено!", "Помилка збереження",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
                return;
            }
            var establishment = new Establishment(
                new Random().Next(),
                nameTextBox.Text,
                imagePath,
                addressTextBox.Text,
                ImmutableList.Create<Product>()
            );
            EstablishmentLocalDataSource.Add(establishment);
            Close();
        }
    }
}
