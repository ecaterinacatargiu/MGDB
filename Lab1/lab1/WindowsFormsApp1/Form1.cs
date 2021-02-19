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


namespace WindowsFormsApp1
{
    public partial class dogId : Form
    {

        string connectionString = @"Data Source = .\SQLEXPRESS; Initial Catalog=DogShelter; Integrated Security = True";

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

        private static String getConnectionString()
        {
            return "Data Source=DESKTOP-PRM8G3D\\SQLEXPRESS;" +
                   "Initial Catalog=DogShelter;" +
                   "Integrated Security = true;";
        }

        private void loadBreeds()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter getBreeds = new SqlDataAdapter("select * from Breed", connectionString);
                
                getBreeds.Fill(ds, "Breed");

                breedGrid.DataSource = ds.Tables["Breed"];

                sqlConnection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadDogs();
        }


        private void loadDogs()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                int getBreedId = int.Parse(breedTextBox.Text);
                string sqlCommand = "select * from Dog where breedId=@breedId";


                SqlCommand getDogs = new SqlCommand(sqlCommand)
                {
                    Connection = new SqlConnection(connectionString)
                };

                getDogs.Parameters.AddWithValue("@breedId", getBreedId);

                SqlDataAdapter dataAd = new SqlDataAdapter(getDogs);

                DataSet ds = new DataSet();

                dataAd.Fill(ds, "Dog");

                dogsGrid.DataSource = ds.Tables["Dog"];          
            }
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
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter getDogs = new SqlDataAdapter("select * from Dog", connectionString);

                getDogs.Fill(ds, "Dog");

                allDogs.DataSource = ds.Tables["Dog"];

                sqlConnection.Close();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            deleteDog();
        }

        private void deleteDog()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                int getBreedId = int.Parse(breedTextBox.Text);
                string sqlCommand = "delete from Dog where breedId=@breedId";


                SqlCommand getDogs = new SqlCommand(sqlCommand)
                {
                    Connection = new SqlConnection(connectionString)
                };

                getDogs.Parameters.AddWithValue("@breedId", getBreedId);

                SqlDataAdapter dataAd = new SqlDataAdapter(getDogs);

                DataSet ds = new DataSet();

                dataAd.Fill(ds, "Dog");

                dogsGrid.DataSource = ds.Tables["Dog"];
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
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                int dogId = int.Parse(textBoxDogId.Text);
                string dogName = textBoxDogName.Text;
                string dogBirthday = textBoxDogBirthday.Text;
                int getBreedId = int.Parse(textBoxbreedId.Text);
                int staffID = int.Parse(textBoxStaffId.Text);
                int addoptionID = int.Parse(textBoxAddoptionId.Text);
                int year = int.Parse(textBoxYears.Text);
                int yearsOfTraining = int.Parse(textBoxYearsOfTraining.Text);



                string sqlCommand = "insert into Dog(dogId, dogName, dogBirthday, breedId, staffID, addoptionId, Years, YearsOfTraining) values (@dogId, @dogName, @dogBirthday, @breedId, @staffId, @addoptionId, @years, @yearsOfTraining)";
   
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand addDog = new SqlCommand(sqlCommand, con);
                con.Open();

                addDog.Parameters.AddWithValue("@dogId", dogId);
                addDog.Parameters.AddWithValue("@dogName", dogName);
                addDog.Parameters.AddWithValue("@dogBirthday", dogBirthday);
                addDog.Parameters.AddWithValue("@breedId", getBreedId);
                addDog.Parameters.AddWithValue("@staffId", staffID);
                addDog.Parameters.AddWithValue("@addoptionId", addoptionID);
                addDog.Parameters.AddWithValue("@years", year);
                addDog.Parameters.AddWithValue("@yearsOfTraining", yearsOfTraining);

                int i = addDog.ExecuteNonQuery();
                sqlConnection.Close();

                if (i != 0)
                {
                    MessageBox.Show(i + "Data Saved");
                }
            }

        }


        private void button1_Click_3(object sender, EventArgs e)
        {
            updateDoggie();
        }

        private void updateDoggie()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                int newBreedId = int.Parse(textBoxtBreedChangeName.Text);
                string dogName = newDogNameTextBox.Text;
               
                string sqlCommand = "update Dog set dogName=@dogName where breedId=@breedId";

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand addDog = new SqlCommand(sqlCommand, con);
                con.Open();

                addDog.Parameters.AddWithValue("@dogName", dogName);
                addDog.Parameters.AddWithValue("@breedId", newBreedId);

                int i = addDog.ExecuteNonQuery();
                sqlConnection.Close();

                if (i != 0)
                {
                    MessageBox.Show(i + "Data Updated");
                }
            }

        }
    }

    
}
