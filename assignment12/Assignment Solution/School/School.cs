namespace School
{
    public partial class School
    {
        public Classes[] ClassArray { get; set; }

        public School(Classes[] classes)
        {
            ClassArray = classes;
        }

    }
}
