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
    public partial class EstablishmentsForm : Form
    {
        public EstablishmentsForm()
        {
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
            var establishments = EstablishmentLocalDataSource.GetAll();
            Bitmap image;
            foreach (Establishment establishment in establishments)
            {
                image = new Bitmap(establishment.ImagePath);
                dataGridView.Rows.Add(image, establishment.Name, establishment.Address);
            }
        }

        private void onCellContentClicked(object sender, DataGridViewCellEventArgs e)
        {
            var establishments = EstablishmentLocalDataSource.GetAll();
            var establishment = establishments.ElementAt(e.RowIndex);

            if (e.ColumnIndex == 4)
            {
                EstablishmentLocalDataSource.DeleteWhereId(establishment.Id);
            } else if(e.ColumnIndex == 3)
            {
                var productsForm = new ProductsForm(establishment.Id);
                productsForm.ShowDialog();
            }
        }
    }
}
