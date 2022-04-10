namespace School
{
    public class Teachers :People
    {
        public Courses[] Courses { get; set; }

        public Teachers(string name, Courses[] courses) : base(name)
        {
            Name = name;
            Courses = courses;
        }

        public void TeachCourses(Courses[] courses)
        {
            for (int i = 0; i < courses.Length; i++)
            {
                System.Console.WriteLine($"Simulating teaching {courses[i]}");
            }
        }

    }
}
