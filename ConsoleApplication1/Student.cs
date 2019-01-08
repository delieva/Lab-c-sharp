using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Student : Person
    {
        public enum Education { Master, Bachelor, SecondEducation, PhD };
        public Education QualifictionLevel { get; set; }
        public string Group { get; set; }
        public string MarkBook { get; set; }
        public List<Examination> DoneExams { get; set; }

        public double AverageValue
        {
            get
            {
                double res = 0, num = DoneExams.Count();
                foreach (Examination i in DoneExams)
                {
                    res += i.GetMark();
                }
                return res / num;
            }
        }
        public void AddExams(Examination[] examList)
        {
            foreach (Examination e in examList)
            {
                if (e.Mark > 60)
                {
                    DoneExams.Add(e);
                }
            }
        }
        public override string ToString()
        {
            //Console.WriteLine($"{Name}, {Surname}, {Group}");
            return $"{Name}, {Surname}, {Group}";
        }
        public override void PrintFullInfo()
        {
            Console.WriteLine("Name: {0}\n" +
            "Surname: {1}\n" +
            "Birth Date: {2}\n" +
            "Qualifiction level: {3}\n" +
            "Group: {4}\n" +
            "Markbook: {5}"
            , Name, Surname, _birthDate.ToShortDateString(), QualifictionLevel, Group, MarkBook);
            for (int i = 0; i < DoneExams.Count(); i++) {
                Console.WriteLine(DoneExams[i]);
            }
            Console.WriteLine();
        }
        
        public void GetExams()
        {
            DoneExams.Sort();
            foreach (var c in DoneExams)
            {
                Console.WriteLine(c);
            }
        }
        public IEnumerable GetExaminations(int mark)
        {
            foreach (var exam in DoneExams)
                if (exam.Mark >= mark)
                    yield return exam;
        }
        public Student(string name, string surname, DateTime birthDate, Education qualificationLevel, string group, string markbook)
        {
            Name = name;
            Surname = surname;
            _birthDate = birthDate;
            QualifictionLevel = qualificationLevel;
            Group = group;
            MarkBook = markbook;
            DoneExams = new List<Examination>();
        }
        public Student()
        {
            Name = "Den";
            Surname = "Wilson";
            _birthDate = new DateTime(1998, 11, 13);
            QualifictionLevel = Education.Bachelor;
            Group = "it-71";
            MarkBook = "it-7104";
            DoneExams = new List<Examination>();
        }
    }
}