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
using Users.Data;


namespace UserForm
{
    public partial class frmMain : Form
    {
        SqlConnection con = ConnectionManager.GetConnection();
        SqlCommand cmd;
        SqlDataAdapter adapt;
         
        int ID = 0;
        public frmMain()
        {
            InitializeComponent();
            DisplayData();
        }
        //Insert Data  
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text != "" && textBoxEmail.Text != "" && textBoxDescription.Text != "" && textBoxCity.Text != "" && textBoxStreet.Text != "")
            {
                cmd = new SqlCommand("insert into Users (Username,Email,Description,City,Street) values(@username,@email,@description,@city,@street)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@username", textBoxUserName.Text);
                cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
                cmd.Parameters.AddWithValue("@description", textBoxDescription.Text);
                cmd.Parameters.AddWithValue("@city", textBoxCity.Text);
                cmd.Parameters.AddWithValue("@street", textBoxStreet.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please complete all the required details");
            }
        }
        //Display Data in DataGridView  
        private void DisplayData()
        {
            
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Users", con);
            adapt.Fill(dt);
           dataGridView1.DataSource = dt;
            con.Close();
        }
        //Clear Data  
        private void ClearData()
        {
            textBoxUserId.Text = "";
            textBoxEmail.Text = "";
            textBoxDescription.Text = "";
            textBoxCity.Text = "";
            textBoxStreet.Text = "";
            ID = 0;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxUserId.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxDescription.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxCity.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxStreet.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
        //Update Record  
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text != "" && textBoxEmail.Text != "" && textBoxDescription.Text != "" && textBoxCity.Text != "" && textBoxStreet.Text != "")
            {
                cmd = new SqlCommand("update Users set Username=@username,Email=@email, Description=@description,City=@city,Street=@street where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@username", textBoxUserId.Text);
                cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
                cmd.Parameters.AddWithValue("@description", textBoxDescription.Text);
                cmd.Parameters.AddWithValue("@city", textBoxCity.Text);
                cmd.Parameters.AddWithValue("@street", textBoxStreet.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please provide all the required details");
            }
        }
        //Delete Record  
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("delete Users where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }    
        
    }
}
