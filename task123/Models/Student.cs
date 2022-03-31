using System;
using System.Collections.Generic;
using System.Text;

namespace task123.Models
{
    class Student:User
    {
        private int  _id;
        public int Id { get;  }
        public string Fullname { get; set; }
        public int Point { get; set; }
        public Student(string Fullname, int Point)
        {
            this.Fullname=Fullname;
            this.Point=Point;
            _id++;
            Id=_id;
        }
       public void StudentInfo()
        {
            Console.WriteLine($"Student id: {Id}\nStudent fullname: {Fullname}\nStudent point:{Point}");
        }
    }
}
