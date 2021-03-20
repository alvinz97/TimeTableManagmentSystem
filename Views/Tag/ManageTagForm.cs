using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagmentSystem.Controllers.Tag;

namespace TimeTableManagmentSystem.Views.Tag
{
    public partial class ManageTagForm : Form
    {
        public ManageTagForm()
        {
            InitializeComponent();
        }
        public void Display()
        {
            string query = "SELECT id, Name, Code, RelatedTag FROM tag";
            TagController.Index(query, tagDataGridView);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Are you sure? You want to delete this record?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    TagController.Delete(tagDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void ManageTagForm_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void tagSearchInput_TextChanged(object sender, EventArgs e)
        {
            string query =
                "SELECT id, Name, Code, RelatedTag " +
                "FROM tag " +
                "WHERE Name " +
                "LIKE '%" + tagSearchInput.Text + "%' " +
                "OR Code " +
                "LIKE '%" + tagSearchInput.Text + "%' " +
                "OR RelatedTag " +
                "LIKE '%" + tagSearchInput.Text + "%' ";
            TagController.Index(query, tagDataGridView);
        }
    }
}
