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
    public partial class ProductsForm : Form
    {
        private readonly int EstablishmentId;

        public ProductsForm(int establishmentId)
        {
            EstablishmentId = establishmentId;
            InitializeComponent();
            populateTable();
            EstablishmentLocalDataSource.OnChanged += () =>
            {
                populateTable();
            };
        }

        private void createEstablishmentButton_Click(object sender, EventArgs e)
        {
            var establishmentCreationForm = new EstablishmentCreationForm();
            establishmentCreationForm.ShowDialog();
        }

        private void populateTable()
        {
            dataGridView.Rows.Clear();
            var products = EstablishmentLocalDataSource.GetAllProducts(EstablishmentId);
            Bitmap image;
            foreach (Product product in products)
            {
                image = new Bitmap(product.ImagePath);
                dataGridView.Rows.Add(image, product.Name, product.Description, product.Price.ToString("0.00"));
            }
        }

        private void onCellContentClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var products = EstablishmentLocalDataSource.GetAllProducts(EstablishmentId);
                var product = products.ElementAt(e.RowIndex);
                EstablishmentLocalDataSource.DeleteProductWhereId(EstablishmentId, product.Id);
            }
        }

        private void createProductButton_Click(object sender, EventArgs e)
        {
            var productCreationForm = new ProductCreationForm(EstablishmentId);
            productCreationForm.ShowDialog();
        }
    }
}
