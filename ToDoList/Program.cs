using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Program
    {
        static List<string> tasks = new List<string>();
        static string filePath = "toDoList.txt";
        static void Main(string[] args)
        {
            LoadTasks();
            while (true)
            {
                Console.WriteLine("1. Add a new task");
                Console.WriteLine("2. Remove a task");
                Console.WriteLine("3. View all pending tasks");
                Console.WriteLine("4. Exit?");
                Console.Write("Enter your choice please: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddTask();
                        break;
                    case 2:
                        RemoveTask();
                        break;
                    case 3:
                        ViewTasks();
                        break;
                    case 4:
                        SaveTasks();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again!!!");
                        break;

                }
            }
        }
        static void LoadTasks()
        {
            if (File.Exists(filePath)) {
                tasks = File.ReadAllLines(filePath).ToList();

            }
        }
        static void AddTask()
        {
            Console.Write("Enter the new task: ");
            string task = Console.ReadLine();
            tasks.Add(task);
            Console.WriteLine("Task added successfullyyy");
        }
        static void RemoveTask()
        {
            Console.Write("Enter task number to be removed: ");
            int index = int.Parse(Console.ReadLine()) - 1;
            if (index >= 0 && index < tasks.Count)
            {
                tasks.RemoveAt(index);
                Console.WriteLine("Task removed successfullyyy.");
            }
            else
            {
                Console.WriteLine("Can't find this task number!!!");
            }
        }
        static void ViewTasks()
        {
            Console.WriteLine("Tadadaaa");
            for(int i= 0; i<tasks.Count; i++)
            {
                Console.WriteLine($"{i+1}: {tasks[i]}");
            }
            Console.WriteLine("Task added successfullyyy");
        }
        static void SaveTasks()
        {
            File.WriteAllLines(filePath, tasks);
            Console.WriteLine($"Tasks saved to {filePath}");
        }
    }

}

