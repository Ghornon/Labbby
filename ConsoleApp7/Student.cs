using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    internal class Student : Person, IEquatable<Student>
    {
        protected string group;
        protected List<Task> tasks = new List<Task>();

        public string Group { get => this.group; set => this.group = value; }

        public Student(string name, int age, string group) : base(name, age)
        {
            this.group = group;
        }

        public Student(string name, int age, string group, List<Task> tasks) : base(name, age)
        {
            this.group = group;
            this.tasks = tasks;
        }

        public void AddTask(string taskName, TaskStatus taskStatus)
        {
            Task task = new Task(taskName, taskStatus);

            tasks.Add(task);
        }

        public void RemoveTask(int index)
        {
            this.tasks.RemoveAt(index);
        }

        public void UpdateTask(int index, TaskStatus taskStatus)
        {
            Task task = tasks[index];
            task.Status = taskStatus;

            this.tasks.RemoveAt(index);
            this.tasks.Insert(index, task);
        }

        public string RenderTasks(string prefix = "\t")
        {
            string result = "";
            for (int i = 0; i < tasks.Count; i++)
            {
                result += $"{prefix}{i}." + tasks[i].ToString();
            }

            return result;
        }

        public override string ToString()
        {
            return $"Student: " + base.ToString() + $"\nGroup: {this.Group}\nTasks: " + this.RenderTasks();
        }

        public bool Equals(Student? other)
        {
            if (other == null) return false;

            if (this.Name == other.Name) return true;

            return false;
        }

        private bool SequenceEquals(List<Task> a, List<Task> b)
        {
            foreach (Task taskA in a)
            {
                foreach (Task taskB in b)
                {
                    if (!taskA.Equals(taskB))
                        return false;
                }
            }

            return true;
        }
    }
}