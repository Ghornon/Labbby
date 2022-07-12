using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Classroom
    {
        private string name;
        private Person[] persons;
        public string Name { get => this.name; set => this.name = value; }

        public Classroom(string name, Person[] persons)
        {
            this.name = name;
            this.persons = persons;
        }

        public override string ToString()
        {
            string result = $"Classroom: {this.Name}\n\n";

            foreach (var person in persons)
                result += person.ToString() + "\n\n";

            return result;
        }
    }
}
