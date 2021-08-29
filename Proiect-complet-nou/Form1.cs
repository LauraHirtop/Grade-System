using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proiect_complet_nou
{
    public partial class Form1 : Form
    {
        public int newLogin;
        public Form1()
        {
            InitializeComponent();
        }

        public static string caut_Student(string user, string pass)
        {
            MySqlConnection conn = new MySqlConnection("Data Source=localhost;UserId=root;database=student");
            MySqlCommand com = conn.CreateCommand();
            com.CommandText = "SELECT id_student FROM students where username = '" + user + "' and password = '" + pass + "'";

            string id = "";
            try
            {
                conn.Open();
                MySqlDataReader readerUser = com.ExecuteReader();
                if (readerUser.Read())
                {
                    id = readerUser["id_student"].ToString();
                }
                else
                {
                    throw new Exception("Incorrect credentials!");
                }
                com.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return id;
        }

        public static string caut_Teacher(string user, string pass)
        {

            MySqlConnection conn = new MySqlConnection("Data Source=localhost;UserId=root;database=student");
            MySqlCommand com = conn.CreateCommand();
            com.CommandText = "SELECT id_profesor FROM profesors where username = '" + user + "' and password = '" + pass + "'";
            string id = "";
            try
            {
                conn.Open();
                MySqlDataReader readerUser = com.ExecuteReader();
                if (readerUser.Read())
                {
                    id = readerUser["id_profesor"].ToString();
                }
                else
                {
                    throw new Exception("Incorrect credentials!");
                }
                com.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return id;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string id = "";
            try
            {
                string userTiped = username.Text.Trim();
                string passwordTiped = password.Text.Trim();
                bool student = radioStudent.Checked;
                bool teacher = radioTeacher.Checked;

                if (userTiped == "") throw new Exception("Please fill in the USERNAME box");
                if (passwordTiped == "") throw new Exception("Please fill in the PASSWORD box");
                if(student == false && teacher == false) throw new Exception("Please select a role for this user!");
                if (student)
                {
                    id = caut_Student(userTiped, passwordTiped);

                }
                if (teacher)
                {
                    id = caut_Teacher(userTiped, passwordTiped);
                }
                if (id != "" && student)
                {
                    newLogin = Convert.ToInt16(id);
                    InfoShow pageStudent = new InfoShow(newLogin);
                    this.Hide();
                    pageStudent.ShowDialog();
                    emptyFields();
                    this.Show();
                }
                if (id != "" && teacher)
                {
                    newLogin = Convert.ToInt16(id);
                    InfoShowTeacher pageTeacher = new InfoShowTeacher(newLogin);
                    this.Hide();
                    pageTeacher.ShowDialog();
                    emptyFields();
                    this.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void emptyFields()
        {
            username.Text = "";
            password.Text = "";
            radioStudent.Checked = false;
            radioTeacher.Checked = false;
            newLogin = 0;
        }
    }
}
