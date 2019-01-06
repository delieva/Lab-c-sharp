using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        protected DateTime _birthDate;
        public int BirthDate
        {
            get
            {
                return _birthDate.Year;
            }
            set
            {
                if (value <= DateTime.Now.Year && value > 1900)
                {
                    int day = _birthDate.Day;
                    int month = _birthDate.Month;
                    _birthDate = new DateTime(value, month, day);
                }
            }
        }
        public virtual void PrintFullInfo()
        {
            Console.WriteLine("Name: {0}\n" +
                              "Surname: {1}\n" +
                              "BirthDate: {2}", Name, Surname, _birthDate.ToShortDateString());
        }
        public Person()
        {
            Name = "Robert";
            Surname = "Smith";
            _birthDate = new DateTime(1999, 08, 22);
        }
        public Person(string name, string surname, DateTime birthDate)
        {
            Name = name;
            Surname = surname;
            _birthDate = birthDate;
        }
        public override bool Equals(object obj)
        {
            Person p = obj as Person;
            if (!(p is null))
            {
                if (this.Name == p.Name &&
                    this.Surname == p.Surname &&
                    this._birthDate == p._birthDate)
                {
                    return true;
                }
                else return false;
            }
            return false;
        }
        public static bool operator !=(Person p1, Person p2)
        {
            return !p1.Equals(p2);
        }
        public static bool operator ==(Person p1, Person p2)
        {
            return p1.Equals(p2);
        }
    }
}