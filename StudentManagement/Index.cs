using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentManagement
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        public DataTable getStudents()
        {
            DataTable studentTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(ConnectionString.DB_CONNECTION_STRING))
            {
                connection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT TEN, MASV, NAM, MAKH FROM SVIEN", connection);
                DataSet data = new DataSet();
                sqlDataAdapter.Fill(data);

                studentTable = data.Tables[0];

                connection.Close();
            }
            return studentTable;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = getStudents();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // dataGridView1.DataSource = getStudents();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd();
            formAdd.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormAdd formAdd = new FormAdd();
            formAdd.setStudentId( this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            formAdd.setStudentName( this.dataGridView1.CurrentRow.Cells[1].Value.ToString());
            formAdd.setStudentYear((int) this.dataGridView1.CurrentRow.Cells[2].Value);
            formAdd.setStudentMajor( this.dataGridView1.CurrentRow.Cells[3].Value.ToString());
            //cff.txtStuName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //cff.dtpDayofBirth.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //cff.CoBMajoy.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();


            formAdd.ShowDialog();
            //ConfirmForm cff = new ConfirmForm();
            //cff.txtStuID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //cff.txtStuName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //cff.dtpDayofBirth.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //cff.CoBMajoy.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            //cff.ShowDialog();
        }
    }
}
