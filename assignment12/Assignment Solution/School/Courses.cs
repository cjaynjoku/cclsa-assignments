namespace School
{
    public class Courses
    {
        public string Name { get; set; }
        public int ClassesCount { get; set; }
        public int ExercisesCount { get; set; }
        
        public Courses(string name, int classesCount, int exercisesCount)
        {
            Name = name;
            ClassesCount = classesCount;
            ExercisesCount = exercisesCount;
        }
    }
}
