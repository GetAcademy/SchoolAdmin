namespace SchoolAdmin
{
    internal class School
    {
        private string _name;
        List<Subject> _subjects;
        List<Student> _students;
        List<Class> _classes;

        public School(string name)
        {
            _name = name;
            _subjects = new List<Subject>();
            _students = new List<Student>();
            _classes = new List<Class>();
        }

        public Subject CreateSubject(string name)
        {
            var subject = new Subject(name);
            _subjects.Add(subject);
            return subject;
        }

        public Student CreateStudent(string name)
        {
            var student = new Student(name);
            _students.Add(student);
            return student;
        }

        private Class CreateClass(DateTime startDate, Subject subject)
        {
            var @class = new Class(startDate, subject);
            _classes.Add(@class);
            return @class;
        }

        public void RegisterStudentForSubject(Subject subject, Student student, DateTime startDate)
        {
            var theClass = GetClass(startDate) ?? CreateClass(startDate, subject);
            theClass.RegisterStudent(student);
        }

        public Class? GetClass(DateTime startDate)
        {
            // var theClass = _classes.SingleOrDefault(c => c.StartDate == startDate) ?? CreateClass(startDate);
            return _classes.SingleOrDefault(c => c.StartDate == startDate);
        }
    }
}
