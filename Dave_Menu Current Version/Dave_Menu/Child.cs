using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dave_Menu
{
    public class Child
    {
        public string Name { get; set; }
        public DateTime DoB { get; set; }
        public string Description { get; set; }

        public Child(string name, DateTime dob, string description)
        {
            Name = name;
            DoB = dob;
            Description = description;
        }

        public Child()
        {

        }

        public class CompareAge : IComparer<Child>
        {
            public int Compare(Child child1, Child child2)
            {
                return DateTime.Compare(child1.DoB, child2.DoB);
            }
        }
        public class CompareName : IComparer<Child>
        {
            public int Compare(Child child1, Child child2)
            {
                return string.Compare(child1.Name, child2.Name);
            }
        }
    }
}
