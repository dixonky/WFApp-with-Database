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
     public partial class FormUser : Form
     {
          private string username;
          private string oldName;
          private int user_ID;
          private List<string>[] records;

          public FormUser()
          {
               InitializeComponent();
          }
          public FormUser(string name, int id)
          {
               user_ID = id;
               username = name;
               InitializeComponent();
               userLabel.Text = "Welcome, " + username;
               getRecords();
          }
          private void recordsBox_SelectedIndexChanged(object sender, System.EventArgs args)
          {
               recordDataBox.Visible = true;
               recNameBox.Visible = false;
               recNameLabel.Visible = false;
               recDataBox.Visible = false;
               recDataLabel.Visible = false;
               recSaveBtn.Visible = false;
               recSaveChBtn.Visible = false;
               string name = recordsBox.SelectedItem.ToString();
               int index = recordsBox.Items.IndexOf(name);
               recordDataBox.Text = (records[1][index]);
          }

          private void delBtn_Click(object sender, EventArgs e)
          {
               string record = recordsBox.SelectedItem.ToString();
               DBConnect conn = new DBConnect();
               int res = conn.DeleteRecord(record);
               if (res == 1)
               {
                    getRecords();
               }
          }

          private void getRecords()
          {
               recordDataBox.Visible = true;
               recNameBox.Visible = false;
               recNameLabel.Visible = false;
               recDataBox.Visible = false;
               recDataLabel.Visible = false;
               recSaveBtn.Visible = false;
               recSaveChBtn.Visible = false;
               recordsBox.Items.Clear();
               DBConnect conn = new DBConnect();
               records = conn.SelectRecords(username);
               if (!records.Any())
               {
                    recordsBox.Items.Add("No records found");
               }
               else
               {
                    foreach (var name in records[0])
                    {
                         recordsBox.Items.Add(name);
                    }
               }
               recordsBox.SelectedIndexChanged += (s, args) => recordsBox_SelectedIndexChanged(s, args);
          }


          private void newRecBtn_Click(object sender, EventArgs e)
          {
               recordDataBox.Visible = false;
               recNameBox.Visible = true;
               recNameLabel.Visible = true;
               recDataBox.Visible = true;
               recDataLabel.Visible = true;
               recSaveBtn.Visible = true;
               recDataBox.Text = "";
               recNameBox.Text = "";
          }

          private void recSaveBtn_Click(object sender, EventArgs e)
          {
               string name = recNameBox.Text;
               string data = recDataBox.Text;
               DBConnect conn = new DBConnect();
               int res = conn.NewRecord(name, data, user_ID);
               if (res == 1)
               {
                    this.Refresh();
                    getRecords();
               }
          }

          private void recEditBtn_Click(object sender, EventArgs e)
          {
               recordDataBox.Visible = false;
               recNameBox.Visible = true;
               recNameLabel.Visible = true;
               recDataBox.Visible = true;
               recDataLabel.Visible = true;
               recSaveBtn.Visible = false;
               recSaveChBtn.Visible = true;
               string name = recordsBox.SelectedItem.ToString();
               int index = recordsBox.Items.IndexOf(name);
               recDataBox.Text = (records[1][index]);
               recNameBox.Text = (records[0][index]);
               oldName = records[0][index];
          }

          private void recSaveChBtn_Click(object sender, EventArgs e)
          {
               string name = recNameBox.Text;
               string data = recDataBox.Text;
               DBConnect conn = new DBConnect();
               int res = conn.UpdateRecord(name, oldName, data, user_ID);
               if (res == 1)
               {
                    this.Refresh();
                    getRecords();
               }
          }
     }
}
