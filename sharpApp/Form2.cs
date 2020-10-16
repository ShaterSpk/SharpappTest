using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sharpApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQL_connect cnnss = new SQL_connect();
            cnnss.Connection();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT jmeno FROM student", cnnss.cnn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            textBox1.Text=dt.Rows[0][0].ToString();
        }
    }
}
