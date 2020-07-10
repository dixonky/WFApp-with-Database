using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WFApp_db
{

     public partial class Login : Form
     {
          public Login()
          {
               InitializeComponent();
          }

          private void connectBtn_Click(object sender, EventArgs e)
          {
               string username = userNameBox.Text;
               string password = passwordBox.Text;
               DBConnect conn = new DBConnect();
               int count = conn.Login(username, password);
               switch (count)
               {
                    case 0:
                         loginTextBox.Visible = true;
                         loginTextBox.Text = "No username/password combo found";
                         break;
                    case 1:
                         loginTextBox.Visible = true;
                         loginTextBox.Text = "Successful login";
                         int id = conn.GetUserID(username);
                         this.Hide();
                         FormUser uForm = new FormUser(username, id);
                         uForm.Closed += (s, args) => this.Close();
                         uForm.Show();
                         break;
                    case -1:
                         loginTextBox.Visible = true;
                         loginTextBox.Text = "Error: Failed to connect to the database";
                         break;
                    default:
                         loginTextBox.Visible = true;
                         loginTextBox.Text = "Error: Unknown";
                         break;
               }
               conn.CloseConnection();
          }

          private void passCheckBox_CheckedChanged(object sender, EventArgs e)
          {
               if (passwordBox.UseSystemPasswordChar == true)
               {
                    passwordBox.UseSystemPasswordChar = false;
               }
               else
               {
                    passwordBox.UseSystemPasswordChar = true;
               }
          }

          private void newUserBtn_Click(object sender, EventArgs e)
          {
               this.Hide();
               FormNewUser nUForm = new FormNewUser();
               nUForm.Closed += (s, args) => this.Close();
               nUForm.Show();
          }
     }
}
