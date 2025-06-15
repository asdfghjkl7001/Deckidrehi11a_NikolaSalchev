using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Deckidrehi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename = C:\\USERS\\АДМИН\\SOURCE\\REPOS\\DECKIDREHI\\DECKIDREHI\\BIN\\DEBUG\\DREHICONTEXT.MDF;Integrated Security = True; Connect Timeout = 30 & ";
            //SqlConnection connect = new SqlConnection(connectionString);
            //connect.Open();
            



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'drehicontextDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.drehicontextDataSet.Products);
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection connect = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\USERS\\АДМИН\\SOURCE\\REPOS\\DECKIDREHI\\DECKIDREHI\\BIN\\DEBUG\\DREHICONTEXT.MDF;Integrated Security=True;Connect Timeout=30"))
            {
                connect.Open();
                string query = "SELECT * FROM Products";
                SqlCommand command = new SqlCommand(query, connect);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    
                    textBox1.Text = reader["Name"].ToString();
                    textBox2.Text = reader["Description"].ToString();
                    numericUpDown2.Value = Convert.ToDecimal(reader["Cena"]);
                    numericUpDown1.Value = Convert.ToInt16(reader["Razmer"]);
                    comboBox1.Text = reader["Vid"].ToString();
                    comboBox2.Text = reader["tip"].ToString();
                }
                connect.Close();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\USERS\\АДМИН\\SOURCE\\REPOS\\DECKIDREHI\\DECKIDREHI\\BIN\\DEBUG\\DREHICONTEXT.MDF;Integrated Security=True;Connect Timeout=30"))
            {
                connect.Open();
                string query = "SELECT * FROM ProductTypes";
                SqlCommand command = new SqlCommand(query, connect);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                   numericUpDown3.Value = Convert.ToDecimal(reader["ProductId"]);
                   textBox6.Text = reader["Name"].ToString();
                   
                }
                connect.Close();
            }
        }
    }
}
