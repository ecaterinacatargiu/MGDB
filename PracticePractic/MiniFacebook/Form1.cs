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

namespace MiniFacebook
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source = .\SQLEXPRESS; Initial Catalog=MiniFacebook; Integrated Security = True";



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                DataSet ds = new DataSet();

                SqlDataAdapter daChild = new SqlDataAdapter("select * from Posts", sqlConnection);
                SqlDataAdapter daParent = new SqlDataAdapter("select * from Users", sqlConnection);

                SqlCommandBuilder cb = new SqlCommandBuilder(daChild);

                daParent.Fill(ds, "Users");
                daChild.Fill(ds, "Posts");

                DataRelation dr = new DataRelation("FK_Users_Posts", ds.Tables["Users"].Columns["userID"], ds.Tables["Posts"].Columns["userID"]);

                ds.Relations.Add(dr);

                BindingSource bsParent = new BindingSource();
                BindingSource bsChild = new BindingSource();

                bsParent.DataSource = ds;
                bsParent.DataMember = "Users";

                bsChild.DataSource = bsParent;
                bsChild.DataMember = "FK_Users_Posts";

                dgvPosts.DataSource = bsChild;
                dgvUsers.DataSource = bsParent;

                daChild.Update(ds, "Posts");

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlDataAdapter daChild = new SqlDataAdapter("select * from Posts", sqlConnection);

                var selectedRowPost = Int32.Parse(dgvPosts.SelectedRows[0].Cells[0].Value.ToString());

                daChild.DeleteCommand = new SqlCommand("delete from Posts where POSTid=@PID", sqlConnection);
                daChild.DeleteCommand.Parameters.Add("@PID", SqlDbType.Int).Value = selectedRowPost;

                sqlConnection.Open();

                daChild.DeleteCommand.ExecuteNonQuery();

                sqlConnection.Close();

                MessageBox.Show("Deleted sucessfully :)");
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlDataAdapter daChild = new SqlDataAdapter("select * from Posts", sqlConnection);
                daChild.InsertCommand = new SqlCommand("INSERT INTO Posts(postDate, postText, postShares, userID) VALUES(@date, @text, @nrShares, @user)", sqlConnection);
                daChild.InsertCommand.Parameters.Add("@date", SqlDbType.VarChar).Value = postDate.Text;
                daChild.InsertCommand.Parameters.Add("@text", SqlDbType.VarChar).Value = postText.Text;
                daChild.InsertCommand.Parameters.Add("@nrShares", SqlDbType.Int).Value = Int32.Parse(postShares.Text);
                daChild.InsertCommand.Parameters.Add("@user", SqlDbType.Int).Value = Int32.Parse(userID.Text);

                sqlConnection.Open();

                daChild.InsertCommand.ExecuteNonQuery();

                sqlConnection.Close();

                MessageBox.Show("Post successfully added :)");

            }

        }

        private void postDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void userID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void updatePostButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlDataAdapter daChild = new SqlDataAdapter("select * from Posts", sqlConnection);

                var selectedRowParent = Int32.Parse(dgvPosts.SelectedRows[0].Cells[0].Value.ToString());
                daChild.UpdateCommand = new SqlCommand("UPDATE Posts SET postDate=@date, postText=@text, postShares = @nrShares, userID = @userID WHERE postID = @postID", sqlConnection);

                daChild.UpdateCommand.Parameters.Add("@date", SqlDbType.VarChar).Value = postDate.Text;
                daChild.UpdateCommand.Parameters.Add("@text", SqlDbType.VarChar).Value = postText.Text;
                daChild.UpdateCommand.Parameters.Add("@nrShares", SqlDbType.Int).Value = Int32.Parse(postShares.Text);
                daChild.UpdateCommand.Parameters.Add("@userID", SqlDbType.VarChar).Value = Int32.Parse(userID.Text);

                daChild.UpdateCommand.Parameters.Add("@postID", SqlDbType.Int).Value = selectedRowParent;

                sqlConnection.Open();

                daChild.UpdateCommand.ExecuteNonQuery();

                sqlConnection.Close();

                MessageBox.Show("Updated with success");            
            }
        }
    }
}
