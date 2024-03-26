using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAAS
{
    public class Grade
    {

        private int fNumber;
        private int subjectId;
        private int grade;
        private string subjectName;
        private string studentName;
        public int FNumber { get => fNumber; set => fNumber = value; }
        public int SubjectId { get => subjectId; set => subjectId = value; }
        public int FinalGrade { get => grade; set => grade = value; }
        public string SubjectName { get => subjectName; set => subjectName = value; }
        public string StudentName { get => studentName; set => studentName = value; }
    }
}