namespace HowToNotFixProblems
{
    public class AddressValidator
    {
        public bool Validate(Address address)
        {
            if (address.HouseNumber > 100) return false;

            return true;
        }
    }
}