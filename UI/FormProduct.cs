using BlApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlApi;
using BO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{

    public partial class FormProduct : Form
    {
        static readonly IBI product_bi = BlApi.Factory.Get();
        Product product;
        public FormProduct()
        {
            InitializeComponent();
            AddPanel.Visible = false;
            panel4.Visible = false;
            ReadOnePanel.Visible = false;
            dataGridView1.Visible = false;
            panel5.Visible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoGenerateColumns = true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = true;
            panel4.Visible = false;
            ReadOnePanel.Visible = false;
            dataGridView1.Visible = false;
            panel5.Visible = false;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            AddPanel.Visible = false;
            ReadOnePanel.Visible = false;
            dataGridView1.Visible = false;
            panel5.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                product = new Product(int.Parse(textBoxUpdateProductId.Text), textBoxUpdateName.Text, int.Parse(numericUpDownPrice.Text), int.Parse(numericUpDown2.Text), Enum.Parse<BO.categoryProduct>(comboBox1.Text));
                product_bi.Product.Update(product);
                panel4.Visible = false;
                dataGridView1.DataSource = product_bi.Product.ReadAll();
                dataGridView1.Visible = true;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void AddSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                product = new Product(0, textBoxNAdd.Text, int.Parse(numericUpDownPA.Text), int.Parse(numericUpDownCA.Text), Enum.Parse<BO.categoryProduct>(comboBoxCaA.Text));
                product_bi.Product.Create(product);
                AddPanel.Visible = false;
                dataGridView1.DataSource = product_bi.Product.ReadAll();
                dataGridView1.Visible = true;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }

        }

        private void sumbitReadOne_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Visible = true;
                List<Product> list = new List<Product>();
                product = product_bi.Product.Read(int.Parse(textBoxReadOne.Text));
                list.Add(product);
                dataGridView1.DataSource = list;
                ReadOnePanel.Visible = false;
                //dataGridView1.Visible=true;
                //panel4.Visible = false;
                //panel5.Visible = false;
                //AddPanel.Visible = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void ReadOneCustomer_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel4.Visible = false;
            AddPanel.Visible = false;
            ReadOnePanel.Visible = true;
        }

        private void ReadAllButton_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Visible = true;
                dataGridView1.DataSource = product_bi.Product.ReadAll();
                panel4.Visible = false;
                panel5.Visible = false;
                AddPanel.Visible = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void filter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = product_bi.Product.ReadAll(p => p.category == Enum.Parse<BO.categoryProduct>(filter.SelectedItem.ToString()));
            dataGridView1.Visible = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel4.Visible = false;
            AddPanel.Visible = false;
            dataGridView1.Visible = false;
        }

        private void deleteSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                product_bi.Product.Delete(int.Parse(textBox1.Text));
                panel5.Visible = false;
                dataGridView1.DataSource = product_bi.Product.ReadAll();
                dataGridView1.Visible = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
