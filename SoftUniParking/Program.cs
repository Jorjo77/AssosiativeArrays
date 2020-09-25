using System;
using System.Collections.Generic;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {

            //Dictionary<string, string> parkingDate = new Dictionary<string, string>();
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    string [] inputDate = Console.ReadLine()
            //        .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //    if (inputDate[0] == "register")
            //    {
            //        string username = inputDate[1];
            //        string plateNumber = inputDate[2];
            //        if (!parkingDate.ContainsKey(username))
            //        {
            //            parkingDate[username] = plateNumber;
            //            Console.WriteLine($"{username} registered {plateNumber} successfully");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
            //        }
            //    }
            //    else if (inputDate[0] == "unregister")
            //    {
            //        string username = inputDate[1];
            //        if (parkingDate.ContainsKey(username))
            //        {
            //            parkingDate.Remove(username);
            //            Console.WriteLine($"{username} unregistered successfully");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"ERROR: user {username} not found");
            //        }
            //    }
            //}
            //foreach (var username in parkingDate)
            //{
            //    Console.WriteLine($"{username.Key} => {username.Value}");
            //}

            int commandsNumber = int.Parse(Console.ReadLine());
            Dictionary<string, string> register = new Dictionary<string, string>();
            for (int i = 0; i < commandsNumber; i++)
            {
                string command = Console.ReadLine();
                string[] splitedNumber = command.Split();
                string splitedCommand = splitedNumber[0];
                string username = splitedNumber[1];
                if (splitedCommand=="register")
                {
                    string licenseNumber = splitedNumber[2];

                    if (!register.ContainsKey(username))
                    {
                        register[username] = licenseNumber;
                        Console.WriteLine($"{username} registered {licenseNumber} successfully");
                    }
                    else if (register.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licenseNumber}");
                    }
                }

                if (splitedCommand == "unregister")
                {
                    if (!register.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found") ;
                    }
                    else if (register.ContainsKey(username))
                    {
                        register.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }
            foreach (var users in register)
            {
                Console.WriteLine($"{users.Key} => {users.Value}");
            }
        }
    }
}
