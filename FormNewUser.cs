using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFApp_db
{
     public partial class FormNewUser : Form
     {
          public FormNewUser()
          {
               InitializeComponent();
          }

          private void submitBtn_Click(object sender, EventArgs e)
          {
               string username = nameTextBox.Text;
               string password = passTextBox.Text;
               DBConnect conn = new DBConnect();
               int res = conn.NewUser(username, password);
               if(res == 1)
               {
                    errorTextBox.Text = "Error: Username not avaliable";
               }
               else
               {
                    this.Hide();
                    Login lForm = new Login();
                    lForm.Closed += (s, args) => this.Close();
                    lForm.Show();
               }
          }
     }
}
