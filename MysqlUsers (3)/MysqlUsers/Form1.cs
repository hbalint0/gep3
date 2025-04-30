using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MysqlUsers
{
    public partial class Form1 : Form
    {
        private MySqlConnection msqlConn;
        private MySqlDataReader msqlDr;

        private string userTeljesLista = "usersTeljesLista";
        private string userInsert = "UserInsert";
        private string userUpdate= "UserUpdate";
        private string userDelete= "UserDelete";

        private string openSikeres = "kapcsolódás sikeres",
                       openNemSikeres = "kapcsolódás nem sikerült",
                       canToRead = "az olvasás megkezdődött",
                       closedDB = "az adatbázis kapcsolat bezárva";

        private string insBasic = "Beszúrás";
        private string insEdit = "Szerkesztés vége";
        private string updBasic= "Módosítás";
        private string updEdit = "Módosítás vége";

        private enum FormState
        {
            Opened,
            Closed,
            Reading,
            EditInsert,
            EditUpdate
        }

        private FormState formState = FormState.Closed;

        private void buttonSwitch(FormState fs)
        {
            switch (fs)
            {
                case FormState.Closed:
                    btnConn.Enabled = true;
                    btnOp.Enabled = false;
                    btnRead.Enabled = false;
                    btnIns.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDel.Enabled = false;
                    btnClose.Enabled = false;
                    break;
                case FormState.Opened:
                    btnConn.Enabled = false;
                    btnOp.Enabled = true;
                    btnRead.Enabled = false;
                    btnIns.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDel.Enabled = true;
                    btnClose.Enabled = true;

                    tbxID.Enabled = false;
                    tbxJelszo.Enabled = false;
                    tbxNev.Enabled = false;
                    cbxAdmin.Enabled = false;

                    btnIns.Text = insBasic;
                    btnEdit.Text = updBasic;
                    break;
                case FormState.Reading:
                    btnConn.Enabled = false;
                    btnOp.Enabled = false;
                    btnRead.Enabled = true;
                    btnIns.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDel.Enabled = true;
                    btnClose.Enabled = true;
                    break;
                case FormState.EditInsert:
                    btnConn.Enabled = false;
                    btnOp.Enabled = false;
                    btnRead.Enabled = false;
                    btnIns.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDel.Enabled = false;
                    btnClose.Enabled = true;

                    tbxJelszo.Enabled = true;
                    tbxNev.Enabled = true;
                    cbxAdmin.Enabled = true;

                    tbxJelszo.Text = String.Empty;
                    tbxNev.Text = String.Empty;
                    cbxAdmin.Checked = false;

                    btnIns.Text = insEdit;
                    break;
                case FormState.EditUpdate:
                    btnConn.Enabled = false;
                    btnOp.Enabled = false;
                    btnRead.Enabled = false;
                    btnIns.Enabled = false;
                    btnEdit.Enabled = true;
                    btnDel.Enabled = false;
                    btnClose.Enabled = true;

                    tbxJelszo.Enabled = true;
                    tbxNev.Enabled = true;
                    cbxAdmin.Enabled = true;

                    btnEdit.Text = updEdit;
                    break;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            mysqlconnect();
        }

        private void mysqlconnect()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
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
                MessageBox.Show($"{openNemSikeres} \n {ex.Message}");
            }
        }

        private void btnOp_Click(object sender, EventArgs e)
        {
            using (MySqlCommand sqlConn = new MySqlCommand(userTeljesLista, msqlConn))
            {
                sqlConn.CommandType = CommandType.StoredProcedure;

                try
                {
                    msqlDr = sqlConn.ExecuteReader();

                    MessageBox.Show(canToRead);

                    formState = FormState.Reading;
                    buttonSwitch(formState);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            NextUser();
        }

        private void NextUser()
        {
            msqlDr.Read();
            tbxID.Text = msqlDr[0].ToString();
            tbxNev.Text=msqlDr[1].ToString();
            tbxJelszo.Text = msqlDr[2].ToString();
            cbxAdmin.Checked = (bool)msqlDr[3];
        } 

        private void btnIns_Click(object sender, EventArgs e)
        {
            switch (formState)
            {
                case FormState.Opened:
                    formState = FormState.EditInsert;
                    buttonSwitch(formState);
                    break;
                case FormState.Reading:
                    msqlDr.Close();
                    formState = FormState.EditInsert;
                    buttonSwitch(formState);
                    break;
                case FormState.EditInsert:
                    InsertUser(tbxNev.Text, tbxJelszo.Text, cbxAdmin.Checked ? 1 : 0);
                    formState = FormState.Reading;
                    buttonSwitch(formState);
                    break;
            }
        }

        private void InsertUser(string pNev, string pJelszo, int pAdmin)
        {
            using(MySqlCommand sqlConn=new MySqlCommand(userInsert, msqlConn))
                {
                sqlConn.CommandType = CommandType.StoredProcedure;
                MySqlParameter p = new MySqlParameter();
                p.ParameterName = "pNev";
                p.Value = pNev;
                p.MySqlDbType = MySqlDbType.String;
                sqlConn.Parameters.Add(p);

                sqlConn.Parameters.AddWithValue("pJelszo", pJelszo);
                sqlConn.Parameters.AddWithValue("pAdmin", pAdmin);

                try
                {
                    sqlConn.ExecuteNonQuery();
                    MessageBox.Show("A rekord felvétele sikeres");
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            switch(formState)
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
            DeleteUser(Convert.ToInt32(tbxID.Text));
        }

        private void DeleteUser(int pID)
        {
            using (MySqlCommand sqlcomm = new MySqlCommand(userDelete, msqlConn))
            {
                sqlcomm.CommandType = CommandType.StoredProcedure;

                sqlcomm.Parameters.AddWithValue("pID", pID);
                try
                {
                    sqlcomm.ExecuteNonQuery();
                    MessageBox.Show("A rekord törlése sikeres");
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
                MessageBox.Show(closedDB);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            switch (formState)
            {
                case FormState.Opened:
                    formState = FormState.EditUpdate;
                    buttonSwitch(formState);
                    break;
                case FormState.Reading:
                    msqlDr.Close();
                    formState = FormState.EditUpdate;
                    buttonSwitch(formState);
                    break;
                case FormState.EditUpdate:
                    UpdateUser(Convert.ToInt32(tbxID.Text), tbxNev.Text, tbxJelszo.Text, cbxAdmin.Checked ? 1 : 0);
                    formState = FormState.Opened;
                    buttonSwitch(formState);
                    break;
            }
        }

        private void UpdateUser(int pID, string pNev, string pJelszo, int pAdmin)
        {
            using (MySqlCommand sqlConn = new MySqlCommand(userUpdate, msqlConn))
            {
                sqlConn.CommandType = CommandType.StoredProcedure;

                sqlConn.Parameters.AddWithValue("ID", pID);

                MySqlParameter p = new MySqlParameter();
                p.ParameterName = "Nev";
                p.Value = pNev;
                p.MySqlDbType = MySqlDbType.String;
                sqlConn.Parameters.Add(p);

                sqlConn.Parameters.AddWithValue("Jelszo", pJelszo);
                sqlConn.Parameters.AddWithValue("Admin", pAdmin);

                try
                {
                    sqlConn.ExecuteNonQuery();
                    MessageBox.Show("A rekord módosítása sikeres");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            msqlConn.Close();
            MessageBox.Show(closedDB);
            formState = FormState.Closed;
            buttonSwitch(formState); ;
        }

    }
}
