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
    public partial class AddTagForm : Form
    {
        public AddTagForm()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            tagNameInput.Text = tagCodeInput.Text = relatedTagInput.Text = string.Empty;
        }

        private void tagClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void tagSaveBtn_Click(object sender, EventArgs e)
        {
            if (tagNameInput.Text == "") {
                MessageBox.Show("Tag Name is required.", "ERROR");
                return;
            }

            if (tagCodeInput.Text == "") {
                MessageBox.Show("Tag Code is required.", "ERROR");
                return;
            }

            if (relatedTagInput.Text == "") {
                MessageBox.Show("Related Tag is required.", "ERROR");
                return;
            }

            if (tagSaveBtn.Text == "Save") {
                Models.Tag tag = new Models.Tag(tagNameInput.Text.Trim(), tagCodeInput.Text.Trim(), relatedTagInput.Text.Trim());
                TagController.Store(tag);
                Clear();
            }
        }
    }
}
