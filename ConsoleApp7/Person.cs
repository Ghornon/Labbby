using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Person: IEquatable<Person>
    {
        protected string name;
        protected int age;
        public string Name { get => this.name; set => this.name = value; }
        public int Age { get => this.age; set => this.age = value; }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return $"{this.Name} ({this.Age} y.o.)";
        }

        public bool Equals(Person? other)
        {
            if (other == null) return false;

            if (this.Name == other.Name && this.Age == other.Age) return true;

            return false;
        }
    }
}
