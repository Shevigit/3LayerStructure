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


namespace UI
{
    public partial class FormCustomer : Form
    {
        static readonly IBI customer_bi = BlApi.Factory.Get();
        Customer Customer;
        public FormCustomer()
        {
            InitializeComponent();

            AddPanel.Visible = false;
            panel4.Visible = false;
            DeletePanel.Visible = false;
            dataGridView1.Visible = false;
            panel5.Visible = false;
            //dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dataGridView1.MultiSelect = false;
            //dataGridView1.AutoGenerateColumns = true;

        }

        private void sumbitReadOne_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Visible = true;
                List<Customer> list = new List<Customer>();
                Customer = customer_bi.Customer.Read(int.Parse(textBoxReadOne.Text));
                list.Add(Customer);
                dataGridView1.DataSource = list;
                DeletePanel.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                AddPanel.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = true;
            panel4.Visible = false;
            DeletePanel.Visible = false;
            dataGridView1.Visible = false;
            panel5.Visible = false;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

            panel4.Visible = true;
            AddPanel.Visible = false;
            DeletePanel.Visible = false;
            dataGridView1.Visible = false;
            panel5.Visible = false;
        }

        private void AddSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Customer = new Customer(int.Parse(textBoxId.Text), textBoxName.Text, textBoxPhone.Text, checkBoxClubAdd.Checked, textBoxAddress.Text);
                customer_bi.Customer.Create(Customer);
                AddPanel.Visible = false;
                dataGridView1.DataSource = customer_bi.Customer.ReadAll();
                dataGridView1.Visible = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Customer = new Customer(int.Parse(textBoxUpdateId.Text), textBoxUpdateName.Text, textBoxUpdatePhone.Text, checkBoxClubUpdate.Checked, textBoxUpdateAddress.Text);
                customer_bi.Customer.Update(Customer);
                panel4.Visible = false;
                dataGridView1.DataSource = customer_bi.Customer.ReadAll();
                dataGridView1.Visible = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ReadOneCustomer_Click(object sender, EventArgs e)
        {
            DeletePanel.Visible = true;

            panel5.Visible = false;
            panel4.Visible = false;
            AddPanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                customer_bi.Customer.Delete(int.Parse(textBox1.Text));
                panel5.Visible = false;
                dataGridView1.DataSource = customer_bi.Customer.ReadAll();
                dataGridView1.Visible = true;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel4.Visible = false;
            AddPanel.Visible = false;
            DeletePanel.Visible = false;
            dataGridView1.Visible = false;
        }

        private void ReadAllButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;

            dataGridView1.DataSource = customer_bi.Customer.ReadAll();

            DeletePanel.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            AddPanel.Visible = false;
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;

            dataGridView1.DataSource = customer_bi.Customer.ReadAll(s => s.IsClub == false);
            DeletePanel.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            AddPanel.Visible = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView1.DataSource = customer_bi.Customer.ReadAll(s => s.IsClub == true);
            DeletePanel.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            AddPanel.Visible = false;
        }
    }
}
