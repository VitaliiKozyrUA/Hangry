using Hangry.common.data.datasources;
using Hangry.common.data.models;
using Hangry.user.login.data.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangry.user.main.ui
{
    public partial class MainForm : Form
    {
        private Dictionary<Product, int> productToQuantity = new Dictionary<Product, int>();
        private List<Product> products;
        internal User User { get; set; }

        internal MainForm(User user)
        {
            User = user;
            InitializeComponent();
            usernameLabel.Text = user.Name;
            populateProductsTable();
            populateOrdersTable();
            EstablishmentLocalDataSource.OnChanged += () =>
            {
                populateProductsTable();
            };

            OrderLocalDataSource.OnChanged += () => {
                populateOrdersTable(); 
            };
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        public void incrementProduct(Product product)
        {
            if (productToQuantity.ContainsKey(product))
            {
                productToQuantity[product] += 1;
            }
            else
            {
                productToQuantity.Add(product, 1);
            }
            updateQuantity(product, productToQuantity[product]);
        }

        public void decrementProduct(Product product)
        {
            if (productToQuantity.ContainsKey(product))
            {
                if (productToQuantity[product] == 0) return;
                productToQuantity[product] -= 1;
            }
            else
            {
                productToQuantity.Add(product, 0);
            }
            updateQuantity(product, productToQuantity[product]);
        }

        private void updateQuantity(Product product, int quantity)
        {
            productsDataGridView.Rows[products.IndexOf(product)].Cells[3].Value = quantity.ToString();
        }

        private void populateProductsTable()
        {
            productsDataGridView.Rows.Clear();
            var establishments = EstablishmentLocalDataSource.GetAll();
            products = establishments.SelectMany(e => e.Products).ToList();
            Bitmap image;
            foreach (Product product in products)
            {
                image = new Bitmap(product.ImagePath);
                var quantity = productToQuantity.GetValueOrDefault(product, 0);
                productsDataGridView.Rows.Add(image, product.Price.ToString("0.00"), product.Name, quantity.ToString());
            }
        }

        private void populateOrdersTable()
        {
            ordersDataGridView.Rows.Clear();
            var orders = OrderLocalDataSource.GetWhereUserId(User.Id);
            foreach (Order order in orders)
            {
                ordersDataGridView.Rows.Add(order.date, order.Product.Name, (order.Product.Price * order.Quantity).ToString("0.00"), order.Quantity);
            }
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            profilePanel.BringToFront();
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            productsPanel.BringToFront();
        }

        private void onProductCellClicked(object sender, DataGridViewCellEventArgs e)
        {
            var product = products.ElementAt(e.RowIndex);

            if (e.ColumnIndex == 4)
            {
                incrementProduct(product);
            }
            else if (e.ColumnIndex == 5)
            {
                decrementProduct(product);
            }
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            if(productToQuantity.Count == 0)
            {
                MessageBox.Show(
                    "Список товарів порожній.", "Помилка замовлення",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
                return;
            }
            var orders = productToQuantity.Select(e => new Order(0, e.Key, e.Value, User.Id, DateTime.Now.ToShortDateString()));
            OrderLocalDataSource.AddAll(orders.ToList());
            productToQuantity.Clear();
            populateProductsTable();
            MessageBox.Show(
                "Товари успішно замовлено!", "Результат замовлення",
                MessageBoxButtons.OK, MessageBoxIcon.Information
            );
        }
    }
}
