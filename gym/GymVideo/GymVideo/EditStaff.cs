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
    public partial class EditStaff : Form
    {
        public EditStaff()
        {
            InitializeComponent();
        }

        private void EditStaff_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-6NIIE6H; database = gym ; integrated security = true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewStaff";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridViewEditStaff.DataSource = DS.Tables[0];
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-6NIIE6H; database = gym ; integrated security = true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;


            cmd.CommandText = " UPDATE NewStaff SET lname = @Lname, gender = @Gender ,dob = @Dob ,  email = @Email, joindate = @JoinDate, statee = @Statee, city = @City WHERE fname = @Fname";
            cmd.Parameters.AddWithValue("@fname",txtFnameEditStaff.Text);
            cmd.Parameters.AddWithValue("@lname", txtFnameEditStaff.Text);
            cmd.Parameters.AddWithValue("@gender", comboBoxEditStaff.Text);
            cmd.Parameters.AddWithValue("@dob", dateTimePickerDOBEditStaff.Text);
            cmd.Parameters.AddWithValue("@email", txtEmailEditStaff.Text);
            cmd.Parameters.AddWithValue("@joindate", dateTimePickerJOINDateEditStaff.Text);
            cmd.Parameters.AddWithValue("@statee", txtStateEditStaff.Text);
            cmd.Parameters.AddWithValue("@city", txtCityEditStaff.Text);


            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Data saved.");
        }
    }
}
