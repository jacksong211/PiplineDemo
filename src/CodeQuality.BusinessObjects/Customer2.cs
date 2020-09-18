namespace CodeQuality.BusinessObjects
{
    internal class Customer2 : BusinessObject
    {
        private string firstName;
        private string lastName;

        public Customer2(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}