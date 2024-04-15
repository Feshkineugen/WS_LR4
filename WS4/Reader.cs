namespace ReadersNamespace
{
    class Reader
    {
        private string fullName = "Untitled";
        public int readerTicketNumber = 0;
        public string faculty = "Untitled";
        private DateTime dateOfBirth;
        public string phoneNumber = "Untitled";

        public Reader(string fullName, int readerTicketNumber, string faculty, DateTime dateOfBirth, string phoneNumber)
        {
            this.fullName = fullName;
            this.readerTicketNumber = readerTicketNumber;
            this.faculty = faculty;
            this.dateOfBirth = dateOfBirth;
            this.phoneNumber = phoneNumber;
        }

        public void TakeBook(int numberOfBooks)
        {
            Console.WriteLine($"{fullName} взял {numberOfBooks} книги.");
        }

        public void TakeBook(params string[] bookNames)
        {
            Console.WriteLine($"{fullName} взял книги: {string.Join(", ", bookNames)}.");
        }

        public void ReturnBook(int numberOfBooks)
        {
            Console.WriteLine($"{fullName} вернул {numberOfBooks} книги.");
        }

        public void ReturnBook(params string[] bookNames)
        {
            Console.WriteLine($"{fullName} вернул книги: {string.Join(", ", bookNames)}.");
        }
    }
}