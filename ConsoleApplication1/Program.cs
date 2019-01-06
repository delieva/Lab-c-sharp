using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deliieva Oleksandra IP-72 7");

            Console.WriteLine();
            Student student = new Student("Oleksandra", "Deliieva", new DateTime(1999, 12, 21), Student.Education.Bachelor, "IP-72", "IP-7208");
            Console.WriteLine(student.ToString());
            student.AddExams(new Examination[]
            {
                new Examination(1, "Math", "Bodnarchuk C.V.", 100, "Def", new DateTime(2018, 01, 10)),
                new Examination(2, "DS", "Galkin P.P.",  100, "Def", new DateTime(2018, 06, 26)),
                new Examination(3, "OOP", "Muha I.P.", 100, "Def", new DateTime(2019, 01, 09)),
                new Examination(4, "DataBases", "Olyinyk T.T.", 100, "Def", new DateTime(2019, 06, 26)),
            });
            Console.WriteLine(student.ToString());
            student.PrintFullInfo();

            Person p1 = new Person("Ivan", "Ivan", new DateTime(1999, 11, 18));
            Person p2 = new Person("Ivan", "Ivan", new DateTime(1999, 11, 18));
            Person p3 = new Person("Denys", "Smirnov", new DateTime(1998, 10, 12));
            Console.WriteLine("Ivan Ivan 18.11.1999 == Ivan Ivan 18.11.1999 : " + (p1 == p2));
            Console.WriteLine("Ivan Ivan 18.11.1999 == Denys Smirnov 12.10.1998 : " + (p1 == p3));
            Console.WriteLine("Ivan Ivan 18.11.1999 != Ivan Ivan 18.11.1999 : " + (p1 != p2));
            Console.WriteLine("Ivan Ivan 18.11.1999 != Denys Smirnov 12.10.1998 : " + (p1 != p3));
            Console.WriteLine();

            Examination exam = new Examination();
            exam.Mark = 66;
            Console.WriteLine($"Mark {exam.Mark}");
            Console.WriteLine("In national scale: {0}", exam.NationalScale());
            Console.WriteLine("In ECTS scale: {0}", exam.EctsScale());
            Console.WriteLine();

            Console.WriteLine($"Exams with mark more than {exam.Mark}");
             foreach (Examination exm in student.GetExaminations(exam.Mark))
             {
                 Console.WriteLine(exm);
             }
            Console.WriteLine();

            Console.WriteLine("Exams sorted by semester: ");
            student.GetExams();

            Console.ReadKey();
            Console.Write("Press any key to continue...");
            
        }
    }
}