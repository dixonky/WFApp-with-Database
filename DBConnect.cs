using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

//Source: https://www.codeproject.com/Articles/43438/Connect-C-to-MySQL

namespace WFApp_db
{
     class DBConnect
     {
          private MySqlConnection connection;
          private string server;
          private string database;
          private string uid;
          private string password;

          //Constructor
          public DBConnect()
          {
               Initialize();
          }

          //Initialize values
          private void Initialize()
          {
               server = "localhost";
               database = "testdb";
               uid = "root";
               password = "FoysLake";
               string connectionString;
               connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                 database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

               connection = new MySqlConnection(connectionString);
          }

          //open connection to database
          public String OpenConnection()
          {
               try
               {
                    connection.Open();
                    return "Connected";
               }
               catch (MySqlException ex)
               {
                    string failResponse;
                    switch (ex.Number)
                    {
                         case 0:
                              failResponse = "Cannot connect to server.  Contact administrator";
                              break;
                         case 1045:
                              failResponse = "Invalid username/password, please try again";
                              break;
                         default:
                              failResponse = "An error occured";
                              break;
                    }
                    return failResponse;
               }
          }

          //Close connection
          public String CloseConnection()
          {
               try
               {
                    connection.Close();
                    return "Connection to db closed";
               }
               catch (MySqlException ex)
               {
                    return ex.Message;
               }
          }


          //Login statement
          public int Login(string username, string password)
          {
               int Count = -1;
               string query = "SELECT COUNT(user_name) from users WHERE " +
                    "user_name ='" + username + "' AND user_password='" + password + "';";
               if (this.OpenConnection() == "Connected")
               {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    Count = int.Parse(cmd.ExecuteScalar() + "");
                    this.CloseConnection();
                    return Count;
               }
               else
               {
                    return Count;
               }
          }

          //User ID statement
          public int GetUserID(string username)
          {
               int ID = -1;
               string query = "SELECT user_ID from users WHERE " +
                    "user_name ='" + username + "';";
               if (this.OpenConnection() == "Connected")
               {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    ID = int.Parse(cmd.ExecuteScalar() + "");
                    this.CloseConnection();
                    return ID;
               }
               else
               {
                    return ID;
               }
          }

          //New User Insert statement
          public int NewUser(string username, string password)
          {
               int res = 0;
               string query = "SELECT COUNT(user_name) from users WHERE " +
                    "user_name ='" + username +"';";
               if (this.OpenConnection() == "Connected")
               {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    res = int.Parse(cmd.ExecuteScalar() + "");
                    this.CloseConnection();
               }
               if (res == 0)
               {
                    query = "INSERT INTO users (user_name, user_password, user_super)" +
                         "VALUES ('" + username + "','" + password + "', '0');";
                    if (this.OpenConnection() == "Connected")
                    {
                         MySqlCommand cmd = new MySqlCommand(query, connection);
                         cmd.ExecuteNonQuery();
                         this.CloseConnection();
                    }
               }
               return res;
          }

          //Update statement
          public int UpdateRecord(string name, string oldName, string data, int user)
          {
               int res = 0;
               string query = "UPDATE records " +
                    "SET record_name = '" + name + "', record_data ='" + data + "'" +
                    "WHERE users = '" + user + "' AND record_name= '" + oldName + "';"; 

               if (this.OpenConnection() == "Connected")
               {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = query;
                    cmd.Connection = connection;
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    res = 1;
               }
               return res;
          }

          //New Record Insert statement
          public int NewRecord(string name, string data, int user)
          {
               int res = 0;
               string query = "INSERT INTO records (record_name, record_data, users)" +
                    "VALUES ('" + name + "','" + data + "', '" + user + "');";

               if (this.OpenConnection() == "Connected")
               {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    res = 1;
               }
               return res;
          }

          //Delete statement
          public int DeleteRecord(string record)
          {
               int res = 0;
               string query = "DELETE FROM records WHERE record_name='" + record +"';";

               if (this.OpenConnection() == "Connected")
               {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    res = 1;
               }
               return res;
          }

          //Select statement
          public List<string>[] SelectRecords(string username)
          {
               int ID = GetUserID(username);
               string query = "SELECT record_name, record_data FROM records where users='" + ID + "';";

               List<string>[] list = new List<string>[2];
               list[0] = new List<string>();
               list[1] = new List<string>();

               if (this.OpenConnection() == "Connected")
               {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                         list[0].Add(dataReader["record_Name"] + "");
                         list[1].Add(dataReader["record_Data"] + "");
                    }
                    dataReader.Close();
                    this.CloseConnection();
                    return list;
               }
               else
               {
                    return list;
               }
          }

          //Backup
          public String Backup()
          {
               try
               {
                    DateTime Time = DateTime.Now;
                    int year = Time.Year;
                    int month = Time.Month;
                    int day = Time.Day;
                    int hour = Time.Hour;
                    int minute = Time.Minute;
                    int second = Time.Second;
                    int millisecond = Time.Millisecond;

                    //Save file to C:\ with the current date as a filename
                    string path;
                    path = "C:\\MySqlBackup" + year + "-" + month + "-" + day +
                 "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
                    StreamWriter file = new StreamWriter(path);


                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.FileName = "mysqldump";
                    psi.RedirectStandardInput = false;
                    psi.RedirectStandardOutput = true;
                    psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                           uid, password, server, database);
                    psi.UseShellExecute = false;

                    Process process = Process.Start(psi);

                    string output;
                    output = process.StandardOutput.ReadToEnd();
                    file.WriteLine(output);
                    process.WaitForExit();
                    file.Close();
                    process.Close();
                    return "Successful Backup";
               }
               catch (IOException ex)
               {
                    return "Error: Unable to backup";
               }
          }

          //Restore
          public String Restore()
          {
               try
               {
                    //Read file from C:\
                    string path;
                    path = "C:\\MySqlBackup.sql";
                    StreamReader file = new StreamReader(path);
                    string input = file.ReadToEnd();
                    file.Close();

                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.FileName = "mysql";
                    psi.RedirectStandardInput = true;
                    psi.RedirectStandardOutput = false;
                    psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                           uid, password, server, database);
                    psi.UseShellExecute = false;


                    Process process = Process.Start(psi);
                    process.StandardInput.WriteLine(input);
                    process.StandardInput.Close();
                    process.WaitForExit();
                    process.Close();
                    return "Successful Restore";
               }
               catch (IOException ex)
               {
                    return "Error: Unable to Restore";
               }
          }
     }
}
