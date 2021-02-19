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

namespace Practic
{
    public partial class Form1 : Form
    {

        string connectionString = @"Data Source = .\SQLEXPRESS; Initial Catalog=Practic; Integrated Security = True";


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                DataSet ds = new DataSet();

                SqlDataAdapter daChild = new SqlDataAdapter("select * from Transactions", sqlConnection);
                SqlDataAdapter daParent = new SqlDataAdapter("select * from Cards", sqlConnection);

                SqlCommandBuilder cb = new SqlCommandBuilder(daChild);

                daParent.Fill(ds, "Card");
                daChild.Fill(ds, "Transactions");

                DataRelation dr = new DataRelation("FK_Cards_Transactions", ds.Tables["Cards"].Columns["cardID"], ds.Tables["Transactions"].Columns["transactionID"]);

                ds.Relations.Add(dr);

                BindingSource bsParent = new BindingSource();
                BindingSource bsChild = new BindingSource();

                bsParent.DataSource = ds;
                bsParent.DataMember = "Cards";

                bsChild.DataSource = bsParent;
                bsChild.DataMember = "FK_Cards_Transactions";


                dvgCards.DataSource = bsParent;
                dvgTransactions.DataSource = bsChild;

                daChild.Update(ds, "Transactions");

            }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlDataAdapter daChild = new SqlDataAdapter("select * from Posts", sqlConnection);
                daChild.InsertCommand = new SqlCommand("INSERT INTO Transactions(transactionAmount, transactionType, transactionDate, atmID, cardID) VALUES(@amount, @type, @date, @atm, @card)", sqlConnection);
                daChild.InsertCommand.Parameters.Add("@amount", SqlDbType.Int).Value = Int32.Parse(amount.Text);
                daChild.InsertCommand.Parameters.Add("@type", SqlDbType.VarChar).Value = type.Text;
                daChild.InsertCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = date.Text;

                daChild.InsertCommand.Parameters.Add("@atm", SqlDbType.Int).Value = Int32.Parse(atm.Text);
                daChild.InsertCommand.Parameters.Add("@card", SqlDbType.Int).Value = Int32.Parse(card.Text);

                sqlConnection.Open();
                daChild.InsertCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Transaction successfully added :)");

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlDataAdapter daChild = new SqlDataAdapter("select * from Transactions", sqlConnection);

                var selectedRowTransaction = Int32.Parse(dvgTransactions.SelectedRows[0].Cells[0].Value.ToString());

                daChild.DeleteCommand = new SqlCommand("delete from Transaction where transactionID=@transaction", sqlConnection);
                daChild.DeleteCommand.Parameters.Add("@transaction", SqlDbType.Int).Value = selectedRowTransaction;

                sqlConnection.Open();
                daChild.DeleteCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Transaction deleted sucessfully :)");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlDataAdapter daChild = new SqlDataAdapter("select * from Transactions", sqlConnection);

                var selectedRowParent = Int32.Parse(dvgTransactions.SelectedRows[0].Cells[0].Value.ToString());
                daChild.UpdateCommand = new SqlCommand("UPDATE Posts SET transactionAmount=@amount, transactionType=@text, transactionDate = @date WHERE transactionID = @transactionID", sqlConnection);

                daChild.UpdateCommand.Parameters.Add("@amount", SqlDbType.VarChar).Value = amount.Text;
                daChild.UpdateCommand.Parameters.Add("@text", SqlDbType.VarChar).Value = type.Text;
                daChild.UpdateCommand.Parameters.Add("@date", SqlDbType.Int).Value = Int32.Parse(date.Text);

                daChild.UpdateCommand.Parameters.Add("@transactionID", SqlDbType.Int).Value = selectedRowParent;

                sqlConnection.Open();
                daChild.UpdateCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Transaction pdated with success");
            }
        }
    }
}
