using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
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

        private enum FormState
        {
            Closed,
            Opened,
            Reading,
            Editinsert,
            Editupdate
        }

        private FormState formState =FormState.Closed;

        private string insBasic = "Beszúrás";
        private string insEdit = "Szerkesztés";
        private string updBasic = "Módosítás";
        private string updEdit = "Módosítás vége";


        private string userTeljesLista = "userTeljesLista";
        private string userInsert = "userInsert";
        private string userUpdate = "userUpdate";
        private string userDelete = "userDelete";



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
        private void buttonSwitch(FormState fs)
        {
            switch (fs)
            {
                case FormState.Closed:
                    button1.Enabled = true;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    break;
                case FormState.Opened:
                    button1.Enabled = false;
                    button2.Enabled = true;
                    button3.Enabled = false;
                    button4.Enabled = true;
                    button5.Enabled = true;
                    button6.Enabled = true;
                    button7.Enabled = true;

                    tbxanozosito.Enabled = false;
                    tbxnev.Enabled = false;
                    tbxjelszo.Enabled = false;
                    cbxadmin.Enabled = false;

                    button4.Text = insBasic;
                    button5.Text = updBasic;
                    break;

                case FormState.Reading:
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = true;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = true;
                    break;

                case FormState.Editinsert:
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = true;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = true;

                    tbxnev.Enabled = true;
                    tbxjelszo.Enabled = true;
                    cbxadmin.Enabled = true;
                    
                    tbxnev.Text = String.Empty;
                    tbxjelszo.Text = String.Empty;
                    cbxadmin.Checked = false;

                    button4.Text = insEdit;
                    break;

                case FormState.Editupdate:
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = true;
                    button6.Enabled = false;
                    button7.Enabled = true;

                    tbxnev.Enabled = true;
                    tbxjelszo.Enabled = true;
                    cbxadmin.Enabled = true;

                    button5.Text = updEdit;

                    break;
            }
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

                formState = FormState.Opened;
                buttonSwitch(formState);
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

        private void button4_Click(object sender, EventArgs e)
        {
            switch (formState)
            { 
              case FormState.Opened:
                formState = FormState.Editinsert;
                buttonSwitch(formState);
                break;
            case FormState.Reading:
                msqlDr.Close();
                formState = FormState.Editinsert;
                buttonSwitch(formState);
                break;
            case FormState.Editinsert:
                InsertUser(tbxnev. Text, tbxjelszo.Text,
                    (cbxadmin.Checked) ? 1 : 0);
                formState = FormState.Opened;
                buttonSwitch(formState);
                break;
            }
        }

        private void InsertUser(string pNev , string pJelszo, int pAdmin)
        {
            using (MySqlCommand sqlComm = new MySqlCommand
                    (userInsert, msqlConn))
            { 
            sqlComm.CommandType = CommandType.StoredProcedure;

            MySqlParameter p = new MySqlParameter();
            p.ParameterName = "pNev";
            p.Value = pNev;
            p.MySqlDbType = MySqlDbType.String;
            sqlComm.Parameters.Add(p);
            sqlComm.Parameters.AddWithValue("pJelszo",
pJelszo);
            sqlComm.Parameters.AddWithValue("pAdmin", pAdmin);


                try
                {
                    sqlComm.ExecuteNonQuery();
                    MessageBox.Show("A rekord felvétele sikeres");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            NextUser();
        }
        private void NextUser()
        {
            msqlDr.Read();
            tbxanozosito.Text= msqlDr[0].ToString().Trim();
            tbxnev.Text= msqlDr[1].ToString().Trim();
            tbxjelszo.Text= msqlDr[2].ToString().Trim();
            cbxadmin.Checked=(bool)msqlDr[3];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch (formState)
            {
                case FormState.Opened:
                    formState = FormState.Editupdate;
                    buttonSwitch(formState);
                    break;
                case FormState.Reading:
                    msqlDr.Close();
                    formState = FormState.Editupdate;
                    buttonSwitch(formState);
                    break;
                case FormState.Editupdate:
                    UpdateUser(Convert.ToInt32(tbxanozosito.Text), tbxnev.Text, 
                        tbxjelszo.Text, (cbxadmin.Checked) ? 1:0);
                    formState = FormState.Editupdate;
                    buttonSwitch(formState);
                    break;
            }

        }

        private void UpdateUser(int pID, string pNev, string pJelszo, int pAdmin)
        { 
            using (MySqlCommand sqlComm = new MySqlCommand
            (userUpdate, msqlConn))
            { 
            sqlComm.CommandType = CommandType.StoredProcedure;
            // - Paraméterek beállitása
            sqlComm.Parameters.AddWithValue("ID", pID);
            MySqlParameter p = new MySqlParameter();
                p.ParameterName = "Nev";
            p.Value = pNev;
            p.MySqlDbType = MySqlDbType.String;
            sqlComm.Parameters.Add(p);
            sqlComm.Parameters.AddWithValue(" Jelszo",
            pJelszo) ;
            sqlComm.Parameters.AddWithValue("Admin", pAdmin);

                try
                {
                    sqlComm.ExecuteNonQuery();
                    MessageBox.Show("Sikeres");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

    
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            switch (formState)
            {
                case FormState.Reading:
                    break;
            }
            if(formState == FormState.Reading)
            {
                msqlDr.Close();
                formState = FormState.Opened;
                buttonSwitch(formState);
            }
            DeleteUser(Convert.ToInt32(tbxanozosito.Text));
        }

        private void DeleteUser(int pID)
        {
         using (MySqlCommand sqlComm = new MySqlCommand
                (userDelete, msqlConn))
            { 
                                sqlComm.CommandType = CommandType.StoredProcedure;
                            // Paraméterek bellitása
              sqlComm.Parameters.AddWithValue("pID", pID);
            try
            {
                sqlComm.ExecuteNonQuery();
                MessageBox.Show("Sikeres");
            }
                
               
               catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (msqlConn != null)
            {
                msqlConn.Close();
            }    
            MessageBox.Show(closeDB);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlCommand sqlComm = new MySqlCommand(userTeljesLista, msqlConn))
            {
                sqlComm.CommandType = CommandType.StoredProcedure;
                try
                {
                    msqlDr = sqlComm.ExecuteReader();
                    MessageBox.Show(cantToRead);
                    formState = FormState.Reading;
                    buttonSwitch(formState);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mysqlConnect();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            msqlConn.Close();
            MessageBox.Show(closeDB);
            formState = FormState.Closed;
            buttonSwitch(formState);
        }
    }
}
