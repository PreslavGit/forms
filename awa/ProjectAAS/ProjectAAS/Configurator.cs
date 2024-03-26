using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
namespace ProjectAAS
{
    public class Configurator
    {
        private DBManipulator manipulator;
        public Configurator()
        {
            this.manipulator = new DBManipulator();
        }
        public bool CheckLogin(string username, string password)
        {
            bool result = false;
            SqlConnection connection = this.manipulator.GetConnection();
            try
            {
                connection.Open();
                SqlCommand command = this.manipulator.GetCommand();
                command.CommandText = "SELECT id FROM Login WHERE username = @username AND password = @password";
                SqlParameter param = null;
                param = new SqlParameter("@username", SqlDbType.VarChar);
                param.Value = username;
                command.Parameters.Add(param);
                param = new SqlParameter("@password", SqlDbType.VarChar);
                param.Value = password;
                command.Parameters.Add(param);
                SqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    if (reader.Read())
                    {
                        result = true;
                    }
                }
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        public DataTable LoadSpecialties()
        {
            DataTable result = new DataTable();
            result.Columns.Add("id");
            result.Columns.Add("name");
            SqlConnection connection = this.manipulator.GetConnection();
            connection.Open();
            SqlCommand command = this.manipulator.GetCommand();
            command.CommandText = "SELECT SpecialtyId, Name FROM Specialty ORDER BY Name ASC";
            SqlDataReader reader = command.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["SpecialtyId"]);
                    string name = Convert.ToString(reader["Name"]);
                    DataRow row = result.NewRow();
                    row[0] = id;
                    row[1] = name;
                    result.Rows.Add(row);
                }
            }
            connection.Close();
            return result;
        }
        public Specialty LoadSpecialtyById(int id)
        {
            Specialty result = null;
            SqlConnection connection = this.manipulator.GetConnection();
            connection.Open();
            SqlCommand command = this.manipulator.GetCommand();
            command.CommandText = "SELECT * FROM Specialty WHERE SpecialtyId = @SpecialtyId";
            SqlParameter param = null;
            param = new SqlParameter("@SpecialtyId", SqlDbType.Int);
            param.Value = id;
            command.Parameters.Add(param);
            SqlDataReader reader = command.ExecuteReader();
            using (reader)
            {
                if (reader.Read())
                {
                    result = new Specialty();

                    string name = Convert.ToString(reader["Name"]);
                    result.Id = id;
                    result.Name = name;
                }
            }
            connection.Close();
            return result;
        }
        public void UpdateSpecialty(int id, string name)
        {
            SqlConnection connection = this.manipulator.GetConnection();
            connection.Open();
            SqlCommand command = this.manipulator.GetCommand();
            command.CommandText = "UPDATE Specialty SET Name = @Name WHERE SpecialtyId = @SpecialtyId";
            SqlParameter param = null;
            param = new SqlParameter("@SpecialtyId", SqlDbType.Int);
            param.Value = id;
            command.Parameters.Add(param);
            param = new SqlParameter("@Name", SqlDbType.VarChar);
            param.Value = name;
            command.Parameters.Add(param);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable LoadSubjects()
        {
            DataTable result = new DataTable();
            result.Columns.Add("id");
            result.Columns.Add("name");
            SqlConnection connection = this.manipulator.GetConnection();
            connection.Open();
            SqlCommand command = this.manipulator.GetCommand();
            command.CommandText = "SELECT SubjectId, Name FROM Subject ORDER BY Name ASC";
            SqlDataReader reader = command.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["SubjectId"]);
                    string name = Convert.ToString(reader["Name"]);
                    DataRow row = result.NewRow();
                    row[0] = id;
                    row[1] = name;
                    result.Rows.Add(row);
                }
            }
            connection.Close();
            return result;
        }
        public Specialty LoadSubjectById(int id)
        {
            Specialty result = null;
            SqlConnection connection = this.manipulator.GetConnection();
            connection.Open();
            SqlCommand command = this.manipulator.GetCommand();
            command.CommandText = "SELECT * FROM Subject WHERE SubjectId = @SubjectId";
            SqlParameter param = null;
            param = new SqlParameter("@SubjectId", SqlDbType.Int);
            param.Value = id;
            command.Parameters.Add(param);
            SqlDataReader reader = command.ExecuteReader();
            using (reader)
            {
                if (reader.Read())
                {
                    result = new Specialty();

                    string name = Convert.ToString(reader["Name"]);
                    result.Id = id;
                    result.Name = name;
                }
            }
            connection.Close();
            return result;
        }
        public void UpdateSubject(int id, string name)
        {
            SqlConnection connection = this.manipulator.GetConnection();
            connection.Open();
            SqlCommand command = this.manipulator.GetCommand();
            command.CommandText = "UPDATE Subject SET Name = @Name WHERE SubjectId = @SubjectId";
            SqlParameter param = null;
            param = new SqlParameter("@SubjectId", SqlDbType.Int);
            param.Value = id;
            command.Parameters.Add(param);
            param = new SqlParameter("@Name", SqlDbType.VarChar);
            param.Value = name;
            command.Parameters.Add(param);
            command.ExecuteNonQuery();
            connection.Close();
        }


        public DataTable LoadGrades()
        {
            DataTable result = new DataTable();
            result.Columns.Add("fnumber");
            result.Columns.Add("subjectid");
            result.Columns.Add("grade");
            result.Columns.Add("studentname");
            result.Columns.Add("subjectname");
            SqlConnection connection = this.manipulator.GetConnection();
            connection.Open();
            SqlCommand command = this.manipulator.GetCommand();
            command.CommandText = "SELECT ss.FNumber, ss.SubjectId, ss.FinalGrade, s.FName, sj.Name FROM StudentSubject ss LEFT JOIN Student s ON ss.FNumber = s.FNumber LEFT JOIN Subject sj ON sj.SubjectId = ss.SubjectId";
            SqlDataReader reader = command.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    int subjectId = Convert.ToInt32(reader["SubjectId"]);
                    int fNumber = Convert.ToInt32(reader["FNumber"]);
                    int grade = Convert.ToInt32(reader["FinalGrade"]);
                    string studentName = Convert.ToString(reader["FName"]);
                    string subjectName = Convert.ToString(reader["Name"]);
                    DataRow row = result.NewRow();
                    row[0] = fNumber;
                    row[1] = subjectId;
                    row[2] = grade;
                    row[3] = studentName;
                    row[4] = subjectName;
                    result.Rows.Add(row);
                }
            }
            connection.Close();
            return result;
        }
        public Grade LoadGradeById(int sId, int fNumber)
        {
            Grade grade = new Grade();
            SqlConnection connection = this.manipulator.GetConnection();
            connection.Open();
            SqlCommand command = this.manipulator.GetCommand();
            command.CommandText = "SELECT ss.FNumber, ss.SubjectId, ss.FinalGrade, s.FName, sj.Name FROM StudentSubject ss LEFT JOIN Student s ON ss.FNumber = s.FNumber LEFT JOIN Subject sj ON sj.SubjectId = ss.SubjectId WHERE ss.SubjectId = @sId AND ss.FNumber = @fNumber";
            
            SqlParameter param = new SqlParameter("@sId", SqlDbType.Int);
            param.Value = sId;
            command.Parameters.Add(param);

            param = new SqlParameter("@fNumber", SqlDbType.Int);
            param.Value = fNumber;
            command.Parameters.Add(param);

            SqlDataReader reader = command.ExecuteReader();
            using (reader)
            {
                if (reader.Read())
                {
                    grade.FNumber = Convert.ToInt32(reader["FNumber"]);
                    grade.StudentName = Convert.ToString(reader["FName"]);
                    grade.SubjectName = Convert.ToString(reader["Name"]);
                    grade.FinalGrade = Convert.ToInt32(reader["FinalGrade"]);
                    grade.SubjectId = Convert.ToInt32(reader["SubjectId"]);
                }
            }
            connection.Close();
            return grade;
        }
        public void UpdateGrade(int sId, int fNumber, int grade)
        {
            SqlConnection connection = this.manipulator.GetConnection();
            connection.Open();
            SqlCommand command = this.manipulator.GetCommand();
            command.CommandText = "UPDATE StudentSubject SET FinalGrade = @FinalGrade WHERE SubjectId = @sId AND FNumber = @fNumber";
            
            SqlParameter param = new SqlParameter("@sId", SqlDbType.Int);
            param.Value = sId;
            command.Parameters.Add(param);
            
            param = new SqlParameter("@fNumber", SqlDbType.VarChar);
            param.Value = fNumber;
            command.Parameters.Add(param);
            
            param = new SqlParameter("@FinalGrade", SqlDbType.VarChar);
            param.Value = grade;
            command.Parameters.Add(param);

            command.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable LoadStudents()
        {
            DataTable result = new DataTable();
            result.Columns.Add("fnumber");
            result.Columns.Add("specialtyId");
            result.Columns.Add("fname");
            result.Columns.Add("mname");
            result.Columns.Add("lname");
            result.Columns.Add("address");
            result.Columns.Add("phone");
            result.Columns.Add("email");
            result.Columns.Add("specialtyName");
            SqlConnection connection = this.manipulator.GetConnection();
            connection.Open();
            SqlCommand command = this.manipulator.GetCommand();
            command.CommandText = "SELECT s.FNumber, s.SpecialtyId, s.FName, s.MName, s.LName, s.Address, s.Phone, s.Email, sp.Name FROM Student s LEFT JOIN Specialty sp ON sp.SpecialtyId = s.SpecialtyId";
            SqlDataReader reader = command.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    int specialtyId = Convert.ToInt32(reader["SpecialtyId"]);
                    int fNumber = Convert.ToInt32(reader["FNumber"]);
                    string fname = Convert.ToString(reader["FName"]);
                    string mname = Convert.ToString(reader["MName"]);
                    string lname = Convert.ToString(reader["LName"]);
                    string address = Convert.ToString(reader["Address"]);
                    string phone = Convert.ToString(reader["Phone"]);
                    string email = Convert.ToString(reader["Email"]);
                    string specialtyName = Convert.ToString(reader["Name"]);
                    DataRow row = result.NewRow();
                    row[0] = fNumber;
                    row[1] = specialtyId;
                    row[2] = fname;
                    row[3] = mname;
                    row[4] = lname;
                    row[5] = address;
                    row[6] = phone;
                    row[7] = email;
                    row[8] = specialtyName;
                    result.Rows.Add(row);
                }
            }
            connection.Close();
            return result;
        }
        public Student LoadStudentById(int fNumber)
        {
            Student student = new Student();
            SqlConnection connection = this.manipulator.GetConnection();
            connection.Open();
            SqlCommand command = this.manipulator.GetCommand();
            command.CommandText = "SELECT s.FNumber, s.SpecialtyId, s.FName, s.MName, s.LName, s.Address, s.Phone, s.Email, sp.Name FROM Student s LEFT JOIN Specialty sp ON sp.SpecialtyId = s.SpecialtyId WHERE s.FNumber = @FNumber";

            SqlParameter param = new SqlParameter("@fNumber", SqlDbType.Int);
            param.Value = fNumber;
            command.Parameters.Add(param);

            SqlDataReader reader = command.ExecuteReader();
            using (reader)
            {
                if (reader.Read())
                {
                    student.SpecialtyId = Convert.ToInt32(reader["SpecialtyId"]);
                    student.FNumber = Convert.ToInt32(reader["FNumber"]);
                    student.FName = Convert.ToString(reader["FName"]);
                    student.MName = Convert.ToString(reader["MName"]);
                    student.LName = Convert.ToString(reader["LName"]);
                    student.Address = Convert.ToString(reader["Address"]);
                    student.Phone = Convert.ToInt32(reader["Phone"]);
                    student.Email = Convert.ToString(reader["Email"]);
                    student.SpecialtyName = Convert.ToString(reader["Name"]);
                }
            }
            connection.Close();
            return student;
        }
        public void UpdateStudent(int fnumber, string fname, string mname, string lname, string address, int phone, string email)
        {
            SqlConnection connection = this.manipulator.GetConnection();
            connection.Open();
            SqlCommand command = this.manipulator.GetCommand();
            command.CommandText = "UPDATE Student SET FName = @FName, MName = @MName, LName = @LName, Phone = @Phone, Address = @Address, Email = @Email WHERE FNumber = @FNumber";

            SqlParameter param = new SqlParameter("@FNumber", SqlDbType.VarChar);
            param.Value = fnumber;
            command.Parameters.Add(param);

            param = new SqlParameter("@FName", SqlDbType.VarChar);
            param.Value = fname;
            command.Parameters.Add(param);

            param = new SqlParameter("@MName", SqlDbType.VarChar);
            param.Value = mname;
            command.Parameters.Add(param);

            param = new SqlParameter("@LName", SqlDbType.VarChar);
            param.Value = lname;
            command.Parameters.Add(param);

            param = new SqlParameter("@Phone", SqlDbType.VarChar);
            param.Value = phone;
            command.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.VarChar);
            param.Value = address;
            command.Parameters.Add(param);

            param = new SqlParameter("@Email", SqlDbType.VarChar);
            param.Value = email;
            command.Parameters.Add(param);

            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}