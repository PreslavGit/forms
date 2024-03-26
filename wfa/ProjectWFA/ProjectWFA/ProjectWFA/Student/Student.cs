using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWFA.Student
{
    public class Student
    {
        public DBManipulator db;
        public Student(DBManipulator manipulator)
        {
            this.db = manipulator;
        }
        public void Save(int fNumber, int specialtyId, string fName, string mName, string lName, string address, string phone, string eMail)
        {
            SqlConnection connection = this.db.GetConnection();

            try
            {
                connection.Open();
                SqlCommand command = this.db.GetCommand();

                command.CommandText = "INSERT INTO Student (FNumber, SpecialtyId, FName, MName, LName, Address, Phone, EMail) VALUES(@FNumber, @SpecialtyId, @FName, @MName, @LName, @Address, @Phone, @EMail)";

                SqlParameter param = new SqlParameter("@FNumber", SqlDbType.Int);
                param.Value = fNumber;
                command.Parameters.Add(param);

                param = new SqlParameter("@SpecialtyId", SqlDbType.Int);
                param.Value = specialtyId;
                command.Parameters.Add(param);

                param = new SqlParameter("@FName", SqlDbType.VarChar);
                param.Value = fName;
                command.Parameters.Add(param);

                param = new SqlParameter("@MName", SqlDbType.VarChar);
                param.Value = mName;
                command.Parameters.Add(param);

                param = new SqlParameter("@LName", SqlDbType.VarChar);
                param.Value = lName;
                command.Parameters.Add(param);

                param = new SqlParameter("@Address", SqlDbType.VarChar);
                param.Value = address;
                command.Parameters.Add(param);

                param = new SqlParameter("@Phone", SqlDbType.VarChar);
                param.Value = phone;
                command.Parameters.Add(param);

                param = new SqlParameter("@EMail", SqlDbType.VarChar);
                param.Value = eMail;
                command.Parameters.Add(param);

                command.ExecuteNonQuery();

                MessageBox.Show("Student added");
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
        public void Update(int fn, int specId, string firstName, string middleName, string lastName, string phone, string address, string email)
        {
            SqlConnection connection = this.db.GetConnection();
            try
            {
                connection.Open();
                SqlCommand command = this.db.GetCommand();

                command.CommandText = "UPDATE Student SET FName = @FirstName, MName = @MiddleName, LName = @LastName, phone = @Phone, address = @Address, email = @Email, specialtyid = @SpecialtyId WHERE FNumber = @fn";

                var param = new SqlParameter("@FirstName", SqlDbType.VarChar);
                param.Value = firstName;
                command.Parameters.Add(param);

                param = new SqlParameter("@MiddleName", SqlDbType.VarChar);
                param.Value = middleName;
                command.Parameters.Add(param);

                param = new SqlParameter("@LastName", SqlDbType.VarChar);
                param.Value = lastName;
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

                param = new SqlParameter("@fn", SqlDbType.Int);
                param.Value = fn;
                command.Parameters.Add(param);

                param = new SqlParameter("@SpecialtyId", SqlDbType.Int);
                param.Value = specId;
                command.Parameters.Add(param);

                command.ExecuteNonQuery();

                MessageBox.Show("Student updated");
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
            dt.Columns.Add("fn");
            dt.Columns.Add("specialtyName");
            dt.Columns.Add("firstName");
            dt.Columns.Add("middleName");
            dt.Columns.Add("lastName");
            dt.Columns.Add("phone");
            dt.Columns.Add("address");
            dt.Columns.Add("email");
            SqlConnection connection = this.db.GetConnection();
            try
            {
                connection.Open();
                SqlCommand command = this.db.GetCommand();
                command.CommandText = "SELECT s.FNumber, s.FName, s.LName, s.MName, s.Phone, s.Address, s.Email, sp.Name FROM Student s LEFT JOIN Specialty sp ON s.SpecialtyId = sp.SpecialtyId";
                SqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        int fNumber = Convert.ToInt32(reader["FNumber"]);
                        string specialtyName = Convert.ToString(reader["Name"]);
                        string fName = Convert.ToString(reader["FName"]);
                        string mName = Convert.ToString(reader["MName"]);
                        string lName = Convert.ToString(reader["LName"]);
                        string phone = Convert.ToString(reader["Phone"]);
                        string address = Convert.ToString(reader["Address"]);
                        string email = Convert.ToString(reader["Email"]);
                        DataRow row = dt.NewRow();
                        row[0] = fNumber;
                        row[1] = specialtyName;
                        row[2] = fName;
                        row[3] = mName;
                        row[4] = lName;
                        row[5] = phone;
                        row[6] = address;
                        row[7] = email;
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
