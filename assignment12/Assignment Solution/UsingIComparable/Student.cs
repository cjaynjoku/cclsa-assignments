using System;

namespace UsingIComparable
{
    public class Student: IComparable<Student>
    {
        public string Name { get; set; }
        public double Mark { get; set; }

        public Student(string name, double mark)
        {
            Name = name;
            Mark = mark;
        }

        public int CompareTo(Student other)
        {
            if(other == null)
            {
                return 1;
            }
            return Mark.CompareTo(other.Mark);
        }

    }
}
