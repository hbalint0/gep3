using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private MySqlConnection msqlConn;
        private MySqlDataReader msqlDr;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void mysqlConnect()
        {
            MySqlConnectionStringBuilder sb = new
                MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "iktat";

            try
            {
                msqlConn = new MySqlConnection(sb.ToString());
                msqlConn.Open();
                MessageBox.Show(openSikeres);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{openNemSikeres} {ex.Message}");
            }
           
        }
        private String openSikeres = "sikeres Kapcsolat",
        openNemSikeres = "Nem sikeres",
            cantToRead = "Megkezdődhet",
            closeDB = "Bezárva";

        private void button7_Click(object sender, EventArgs e)
        {
            msqlConn.Close();
            MessageBox.Show(closeDB);
            FormWindowState = FormWindowState.Closed;
            buttonswitch(formState);
        }
    }
}
