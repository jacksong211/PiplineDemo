namespace CodeQuality.BusinessObjects
{
    public class Person : BusinessObject
    {
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get ; set; }
        public string LastName { get; set; }
    }
}
