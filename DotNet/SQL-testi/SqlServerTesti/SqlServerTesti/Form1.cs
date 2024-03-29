﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlServerTesti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Database=Northwind;Integrated Security=true;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            MessageBox.Show("Tietokantayhteys avattu.");

            string maa = textBox1.Text;

            // VAROITUS: SQL-injektiohyökkäysmahdollisuus
            //string sql = "SELECT * FROM Customers WHERE Country = '"+maa+"'";

            // parametroitu kysely
            string sql = "SELECT * FROM Customers WHERE Country = @Maa";

            MessageBox.Show(sql);

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Maa", maa);
            // command.ExecuteReader();
        }
    }
}
