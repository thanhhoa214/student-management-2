using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    class SinhVienDAO
    {
        private static SqlConnection connection = new SqlConnection(ConnectionString.DB_CONNECTION_STRING);
        private SqlCommand cmd = new SqlCommand();

        public int InsertStudents(String name, int masv, int year, String makhoa)
        {
            int resultInsert = 0;
            try
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT SVIEN VALUES('" + name + "','" + masv + "','" + year + "','" + makhoa + "');";
                resultInsert = cmd.ExecuteNonQuery();
                cmd.Clone();
                connection.Close();
                resultInsert = 1;
            }
            catch(Exception ex)
            {
                if(ex.Message.Contains("PRIMARY KEY constraint"))
                {                   
                    resultInsert = -1;
                    connection.Close();
                } else
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            return resultInsert;


        }


        public int UpDateStudents(String name, int masv, int year, String makhoa)
        {
            connection.Open();
            cmd = connection.CreateCommand();
            cmd.CommandText = "UPDATE SVIEN SET TEN = '" + name + "',NAM = '" + year + "',MAKH = '" + makhoa + "'\n Where MASV = '" + masv + "'";
            int resultUpdate = cmd.ExecuteNonQuery();
            cmd.Clone();
            connection.Close();
            if (resultUpdate > 0)
                return 1;
            else return 0;

        }


        public int DeleteStudents(int masv)
        {
            connection.Open();
            cmd = connection.CreateCommand();
            cmd.CommandText = "DELETE FROM SVIEN WHERE MASV = '" + masv + "'";
            int resultDelete = cmd.ExecuteNonQuery();
            cmd.Clone();
            connection.Close();
            if (resultDelete > 0)
                return 1;
            else return 0;

        }
    }
}
