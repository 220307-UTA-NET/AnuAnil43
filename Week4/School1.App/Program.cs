﻿using System;
using School.DataInfrastructure;
using School.Logic;

namespace School.App
{
    class Program
    {
        static void Main()
        {
            //    Console.WriteLine("Hello Again!");

            //    Student temp = new Student(123, "Jonathan");
            //    Console.WriteLine(temp.Introduce());

            //    Teacher temp2 = new Teacher(098, "Brian");
            //    Console.WriteLine(temp2.Introduce());


            string connectionString = File.ReadAllText(@"/Revature/ConnectionStrings/220307-DB.txt");

            IRepository repo = new SqlRepository(connectionString);

            School myschool = new School(repo);
            Student tmpStudent = myschool.GetStudent(4);
            Console.WriteLine(tmpStudent.Introduce());
            //IEnumerable<Teacher> teachers = repo.GetAllTeachers();

            //foreach (Teacher teacher in teachers)
            //{
            //    Console.WriteLine(teacher.Introduce());
            // }

            //Teacher NewTeacher = repo.CreateNewTeacher("Jerome");
            //Console.WriteLine(NewTeacher.Introduce());
        }
    }
}