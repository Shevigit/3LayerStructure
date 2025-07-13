using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSale formSale = new FormSale();
            this.Hide();
            formSale.FormClosed += FormSale_FormClosed;
            formSale.Show();
        }

        private void FormSale_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            FormProduct formProduct = new FormProduct();
            this.Hide();
            formProduct.FormClosed += FormProduct_FormClosed;
            formProduct.Show();
        }

        private void FormProduct_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer = new FormCustomer();
            this.Hide();
            formCustomer.FormClosed += FormCustomer_FormClosed;
            formCustomer.Show();
           
        }

        private void FormCustomer_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void FormProduct_FormClosed1(object? sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
