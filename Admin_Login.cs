using PranjulMedicalCenter.Common;
using PranjulMedicalCenter.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PranjulMedicalCenter
{
    public partial class Admin_Login : Form
    {
        //SqlConnection sqlCon = new SqlConnection(DBComman.ConString);

        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;string connectionString = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text.Trim() == "" || passwordTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Enter Username & Password");
                usernameTextBox.Focus();
            }
            else
            {
                sqlCon = CmnMethods.OpenConnectionString(connectionString);
                string query = string.Format(@"SELECT * FROM View_UserInfo WHERE UserName = '{0}' AND UserPassword = '{1}'", usernameTextBox.Text.Trim(), passwordTextBox.Text.Trim());
                SqlDataAdapter sda = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    this.Hide();
                    MenuForm form = new MenuForm();
                    form.Show();
                }
            }
        }

        private void linkLabelCreateUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(usernameTextBox.Text.Trim() == "" || passwordTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Fill Username & Password...");
                usernameTextBox.Focus();
            }
            else
            {
                sqlCon = CmnMethods.OpenConnectionString(sqlCon);
                string query = "@INSERT INTO UserInfo(UserName,UserPassword,UserType,AddedDate,AddedBy) VALUES(@UserName,@UserPassword,@UserType,@AddedDate,@AddedBy)";
                SqlCommand command = new SqlCommand(query, sqlCon);
                command.Parameters.AddWithValue("@UserName", usernameTextBox.Text.Trim());
                command.Parameters.AddWithValue("@UserPassword", passwordTextBox.Text.Trim());
                command.Parameters.AddWithValue("@UserType", 1); //Admin Only
                command.Parameters.AddWithValue("@AddedDate", DateTime.Now);
                command.Parameters.AddWithValue("@AddedBy", Global.UserInfo.UserId);
                command.ExecuteNonQuery();
                MessageBox.Show("SignUp Successfully...");
                sqlCon.Close();
            }
        }
    }
}
