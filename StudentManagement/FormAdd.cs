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

namespace StudentManagement
{
    
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
            var years = new BindingList<KeyValuePair<int, string>>();

            years.Add(new KeyValuePair<int, string>(1, "First year"));
            years.Add(new KeyValuePair<int, string>(2, "Second year"));
            years.Add(new KeyValuePair<int, string>(3, "Third year"));
            years.Add(new KeyValuePair<int, string>(4, "Last year"));

            cboYear.DataSource = years;
            cboYear.ValueMember = "Key";
            cboYear.DisplayMember = "Value";
            cboYear.SelectedIndex = 0;

            var majors  = new BindingList<KeyValuePair<int, string>>();

            years.Add(new KeyValuePair<int, string>(1, "First year"));
            years.Add(new KeyValuePair<int, string>(2, "Second year"));
            years.Add(new KeyValuePair<int, string>(3, "Third year"));
            years.Add(new KeyValuePair<int, string>(4, "Last year"));

            cboMajor.DataSource = years;
            cboMajor.ValueMember = "Key";
            cboMajor.DisplayMember = "Value";
            cboMajor.SelectedIndex = 0;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void txtStudentID_Enter(object sender, EventArgs e)
        {
            if (txtStudentID.Text == "Enter ID")
            {
                txtStudentID.Text = "";

                txtStudentID.ForeColor = Color.Black;

            }
        }

        private void txtStudentID_Leave(object sender, EventArgs e)
        {

            if (txtStudentID.Text == "")
            {
                txtStudentID.Text = "Enter ID";

                txtStudentID.ForeColor = Color.DarkGray;

            }
        }

        private void txtStudentName_Enter(object sender, EventArgs e)
        {
            if (txtStudentName.Text == "Enter Name")
            {
                txtStudentName.Text = "";

                txtStudentName.ForeColor = Color.Black;

            }
        }

        private void txtStudentName_Leave(object sender, EventArgs e)
        {
            if (txtStudentName.Text == "")
            {
                txtStudentName.Text = "Enter Name";

                txtStudentName.ForeColor = Color.DarkGray;

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConnectionString.DB_CONNECTION_STRING);


            SqlCommand cmd = new SqlCommand();

            connection.Open();

            cmd.CommandText = "insert SVIEN values('chhong', 123, 4, 'abc')";
            cmd.ExecuteNonQuery();
            cmd.Clone();
               
                
        }

        public void setStudentId(string id)
        {
            txtStudentID.Text = id;
        }
        public void setStudentName(string name)
        {
            txtStudentName.Text = name;
        }

        public void setStudentYear(int year)
        {
            cboYear.SelectedValue = year;
        }
        public void setStudentMajor(string majorId)
        {
            cboYear.SelectedValue = majorId;
        }
    }
}
