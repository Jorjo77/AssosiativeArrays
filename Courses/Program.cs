using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {

            //Dictionary<string, List<string>> coursesData = new Dictionary<string, List<string>>();
            //string input;
            //int studentsCounter = 0;
            //while ((input = Console.ReadLine()) != "end")
            //{
            //    string[] inputInArguments =
            //        input.Split(':', StringSplitOptions.RemoveEmptyEntries);
            //    string courseName = inputInArguments[0];
            //    string studentName = inputInArguments[1];
            //    if (!coursesData.ContainsKey(courseName))
            //    {
            //        coursesData[courseName] = new List<string>();
            //    }
            //    coursesData[courseName].Add(studentName);
            //    studentsCounter++;
            //}

            //var sortedCoursesData = coursesData.OrderByDescending(s => s.Value.Count)
            //    .ToList();

            //foreach (var kvp in sortedCoursesData)
            //{
            //    Console.WriteLine($"{kvp.Key.Trim()}: {kvp.Value.Count}");

            //    Console.WriteLine($"--{String.Join("\n--", kvp.Value.OrderBy(x => x))}");
                //Варианта с форич, който ми помогна!!! :
                //var orderedStudents = kvp.Value.OrderBy(x => x);
                //foreach (var value in orderedStudents)
                //{
                //    Console.WriteLine($"-- {value}");
                //}
            

            Dictionary<string, List<string>> coursesRegister = new Dictionary<string, List<string>>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] splitedCommand = command.Split(" : ");
                string courseName = splitedCommand[0];
                string student = splitedCommand[1];
                if (!coursesRegister.ContainsKey(courseName))
                {
                    coursesRegister.Add(courseName, new List<string>());
                }
                coursesRegister[courseName].Add(student);
            }
            var sortedCoursesRegister = coursesRegister.OrderByDescending(x => x.Value.Count)
                .ToDictionary(x => x.Key, x => x.Value);
            foreach (var kvp in sortedCoursesRegister)
            {
                Console.WriteLine($"{kvp.Key.Trim()}: {kvp.Value.Count}");
                Console.WriteLine($"-- {string.Join("\n-- ", kvp.Value.OrderBy(x=>x))}");
            }
        }
    }
}
