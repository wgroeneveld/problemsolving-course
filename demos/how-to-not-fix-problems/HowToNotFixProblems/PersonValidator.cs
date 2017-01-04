namespace HowToNotFixProblems
{
    public class PersonValidator
    {
        public bool Validate(Person person)
        {
            if (person.Age > 100) return false;
            if (string.IsNullOrEmpty(person.FirstName)) return false;
            if (!new AddressValidator().Validate(person.Address)) return false;

            return true;
        }
    }
}