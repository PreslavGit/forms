using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjectWFA.Subject
{
    public class Subject
    {
        private DBManipulator db;
        public Subject(DBManipulator manipulator)
        {
            this.db = manipulator;
        }

        public void Save(string name)
        {
            SqlConnection connection = this.db.GetConnection();

            try
            {
                connection.Open();
                SqlCommand command = this.db.GetCommand();
                command.CommandText = "INSERT INTO Subject (Name) VALUES(@Name)";

                SqlParameter param = new SqlParameter("@Name", SqlDbType.VarChar);
                param.Value = name;
                command.Parameters.Add(param);

                command.ExecuteNonQuery();

                MessageBox.Show("Subject '" + name + "' added");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        public void Update(int id, string name)
        {
            SqlConnection connection = this.db.GetConnection();
            try
            {
                connection.Open();
                SqlCommand command = this.db.GetCommand();

                command.CommandText = "UPDATE Subject SET Name = @Name WHERE SubjectId = @OriginalId";

                SqlParameter param = new SqlParameter("@Name", SqlDbType.VarChar);
                param.Value = name;
                command.Parameters.Add(param);

                param = new SqlParameter("@OriginalId", SqlDbType.Int);
                param.Value = id;
                command.Parameters.Add(param);

                command.ExecuteNonQuery();

                MessageBox.Show("Subject name updated");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable Load()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("name");
            SqlConnection connection = this.db.GetConnection();
            try
            {
                connection.Open();
                SqlCommand command = this.db.GetCommand();
                command.CommandText = "SELECT SubjectId, Name FROM Subject ORDER BY Name ASC";
                SqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["SubjectId"]);
                        string name = Convert.ToString(reader["Name"]);
                        DataRow row = dt.NewRow();
                        row[0] = id;
                        row[1] = name;
                        dt.Rows.Add(row);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }
    }
}
