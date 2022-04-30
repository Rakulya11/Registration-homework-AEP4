using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Models
{
    class Group
    {
        private int _studentLimit;
        private List<Student> _students;

        public string GroupNo { get; set; }
        public int StudentLimit
        {
            get { return _studentLimit; }
            set
            {
                if (value >= 5 && value <= 18 )
                {
                    _studentLimit = value;
                } 
            } 
        }
        public List<Student> Students { get { return _students; } set { _students = value; } }


        private Group()
        {
            _students = new List<Student>();
        }
        public Group(string groupNo, int studentLimit) : this()
        {
            GroupNo = groupNo;
            StudentLimit = studentLimit;
        }


        public bool CheckGroupNo(string groupNo)
        {
            bool isUpper = false;
            bool isDigit = false;
            bool isAll = false;
            for (int i = 0; i < groupNo.Length; i++)
            {
                if (groupNo.Length >= 5)
                {
                    if (char.IsUpper(groupNo[0]) && char.IsUpper(groupNo[1]))
                    {
                        isUpper = true;
                    }
                    if (char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]) && char.IsDigit(groupNo[4]))
                    {
                        isDigit = true;
                    }
                }
                if (isUpper && isDigit)
                {
                    isAll = true;
                }
            }
            if (isAll)
            {
                Console.WriteLine("Correct Group number.");
            }
            else
            {
                Console.WriteLine("Incorrect Group number.");
            }
            return isAll;
        }

        public void AddStudent(Student student)
        {
            if (Students.Count <= StudentLimit)
            {
                Students.Add(student);
                Console.WriteLine($"\n A new student has joined your group. Congratulations! ");
            }
            else
            {
                Console.WriteLine($"\n It is no longer possible to add a student to the group. " +
                    $"\n The group can be joined by max {StudentLimit} student .");
            }
        }
        public Student GetStudent(int? id)
        {
            var student = Students.Find(i => i.ID == id);
            if (student==null)
            {

            }
            Console.WriteLine(student.ShowInfo());
            return student;
        }

        public Student[] GetAllStudents()
        {
            for (int i = 0; i < Students.Count; i++)
            {
                Console.WriteLine($"{Students[i].ShowInfo()}");
            }
            return Students.ToArray();
        }

        public void CreateGroup()
        {
            TryAgain1:
            Console.WriteLine("\n Enter group No: ");
            GroupNo = Console.ReadLine();
            if (CheckGroupNo(GroupNo))
            {
                Console.WriteLine("It's Okay.");
            }
            else
            {
                goto TryAgain1;
            }

            TryAgain2:
            Console.WriteLine("\n Enter student limit: ");
            StudentLimit = Convert.ToInt32(Console.ReadLine());
            if (StudentLimit >= 5 && StudentLimit <= 18)
            {
                Console.WriteLine("\n New group Created.");
            }
            else
            {
                Console.WriteLine("\n Wrong choice. Please try again.");
                goto TryAgain2;
            }
        }
    }
}