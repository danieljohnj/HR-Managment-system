using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Management_System
{
    public partial class Job_title : Form
    {
        public Job_title()
        {
            InitializeComponent();
        }

        private void job_titlesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.job_titlesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.emp_Data);

        }

        private void Job_title_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emp_Data.Job_titles' table. You can move, or remove it, as needed.
            this.job_titlesTableAdapter.Fill(this.emp_Data.Job_titles);

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            this.job_titlesBindingSource.AddNew();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.job_titlesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.emp_Data);

            MessageBox.Show("Record Saved");
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult iDelete;

            iDelete = MessageBox.Show("Please confirm if you want to delete", "Job Title",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iDelete == DialogResult.Yes)
                MessageBox.Show("Record Deleted");

            this.Validate();
            this.job_titlesBindingSource.RemoveCurrent();
            this.tableAdapterManager.UpdateAll(this.emp_Data);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            emp_idTextBox.Clear();
           
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult iClose;

            iClose = MessageBox.Show("Please confirm if you want to close", "Job Title",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iClose == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            this.job_titlesBindingSource.MoveNext();
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            this.job_titlesBindingSource.MovePrevious();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Please confirm if you want to exit", "Job Title",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.job_titlesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.emp_Data);
            MessageBox.Show("Record Updated");
        }
    }
}
