namespace SchoolAdmin
{
    internal class Subject
    {
        private string _name;
        List<Class> _classes;

        public Subject(string name)
        {
            _name = name;
            _classes = new List<Class>();
        }

        public void RegisterClass(Class @class)
        {
            _classes.Add(@class);
        }
    }
}
