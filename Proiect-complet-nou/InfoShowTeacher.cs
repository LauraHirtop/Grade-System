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
    public partial class InfoShowTeacher : Form
    {
        public int teacher;
        public int alreadytableRowCount;
        DataSet displayedInfo = new DataSet();

        public InfoShowTeacher(int user)
        {
            teacher = user;
            InitializeComponent();
        }

        public void displayAllData(int t)
        {
            MySqlConnection conn = new MySqlConnection("Data Source=localhost;UserId=root;database=student");
            try
            {
                conn.Open();
                MySqlCommand com = conn.CreateCommand();
                com.CommandText = "Select students.name, subjects.subject, situations.status, situations.grade from situations inner join students on situations.id_student = students.id_student inner join subjects on situations.id_subject = subjects.id_subject inner join profesors on subjects.id_profesor = profesors.id_profesor where profesors.id_profesor = " + t + " order by students.name";
                MySqlDataReader reader = com.ExecuteReader();
                DataTable teacherDataTable = new DataTable();
                teacherDataTable.Load(reader);
                tableTeacher.DataSource = teacherDataTable;
                foreach (DataGridViewRow row in tableTeacher.Rows)
                {
                    row.ReadOnly = true;
                }
                tableTeacher.AllowUserToAddRows = true;
                alreadytableRowCount = teacherDataTable.Rows.Count - 1;
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
           
       public void addRow(int t, int alreadytableRowCount)
        {
            MySqlConnection conn = new MySqlConnection("Data Source=localhost;UserId=root;database=student");

            int i = alreadytableRowCount + 1;
            string name = tableTeacher.Rows[i].Cells[0].Value.ToString();
            string subject = tableTeacher.Rows[i].Cells[1].Value.ToString();
            string status = tableTeacher.Rows[i].Cells[2].Value.ToString();
            string grade = tableTeacher.Rows[i].Cells[3].Value.ToString();
            string idStudent;
            string idSubject;

            try
            {
                conn.Open();
                bool namecheck = false;
                bool subjectcheck = false;                
                if(name != "")
                {
                    MySqlCommand com = conn.CreateCommand();
                    com.CommandText = "Select id_student from students where name = '" + name + "'";
                    MySqlDataReader reader = com.ExecuteReader();
                    if (reader.Read()) {
                        idStudent = reader["id_student"].ToString();
                        namecheck = true;
                        reader.Close();
                    }
                    else throw new Exception("The student inserted is not in the database");
                }else throw new Exception("Empty name field!");
                if (subject != "")
                {
                    MySqlCommand com = conn.CreateCommand();
                    com.CommandText = "Select id_subject from subjects where subject = '" + subject + "' and id_profesor = " + t;
                    MySqlDataReader reader = com.ExecuteReader();
                    if (reader.Read())
                    {
                        idSubject = reader["id_subject"].ToString();
                        subjectcheck = true;
                        reader.Close();
                    }
                    else throw new Exception("The subject inserted is not in the database");
                }
                else throw new Exception("Empty subject field!");
                if (namecheck && subjectcheck)
                {
                    MySqlCommand com = conn.CreateCommand();
                    com.CommandText = " INSERT INTO `situations`(`id_student`, `id_subject`, `status`, `grade`) VALUES ( " + Convert.ToInt16(idStudent) + " , " + Convert.ToInt16(idSubject)+ ", " + Convert.ToBoolean(status) + " , " + Convert.ToDecimal(grade) + ")";
                    int a = com.ExecuteNonQuery();
                    if (a == 0) throw new Exception("Could not insert into database");
                    else MessageBox.Show("Data inserted successfully");
                }
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

        public void deleteRow(int row)
        {
            MySqlConnection conn = new MySqlConnection("Data Source=localhost;UserId=root;database=student");
            int entry = row;
            string name = tableTeacher.Rows[entry].Cells[0].Value.ToString();
            string subject = tableTeacher.Rows[entry].Cells[1].Value.ToString();
            string status = tableTeacher.Rows[entry].Cells[2].Value.ToString();
            string grade = tableTeacher.Rows[entry].Cells[3].Value.ToString();
            try
            {
                conn.Open();
                MySqlCommand com = conn.CreateCommand();
                com.CommandText = "SELECT id_situation FROM situations inner join students on situations.id_student = students.id_student inner join subjects on situations.id_subject = subjects.id_subject where students.name = '" + name + "' and subjects.subject = '" + subject + "' and situations.status = " + Convert.ToBoolean(status) + " and situations.grade = " + Convert.ToDecimal(grade) + " ";
                MySqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    string entryToBeDeleted = reader["id_situation"].ToString();
                    reader.Close();
                    try
                    {
                        MySqlCommand com2 = conn.CreateCommand();
                        com2.CommandText = "DELETE FROM situations WHERE situations.id_situation = " + Convert.ToInt16(entryToBeDeleted) + " ";
                        int a = com2.ExecuteNonQuery();
                        if (a == 0) throw new Exception("Could not delete the entry");
                        else MessageBox.Show("Data deleted successfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    throw new Exception("Could not find the data in the database");
                }
                

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

        public void displaySelectedData(int t)
        {
            MySqlConnection conn = new MySqlConnection("Data Source=localhost;UserId=root;database=student");
            try
            {
                string criteria = comboSearch.Text.Trim();
                string value = searchBox.Text.Trim();
                if (criteria == "" || value == "") throw new Exception("Empty input field!");
                conn.Open();
                if (criteria == "Name")
                {
                    displayedInfo.Clear();
                    MySqlCommand com = conn.CreateCommand();
                    com.CommandText = "Select situations.id_situation, subjects.subject, subjects.semester, situations.grade, situations.status from situations inner join students on situations.id_student = students.id_student inner join subjects on situations.id_subject = subjects.id_subject inner join profesors on subjects.id_profesor = profesors.id_profesor where profesors.id_profesor = " + t + " and students.name = '" + value + "'";
                    MySqlDataReader reader = com.ExecuteReader();
                    DataTable teacherSearchDataTable = new DataTable();
                    teacherSearchDataTable.Load(reader);
                    tableTeacher.DataSource = teacherSearchDataTable;

                    if (tableTeacher.Rows.Count == 0) MessageBox.Show("The student doesn't belong to our database!");

                    tableTeacher.AllowUserToAddRows = false;
                    tableTeacher.Columns["id_situation"].Visible = false;
                    tableTeacher.Columns["subject"].ReadOnly = true;
                    tableTeacher.Columns["semester"].ReadOnly = true;
                    displayedInfo.Tables.Add(teacherSearchDataTable.Copy());

                }
                else if (criteria == "Semester")
                {
                    displayedInfo.Clear();
                    MySqlCommand com = conn.CreateCommand();
                    com.CommandText = "Select situations.id_situation, students.name, subjects.subject, situations.grade, situations.status from situations inner join students on situations.id_student = students.id_student inner join subjects on situations.id_subject = subjects.id_subject inner join profesors on subjects.id_profesor = profesors.id_profesor where profesors.id_profesor = " + t + " and subjects.semester = " + value + " order by subjects.subject";
                    MySqlDataReader reader = com.ExecuteReader();
                    DataTable teacherSearchDataTable = new DataTable();
                    teacherSearchDataTable.Load(reader);
                    tableTeacher.DataSource = teacherSearchDataTable;

                    if (tableTeacher.Rows.Count == 0) MessageBox.Show("The semester does not correspond to our database!");

                    tableTeacher.AllowUserToAddRows = false;
                    tableTeacher.Columns["id_situation"].Visible = false;
                    tableTeacher.Columns["name"].ReadOnly = true;
                    tableTeacher.Columns["subject"].ReadOnly = true;
                    displayedInfo.Tables.Add(teacherSearchDataTable.Copy());
                }
                else
                {
                    displayedInfo.Clear();
                    MySqlCommand com = conn.CreateCommand();
                    com.CommandText = "Select situations.id_situation, students.name, subjects.semester, situations.grade, situations.status from situations inner join students on situations.id_student = students.id_student inner join subjects on situations.id_subject = subjects.id_subject inner join profesors on subjects.id_profesor = profesors.id_profesor where profesors.id_profesor = " + t + " and subjects.subject = '" + value + "' order by students.name";
                    MySqlDataReader reader = com.ExecuteReader();
                    DataTable teacherSearchDataTable = new DataTable();
                    teacherSearchDataTable.Load(reader);
                    tableTeacher.DataSource = teacherSearchDataTable;

                    if (tableTeacher.Rows.Count == 0) MessageBox.Show("The subject does not belong to our database!");

                    tableTeacher.AllowUserToAddRows = false;
                    tableTeacher.Columns["id_situation"].Visible = false;
                    tableTeacher.Columns["name"].ReadOnly = true;
                    tableTeacher.Columns["semester"].ReadOnly = true;
                    displayedInfo.Tables.Add(teacherSearchDataTable.Copy());
                }
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

        public void emptySearch()
        {
            comboSearch.Text = null;
            searchBox.Text = null;
            if (buttonModify.Visible == true) buttonModify.Visible = false;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAllData_Click(object sender, EventArgs e)
        {
            //tableTeacher.AllowUserToAddRows = true;
            displayAllData(teacher);
            emptySearch();
            buttonDelete.Visible = true;
            buttonSaveChanges.Visible = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            tableTeacher.DataSource = null;
            emptySearch();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            displaySelectedData(teacher);
            buttonModify.Visible = true;
            buttonDelete.Visible = false;
            buttonSaveChanges.Visible = false;
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            int newtableRowCount = tableTeacher.Rows.Count - 2;
            int difference = newtableRowCount - alreadytableRowCount;
            if(difference > 0)
            {
                for (int i = 0; i < difference; i++)
                {
                    addRow(teacher, alreadytableRowCount);
                }
            }
            tableTeacher.AllowUserToAddRows = true;
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                for(int i = 0; i < tableTeacher.SelectedRows.Count; i++)
                {
                    int selectedItem = tableTeacher.SelectedRows[i].Index;
                    deleteRow(selectedItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Data Source=localhost;UserId=root;database=student");
            conn.Open();
            try
            {
                int index = Convert.ToInt16(displayedInfo.Tables.Count) - 1;
                DataTable dtCh = new DataTable();
                dtCh = displayedInfo.Tables[index];
                int i = 0;
                foreach (DataRow dr in dtCh.Rows)
                {
                    MySqlCommand com = conn.CreateCommand();
                    com.CommandText = "UPDATE `situations` SET `status` = " + tableTeacher.Rows[i].Cells[4].Value + ", `grade` = '" + tableTeacher.Rows[i].Cells[3].Value + "' WHERE `situations`.`id_situation` = " + dr[0] + ";";
                    com.ExecuteNonQuery();
                    i++;
                }
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
    }
}
