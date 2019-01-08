
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Examination : IMarkName, IComparable
    {
        private int _semester;
        public int Semester
        {
            get { return _semester; }
            set
            {
                if (value > 0 && value < 13)
                    _semester = value;
            }
        }
        public string Subject { get; set; }
        public string LecturerName { get; set; }
        public int Mark { get; set; }
        public string ExamType { get; set; }
        public DateTime ExamDate { get; set; }
        public override string ToString()
        {
            return $"{Semester} semester: {Subject}, {LecturerName}, {Mark}.";
        }

        public string NationalScale()
        {
            if (Mark <= 100 && Mark >= 95)
            {
                return "Excelent";
            }
            else if (Mark <= 94 && Mark >= 85)
            {
                return "Very good";
            }

            else if (Mark <= 84 && Mark >= 75)
            {
                return "Good";
            }
            else if (Mark <= 74 && Mark >= 65)
            {
                return "Satisfactory";
            }
            else if (Mark <= 64 && Mark >= 60)
            {
                return "Satisfactory (satisfy minimum criteria)";
            }
            else if (Mark < 60 && Mark >= 35)
            {
                return "Unsatisfactory";
            }
            else 
            {
                return "Fail (additional work is required)";
            }
        }

        public string EctsScale()
        {
            if (Mark <= 100 && Mark >= 95)
            {
                return "A";
            }
            else if (Mark <= 94 && Mark >= 85) {
                return "B";
            }
            else if (Mark <= 84 && Mark >= 75)
            {
                return "C";
            }
            else if (Mark <= 74 && Mark >= 65)
            {
                return "D";
            }
            else if (Mark <= 64 && Mark >= 60)
            {
                return "E";
            }
            else if (Mark <= 59 && Mark >= 35)
            {
                return "Fx";
            }
            else
            {
                return "F";
            }
        }

        public double GetMark()
        {
            return Mark;
        }
        public int CompareTo(object obj)
        {
            Examination exam = obj as Examination;
            if (obj is null)
                throw new ApplicationException("Compare To method: obj is null");

            return this.Semester.CompareTo(exam.Semester);
        }

        public Examination()
        {
            Semester = 3;
            Subject = "OOP";
            LecturerName = "Muha I.P.";
            Mark = 94;
            ExamType = "Def";
            ExamDate = new DateTime(2019, 01, 09);
        }
        public Examination(int semester, string subject, string lecturerName, int mark, string examType, DateTime examTime)
        {
            Semester = semester;
            Subject = subject;
            LecturerName = lecturerName;
            Mark = mark;
            ExamType = examType;
            ExamDate = examTime;
        }
    }
}
