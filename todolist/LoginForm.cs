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
    public partial class form_login : Form
    {
        //connection string
        string connection_string = "datasource=localhost;username=root;password=;database=todo";
        public form_login()
        {
            InitializeComponent();
        }

        private void cb_togglepw_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_togglepw.Checked)
            {
                txt_pw.UseSystemPasswordChar = false;
            }
            else
            {
                txt_pw.UseSystemPasswordChar = true;
            }
        }

        private void btn_showRegisterFrm_Click(object sender, EventArgs e)
        {
            Form register = new frm_register();
            register.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //validation 
            TextBox[] inputs = { txt_email  , txt_pw};
            if (!Validation.IsNotEmpty(inputs))
            {
                
            }
            else
            {
                try
                {
                    //query
                    //string query = "SELECT * FROM users WHERE email = '" + txt_email.Text + "' AND password = '" + txt_pw.Text + "' ";
                    string query = "SELECT * FROM users WHERE email = @email AND password = @password";

                    // instiantiate db connection
                    MySqlConnection conn = new MySqlConnection(connection_string);

                    // will use to prepare the query
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    //sanitize strings
                    cmd.Parameters.AddWithValue("@email", txt_email.Text);
                    cmd.Parameters.AddWithValue("@password", txt_pw.Text);

                    // open the connection
                    conn.Open();

                    MySqlDataReader dr = cmd.ExecuteReader();
                    //check if there is a result
                    if (dr.Read())
                    {
                       string user_id = dr[0].ToString();
                      
                        MessageBox.Show("You are now logged in", "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //close the login form and open the new form after logging in...
                        Hide();
                       
                        //show the index form

                        Form todo = new todo_frm(user_id);
                        todo.Show();
                        dr.Close();


                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("Invalid Email/Password", "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Message Info" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
