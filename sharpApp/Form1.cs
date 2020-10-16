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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SQL_connect cnn = new SQL_connect();

            MessageBox.Show("Connection Open!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQL_connect cnns = new SQL_connect();
            cnns.Connection();
            SqlDataAdapter adapter = new SqlDataAdapter("select predmet.nazev,ucitel.jmeno,ucitel.prijmeni,student.jmeno as jmenostudenta,student.prijmeni as prijmenistudenta from predmet,student,ucitel,student_predmet where (student.jmeno like '"+ textBox1.Text + "%' or student.prijmeni like '" + textBox1.Text + "%') and student.id_student=student_predmet.id_student and ucitel.id_ucitel=predmet.id_ucitel and student_predmet.id_predmet=predmet.id_predmet", cnns.cnn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            string seznam = String.Empty;
            
            
            foreach (DataRow dr in dt.Rows)
            {
      
                    seznam += dr["nazev"].ToString() + "," + dr["jmeno"].ToString() + " " + dr["prijmeni"].ToString() + ", " +  dr["prijmenistudenta"].ToString() + System.Environment.NewLine;
                      
            }
            seznam = seznam.Remove(seznam.Length - 1);
            MessageBox.Show(seznam);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
       
        private void label1_Click(object sender, EventArgs e)
        {
            Form2 myForm = new Form2();
            
            myForm.ShowDialog();
            
        }
    }
}
