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

namespace todolist
{
    public partial class MyAccount : Form
    {
        //connection string
        string connection_string = "datasource=localhost;username=root;password=;database=todo";
        string user_id;
        public MyAccount(string value)
        {
            user_id = value;
            InitializeComponent();
        }

        private void MyAccount_Load(object sender, EventArgs e)
        {
            try
            {
                string squery = "SELECT * FROM users WHERE id = @user_id";
                var conn = new MySqlConnection(connection_string);
                var cmd = new MySqlCommand(squery, conn);
                cmd.Parameters.AddWithValue("@user_id", user_id);
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Txt_name.Text = dr.GetValue(1).ToString();
                    Txt_uname.Text = dr.GetValue(2).ToString();
                    Txt_email.Text = dr.GetValue(3).ToString();
                    Txt_address.Text = dr.GetValue(4).ToString();
                    Txt_pw.Text = dr.GetValue(5).ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btn_MyAccount_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to logout ?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Environment.Exit(0);

            }
            else
            {

            }
        }

        private void Btn_updateUser_Click(object sender, EventArgs e)
        {
            try
            {
                string uquery = "UPDATE users SET name = @name , username = @uname , email = @email , address = @address , password = @password WHERE id = @user_id";
                var conn = new MySqlConnection(connection_string);
                var cmd = new MySqlCommand(uquery, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@user_id", user_id);
                cmd.Parameters.AddWithValue("@name", Txt_name.Text);
                cmd.Parameters.AddWithValue("@uname", Txt_uname.Text);
                cmd.Parameters.AddWithValue("@email", Txt_email.Text);
                cmd.Parameters.AddWithValue("@address", Txt_address.Text);
                cmd.Parameters.AddWithValue("@password", Txt_pw.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Updated Successfully!", "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("Error Update", "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          

        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            Hide();
            Form backToTodo = new todo_frm(user_id);
            backToTodo.Show();

        }
    }
}
