namespace SchoolAdmin
{
    internal class Class
    {
        List<Student> _students;
        private Subject _subject;
        public DateTime StartDate { get; }

        public Class(DateTime startDate, Subject subject)
        {
            _subject = subject;
            StartDate = startDate;
            _students = new List<Student>();
            subject.RegisterClass(this);
        }

        public void RegisterStudent(Student student)
        {
            _students.Add(student);
            student.RegisterClass(this);
        }

        public Weekplan GetWeekplan()
        {
            return new Weekplan();
        }
    }
}
