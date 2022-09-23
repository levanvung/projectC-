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
    public partial class StaffView : Form
    {
        public StaffView()
        {
            InitializeComponent();
        }

        private void StaffView_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-6NIIE6H; database = gym ; integrated security = true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewStaff";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView3.DataSource = DS.Tables[0];
        }

        private void SearchStaff_Click(object sender, EventArgs e)
        {
            if (txtStaffSearch.Text != "")
            {


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-6NIIE6H; database = gym ; integrated security = true";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewStaff Where SID = " + txtStaffSearch.Text + "";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView3.DataSource = DS.Tables[0];
            }
            else
            {
                MessageBox.Show("Nhap Id", "messengeer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("co chac muon xoa ? .muon", "Xoa data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {



                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-6NIIE6H; database = gym ; integrated security = true";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from NewStaff where SID = " +txtStaffSearch.Text + "";

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

                cmd.CommandText = "select * from NewStaff ";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView3.DataSource = DS.Tables[0];
            }
        }
    }
}
