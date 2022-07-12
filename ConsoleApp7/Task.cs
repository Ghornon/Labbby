using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public enum TaskStatus
    {
        Waiting,
        Progress,
        Done,
        Rejected
    }

    class Task : IEquatable<Task>
    {
        private string name;
        private TaskStatus status;

        public string Name { get => name; set => name = value; }
        public TaskStatus Status { get => status; set => status = value; }

        public Task(string name, TaskStatus status)
        {
            Name = name;
            Status = status;
        }

        public bool Equals(Task? other)
        {
            if (other == null) return false;

            if (this.Name == other.Name && this.Status == other.Status) return true;

            return false;
        }

        public override string ToString()
        {
            return $"{this.Name} [{this.Status}]\n";
        }

    }
}
