using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Models
{
    class Student
    {
        private static int _id;


        public int ID { get { return _id; } private set { _id = value; } }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Point { get; set; }


        private Student()
        {
            _id++;
            ID = _id;
        }
        public Student(string name, string surname, int point):this()
        {
            Name = name;
            Surname = surname;
            Point = point;
        }

        public bool PointChecker( int point)
        {
            bool pointTrueOrFalse = false;


            if (Point <= 100 && Point >= 0)
            {
                pointTrueOrFalse = true;
                Console.WriteLine("\n It's Okay");
            }
            else
            {
                Console.WriteLine("\n Wrong choice! Please try again.");
            }
            if (true)
            {

            }
            return pointTrueOrFalse;
        }

        public string Fullname()
        {
            return Name + " " + Surname;
        }
        public string ShowInfo()
        {
            return $"\n Student ID: {ID} \n Student Fullname: {Fullname()} \n Student's Point: {Point}";
        }

        public void CreateStudent()
        {
            Console.WriteLine("\n Enter Student name: ");
            Name = Console.ReadLine();
            Console.WriteLine("\n Enter Student surname: ");
            Surname = Console.ReadLine();
            
        TryAgain:
            Console.WriteLine("\n Enter Student's Point: ");
            Point = Convert.ToInt32(Console.ReadLine());
            if (PointChecker(Point))
            {
                Console.WriteLine("It's Okay");
            }
            else
            {
                goto TryAgain;
            }
        }
    }
}
