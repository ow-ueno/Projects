using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    //
    class Example1_3
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hello World!");



            //こうしておけばcsv出力時とかの大量データに対応できる
            List<Student> students = new List<Student>
            {
                CreateStudent("taro",2001,9,11,3,2)
            };

            foreach (Student s in students)
            {
                Console.WriteLine("名前は{0}です。\n誕生日は{1}で、{2}年{3}組の生徒です。", s.Name, s.Birthday.ToString("yyyy年MM月dd日"), s.Grade, s.ClassNumber);
            }

            //最後にきちんとコンソールを止める親切設計
            Console.WriteLine("Press Any Key...");
            Console.ReadKey();
        }

        static Student CreateStudent(String name, int year, int month, int day, int grade, int classNumber) {

            //1.3.2 Studentクラスのインスタンスを生成
            Student student = new Student
            {
                Name = name,
                Birthday = new DateTime(year, month, day),
                Grade = grade,
                ClassNumber = classNumber
            };

            return student;

        }
    }

    //p38 ぱーそんクラス
    class Person
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int GetAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - Birthday.Year;
            if (today < Birthday.AddYears(age))
            {
                age--;
            }
            return age;
        }
    }

    //1.3.1 継承した型を作る
    class Student : Person
    {
        public int Grade { get; set; }
        public int ClassNumber { get; set; }
    }

}