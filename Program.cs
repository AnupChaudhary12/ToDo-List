using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todolist
{
    internal class Program
    {

        enum Userchoice
        {
            addTask = 1,
            viewtask = 2,
            editTask = 3,
            removeTask = 4,


            exit = 5

        }
        static void Main(string[] args)
        {
            List<string> todolist = new List<string>();
            while (true)
            {
                /* if (todolist.Count > 0)
                 {
                     Console.WriteLine("to-do list:");
                     for (int i = 0; i < todolist.Count; i++)
                     {
                         Console.WriteLine("- " + todolist[i]);

                     }
                     Console.WriteLine("");
                 }*/
                Console.WriteLine("\n (1) Press 1 to add task\n (2)Press 2 to view task\n (3)press 3 to edit task\n (4)press 4 to remove task\n (5)press 5 to exit ");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == (int)Userchoice.addTask)
                {
                    Console.WriteLine("Add Task");
                    string task = Console.ReadLine();
                    todolist.Add(task);
                    Console.Clear();
                    Console.WriteLine("Task added succesfully:");
                }

                else if (choice == (int)Userchoice.viewtask)
                {
                    if (todolist.Count > 0)
                    {
                        Console.WriteLine("The task in todo-list are:");
                        for (int i = 0; i < todolist.Count; i++)
                        {
                            Console.WriteLine(todolist[i]);
                        }
                    }
                }

                else if (choice == (int)Userchoice.removeTask)
                {
                    if (todolist.Count > 0)
                    {
                        Console.WriteLine("Enter the task you want to delete:");
                        for (int i = 0; i < todolist.Count; i++)
                        {
                            Console.WriteLine("(" + (i + 1) + ") " + todolist[i]);
                        }
                        int taskNum = int.Parse(Console.ReadLine());
                        taskNum--;

                        if (taskNum >= 0 && taskNum < todolist.Count)
                        {
                            todolist.RemoveAt(taskNum);
                            Console.Clear();
                            Console.WriteLine("Task deleted successfully!");
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid task number.");
                            Console.WriteLine("");
                        }
                    }
                }

                else if (choice == (int)Userchoice.editTask)
                {
                    Console.WriteLine("Enter the task number you want to edit:");

                    for (int i = 0; i < todolist.Count; i++)
                    {
                        Console.WriteLine("(" + (i + 1) + ") " + todolist[i]);
                    }
                    int tasknum = int.Parse(Console.ReadLine());
                    tasknum--;
                    if (tasknum >= 0 && tasknum < todolist.Count)
                    {
                        Console.WriteLine("the task number you are trying to edit is :" + tasknum + 1);

                        Console.WriteLine("Enter the new task in string:");
                        string newtask = Console.ReadLine();
                        todolist[tasknum] = newtask;

                        Console.Clear();

                        Console.WriteLine("Task edited succesfully");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid task number");
                        Console.WriteLine("");
                    }
                }


                else if (choice == (int)Userchoice.exit)
                {
                    break;
                }

            }
        }
    }
}
