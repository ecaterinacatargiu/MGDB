using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class dogId : Form
    {

        string connectionString = @"Data Source = .\SQLEXPRESS; Initial Catalog=DogShelter; Integrated Security = True";
        private SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        static string connString = ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.DogShelterConnectionString"].ConnectionString.ToString();
        SqlConnection conn = new SqlConnection(connString);



        public dogId()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadBreeds();
        }

        private void loadBreeds()
        {
            conn.Open();

            string select = ConfigurationSettings.AppSettings["SelectParent"];
            da.SelectCommand = new SqlCommand(select, conn);

            ds.Clear();
            da.Fill(ds);

            breedGrid.DataSource = ds.Tables[0];

            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadDogs();
        }


        private void loadDogs()
        {
            conn.Open();

            int getBreedId = int.Parse(breedTextBox.Text);

            string select = ConfigurationManager.AppSettings["SelectChild"];
            SqlCommand cmd = new SqlCommand(select, conn);
            cmd.Parameters.AddWithValue("@breedId", getBreedId);
            SqlDataAdapter daChild = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            daChild.Fill(dataSet);
            dogsGrid.DataSource = dataSet.Tables[0];
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            loadAllDogs();
        }

        private void loadAllDogs()
        {
            conn.Open();

            string select = ConfigurationManager.AppSettings["SelectAllChild"];
            SqlCommand cmd = new SqlCommand(select, conn);

            SqlDataAdapter daChild = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            daChild.Fill(dataSet);
            allDogs.DataSource = dataSet.Tables[0];
            conn.Close();

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            deleteDog();
        }

        private void deleteDog()
        {
            try
            {
                int getBreedId = int.Parse(breedTextBox.Text);
                string delete = ConfigurationManager.AppSettings["DeleteChild"];

                SqlCommand cmd = new SqlCommand(delete, conn);

                cmd.Parameters.AddWithValue("@breedId", getBreedId);

                SqlDataAdapter daChild = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();

                conn.Open();

                cmd.ExecuteNonQuery();
                daChild.Fill(dataSet);

                conn.Close();

                MessageBox.Show("Doggie addopted <3");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                conn.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addDoggie();
        }

        private void addDoggie()
        {
            try
            {
                int dogId = int.Parse(textBoxDogId.Text);
                string dogName = textBoxDogName.Text;
                string dogBirthday = textBoxDogBirthday.Text;
                int getBreedId = int.Parse(textBoxbreedId.Text);
                int staffID = int.Parse(textBoxStaffId.Text);
                int addoptionID = int.Parse(textBoxAddoptionId.Text);
                int year = int.Parse(textBoxYears.Text);
                int yearsOfTraining = int.Parse(textBoxYearsOfTraining.Text);

                string add = ConfigurationManager.AppSettings["AddChild"];
                SqlCommand addDog = new SqlCommand(add, conn);

                addDog.Parameters.AddWithValue("@dogId", dogId);
                addDog.Parameters.AddWithValue("@dogName", dogName);
                addDog.Parameters.AddWithValue("@dogBirthday", dogBirthday);
                addDog.Parameters.AddWithValue("@breedId", getBreedId);
                addDog.Parameters.AddWithValue("@staffId", staffID);
                addDog.Parameters.AddWithValue("@addoptionId", addoptionID);
                addDog.Parameters.AddWithValue("@years", year);
                addDog.Parameters.AddWithValue("@yearsOfTraining", yearsOfTraining);

                SqlDataAdapter daChild = new SqlDataAdapter(addDog);
                DataSet dataSet = new DataSet();

                conn.Open();
                daChild.Fill(dataSet);
                conn.Close();
                MessageBox.Show("Dog available for adoption");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                conn.Close();
            }
     }


        private void button1_Click_3(object sender, EventArgs e)
        {
            updateDoggie();
        }

        private void updateDoggie()
        {
            try
            {
                int newBreedId = int.Parse(textBoxtBreedChangeName.Text);
                string dogName = newDogNameTextBox.Text;

                string update = ConfigurationManager.AppSettings["UpdateChild"];
                SqlCommand cmd = new SqlCommand(update, conn);

                cmd.Parameters.AddWithValue("@dogName", dogName);
                cmd.Parameters.AddWithValue("@breedId", newBreedId);

                SqlDataAdapter daChild = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();

                conn.Open();
                daChild.Fill(dataSet);
                conn.Close();

                MessageBox.Show("Info about this doggie have been updated");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                conn.Close();
            }
        }

        private void breedGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void allDogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    
}
