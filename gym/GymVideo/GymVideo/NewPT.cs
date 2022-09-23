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
    public partial class NewPT : Form
    {
        public NewPT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cc = txtChieuCao.Text;
            String gt = comboBoxGioiTinh.Text;
            String cn = txtCanNang.Text;
            String sdt = txtSDT.Text;
            String name = txtNamePt.Text;
            String cm = comboBoxChuyenMon.Text;
            String time = dateTimePickerBDlam.Text;
            String cl = comboBoxCalam.Text;
            String luong = txtLuong.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-6NIIE6H; database = gym ; integrated security = true";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into PT(Chieucao,GioiTinh,CanNang,SDTPT,PTName,ChuyenMon,Time,calam,luong) values ('" + cc + "','" + gt + "','" + cn + "','" + sdt + "','" + name + "','" + cm + "','" + time + "','" + cl + "','" + luong + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data saved.");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtChieuCao.Clear();

            comboBoxGioiTinh.ResetText();
            txtCanNang.Clear();
            txtSDT.Clear();
            txtNamePt.Clear();
            comboBoxChuyenMon.ResetText();
            dateTimePickerBDlam.Value = DateTime.Now;
            comboBoxCalam.ResetText();
            txtLuong.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewPT vt = new ViewPT();
            vt.Show();
        }
    }
}
