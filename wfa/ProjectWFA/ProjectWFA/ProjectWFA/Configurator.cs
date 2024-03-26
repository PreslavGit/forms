using ProjectWFA.Specialty;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjectWFA
{
    public class Configurator
    {
        public DBManipulator manipulator;
        public Specialty.Specialty Specialty;
        public Student.Student Student;
        public Subject.Subject Subject;
        public Grade.Grade Grade;
        public Configurator()
        {
            this.manipulator = new DBManipulator();
            this.Specialty = new Specialty.Specialty(this.manipulator);
            this.Student = new Student.Student(this.manipulator);
            this.Subject = new Subject.Subject(this.manipulator);
            this.Grade = new Grade.Grade(this.manipulator);
        }
    }
}
