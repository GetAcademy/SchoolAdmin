namespace SchoolAdmin
{
    internal class Student
    {
        List<Class> _classes;
        private string _name;

        public Student(string name)
        {
            _name = name;
            _classes = new List<Class>();
        }

        public void RegisterClass(Class @class)
        {
            _classes.Add(@class);
        }

        public Weekplan GetWeekplan()
        {
            var weekplan = new Weekplan();
            foreach (var @class in _classes)
            {
                weekplan.Include(@class.GetWeekplan());
            }
            return weekplan;
        }
    }
}
