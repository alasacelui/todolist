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
    public partial class todo_frm : Form
    {
      
        //connection string
        string connection_string = "datasource=localhost;username=root;password=;database=todo";
        string user_id; 
        public todo_frm(string val)
        {
            InitializeComponent();
            user_id = val; // user_id

           
        }

        private void todo_frm_Load(object sender, EventArgs e)
        {

            LoadTask();
 
        }

        public void LoadTask()
        {
            string query = "SELECT id, task, status, created_at FROM tasks WHERE user_id = @user_id ORDER BY id DESC";
            MySqlConnection conn = new MySqlConnection(connection_string);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@user_id", user_id);
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dg_task.DataSource = dt;
            dg_task.Columns["id"].Visible = false;

            conn.Close();

        }


        private void btn_insertT_Click(object sender, EventArgs e)
        {

            if (txt_task.Text == "")
            {
                MessageBox.Show("Field must not be empty!", "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string query = "Insert into tasks (user_id,task) VALUES (@user_id , @task)";
                    MySqlConnection conn = new MySqlConnection(connection_string);
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user_id", user_id);
                    cmd.Parameters.AddWithValue("@task", txt_task.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Task Added Successfully!", "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_task.Clear();
                    LoadTask();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

       
        private void btn_update_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to update ?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    foreach (DataGridViewRow row in dg_task.SelectedRows)
                    {
                        var id = row.Cells[0].Value;
                        string dquery = "UPDATE tasks set status='COMPLETED' WHERE id = @id";
                        var conn = new MySqlConnection(connection_string);
                        var cmd = new MySqlCommand(dquery, conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Updated Successfully!", "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTask();

                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Error Update!", "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {

            }
          
        }

 
        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to delete ?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    foreach (DataGridViewRow row in dg_task.SelectedRows)
                    {
                        var id = row.Cells[0].Value;
                        string dquery = "DELETE FROM tasks WHERE id = @id";
                        var conn = new MySqlConnection(connection_string);
                        var cmd = new MySqlCommand(dquery, conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Deleted Successfully!", "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTask();

                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Error Delete!", "Message Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {

            }
          
           

        }



        //Exit CRUD
        private void btn_MyAccount_MouseHover(object sender, EventArgs e)
        {
            btn_MyAccount.IconColor = Color.FromArgb(52, 152, 219);
        }

        private void btn_MyAccount_MouseLeave(object sender, EventArgs e)
        {
            btn_MyAccount.IconColor = Color.WhiteSmoke;
        }

        private void btn_MyAccount_Click(object sender, EventArgs e)
        {
            Hide();
            var myAccount = new MyAccount(user_id);
            myAccount.Show();
        }

        private void btn_logout_Click_1(object sender, EventArgs e)
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

        private void dg_task_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
        }
    }
}
