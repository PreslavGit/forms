using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWFA.Grade
{
    public class Grade
    {
        private DBManipulator db;
        public Grade(DBManipulator manipulator)
        {
            this.db = manipulator;
        }

        public void Save(int fNumber, int subjectId, int finalGrade)
        {
            SqlConnection connection = this.db.GetConnection();
            try
            {
                connection.Open();
                SqlCommand command = this.db.GetCommand();

                command.CommandText = "INSERT INTO StudentSubject (FNumber, SubjectId, FinalGrade) VALUES(@FNumber, @SubjectId, @FinalGrade)";

                SqlParameter param = new SqlParameter("@FNumber", SqlDbType.Int);
                param.Value = fNumber;
                command.Parameters.Add(param);

                param = new SqlParameter("@SubjectId", SqlDbType.Int);
                param.Value = subjectId;
                command.Parameters.Add(param);

                param = new SqlParameter("@FinalGrade", SqlDbType.Int);
                param.Value = finalGrade;
                command.Parameters.Add(param);

                command.ExecuteNonQuery();

                MessageBox.Show("Grade added");
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
            dt.Columns.Add("studentname");
            dt.Columns.Add("subjectname");
            dt.Columns.Add("grade");
            dt.Columns.Add("fnumber");
            dt.Columns.Add("subjectid");
            SqlConnection connection = this.db.GetConnection();
            try
            {
                connection.Open();
                SqlCommand command = this.db.GetCommand();
                command.CommandText = "SELECT ss.FNumber, ss.SubjectId, ss.FinalGrade, s.FName, sj.Name FROM StudentSubject ss LEFT JOIN Student s ON s.FNumber = ss.FNumber LEFT JOIN Subject sj ON sj.SubjectId = ss.SubjectId";
                SqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        int fn = Convert.ToInt32(reader["FNumber"]);
                        int subjId = Convert.ToInt32(reader["SubjectId"]);
                        string grade = Convert.ToString(reader["FinalGrade"]);
                        string studentName = Convert.ToString(reader["FName"]);
                        string subjectName = Convert.ToString(reader["Name"]);
                        DataRow row = dt.NewRow();
                        row[0] = studentName;
                        row[1] = subjectName;
                        row[2] = grade;
                        row[3] = fn;
                        row[4] = subjId;
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

        public void Update(int fn, int subjId, double grade)
        {
            SqlConnection connection = this.db.GetConnection();
            try
            {
                connection.Open();
                SqlCommand command = this.db.GetCommand();

                command.CommandText = "UPDATE StudentSubject SET FinalGrade = @Grade WHERE FNumber = @fn AND SubjectId = @subjId";

                SqlParameter param = new SqlParameter("@Grade", SqlDbType.VarChar);
                param.Value = grade;
                command.Parameters.Add(param);

                param = new SqlParameter("@fn", SqlDbType.Int);
                param.Value = fn;
                command.Parameters.Add(param);

                param = new SqlParameter("@subjId", SqlDbType.Int);
                param.Value = subjId;
                command.Parameters.Add(param);

                command.ExecuteNonQuery();

                MessageBox.Show("Grade updated");
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
    }
}
