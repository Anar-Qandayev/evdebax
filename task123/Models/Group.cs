using System;
using System.Collections.Generic;
using System.Text;
using task123.Models1;

namespace task123.Models
{
    class Group
    {
        public string GroupNo { get; set; }
        public int StudentLimit { get; set; }
        private Student[] _student = new Student[0];
        public Group(string GroupNo, int StudentLimit)
        {
            this.GroupNo=GroupNo;
            this.StudentLimit=StudentLimit;
        }
        public bool CheckGroupNo()
        {
            bool isupper = false;
            bool isdigit = false;
            int upCount = 0;
            int digCount = 0;
            if (GroupNo.Length>5)
            {
                foreach (var item in GroupNo)
                {
                    if (char.IsUpper(item))
                    {
                        isupper=true; upCount++;
                    }
                    else if (char.IsDigit(item))
                    {
                        isdigit=true; digCount++;
                    }
                }
                if (upCount>2&&digCount>3) return false;
            }
            return false;
        }
        public void AddStudent(Student student)
        {
            if (StudentLimit>5||StudentLimit<18)
            {
                throw new CapacityLimitException("Isci mehdudiyyeti var!");
                Console.WriteLine("Isci mehdudiyyeti var!");
                Array.Resize(ref _student, _student.Length+1);
                _student[_student.Length - 1] = student;
            }
            else
            {
                throw new CapacityLimitException("Stack Overflow");
                Console.WriteLine("Stack Overflow");
            }
        }
        public void GetStudent()
        {

        }
        public void GetAllStudents()
        {

        }
    }
}
