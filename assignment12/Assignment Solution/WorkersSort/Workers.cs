using System;

namespace WorkersSort
{
    public class Worker : IComparable<Worker>
    {
        public string Name { get; set; }
        public double Wages { get; set; }

        public Worker(string name, double wages)
        {
            Name = name;
            Wages = wages;
        }

        public int CompareTo(Worker other)
        {
            
            if (other == null)
            {
                return 1;
            }
            return Wages.CompareTo(other.Wages);
        }

        
        }
    }
