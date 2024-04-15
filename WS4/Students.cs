namespace StudentsNamespace
{
    class Student
    {
        public string fullName = "Untitled";
        public string groupNumber = "Untitled";
        private int age = 0;

        public Student(string fullName, string groupNumber, int age)
        {
            this.fullName = fullName;
            this.groupNumber = groupNumber;
            this.age = age;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Студент {fullName}, группа {groupNumber}, возраст {age} лет.");
        }
    }
}