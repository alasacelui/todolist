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
    public partial class frm_register : Form
    {
    
        public frm_register()
        {
            InitializeComponent();
        }

        public void btn_register_Click(object sender, EventArgs e)
        {   
            //connection string
            string connection_string = "datasource=localhost;username=root;password=;database=todo";

            try
            {
                //validation
                TextBox[] inputs = { txt_name, txt_uname, txt_email, txt_address , txt_pw , txt_cpw };

                //if the field is empty then the method will throw an error msg
                if(!Validation.IsNotEmpty(inputs))
                {

                }
                else if (!Validation.IsValidInput(txt_address))
                {

                }
                else if(!Validation.IsValidEmail(txt_email))
                {

                }
                else if (!txt_pw.Text.Equals(txt_cpw.Text))
                {
                    MessageBox.Show("The two password do not match", "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    //query
                    string sql_select = "SELECT * FROM users WHERE email = @email LIMIT 1";
                    string sql_insert = "INSERT INTO users (name , username , email , address , password) VALUES (@name , @username , @email , @address , @password)";

                    // instiantiate db connection
                    MySqlConnection conn = new MySqlConnection(connection_string);

                    //check first if the email is already exist 
                    MySqlCommand cmd_select = new MySqlCommand(sql_select, conn);
                    cmd_select.Parameters.AddWithValue("@email", txt_email.Text);
                    conn.Open();
                    MySqlDataReader dr = cmd_select.ExecuteReader();
                    if(dr.Read())
                    {
                        MessageBox.Show("Email is already taken", "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                    }
                    else
                    {
                        conn.Close();
                        // will use to prepare the query
                        MySqlCommand cmd = new MySqlCommand(sql_insert, conn);

                        conn.Open();
                        //santize inputs
                        cmd.Parameters.AddWithValue("@name", txt_name.Text);
                        cmd.Parameters.AddWithValue("@username", txt_uname.Text);
                        cmd.Parameters.AddWithValue("@email", txt_email.Text);
                        cmd.Parameters.AddWithValue("@address", txt_address.Text);
                        cmd.Parameters.AddWithValue("@password", txt_pw.Text);
                        cmd.ExecuteNonQuery();

                        conn.Close();

                        MessageBox.Show("Registered Successfully", "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_name.Text = txt_uname.Text = txt_email.Text = txt_address.Text = txt_pw.Text = txt_cpw.Text = "";
                    }
                  
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    

        }


        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
