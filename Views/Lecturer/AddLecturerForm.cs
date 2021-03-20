using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagmentSystem.Configurations;
using TimeTableManagmentSystem.Controllers.Lecturer;
using TimeTableManagmentSystem.Helpers;

namespace TimeTableManagmentSystem.Views.Lecturer
{
    public partial class AddLecturerForm : Form
    {
        string LecturerLevel = string.Empty;
        Helper helper = new Helper();

        public AddLecturerForm() {
            InitializeComponent();
            SetLectuerLevelComboBoxValues();
            SetFacultyComboBoxValues();
            SetDepartmentComboBoxValues();
            SetCenterComboBoxValues();
            selectLevelComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            facultySelectCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            departmentSelectCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            selectCenterCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            employeeIDInput.Text = Convert.ToString(helper.GenerateID());
            employeeIDInput.ReadOnly = true;
            rankInput.ReadOnly = true;
            rankInput.Text = "1."+employeeIDInput.Text;
        }
        public void Clear() {
            lecturerNameInput.Text = 
            employeeIDInput.Text = 
            facultySelectCombobox.Text = 
            departmentSelectCombobox.Text =
            selectCenterCombobox.Text = 
            buildingInput.Text = 
            selectLevelComboBox.Text = 
            rankInput.Text = string.Empty;
        }

        private void roomSaveBtn_Click(object sender, EventArgs e)
        {
            if (lecturerNameInput.Text == "") {
                MessageBox.Show("Lecturer Name is required.", "ERROR");
                return;
            }

            if (employeeIDInput.Text == "") {
                MessageBox.Show("Employee ID is required.", "ERROR");
                return;
            }

            if (facultySelectCombobox.Text == "") {
                MessageBox.Show("Select the faculty.", "ERROR");
                return;
            }

            if (departmentSelectCombobox.Text == "") {
                MessageBox.Show("Select the department.", "ERROR");
                return;
            }

            if (selectCenterCombobox.Text == "") {
                MessageBox.Show("Center is required.", "ERROR");
                return;
            }

            if (buildingInput.Text == "") {
                MessageBox.Show("Building is required.", "ERROR");
                return;
            }

            if (selectLevelComboBox.Text == "")
            {
                MessageBox.Show("Select lavel.", "ERROR");
                return;
            }

            if (rankInput.Text == "")
            {
                MessageBox.Show("Rank is required.", "ERROR");
                return;
            }

            if (lecturerSaveBtn.Text == "Save")
            {
                int level = selectLevelComboBox.SelectedIndex+1;
                Models.Lecturer lecturer = new Models.Lecturer(
                                                    lecturerNameInput.Text.Trim(), 
                                                    facultySelectCombobox.Text.Trim(), 
                                                    departmentSelectCombobox.Text.Trim(),
                                                    selectCenterCombobox.Text.Trim(), 
                                                    buildingInput.Text.Trim(), 
                                                    level, 
                                                    rankInput.Text.Trim());
                LecturerController.Store(lecturer);
                Clear();
            }
        }

        void SetLectuerLevelComboBoxValues() {
            string query = "SELECT * FROM lecturerLevel";
            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);

            try {
                using (SqlDataReader read = command.ExecuteReader()) {
                    while (read.Read()) {
                        LecturerLevel = read["Title"].ToString();
                        selectLevelComboBox.Items.Add(LecturerLevel);
                    }
                }
            } finally {
                connection.Close();
            }
        }
        void SetFacultyComboBoxValues() {
            string[] faculty = new string[7];
            faculty[0] = "Computing";
            faculty[1] = "Buisiness";
            faculty[2] = "Engineering";
            faculty[3] = "Quantity Surveyor";
            faculty[4] = "Humanities & Sciences";
            faculty[5] = "School of Architecture";
            faculty[6] = "School of Law";

            for (int i = 0; i < faculty.Length; i++) {
                string singleFaculty = faculty[i];
                facultySelectCombobox.Items.Add(singleFaculty);
            }
        }
        void SetDepartmentComboBoxValues()
        {
            string[] department = new string[4];
            department[0] = "IT";
            department[1] = "SE";
            department[2] = "BM";
            department[3] = "EN";

            for (int i = 0; i < department.Length; i++) {
                string singleDepartment = department[i];
                departmentSelectCombobox.Items.Add(singleDepartment);
            }
        }
        void SetCenterComboBoxValues()
        {
            string[] center = new string[5];
            center[0] = "Malabe";
            center[1] = "Kollupity";
            center[2] = "Kandy";
            center[3] = "Matara";
            center[4] = "Jaffna";

            for (int i = 0; i < center.Length; i++) {
                string singleCenter = center[i];
                selectCenterCombobox.Items.Add(singleCenter);
            }
        }

        private void selectLevelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            int selectedIndex = selectLevelComboBox.SelectedIndex;
            rankInput.Text = (selectedIndex+1).ToString()+"." + employeeIDInput.Text;
        }
    }
}
