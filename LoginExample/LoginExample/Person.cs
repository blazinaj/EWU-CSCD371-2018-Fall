namespace LoginExample
{
    public class Person
    {
        private string UserName;
        private string Password;

        public Person(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public Person(string firstName, string lastName, string password)
        {
            UserName = $"{firstName}.{lastName}";
            Password = password;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}