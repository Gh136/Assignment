using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_oop3
{
    public class person
    {
        private int _id;
        private string _name;
        private string _email;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public virtual void getdetails()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Email: {Email}");
        }
    }

    public class student : person
    {
        public int gradeLevel { get; set; }
        override public void getdetails()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Email: {Email}, Grade Level: {gradeLevel}");
        }

    }
    public class teacher : person
    {
        public string subject { get; set; }
        override public void getdetails()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Email: {Email}, Subject: {subject}");
        }
    }
    public class admin : person
    {
        public string role { get; set; }
        override public void getdetails()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Email: {Email}, Role: {role}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            List<person> people = new List<person>
            {
                new student { Id = 1, Name = "Alice", Email = "ghada" + "@example.com", gradeLevel = 10 },
                new teacher { Id = 2, Name = "Bob", Email = "bob" + "@example.com", subject = "Math" },
                new admin { Id = 3, Name = "Charlie", Email = "charlie" + "@example.com", role = "Principal" }

               

            };
            foreach (var person in people)
            {
                person.getdetails();
            }
        }
    }
}