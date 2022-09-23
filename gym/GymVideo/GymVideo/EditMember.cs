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
    public partial class EditMember : Form
    {
        public EditMember()
        {
            InitializeComponent();
        }

        private void EditMember_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-6NIIE6H; database = gym ; integrated security = true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewMember";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridViewEdit.DataSource = DS.Tables[0];
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-6NIIE6H; database = gym ; integrated security = true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

         
            cmd.CommandText = " UPDATE NewMember SET lname = @Lname, gender = @Gender ,dob = @Dob ,  email = @Email, joindate = @JoinDate, gymtime = @GymTime, maddress = @Maddress, membershiptime = @MembershipTime WHERE fname = @Fname";
            cmd.Parameters.AddWithValue("@fname",txtFirstNameEdit.Text);
            cmd.Parameters.AddWithValue("@lname", txtLastNameEdit.Text);
            cmd.Parameters.AddWithValue("@gender", comboBoxGioitinh.Text);


            cmd.Parameters.AddWithValue("@dob", dateTimePickerDOBEdit.Text);
            
            cmd.Parameters.AddWithValue("@email", txtEmailEdit.Text);
            cmd.Parameters.AddWithValue("@joindate", dateTimePickerJoinDateEdit.Text);
            cmd.Parameters.AddWithValue("@gymtime", comboBoxGymTimeEdit.Text);
            cmd.Parameters.AddWithValue("@maddress", txtAddressEdit.Text );
            cmd.Parameters.AddWithValue("@membershiptime", comboBoxMembershipEdit.Text);
            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Data saved.");





        }

      
    }
}
