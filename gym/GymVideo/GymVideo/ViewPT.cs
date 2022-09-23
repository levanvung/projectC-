using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymVideo
{
    public partial class ViewPT : Form
    {
        public ViewPT()
        {
            InitializeComponent();
        }

        private void ViewPT_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-6NIIE6H; database = gym ; integrated security = true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from PT";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridViewPT.DataSource = DS.Tables[0];
        }

        private void btnSearchPT_Click(object sender, EventArgs e)
        {
            if (txtSearchPT.Text != "")
            {


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-6NIIE6H; database = gym ; integrated security = true";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from PT Where PID = " + txtSearchPT.Text + "";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridViewPT.DataSource = DS.Tables[0];
            }
            else
            {
                MessageBox.Show("Nhap Id", "messengeer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("co chac muon xoa ? .muon", "Xoa data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {



                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-6NIIE6H; database = gym ; integrated security = true";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from PT where PID = " + txtSearchPT.Text + "";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

            }
            else
            {
                this.Activate();
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-6NIIE6H; database = gym ; integrated security = true";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from PT ";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridViewPT.DataSource = DS.Tables[0];
            }
        }

        private void dataGridViewPT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
