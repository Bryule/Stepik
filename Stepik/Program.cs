using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Stepik
{
    internal class Program
    {

        static void Main(string[] args)
        {

        }
    }
    class Performer
    {
        public string Name;

        public Performer(string name)
        {
            Name = name;
        }
    }

    class Board
    {
        public Task[] Tasks;

        public Board (Task[] tasks)
        {
            Tasks = tasks;
        }

        public void ShowAllTasks()
        {
            for (int i = 0; i < Tasks.Length; i++)
            {
                Tasks[i].ShowInfo();
            }
        }
    }
    class Task
    {
        public Performer Worker;
        public string Description;

        public Task (Performer worker, string description)
        {
            Worker = worker;
            Description = description;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Отвественный - {Worker}\nОписание задачи - {Description}\n");
        }
    }
}








