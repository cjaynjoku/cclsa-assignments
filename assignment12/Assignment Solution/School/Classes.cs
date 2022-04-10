namespace School
{
        public class Classes
        {
            public string ClassName { get; set; }

            public Teachers[] Teachers { get; set; }

            public Students[] Students { get; set; }

            private Classes()
            {

            }

            public Classes(string className, Teachers[] teachers, Students[] students) : this()
            {
                ClassName = className;
                Teachers = teachers;
                Students = students;
            }
        }
}
