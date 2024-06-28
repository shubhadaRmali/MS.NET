using ConnectedArchitectureExamples.Dal;
using ConnectedArchitectureExamples.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectedArchitectureExamples
{
    public partial class frmInfowayCustomerForm : Form
    {
        public frmInfowayCustomerForm()
        {
            InitializeComponent();
        }
        CustomerDal customerDal = new CustomerDal();
        List<Customer> customers;
        int currentIndex = 0;
        private void frmInfowayCustomerForm_Load(object sender, EventArgs e)
        {
            customers = customerDal.GetAllCustomers();
            Navigate(currentIndex);
        }
        private void Navigate(int index)
        {
            if (customers.Count > 0)
            {
                txtCustomerId.Text = customers[index].CustomerId.ToString();
                txtContactName.Text = customers[index].ContactName.ToString();
                txtCity.Text = customers[index].City.ToString();
            }
        }

        private void btnMoveFirst_Click(object sender, EventArgs e)
        {
            currentIndex= 0;
            Navigate(currentIndex);
        }

        private void btnMoveLast_Click(object sender, EventArgs e)
        {
            currentIndex=customers.Count - 1;
            Navigate(currentIndex);
        }

        private void btnMoveNext_Click(object sender, EventArgs e)
        {
            if(currentIndex<customers.Count-1)
            {
                currentIndex++;
                Navigate(currentIndex);
            }
        }

        private void btnMovePrevious_Click(object sender, EventArgs e)
        {
            if(currentIndex>0)
            {
                currentIndex--;
                Navigate(currentIndex);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtCustomerId.Text=string.Empty;
            txtContactName.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCustomerId.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer customer=new Customer()
            {
                CustomerId = int.Parse(txtCustomerId.Text),
                ContactName=txtContactName.Text,
                City=txtCity.Text
            };
            customerDal.InsertCustomerProfile(customer);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                CustomerId = int.Parse(txtCustomerId.Text),
                ContactName = txtContactName.Text,
                City = txtCity.Text
            };
            customerDal.UpdateCustomerProfile(customer);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            customerDal.DeleteCustomerProfile(int.Parse(txtCustomerId.Text));
        }
    }
}
