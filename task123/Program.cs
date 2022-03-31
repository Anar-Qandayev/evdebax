using System;
using task123.Models;

namespace task123
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Anar Qandayev",90);
            student1.StudentInfo();
            User user1 = new User();
            user1.Fullname="Anar Qandayev";
            user1.Email="anar@gamil.com";
            user1.ShowInfo();
            Console.WriteLine(user1.PasswordChecker("AP2001"));
            Group group = new Group("AP205",21);
            Console.WriteLine(group.CheckGroupNo());
            group.AddStudent(student1);
        }
    }
}
