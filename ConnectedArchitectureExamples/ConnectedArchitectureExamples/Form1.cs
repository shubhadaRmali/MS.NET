using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectedArchitectureExamples.Dal;
using ConnectedArchitectureExamples.Models;

namespace ConnectedArchitectureExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //List<Customer> customers;
        CustomerDal customerDal=new CustomerDal();
        private void Form1_Load(object sender, EventArgs e)
        {
          //  customers=customerDal.GetAllCustomers();
          dgvCustomers.DataSource= customerDal.GetAllCustomers();
        }
    }
}
