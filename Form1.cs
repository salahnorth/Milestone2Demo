using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Milestone2Demo
{
    public partial class Demo : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-KLSST8B8;Initial Catalog=BranchConnection;Integrated Security=True");
        public Demo()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private DataTable DTGrid = new DataTable();
        private void Demo_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetGridList();
        }
        
        private DataTable GetGridList()
        {
            //DataTable DTGrid = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["dgrid"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Branch", con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    DTGrid.Load(reader);
                }
            }


            return DTGrid;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CusIDText.Clear();
            FnameText.Clear();
            LNameText.Clear();
            PhoneNumberText.Clear();
        }

        private void CusIDText_TextChanged(object sender, EventArgs e)
        {
            DataView dvGrid = DTGrid.DefaultView;

            dvGrid.RowFilter = "Convert(Branch_ID, 'System.String') LIKE '%" + CusIDText.Text + "%'";
        }

        private void FnameText_TextChanged(object sender, EventArgs e)
        {
            DataView dvGrid = DTGrid.DefaultView;

            dvGrid.RowFilter = "Description LIKE '%" + FnameText.Text + "%'";
        }

        private void LNameText_TextChanged(object sender, EventArgs e)
        {
            DataView dvGrid = DTGrid.DefaultView;

            dvGrid.RowFilter = "Street_Add1 LIKE '%" + LNameText.Text + "%'";
        }

        private void PhoneNumberText_TextChanged(object sender, EventArgs e)
        {
            DataView dvGrid = DTGrid.DefaultView;

            dvGrid.RowFilter = "Convert(Phone_Num, 'System.String') LIKE '%" + PhoneNumberText.Text.ToString() + "%'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Branch values ('"+BranchIDtext.Text + "','" + Descriptiontext.Text + "','" + Street_Add1text.Text + "','" + Street_Add2text.Text + "','" + Citytext.Text + "','" + Provincetext.Text + "','" + PostalCodetext.Text + "', '" + Phone_Numtext.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record inserted successfully");

            Descriptiontext.Text = "";
            Street_Add1text.Text = "";
            Street_Add2text.Text = "";
            Citytext.Text = "";
            Provincetext.Text = "";
            PostalCodetext.Text = "";
            Phone_Numtext.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Branch where Branch_ID ='" +BranchIDtext.Text + "'" ;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record deleted successfully");

            Descriptiontext.Text = "";
            Street_Add1text.Text = "";
            Street_Add2text.Text = "";
            Citytext.Text = "";
            Provincetext.Text = "";
            PostalCodetext.Text = "";
            Phone_Numtext.Text = "";
        }
    }
}
