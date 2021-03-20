using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagmentSystem.Configurations;

namespace TimeTableManagmentSystem.Controllers.Tag
{
    class TagController
    {
        public static void Index(string query, DataGridView dataGridView)
        {
            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            connection.Close();
        }

        public static void Store(Models.Tag tag)
        {
            string query = "INSERT INTO tag " +
                "(Name, Code, RelatedTag) " +
                "VALUES " +
                "(@Name, @Code, @RelatedTag)";

            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@Name", tag.Name);
            command.Parameters.AddWithValue("@Code", tag.Code);
            command.Parameters.AddWithValue("@RelatedTag", tag.RelatedTag);
            command.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
            command.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);

            try {
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (SqlException e) {
                MessageBox.Show("Error Occur. \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                connection.Close();
            }
        }

        public static void Update(Models.Tag tag, string id)
        {
            string query = "UPDATE tag SET " +
                "Name = @Name, " +
                "Code = @Code, " +
                "RelatedTag = @RelatedTag, " +
                "UpdatedAt = @UpdatedAt " +
                "WHERE id = @ID";

            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@Name", tag.Name);
            command.Parameters.AddWithValue("@Code", tag.Code);
            command.Parameters.AddWithValue("@RelatedTag", tag.RelatedTag);
            command.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);

            try {
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (SqlException e) {
                MessageBox.Show("Error Occur. \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                connection.Close();
            }
        }

        public static void Delete(string id)
        {
            string query = "DELETE FROM tag WHERE id = @ID";
            SqlConnection connection = Connection.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;

            try {
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (SqlException e) {
                MessageBox.Show("Error Occur. \n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                connection.Close();
            }
        }
    }
}
