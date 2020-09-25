using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {

            //Dictionary<string, List<double>> studentsData = new Dictionary<string, List<double>>();
            //Dictionary<string, double> exelentStudentsData = new Dictionary<string, double>();
            //int n = int.Parse(Console.ReadLine());
            //double averageGrade = 0d;
            //for (int i = 0; i < n; i++)
            //{
            //    string studentName = Console.ReadLine();
            //    double studentGrade = double.Parse(Console.ReadLine());

            //    if (!studentsData.ContainsKey(studentName))
            //    {
            //        studentsData[studentName] = new List<double>();
            //    }
            //    studentsData[studentName].Add(studentGrade);
            //}
            //foreach (var student in studentsData)
            //{
            //    double gradesSum = student.Value.Sum();
            //    double gradeCounter = student.Value.Count();
            //    averageGrade = gradesSum / gradeCounter;

            //    if (averageGrade>= 4.50)
            //    {
            //        exelentStudentsData.Add(student.Key, averageGrade);
            //    }
            //}

            //var sortedexelentStudentsData = exelentStudentsData.OrderByDescending(s => s.Value).ToList();
            //foreach (var kvp in sortedexelentStudentsData)
            //{
            //    Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
            //}


            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentsGrade = new Dictionary<string, List<double>>();
            Dictionary<string, double> goodStudents = new Dictionary<string, double>();
            for (int i = 0; i < n; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!studentsGrade.ContainsKey(student))
                {
                    studentsGrade.Add(student, new List<double>());
                }
                studentsGrade[student].Add(grade);
            }
            foreach (var student in studentsGrade)
            {
                double gradeSum = student.Value.Sum();
                double gradeCounter = student.Value.Count;
                double averageGrade = gradeSum/ gradeCounter;
                if (averageGrade>=4.50)
                {
                    goodStudents.Add(student.Key, averageGrade);
                }
            }
            var orderedGoodStudents = goodStudents.OrderByDescending(x => x.Value);
            foreach (var student in orderedGoodStudents)
            {
                Console.WriteLine($"{student.Key} -> {student.Value:f2}");
            }
        }
    }
}
    

