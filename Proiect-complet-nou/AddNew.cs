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
    public partial class AddNew : Form
    {
        public int teacher;
        public AddNew(int user)
        {
            teacher = user;
            populateCombos();
            InitializeComponent();
            comboStudents.SelectedIndex = 0;
        }

        public void populateCombos()
        {
            MySqlConnection conn = new MySqlConnection("Data Source=localhost;UserId=root;database=student");
            string[] list = new string[200];
            int i = 0;
            try
            {
                conn.Open();
                MySqlCommand com = new MySqlCommand("SELECT * FROM students ORDER BY name", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(com);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                com.ExecuteNonQuery();
                conn.Close();

                comboStudents.DataSource = ds.Tables[0];
                comboStudents.DisplayMember = "name";
                comboStudents.ValueMember = "id_student";


                //MySqlCommand com = conn.CreateCommand();
                //com.CommandText = "Select students.name from students order by students.name";
                //MySqlDataReader reader = com.ExecuteReader();

                // while (reader.Read())
                //{
                //    list[i] = reader[0].ToString();
                //    i = i + 1;
                //};
                // for (int a = 0; a < list.Length; a++)
                //{
                //    comboStudents.Items.Add(list[a]);
                //    MessageBox.Show(list[a]);
                // }
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
