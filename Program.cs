<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;

namespace ToDoListWinForms
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new auth());
        }
    }
    
    public partial class functions
    {

        public static void Auth()
        {
            auth authForm = new auth();
            workspace workSpace = new workspace();

            MySqlConnection myConn;
            string myConnString;
            myConnString = "server=141.8.195.82;uid=a0141773_todolis;" +
                "pwd=apache12;database=a0141773_todolist;";

            try
            {
                myConn = new MySqlConnection(myConnString);
                myConn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT * FROM a0141773_todolist.users WHERE user = '" + authForm.loginBox.Text + "' and password = '" + authForm.pwdBox.Text + "';", myConn);
                MySqlDataReader myReader;
                myReader = comm.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {

                    authForm.Hide();
                    authForm.Close();
                    workSpace.ShowDialog();
                }
                else
                {
                    authForm.auth_error.Visible = true;
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }         
        }        
        public static void getGroup()
        {
            /* SELECT TABLE*/
        }
        public static void getProject()
        {
            /* SELECT TABLE*/
        }
        public static void getTodo()
        {
            /* SELECT TABLE*/
        }
        public static void getDate()
        {
            workspace workSpace = new workspace();
            workSpace.dateLabel.Text = "25/05/2017";
        }
        public static void getUsername()
        {
            auth authForm = new auth();
            string username;
            username = authForm.loginBox.Text;
            workspace workSpace = new workspace();
            workSpace.usernameLabel.Text = username;
        }
        public static void getIP()
        {
            workspace workSpace = new workspace();
            string externalip = new WebClient().DownloadString("http://icanhazip.com");
            workSpace.ipLabel.Text = externalip;
        }
        public static void getProjectName()
        {

        }

        public static void cngTodo()
        {
            /* UPDATE TABLE*/
        }
        public static void cngProject()
        {
            /* UPDATE TABLE*/
        }
        public static void checkLicense()
        {
           /* bool license = true;
            proverka license */
        }
        public static void checkBanned()
        {
            bool ban = false;
            /* proverka na ban
            */
            if (ban)
            {
                MessageBox.Show("Your account is banned. Check todolist.ru/ban-list");
            }
        }
        public static void checkUpdateProgram()
        {
            bool updateReady = false;
            if (updateReady)
            {
                MessageBox.Show("We have update for you! Check it on our website... blablabla");
            }
        }
    }
}

=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;

namespace ToDoListWinForms
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new auth());
        }
    }
    
    public partial class functions
    {

        public static void Auth()
        {
            try
            {
               
                auth authForm = new auth();
                MySqlConnection myConn = new MySqlConnection("server=141.8.195.82;port=3306;username=a0141773_todolis;database=a0141773_todolist;password=apache12");
                myConn.Open();
                MySqlCommand comm = new MySqlCommand("select user, password from users where user = '" + authForm.loginBox.Text + "' and password = '" + authForm.pwdBox.Text + "';", myConn);
                //MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                //myDataAdapter.SelectCommand = comm.ExecuteReader;
                //MySqlCommandBuilder commBuilder = new MySqlCommandBuilder(myDataAdapter);
                MySqlDataReader reader;
                reader = comm.ExecuteReader();


                int count = 0;
                while (reader.Read())   
                {
                    count = count + 1;
                }
                if (count == 0)
                {

                    authForm.Close();
                    workspace workSpace = new workspace();
                    workSpace.ShowDialog();
                }
                else
                {
                    authForm.auth_error.Visible = true;
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        
        public static void getGroup()
        {
            /* SELECT TABLE*/
        }
        public static void getProject()
        {
            /* SELECT TABLE*/
        }
        public static void getTodo()
        {
            /* SELECT TABLE*/
        }
        public static void getDate()
        {
            workspace workSpace = new workspace();
            workSpace.dateLabel.Text = "25/05/2017";
        }
        public static void getUsername()
        {
            auth authForm = new auth();
            string username;
            username = authForm.loginBox.Text;
            workspace workSpace = new workspace();
            workSpace.usernameLabel.Text = username;
        }
        public static void getIP()
        {
            workspace workSpace = new workspace();
            string externalip = new WebClient().DownloadString("http://icanhazip.com");
            workSpace.ipLabel.Text = externalip;
        }
        public static void getProjectName()
        {

        }

        public static void cngTodo()
        {
            /* UPDATE TABLE*/
        }
        public static void cngProject()
        {
            /* UPDATE TABLE*/
        }
        public static void checkLicense()
        {
           /* bool license = true;
            proverka license */
        }
        public static void checkBanned()
        {
            bool ban = false;
            /* proverka na ban
            */
            if (ban)
            {
                MessageBox.Show("Your account is banned. Check todolist.ru/ban-list");
            }
        }
        public static void checkUpdateProgram()
        {
            bool updateReady = false;
            if (updateReady)
            {
                MessageBox.Show("We have update for you! Check it on our website... blablabla");
            }
        }
    }
}

>>>>>>> origin/master
