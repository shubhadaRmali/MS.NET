using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DisconnectedExamples
{
    public partial class frmCustomerDataForm : Form
    {
        public frmCustomerDataForm()
        {
            InitializeComponent();
        }
        MySqlConnection CN;
        MySqlDataAdapter DA;
        MySqlCommandBuilder CMD_BLD;
        DataSet DS;
        int currentIndex = 0;
        private void frmCustomerDataForm_Load(object sender, EventArgs e)
        {
            CN = new MySqlConnection("Data Source=192.168.100.80;PORT=3306;Database=group009;User Id=group009;Password=welcome;");
            DA = new MySqlDataAdapter("Select * from Customers", CN);
            CMD_BLD = new MySqlCommandBuilder(DA);
            DS = new DataSet();
            DA.Fill(DS, "Customers");
            Navigate(currentIndex);
        }
        private void Navigate(int index)
        {
            if (DS.Tables[0].Rows.Count > 0)
            {
                txtCustomerId.Text = DS.Tables[0].Rows[index][0].ToString();
                txtContactName.Text = DS.Tables[0].Rows[index][1].ToString();
                txtCity.Text = DS.Tables[0].Rows[index][2].ToString();
            }
        }

        private void btnMoveFirst_Click(object sender, EventArgs e)
        {
            currentIndex = 0;
            Navigate(currentIndex);
        }

        private void btnMoveLast_Click(object sender, EventArgs e)
        {
            currentIndex = DS.Tables[0].Rows.Count - 1;
            Navigate(currentIndex);
        }

        private void btnMoveNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < DS.Tables[0].Rows.Count - 1)
            {
                currentIndex++;
                Navigate(currentIndex);
            }
        }

        private void btnMovePrevious_Click(object sender, EventArgs e)
        {
            if (currentIndex>0)
            {
                currentIndex--;
                Navigate(currentIndex);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtCustomerId.Text = string.Empty;
            txtContactName.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCustomerId.Focus();
        }
 
        private void btnSave_Click(object sender, EventArgs e)
        {
            DataRow row = DS.Tables[0].NewRow();
            row["CustomerId"] =Convert.ToInt32(txtCustomerId.Text);
            row["CustomerName"] = txtContactName.Text;
            row["City"] = txtCity.Text;
            DS.Tables[0].Rows.Add(row);//Modify the data table
            DA.Update(DS.Tables[0]);//Update your database
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DS.Tables[0].Rows[currentIndex].Delete();
            DA.Update(DS.Tables[0]);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
