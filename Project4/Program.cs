﻿using Project4;
using System;
namespace Project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("--------STUDENTS---------");
                Console.WriteLine("Enter the number of students:");
                int n = int.Parse(Console.ReadLine());

                Student[] stud = new Student[n];

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Enter student {i+1} name:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter class:");
                    int cls = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter section:");
                    char section = char.Parse(Console.ReadLine());

                    stud[i] = new Student(name, cls, section);
                    Console.WriteLine();
                }

                Console.WriteLine("--------TEACHERS---------");
                Console.WriteLine("Enter the number of teachers:");
                int n1 = int.Parse(Console.ReadLine());

                Teacher[] teacher = new Teacher[n1];

                for (int i = 0; i < n1; i++)
                {
                    Console.WriteLine($"Enter teacher {i+1} name:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter class:");
                    int class1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter section:");
                    char section = char.Parse(Console.ReadLine());

                    teacher[i] = new Teacher(name, class1, section);
                    Console.WriteLine();
                }

                Console.WriteLine("--------SUBJECTS---------");

                Console.WriteLine("Enter the number of subjects:");
                int n2 = int.Parse(Console.ReadLine());

                Subject[] sub = new Subject[n2];

                for (int i = 0; i < n2; i++)
                {
                    Console.WriteLine($"Enter subject {i+1} name:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter subject code:");
                    string code = Console.ReadLine();

                    Console.WriteLine($"Enter assigned teacher name for {name}:");
                    string teacherName = Console.ReadLine();

                    // Find the teacher from the array
                    Teacher assignedTeacher = Array.Find(teacher, t => t.Name == teacherName);

                    sub[i] = new Subject(name, code, assignedTeacher);
                    Console.WriteLine();
                }

                Console.WriteLine("----------PRINTING DETAILS OF STUDENTS------------------------");
                foreach (var item in stud)
                {
                    Console.WriteLine($"Student Name  : {item.Name}");
                    Console.WriteLine($"Class   : {item.Class}");
                    Console.WriteLine($"Section : {item.Section}");
                    Console.WriteLine();
                }

                Console.WriteLine("----------PRINTING DETAILS OF TEACHERS------------------------");
                foreach (var item in teacher)
                {
                    Console.WriteLine($"Name       : {item.Name}");
                    Console.WriteLine($"Subject    : {item.Class}");
                    Console.WriteLine($"Section : {item.Section}");
                    Console.WriteLine();
                }

                Console.WriteLine("----------PRINTING DETAILS OF SUBJECTS------------------------");
                foreach (var item in sub)
                {
                    Console.WriteLine($"Name           : {item.Name}");
                    Console.WriteLine($"Subject Code   : {item.SubCode}");
                    Console.WriteLine($"Assigned Teacher: {item.AssignedTeacher?.Name ?? "Not Assigned"}");
               
                    Console.WriteLine();
                }
              Console.ReadKey();
        }
    }
}




