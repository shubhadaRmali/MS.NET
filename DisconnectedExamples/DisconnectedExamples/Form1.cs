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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection CN;
        MySqlDataAdapter DA;
        DataSet DS;
        private void Form1_Load(object sender, EventArgs e)
        {
            CN = new MySqlConnection("Data Source=192.168.100.80;PORT=3306;Database=group009;User Id=group009;Password=welcome;");
            DA = new MySqlDataAdapter("Select * from Customers", CN);
            DS = new DataSet();
            DA.Fill(DS, "Customers");
            dgvCustomers.DataSource = DS.Tables[0];
        }
    }
}
