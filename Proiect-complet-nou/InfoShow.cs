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
    public partial class InfoShow : Form
    {
        public int student;
        public InfoShow(int user)
        {
            student = user;
            InitializeComponent();
            displayInfo(user);
        }
        public void displayInfo(int stud)
        {
            MySqlConnection conn = new MySqlConnection("Data Source=localhost;UserId=root;database=student");
            try
            {
                conn.Open();
                MySqlCommand com = conn.CreateCommand();
                com.CommandText = "Select subjects.subject, subjects.semester, situations.grade, situations.status from situations inner join subjects on situations.id_subject = subjects.id_subject inner join students on situations.id_student = students.id_student where students.id_student = " + stud + " ";
                MySqlDataReader reader = com.ExecuteReader();
                DataTable studentDataTable = new DataTable();
                studentDataTable.Load(reader);
                tableInfo.DataSource = studentDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
